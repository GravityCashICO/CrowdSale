using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Gravity.Data;
using Gravity.Models;
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
        public async Task<IActionResult> AutoPush([FromServices] INodeServices nodeServices)
        {
            var trnxs = _ctx.Transactions.Where(x => x.Status == EnumType.Pending).OrderBy(x => x.CreationDate).ToList();

            var Signature = trnxs.Select(x => x.Signature);
            string signs = string.Join(".", Signature);
            string[] _toes = trnxs.Select(x => x.ToKey).ToArray();

            var p = System.Convert.ToDecimal(Math.Pow(10, 18));

            string[] _values = trnxs.Select(x => (x.CoinAmount * p).ToString().Split('.')[0]).ToArray();
            decimal[] _fees = trnxs.Select(x => x.FeeInCoinAmount * p).ToArray();
            string[] _nonces = Enumerable.Repeat("0", trnxs.Count).ToArray();

            var obj = new { signs, _toes, _values, _fees = _nonces, _nonces };
            string json_obj = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

            var result = await nodeServices.InvokeAsync<object>("wwwroot/Scripts/AutoPush.js", json_obj);

            return Content(Newtonsoft.Json.JsonConvert.SerializeObject(result));
        }
        public async Task<IActionResult> Explorer()
        {
            return View(await _ctx.MineTransactions.ToListAsync());
        }
            public async Task<IActionResult> Index()
        {
            var trnxs = _ctx.Transactions.Where(x => x.Status == EnumType.Pending).OrderBy(x => x.CreationDate).ToList();

            var Signature = trnxs.Select(x => x.Signature);
            string signs = string.Join(".", Signature);
            string[] _toes = trnxs.Select(x => x.ToKey).ToArray();

            var p = Convert.ToDecimal(Math.Pow(10, 18));

            string[] _values = trnxs.Select(x => (x.CoinAmount * p).ToString().Split('.')[0]).ToArray();
            decimal[] _fees = trnxs.Select(x => x.FeeInCoinAmount * p).ToArray();
            string[] _nonces = Enumerable.Repeat("0", trnxs.Count).ToArray();

            ViewBag.signs = signs;
            /////
            var web3 = new Web3(Admin.InfuraUrl);
            var contract = web3.Eth.GetContract(Admin.abi, Admin.ContractAddress);
            var transferArrayFunction = contract.GetFunction("transferArray");

            string hash;
            object[] b = new object[] { signs, _toes, _values, _fees, _nonces };
            try
            {
                var rslt = transferArrayFunction.CreateCallInput(functionInput: b);
                var c = await transferArrayFunction.CallRawAsync(rslt);
                hash = c.ToHex();


                var rslt1 = transferArrayFunction.CreateTransactionInput(Admin.PublicKey, functionInput: b);

                //var jh = await transferArrayFunction.SendTransactionAndWaitForReceiptAsync(input: rslt1);
                //var r = jh.TransactionHash;
                //var cv = await transferArrayFunction.CallRawAsync(rslt);
            }
            catch (Exception ex)
            {

                throw;
            }


            return Content("Success");
            //return View(trnxs);
        }

        public async Task<string> UploadTransaction(string hash,DateTime lastTrnxDate)
        {
            var trnxs = _ctx.Transactions.Where(x => x.Status == EnumType.Pending&& DateTime.Compare(x.CreationDate, lastTrnxDate) <= 0).ToList();
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