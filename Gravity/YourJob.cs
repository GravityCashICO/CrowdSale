using Gravity.Data;
using Gravity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using Quartz;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Quartz.Spi;
using Microsoft.AspNetCore.Builder;

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
        public static void Start(IServiceProvider container)
        {

            var schedulerFactory = new Quartz.Impl.StdSchedulerFactory();
            var _scheduler = schedulerFactory.GetScheduler().Result;
            _scheduler.JobFactory = new JobFactory(container);
            _scheduler.Start().Wait();

            var yourJob = JobBuilder.Create<YourJob>()
                .Build();

            var yourJobTrigger = TriggerBuilder.Create()
                .StartNow()
                .WithSimpleSchedule(s => s
                    .WithIntervalInSeconds(30)
                    .RepeatForever())
                .Build();

            _scheduler.ScheduleJob(yourJob, yourJobTrigger).Wait();
        }

        
    }
    
        public class YourJob : IJob
    {
        private readonly ApplicationDbContext _ctx;
        private readonly INodeServices _nodeServices;
        public YourJob(ApplicationDbContext ctx,INodeServices nodeServices)
        {
            _ctx = ctx;
            _nodeServices = nodeServices;
        }




        async Task IJob.Execute(IJobExecutionContext context)
        {

            
            try
            {

                var trnxs =await _ctx.Transactions.Where(x => x.Status == EnumType.Pending).OrderBy(x => x.CreationDate).ToListAsync();
                if (trnxs.Count() > 0)
                {
                    //var Signature = trnxs.Select(x => x.Signature);
                    //string signs = string.Join(".", Signature);
                    //string[] _toes = trnxs.Select(x => x.ToKey).ToArray();

                    //var p = System.Convert.ToDecimal(Math.Pow(10, 18));

                    //string[] _values = trnxs.Select(x => (x.CoinAmount * p).ToString().Split('.')[0]).ToArray();
                    //decimal[] _fees = trnxs.Select(x => x.FeeInCoinAmount * p).ToArray();
                    //string[] _nonces = Enumerable.Repeat("0", trnxs.Count).ToArray();

                    //var obj = new { signs, _toes, _values, _fees = _nonces, _nonces };
                    //string json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                    //var result = await nodeServices.InvokeAsync<object>("wwwroot/Scripts/AutoPush.js", json_obj);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            //return Task.Run( () =>
           
            //    AutoPush(_serviceProvider)
            //    //Program.Counter++;
            //);
        }

        public async Task AutoPush(IServiceProvider serviceProvider)
        {
            //var nodeServices= serviceProvider.GetRequiredService<INodeServices>();
            using (var _ctx = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                var trnxs = _ctx.Transactions.Where(x => x.Status == EnumType.Pending).OrderBy(x => x.CreationDate).ToList();
                if (trnxs.Count() > 0)
                {
                    //var Signature = trnxs.Select(x => x.Signature);
                    //string signs = string.Join(".", Signature);
                    //string[] _toes = trnxs.Select(x => x.ToKey).ToArray();

                    //var p = System.Convert.ToDecimal(Math.Pow(10, 18));

                    //string[] _values = trnxs.Select(x => (x.CoinAmount * p).ToString().Split('.')[0]).ToArray();
                    //decimal[] _fees = trnxs.Select(x => x.FeeInCoinAmount * p).ToArray();
                    //string[] _nonces = Enumerable.Repeat("0", trnxs.Count).ToArray();

                    //var obj = new { signs, _toes, _values, _fees = _nonces, _nonces };
                    //string json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                    //var result = await nodeServices.InvokeAsync<object>("wwwroot/Scripts/AutoPush.js", json_obj);
                }
            }

        }
    }
}
