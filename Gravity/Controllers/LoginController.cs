using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Gravity.Data;
using Gravity.Models;
using Gravity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Signer;
using Nethereum.StandardTokenEIP20.ContractDefinition;
using Nethereum.Web3;

namespace Gravity.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _ctx;
        public LoginController(UserManager<ApplicationUser> userManager, ApplicationDbContext ctx)
        {
            _ctx = ctx;
            _userManager = userManager;
        }
        public IActionResult Home()
        {
            var publicKeys = _ctx.Wallets.Where(x => x.UserId == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(x=>x.PublicKey).ToList();
            ViewBag.publicKeys = publicKeys;
            var trns = _ctx.Transactions.Where(x => publicKeys.Any(pubKey => pubKey == x.FromKey || pubKey == x.ToKey)).OrderByDescending(x=>x.CreationDate).ToList();

            return View(trns);
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Password_change()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Password_change(string oldPass,string password)
        {
            //var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value;
            var user =await _userManager.GetUserAsync(User);
            var result = await _userManager.ChangePasswordAsync(
                                user, oldPass, password);

            TempData["msg"] = Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors); ;

            return View();
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(ApplicationUser user)
        {
            var mUser = await _userManager.FindByIdAsync(user.Id);
            mUser.PhoneNumber = user.PhoneNumber;

            mUser.FirstName = user.PhoneNumber;
            mUser.LastName = user.LastName;
            mUser.Country = user.Country;
            mUser.Sex = user.Sex;
            mUser.Address = user.Address;

            var result= await _userManager.UpdateAsync(mUser);

            TempData["msg"] = Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors); ;

            return View(mUser);
        }
        
        public IActionResult Send(string addrHolder)
        {
           
            //   var msg1 = "0x9999d9b4714b9639caa28716da353e9e1c22253f58216f2eda5adbb784767ee5";
            //var msg1Bytes = msg1.HexToByteArray();
            ////var msg1Hex = msg1Bytes.ToHex(true);
        
            //string prveKey = "755e1e09cd0ce504ad06c477fdf7c18167c0582267bd04d0cfa71c06eafa3564";
            //Nethereum.Signer.EthECKey privateKey = new Nethereum.Signer.EthECKey(prveKey);
            //var signer = new MessageSigner();
            //var signature = signer.Sign(msg1Bytes, prveKey);
            
            //web3.Client.SendRequestAsync(method:"transferArray", paramList: new { b=""});
            //var web3 = new Nethereum.Web3.Web3("HTTP://127.0.0.1:7545");
            //var ipcClient = new Nethereum.JsonRpc.IpcClient("./geth.ipc");
            //var web3 = new Nethereum.Web3.Web3(ipcClient);

            //var encoded = web3.OfflineTransactionSigning.SignTransaction(privateKey, receiveAddress, 10, txCount.Value);
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Send(string addrHolder, string addr,decimal amnt)
        {
            var wallet = _ctx.Wallets.First(x => x.PublicKey == addrHolder);
            var fes = amnt * Convert.ToDecimal(Admin.feis);


            var web3 = new Web3(Admin.InfuraUrl);
            var handler = web3.Eth.GetContractHandler(Admin.ContractAddress);
            var balanceMessage = new BalanceOfFunction() { Owner = wallet.PublicKey };
            var balance = await handler.QueryAsync<BalanceOfFunction, BigInteger>(balanceMessage);

            //assuming all have 18 decimals
            var value = Web3.Convert.FromWeiToBigDecimal(balance);

            var pendingTrnx = _ctx.Transactions.Where(x => x.FromKey == wallet.PublicKey && x.Status == EnumType.Pending).Sum(x => x.FeeInCoinAmount + x.CoinAmount);

            if (value < (amnt+ fes+pendingTrnx))
            {
                string err = "Insuffcient valance ";
                err= pendingTrnx != 0 ? err += "(Pending Transactions Amount) "+pendingTrnx : err;
                TempData["msg"] = err;
                return RedirectToAction("Send",new { addrHolder= addrHolder });
            }
            else
            {
                wallet.TotalCoin = wallet.TotalCoin - (amnt+fes);

                var walletTo= _ctx.Wallets.FirstOrDefault(x => x.PublicKey == addr);
                if (walletTo != null)
                {
                    walletTo.TotalCoin = walletTo.TotalCoin + amnt;
                }


                var trns = new Models.Transaction
                {
                    Id = new Guid(),
                    CoinAmount = amnt,
                    CreationDate = DateTime.UtcNow,
                    FeeInCoinAmount = fes,
                    FromKey = wallet.PublicKey,
                    Status = EnumType.Pending,
                    ToKey = addr,
                    StatusType = EnumType.Transfer
                };


                /////
                //var web3 = new Web3(Admin.InfuraUrl);
                //var contract = web3.Eth.GetContract(Admin.abi, Admin.ContractAddress);
                //var recoverPreSignedHashFunction = contract.GetFunction("recoverPreSignedHash");
                
                //var p = Convert.ToDecimal(Math.Pow(10, 18));
                //var to = trns.ToKey;
                //var val = trns.CoinAmount;

                //val = val * p;//(10 ** 18);
                //var fee = trns.FeeInCoinAmount;
                //fee = fee * p;
                //var nonce = 0;
                //var transferSig = "0x48664c16".HexToByteArray();

                //var prms = new { _token = Admin.ContractAddress, _functionSig = transferSig, _spender = to, _value = val, _fee = fee, _nonce = nonce };
                //string hash;
                //object[] b = new object[] { Admin.ContractAddress, transferSig, to, val, fee, nonce };
                //try
                //{
                //    var rslt = recoverPreSignedHashFunction.CreateCallInput(functionInput: b);
                //    var c = await recoverPreSignedHashFunction.CallRawAsync(rslt);
                //    hash = c.ToHex();
                //}
                //catch (Exception ex)
                //{

                //    throw;
                //}

                //trns.HashHex = hash;
                var signer = new MessageSigner();
                var digest = "0x618e860eefb172f655b56aad9bdc5685c037efba70b9c34a8e303b19778efd2c";
                trns.Signature= signer.Sign(digest.HexToByteArray(), wallet.PrivateKey);
                

                _ctx.Transactions.Add(trns);

                _ctx.SaveChanges();

                
            }

            return RedirectToAction("Home");
        }

        public IActionResult Transactions()
        {
            var publicKeys = _ctx.Wallets.Where(x => x.UserId == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(x => x.PublicKey).ToList();
            ViewBag.publicKeys = publicKeys;
            return View();
        }
        public IActionResult Wallet()
        {
            return View(_ctx.Wallets.Where(x=>x.UserId== User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).ToList());
        }
    }
}