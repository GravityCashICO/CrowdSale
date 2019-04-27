using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Gravity.Data;
using Gravity.Models;
using Gravity.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.EntityFrameworkCore;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Web3;

namespace Gravity.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _ctx;
        public AdminController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
		public async Task<IActionResult> Test(string s,[FromServices] INodeServices nodeServices)
		{
			try
			{
				var result = await nodeServices.InvokeAsync<string>("wwwroot/Scripts/test.js", s);
				return Content(result);
			}
			catch (Exception ex)
			{

				return Content(ex.Message);
			}
		}
		public async Task<IActionResult> Test2(string s, [FromServices] INodeServices nodeServices)
		{
			try
			{
				var result = await nodeServices.InvokeAsync<string>("wwwroot/Scripts/test.js", s);
				return Content(result);
			}
			catch (Exception ex)
			{

				return Content(ex.Message);
			}
		}
		public async Task<IActionResult> AutoPush([FromServices] INodeServices nodeServices)
        {
            var trnxs = await _ctx.Transactions.Where(x => x.Status == EnumType.Pending).OrderBy(x => x.CreationDate).ToListAsync();

            if (trnxs.Count <= 0)
            {
                return null;
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
                    //AddMineTransaction(result, json_obj, airdrop.Count());  //
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
                    //AddMineTransaction(result, json_obj, autoPush.Count());  //
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

                await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "Node Error:exception: " + json_obj + " resp  " + Newtonsoft.Json.JsonConvert.SerializeObject(result) + Newtonsoft.Json.JsonConvert.SerializeObject(ex));
                //await _ctx.SaveChangesAsync();

            }

            // await _ctx.SaveChangesAsync();
            //var trnxs = _ctx.Transactions.Where(x => x.Status == EnumType.Pending).OrderBy(x => x.CreationDate).ToList();
            //if (trnxs.Count > 0)
            //{

            //    var Signatures = trnxs.Select(x => x.Signature).ToArray();
            //    //string signs = string.Join(".", Signature);
            //    string[] _toes = trnxs.Select(x => x.ToKey).ToArray();

            //    var p = System.Convert.ToDecimal(Math.Pow(10, 18));

            //    string[] _values = trnxs.Select(x => (x.CoinAmount * p).ToString().Split('.')[0]).ToArray();
            //    //decimal[] _fees = trnxs.Select(x => x.FeeInCoinAmount * p).ToArray();
            //    string[] _nonces = Enumerable.Repeat("0", trnxs.Count).ToArray();

            //    var obj = new { signatures = Signatures, _toes, _values, _fees = _nonces };
            //    string json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            //    var result = await nodeServices.InvokeAsync<PushResp>("wwwroot/Scripts/AutoPush.js", json_obj);

            //    foreach (var trn in trnxs)
            //    {
            //        trn.Status = EnumType.Success;
            //    }

            //    var mineTrnx = new MineTransaction();
            //    mineTrnx.Id = new Guid();
            //    mineTrnx.CreationDate = DateTime.UtcNow;
            //    mineTrnx.GasFee = Convert.ToInt32(result.GasPrice.Hex, 16);
            //    mineTrnx.LastTransactinTime = trnxs.Last().CreationDate;
            //    mineTrnx.totalCoinFee = trnxs.Sum(x => x.FeeInCoinAmount);
            //    mineTrnx.TotalFee = Convert.ToInt32(result.GasLimit.Hex, 16);
            //    mineTrnx.txHash = result.Hash;

            //    _ctx.MineTransactions.Add(mineTrnx);
            //    await _ctx.SaveChangesAsync();

            //    return Content(Newtonsoft.Json.JsonConvert.SerializeObject(result));
            //}

            return null;
        }
        public async Task<IActionResult> Explorer()
        {
            return View(await _ctx.MineTransactions.ToListAsync());
        }
		[HttpPost]
		public async Task<IActionResult> Explorer(string hash)
		{
			if (hash.Length < 50)//48
			{
				var trnx = await _ctx.Transactions.Where(x => x.FromKey == hash || x.ToKey==hash).ToListAsync();

				return View("_Transactions", trnx);
			}
			var mt= await _ctx.MineTransactions.Where(x => x.txHash == hash).ToListAsync();

			return View("_HashExplorer",mt);
		}
		public async Task<IActionResult> Index()
        {
            Admin.IsQuartzDone = true;

            

            return Content("Success");
            //return View(trnxs);
        }

        public async Task<string> UploadTransaction(string hash, DateTime lastTrnxDate)
        {
            var trnxs = _ctx.Transactions.Where(x => x.Status == EnumType.Pending && DateTime.Compare(x.CreationDate, lastTrnxDate) <= 0).ToList();
            //trnxs = trnxs.Where(x => DateTime.Compare(x.CreationDate, lastTrnxDate) <= 0).ToList();
            foreach (var trn in trnxs)
            {
                trn.Status = EnumType.Success;
            }

            var mineTrnx = new MineTransaction();
            mineTrnx.Id = new Guid();
            mineTrnx.CreationDate = DateTime.UtcNow;
            mineTrnx.GasFee = 0;
            mineTrnx.LastTransactinTime = lastTrnxDate;
            mineTrnx.totalCoinFee = 0;
            mineTrnx.TotalFee = 0;
            mineTrnx.txHash = hash;

            _ctx.MineTransactions.Add(mineTrnx);
            await _ctx.SaveChangesAsync();

            return "Transactions Uplooaded..!";
        }

    }
}