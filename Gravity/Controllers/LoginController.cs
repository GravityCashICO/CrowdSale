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
using Microsoft.EntityFrameworkCore;
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
			var publicKeys = GetPubKeys();
			ViewBag.publicKeys = publicKeys;
			var trns = _ctx.Transactions.Where(x => publicKeys.Any(pubKey => pubKey == x.FromKey || pubKey == x.ToKey)).OrderByDescending(x => x.CreationDate).Take(5).ToList();

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
		public async Task<IActionResult> Password_change(string oldPass, string password)
		{
			//var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value;
			var user = await _userManager.GetUserAsync(User);
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

			var result = await _userManager.UpdateAsync(mUser);

			TempData["msg"] = Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors); ;

			return View(mUser);
		}

		public IActionResult Send()
		{
			var publicKeys = GetPubKeys();
			ViewBag.publicKeys = publicKeys;
			return View();
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

		}
		[HttpPost]
		public async Task<IActionResult> Send(string addr, decimal amnt, decimal feee)//string addrHolder, 
		{
			var wallets = _ctx.Wallets.Where(x => x.UserId == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).ToList();


			//var fes = feee;
			decimal totalCoins = 0;
			decimal pendingCoins = 0;


			var web3 = new Web3(Admin.InfuraUrl);
			var handler = web3.Eth.GetContractHandler(Admin.ContractAddress);

			foreach (var wallet in wallets)
			{
				var balanceMessage = new BalanceOfFunction() { Owner = wallet.PublicKey };
				var balance = await handler.QueryAsync<BalanceOfFunction, BigInteger>(balanceMessage);
				var value = Web3.Convert.FromWeiToBigDecimal(balance);

				wallet.TotalCoin = Convert.ToDecimal(value.ToString());
				totalCoins += wallet.TotalCoin;

				var pendingTrnx = _ctx.Transactions.Where(x => x.FromKey == wallet.PublicKey && x.Status == EnumType.Pending).Sum(x => x.FeeInCoinAmount + x.CoinAmount);
				pendingCoins += pendingTrnx;

				wallet.TotalCoin -= pendingTrnx;

			}


			//assuming all have 18 decimals




			if (totalCoins < (amnt + feee + pendingCoins))
			{
				string err = "Insuffcient Balance ";
				err = pendingCoins != 0 ? err += "(Pending Transactions Amount) " + pendingCoins : err;
				TempData["msg"] = err;
				return RedirectToAction("Send");
			}
			else
			{
				decimal amountWithFee = (amnt + feee);
				var signer = new MessageSigner();
				var digest = "0x618e860eefb172f655b56aad9bdc5685c037efba70b9c34a8e303b19778efd2c";
				foreach (var wallet in wallets.Where(x => x.TotalCoin > 0 && x.PublicKey != addr).OrderBy(n => Math.Abs(amountWithFee - n.TotalCoin)))
				{
					if (wallet.TotalCoin >= amountWithFee)
					{
						wallet.TotalCoin = wallet.TotalCoin - amountWithFee;

						var trns = new Models.Transaction
						{
							Id = new Guid(),
							CoinAmount = amountWithFee - feee,
							CreationDate = DateTime.UtcNow,
							FeeInCoinAmount = feee,
							FromKey = wallet.PublicKey,
							Status = EnumType.Pending,
							ToKey = addr,
							StatusType = EnumType.Transfer,
							Signature = signer.Sign(digest.HexToByteArray(), wallet.PrivateKey)
						};
						_ctx.Transactions.Add(trns);
						break;
					}
					else
					{
						var trns = new Models.Transaction
						{
							Id = new Guid(),
							CoinAmount = wallet.TotalCoin - feee,
							CreationDate = DateTime.UtcNow,
							FeeInCoinAmount = feee,
							FromKey = wallet.PublicKey,
							Status = EnumType.Pending,
							ToKey = addr,
							StatusType = EnumType.Transfer,
							Signature = signer.Sign(digest.HexToByteArray(), wallet.PrivateKey)
						};
						_ctx.Transactions.Add(trns);


						amountWithFee = amountWithFee - wallet.TotalCoin;
						wallet.TotalCoin = 0;
					}

					feee = 0;
				}

				var walletTo = _ctx.Wallets.FirstOrDefault(x => x.PublicKey == addr);

				if (walletTo != null)
				{
					walletTo.TotalCoin = walletTo.TotalCoin + amnt;
				}




				_ctx.SaveChanges();


			}

			return RedirectToAction("Home");
		}

		public IActionResult Transactions()
		{
			var publicKeys = GetPubKeys();
			ViewBag.publicKeys = publicKeys;
			var trns = _ctx.Transactions.Where(x => publicKeys.Any(pubKey => pubKey == x.FromKey || pubKey == x.ToKey)).OrderByDescending(x => x.CreationDate).ToList();

			return View(trns);
		}
		public IActionResult Wallet()
		{
			return View(_ctx.Wallets.Where(x => x.UserId == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).ToList());
		}

		public async Task<IActionResult> ICO()
		{
			return View(await _ctx.Packages.ToListAsync());
		}


		public string[] GetPubKeys()
		{
			var publicKeys = _ctx.Wallets.Where(x => x.UserId == User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value).Select(x => x.PublicKey).ToArray();
			return publicKeys;
		}
	}
}