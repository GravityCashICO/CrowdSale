﻿using Gravity.Data;
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

			//reward
			var rewardJob = JobBuilder.Create<RewardJob>()
				.Build();

			var rewardJobTrigger = TriggerBuilder.Create()
				.StartNow()
				.WithSimpleSchedule(s => s
					.WithIntervalInHours(24)
					.RepeatForever())
				.Build();

			await _scheduler.ScheduleJob(rewardJob, rewardJobTrigger);
		}


	}

	public class RewardJob : IJob
	{
		private readonly ApplicationDbContext _ctx;
		private readonly INodeServices nodeServices;
		static decimal p = Convert.ToDecimal(Math.Pow(10, Admin.decimalNumber));
		public RewardJob(ApplicationDbContext ctx, INodeServices nd)
		{
			_ctx = ctx;
			nodeServices = nd;
		}




		async Task IJob.Execute(IJobExecutionContext context)
		{
			try
			{
				await AirDrop();
			}
			catch (Exception ex)
			{

				await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "(Reward)Quartz Error:exception: " + Newtonsoft.Json.JsonConvert.SerializeObject(ex));

			}
		}
		public async Task<bool> AirDrop()
		{
			var airdrop = await _ctx.Transactions.Where(x => x.Status == EnumType.Pending && x.StatusType == EnumType.Reward).OrderBy(x => x.CreationDate).Take(500).ToListAsync();
			if (airdrop.Count <= 0)
			{
				return true;
			}
			PushResp result = new PushResp();

			var objAirdrop = new
			{
				toes = airdrop.Select(x => x.ToKey).ToArray(),
				values = airdrop.Select(x => ((BigInteger)(x.CoinAmount * p)).ToString()).ToArray(),
			};
			var json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(objAirdrop);

			try
			{
				result = await nodeServices.InvokeExportAsync<PushResp>("wwwroot/Scripts/AutoPush.js", "sendBatchCS", json_obj, Admin.PrivateKey);
				AddMineTransaction(result, json_obj, airdrop.Count());  //
				foreach (var trn in airdrop)
				{
					trn.Status = EnumType.Success;
					trn.HashHex = result.Hash;
				}
			}
			catch (Exception ex)
			{
				airdrop.ForEach(x => x.Status = EnumType.Failed);
				await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "Node(Reward) Error:exception: " + json_obj + " resp  " + Newtonsoft.Json.JsonConvert.SerializeObject(result) + "  EXCEPTN::" + ex.Message);
			}

			await _ctx.SaveChangesAsync();
			return true;
		}


		private void AddMineTransaction(PushResp result, string json, int trnxCount, decimal totalCoinFee = 0)
		{
			var mineTrnx = new MineTransaction();
			mineTrnx.Id = new Guid();
			mineTrnx.CreationDate = DateTime.UtcNow;
			mineTrnx.GasFee = Convert.ToUInt64(result.GasPrice.Hex, 16);
			mineTrnx.LastTransactinTime = DateTime.Now;//trnxs.Last().CreationDate;
			mineTrnx.totalCoinFee = totalCoinFee;//trnxs.Sum(x => x.FeeInCoinAmount);
			mineTrnx.TotalFee = Convert.ToUInt64(result.GasLimit.Hex, 16);
			mineTrnx.txHash = result.Hash;

			mineTrnx.StatusType = totalCoinFee == 0 ? EnumType.Buy : EnumType.Transfer;
			mineTrnx.TransactionCount = trnxCount;
			mineTrnx.JsonTransactions = json;
			mineTrnx.Nonce = result.Nonce;

			_ctx.MineTransactions.Add(mineTrnx);
		}
	}



	public class YourJob : IJob
	{
		private readonly ApplicationDbContext _ctx;
		private readonly INodeServices nodeServices;
		static decimal p = Convert.ToDecimal(Math.Pow(10, Admin.decimalNumber));
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
					await AirDrop();
					await Transfer();
					Admin.IsQuartzDone = true;
				}
				catch (Exception ex)
				{

					await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "Quartz Error:exception: " + Newtonsoft.Json.JsonConvert.SerializeObject(ex));

				}
			}
			else
			{
				await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "System Busy Or Check");
			}


			//return Task.Run( () =>

			//    AutoPush(_serviceProvider)
			//    //Program.Counter++;
			//);
		}
		public async Task<bool> AirDrop()
		{
			var airdrop = await _ctx.Transactions.Where(x => x.Status == EnumType.Pending && x.StatusType == EnumType.Buy).OrderBy(x => x.CreationDate).Take(500).ToListAsync();
			if (airdrop.Count <= 0)
			{
				return true;
			}
			PushResp result = new PushResp();

			var objAirdrop = new
			{
				toes = airdrop.Select(x => x.ToKey).ToArray(),
				values = airdrop.Select(x => ((BigInteger)(x.CoinAmount * p)).ToString()).ToArray(),
			};
			var json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(objAirdrop);

			try
			{
				result = await nodeServices.InvokeExportAsync<PushResp>("wwwroot/Scripts/AutoPush.js", "sendBatchCS", json_obj, Admin.PrivateKey);
				AddMineTransaction(result, json_obj, airdrop.Count());  //
				foreach (var trn in airdrop)
				{
					trn.Status = EnumType.Success;
					trn.HashHex = result.Hash;
				}
			}
			catch (Exception ex)
			{
				airdrop.ForEach(x => x.Status = EnumType.Failed);
				await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "Node(Buy) Error:exception: " + json_obj + " resp  " + Newtonsoft.Json.JsonConvert.SerializeObject(result) + "  EXCEPTN::" + ex.Message);
			}

			await _ctx.SaveChangesAsync();
			return true;
		}
		public async Task<bool> Transfer()
		{
			var autoPush = await _ctx.Transactions.Where(x => x.Status == EnumType.Pending && x.StatusType == EnumType.Transfer).OrderBy(x => x.CreationDate).Take(150).ToListAsync();
			if (autoPush.Count <= 0)
			{
				return true;
			}
			PushResp result = new PushResp();

			var objTransfer = new
			{
				signatures = autoPush.Select(x => x.Signature).ToArray(),
				toes = autoPush.Select(x => x.ToKey).ToArray(),
				values = autoPush.Select(x => ((BigInteger)(x.CoinAmount * p)).ToString()).ToArray(),
				//fees= Enumerable.Repeat("0", autoPush.Count).ToArray()
				fees = autoPush.Select(x => ((BigInteger)(x.FeeInCoinAmount * p)).ToString()).ToArray()
			};


			var json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(objTransfer);
			try
			{
				result = await nodeServices.InvokeExportAsync<PushResp>("wwwroot/Scripts/AutoPush.js", "transferArray", json_obj, Admin.PrivateKey);
				AddMineTransaction(result, json_obj, autoPush.Count());  //
				foreach (var trn in autoPush)
				{
					trn.Status = EnumType.Success;
					trn.HashHex = result.Hash;
				}

			}
			catch (Exception ex)
			{
				autoPush.ForEach(x => x.Status = EnumType.Failed);
				await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "Node(Transfer) Error:exception: " + json_obj + " resp  " + Newtonsoft.Json.JsonConvert.SerializeObject(result) + "  EXCEPTN::" + ex.Message);
			}

			await _ctx.SaveChangesAsync();

			return true;
		}

		private void AddMineTransaction(PushResp result, string json, int trnxCount, decimal totalCoinFee = 0)
		{
			var mineTrnx = new MineTransaction();
			mineTrnx.Id = new Guid();
			mineTrnx.CreationDate = DateTime.UtcNow;
			mineTrnx.GasFee = Convert.ToUInt64(result.GasPrice.Hex, 16);
			mineTrnx.LastTransactinTime = DateTime.Now;//trnxs.Last().CreationDate;
			mineTrnx.totalCoinFee = totalCoinFee;//trnxs.Sum(x => x.FeeInCoinAmount);
			mineTrnx.TotalFee = Convert.ToUInt64(result.GasLimit.Hex, 16);
			mineTrnx.txHash = result.Hash;

			mineTrnx.StatusType = totalCoinFee == 0 ? EnumType.Buy : EnumType.Transfer;
			mineTrnx.TransactionCount = trnxCount;
			mineTrnx.JsonTransactions = json;
			mineTrnx.Nonce = result.Nonce;

			_ctx.MineTransactions.Add(mineTrnx);
		}
	}
}
