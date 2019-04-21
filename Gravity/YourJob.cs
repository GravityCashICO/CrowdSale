using Gravity.Data;
using Gravity.Models;
using Microsoft.AspNetCore.NodeServices;
using Quartz;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Quartz.Spi;
using System.Numerics;
using System.Collections.Generic;
using Gravity.Services;

namespace Gravity
{
    public class JobFactory : IJobFactory, IDisposable
    {
        protected readonly IServiceScope _scope;

        public JobFactory(IServiceProvider container)
        {
            _scope = container.CreateScope();
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            var res = _scope.ServiceProvider.GetService(bundle.JobDetail.JobType) as IJob;
            return res;
        }

        public void ReturnJob(IJob job)
        {
            (job as IDisposable)?.Dispose();
        }

        public void Dispose()
        {
            _scope.Dispose();
        }
    }


    public class QuartzStartup
    {

        // starts the scheduler, defines the jobs and the triggers
        public static async Task Start(IServiceProvider container)
        {

            var schedulerFactory = new Quartz.Impl.StdSchedulerFactory();
            var _scheduler = schedulerFactory.GetScheduler().Result;
            _scheduler.JobFactory = new JobFactory(container);
            await _scheduler.Start();

            var yourJob = JobBuilder.Create<YourJob>()
                .Build();

            var yourJobTrigger = TriggerBuilder.Create()
                .StartNow()
                .WithSimpleSchedule(s => s
                    .WithIntervalInMinutes(2)
                    .RepeatForever())
                .Build();

            await _scheduler.ScheduleJob(yourJob, yourJobTrigger);
        }


    }

    public class YourJob : IJob
    {
        private readonly ApplicationDbContext _ctx;
        private readonly INodeServices nodeServices;
        public YourJob(ApplicationDbContext ctx, INodeServices nd)
        {
            _ctx = ctx;
            nodeServices = nd;
        }




        async Task IJob.Execute(IJobExecutionContext context)
        {
            if (Admin.IsQuartzDone)
            {
                try
                {
                    Admin.IsQuartzDone = false;
                    Admin.IsQuartzDone = await AutoPush();

                }
                catch (Exception ex)
                {
                    Admin.IsQuartzDone = false;
                    await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "Quartz Error:exception: " + Newtonsoft.Json.JsonConvert.SerializeObject(ex));

                }
            }
            else
            {
                await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "System Busy or Check");
            }


            //return Task.Run( () =>

            //    AutoPush(_serviceProvider)
            //    //Program.Counter++;
            //);
        }

        public async Task<bool> AutoPush()
        {
            var trnxs = await _ctx.Transactions.Where(x => x.Status == EnumType.Pending).OrderBy(x => x.CreationDate).ToListAsync();

            if (trnxs.Count <= 0)
            {
                return true;
            }

            var p = System.Convert.ToDecimal(Math.Pow(10, Admin.decimalNumber));
            var autoPush = new List<Transaction>();
            var airdrop = new List<Transaction>();

            trnxs.ForEach
            (i =>
            {
                if (i.StatusType == EnumType.Buy)
                    airdrop.Add(i);
                else
                    autoPush.Add(i);
            });

            string json_obj = "";
            PushResp result = new PushResp();
            bool isAirdropped = false; ;

            try
            {
                if (airdrop.Count > 0)
                {
                    var objAirdrop = new
                    {
                        toes = airdrop.Select(x => x.ToKey).ToArray(),
                        values = airdrop.Select(x => ((BigInteger)(x.CoinAmount * p)).ToString()).ToArray(),
                    };
                    json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(objAirdrop);

                    result = await nodeServices.InvokeExportAsync<PushResp>("wwwroot/Scripts/AutoPush.js", "sendBatchCS", json_obj);
                    AddMineTransaction(result, json_obj, airdrop.Count());  //
                    isAirdropped = true;
                }
                else if (autoPush.Count > 0)
                {
                    var objTransfer = new
                    {
                        signatures = autoPush.Select(x => x.Signature).ToArray(),
                        toes = autoPush.Select(x => x.ToKey).ToArray(),
                        values = autoPush.Select(x => ((BigInteger)(x.CoinAmount * p)).ToString()).ToArray(),
                        //fees= Enumerable.Repeat("0", autoPush.Count).ToArray()
                        fees = autoPush.Select(x => ((BigInteger)(x.FeeInCoinAmount * p)).ToString()).ToArray()
                    };

                    json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(objTransfer);

                    result = await nodeServices.InvokeExportAsync<PushResp>("wwwroot/Scripts/AutoPush.js", "transferArray", json_obj);
                    AddMineTransaction(result, json_obj, autoPush.Count());  //
                }

                //foreach (var trn in trnxs)
                //{
                //    trn.Status = EnumType.Success;
                //}
                trnxs.ForEach(x => x.Status = EnumType.Success);

            }
            catch (Exception ex)
            {
                //email
                if (isAirdropped)
                    trnxs.Where(x => x.StatusType != EnumType.Buy).ToList().ForEach(x => x.Status = EnumType.Failed);
                else
                    trnxs.ForEach(x => x.Status = EnumType.Failed);

                await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "Node Error:exception: " + json_obj + " resp  " + Newtonsoft.Json.JsonConvert.SerializeObject(result));
                await _ctx.SaveChangesAsync();

                return false;
            }

            await _ctx.SaveChangesAsync();

            return true;
        }

        private void AddMineTransaction(PushResp result, string json, int trnxCount, decimal totalCoinFee = 0)
        {
            var mineTrnx = new MineTransaction();
            mineTrnx.Id = new Guid();
            mineTrnx.CreationDate = DateTime.UtcNow;
            mineTrnx.GasFee = Convert.ToInt32(result.GasPrice.Hex, 16);
            mineTrnx.LastTransactinTime = DateTime.Now;//trnxs.Last().CreationDate;
            mineTrnx.totalCoinFee = totalCoinFee;//trnxs.Sum(x => x.FeeInCoinAmount);
            mineTrnx.TotalFee = Convert.ToInt32(result.GasLimit.Hex, 16);
            mineTrnx.txHash = result.Hash;

            mineTrnx.StatusType = totalCoinFee == 0 ? EnumType.Buy : EnumType.Transfer;
            mineTrnx.TransactionCount = trnxCount;
            mineTrnx.JsonTransactions = json;

            _ctx.MineTransactions.Add(mineTrnx);
        }
    }
}
