using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gravity.Data;
using Gravity.Models;
using Microsoft.AspNetCore.Mvc;
using Nethereum.Hex.HexConvertors.Extensions;

namespace Gravity.Controllers
{
	public class WalletController : Controller
	{
		private readonly ApplicationDbContext _ctx;
		public WalletController(ApplicationDbContext ctx)
		{
			_ctx = ctx;
		}
		public IActionResult Create(string userId)
		{


			var ecKey = EthECKey.GenerateKey();//Nethereum.Signer.EthECKey.GenerateKey();
			var privateKey = ecKey.GetPrivateKeyAsBytes().ToHex();
			var account = new Nethereum.Web3.Accounts.Account(privateKey);

			var publicKey = Nethereum.Signer.EthECKey.GetPublicAddress(privateKey);

			var wallet = new Wallet();
			wallet.Id = new Guid();
			wallet.CreationDate = DateTime.UtcNow;
			wallet.PrivateKey = privateKey;
			wallet.PublicKey = publicKey;
			wallet.TotalCoin = 0;
			wallet.UserId = userId;
			_ctx.Wallets.Add(wallet);

			_ctx.SaveChanges();


			return RedirectToAction(nameof(LoginController.Wallet), "Login");
		}

		public IActionResult Import(string userId, string privateKey)
		{
			if (_ctx.Wallets.FirstOrDefault(x => x.PrivateKey == privateKey.Trim()) != null)
			{
				TempData["msg"] = "Wallet Already Exists..!";
				return RedirectToAction(nameof(LoginController.Wallet), "Login");
			}

			//var ecKey = EthECKey.GenerateKey();//Nethereum.Signer.EthECKey.GenerateKey();
			//var privateKey = ecKey.GetPrivateKeyAsBytes().ToHex();
			//var account = new Nethereum.Web3.Accounts.Account(privateKey);

			var publicKey = Nethereum.Signer.EthECKey.GetPublicAddress(privateKey);

			var wallet = new Wallet();
			wallet.Id = new Guid();
			wallet.CreationDate = DateTime.UtcNow;
			wallet.PrivateKey = privateKey;
			wallet.PublicKey = publicKey;
			wallet.TotalCoin = 0;
			wallet.UserId = userId;
			_ctx.Wallets.Add(wallet);

			_ctx.SaveChanges();


			return RedirectToAction(nameof(LoginController.Wallet), "Login");
		}
	}
}