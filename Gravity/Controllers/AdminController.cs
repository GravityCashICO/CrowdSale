using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gravity.Data;
using Gravity.Models;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index()
        {
            var trnxs = _ctx.Transactions.Where(x => x.Status == EnumType.Pending).ToList();

            var Signature = trnxs.Select(x => x.Signature);
            string signs = string.Join(".", Signature);
            string[] _toes = trnxs.Select(x => x.ToKey).ToArray();

            var p = Convert.ToDecimal(Math.Pow(10, 18));
            
            decimal[] _values = trnxs.Select(x => x.CoinAmount*p).ToArray();
            decimal[] _fees = trnxs.Select(x => x.FeeInCoinAmount * p).ToArray();
            var _nonces = Enumerable.Repeat(0, trnxs.Count).ToArray();


            /////
            var web3 = new Web3(Admin.InfuraUrl);
            var contract = web3.Eth.GetContract(Admin.abi, Admin.ContractAddress);
            var transferArrayFunction = contract.GetFunction("transferArray");

            string hash;
            object[] b = new object[] { signs, _toes, _values, _fees, _nonces };
            try
            {
                var rslt = transferArrayFunction.CreateTransactionInput(Admin.PublicKey, functionInput: b);

                var jh = await transferArrayFunction.SendTransactionAndWaitForReceiptAsync(input: rslt);
                var r=jh.TransactionHash;
                var c = await transferArrayFunction.CallRawAsync(rslt);
            }
            catch (Exception ex)
            {

                throw;
            }
            


            return View();
        }
    }
}