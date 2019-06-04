using System.Threading.Tasks;
using Gravity.Models;
using Gravity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nethereum.Hex.HexConvertors.Extensions;
using System;
using Gravity.Data;
using Gravity.Helpers;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace Gravity.Controllers
{
	[AllowAnonymous]
	[Route("Account")]
	public class AccountController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
		private readonly ApplicationDbContext _ctx;
		public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext ctx)
		{
			_userManager = userManager;
			_signInManager = signInManager;
			_ctx = ctx;
		}

		[Route("Login/{returnUrl?}")]
		public IActionResult Login(string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;

			return View();
		}
		[HttpPost]
		[Route("Login/{returnUrl?}")]
		public async Task<IActionResult> Login(string email, string password, string remember, string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;


			var user = _userManager.FindByNameAsync(email).Result;
			if (user != null)
			{
				if (!_userManager.IsEmailConfirmedAsync
					 (user).Result)
				{
					var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
					var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = code }, protocol: HttpContext.Request.Scheme);

					var model = new ViewModels.emailVerification { UserName = user.FirstName + " " + user.LastName, Link = callbackUrl, Email = user.UserName };

					string viewHtml = await this.RenderViewAsync("emailVerification", model);
					await SendEmail.SendEmailAsync(user.UserName, viewHtml);
					//await SendEmail.SendEmailAsync(email, "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
					TempData["msg"] = "Need Email Confirmation. A Confirmation email already sent." + Admin.EmailNotice;
					return View();
				}
			}

			var result = await _signInManager.PasswordSignInAsync(email,
			password, true, lockoutOnFailure: false);
			if (result.Succeeded)
			{
				//_logger.LogInformation(1, "User logged in.");
				return RedirectToAction(nameof(LoginController.Home), "Login");
				//return LocalRedirect(returnUrl);
			}
			//if (result.RequiresTwoFactor)
			//{
			//    return RedirectToAction(nameof(SendCode), new { ReturnUrl = returnUrl, RememberMe = true });
			//}
			//if (result.IsLockedOut)
			//{
			//    //_logger.LogWarning(2, "User account locked out.");
			//    return View("Lockout");
			//}
			//else
			//{
			//    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
			//    return View(model);
			//}
			TempData["msg"] = "Invalid login attempt.";


			return View();
		}
		[Route("Register")]
		public IActionResult Register()
		{
			return View();
		}
		[HttpPost]
		[Route("Register")]
		public async Task<IActionResult> Register(string email, string password)
		{
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync("https://disposable.debounce.io/?email=" + email);

				using (var content = response.Content)
				{
					var json = await content.ReadAsStringAsync();
					dynamic rslt = JsonConvert.DeserializeObject(json);
					bool v = rslt.disposable;
					if (v == true)
					{
						TempData["msg"] = "Temporary Email Not Accepted";
						return View();
					}
				}

			}

			var user = new ApplicationUser { UserName = email, Email = email };
			var result = await _userManager.CreateAsync(user, password);
			if (result.Succeeded)
			{
				// For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
				// Send an email with this link
				var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
				var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = code, referral = Request.Query["referral"].ToString() }, protocol: HttpContext.Request.Scheme);

				//var resendUrl = Url.Action("ReSendEmail", "Account", new { email }, protocol: HttpContext.Request.Scheme);

				var model = new ViewModels.emailVerification { UserName = user.FirstName + " " + user.LastName, Link = callbackUrl, Email = user.UserName };

				string viewHtml = await this.RenderViewAsync("emailVerification", model);
				await SendEmail.SendEmailAsync(user.UserName, viewHtml);
				//await SendEmail.SendEmailAsync(email, "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
				TempData["msg"] = "A Confirmation email already sent...Check your Email." + Admin.EmailNotice;
				return RedirectToAction(nameof(AccountController.Login), "Account");
				//await _signInManager.SignInAsync(user, isPersistent: false);
				//_logger.LogInformation(3, "User created a new account with password.");
				//return RedirectToAction(nameof(HomeController.Index), "Home");

				//return Content("Please check email to confirm your account ");
			}
			else
			{
				TempData["msg"] = result.Errors.First().Description;//Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors);
			}
			//AddErrors(result);


			return View();
		}
		[Route("ReSendEmail")]
		public async Task<IActionResult> ReSendEmail(string email)
		{
			var user = _userManager.FindByNameAsync(email).Result;
			var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
			var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = code }, protocol: HttpContext.Request.Scheme);

			var resendUrl = Url.Action("ReSendEmail", "Account", new { userId = user.Id }, protocol: HttpContext.Request.Scheme);

			var model = new ViewModels.emailVerification { UserName = user.FirstName + " " + user.LastName, Link = callbackUrl, Email = user.UserName };

			string viewHtml = await this.RenderViewAsync("emailVerification", model);
			await SendEmail.SendEmailAsync(user.UserName, viewHtml);
			//await SendEmail.SendEmailAsync(email, "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
			TempData["msg"] = "A Confirmation email already sent." + Admin.EmailNotice;
			return RedirectToAction(nameof(AccountController.Login), "Account");

		}
		[Route("LogOut")]
		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			//_logger.LogInformation(4, "User logged out.");
			return RedirectToAction(nameof(AccountController.Login), "Account");
		}
		[Route("ConfirmEmail")]

		public IActionResult ConfirmEmail(string userid, string token)
		{
			var user = _userManager.FindByIdAsync(userid).Result;
			if (_userManager.IsEmailConfirmedAsync
					 (user).Result)
			{
				TempData["msg"] = "Email Already Confirmed!";
				return RedirectToAction("Login");
			}
				IdentityResult result = _userManager.
						ConfirmEmailAsync(user, token).Result;
			if (result.Succeeded)
			{
				TempData["msg"] = "Email confirmed successfully!";

				var ecKey = EthECKey.GenerateKey();//Nethereum.Signer.EthECKey.GenerateKey();
				var privateKey = ecKey.GetPrivateKeyAsBytes().ToHex();
				var account = new Nethereum.Web3.Accounts.Account(privateKey);

				var publicKey = Nethereum.Signer.EthECKey.GetPublicAddress(privateKey);

				var wallet = new Wallet();
				wallet.Id = new Guid();
				wallet.CreationDate = DateTime.UtcNow;
				wallet.PrivateKey = privateKey;
				wallet.PublicKey = publicKey;
				wallet.TotalCoin = Admin.signupReward;
				wallet.UserId = userid;
				_ctx.Wallets.Add(wallet);

				var referral = Request.Query["referral"].ToString().Trim();
				if (referral != "")
				{
					var referredUser = _userManager.FindByIdAsync(referral).Result;//the user who shared
					if (referredUser != null)
					{
						var referredUserAddr = _ctx.Wallets.First(x => x.UserId == referredUser.Id).PublicKey;
						AddRewardTrnx(Admin.referralReward, referredUserAddr);//referral
						AddRewardTrnx(Admin.referralReward, wallet.PublicKey);//referral

						var email = user.Email;
						var refferal = _ctx.Referrals.FirstOrDefault(x => x.Email == email);
						if (refferal == null)
						{
							refferal = new Referral();
							refferal.Email = email;
							refferal.Invitation = "Another Source";
							refferal.UserId = referredUser.Id;

							_ctx.Referrals.Add(refferal);
							//_ctx.SaveChanges();
						}
						refferal.Status = "Active";
						refferal.Bonus = "Success";
					}
				}
				AddRewardTrnx(Admin.signupReward, wallet.PublicKey);//signupReward

				_ctx.SaveChanges();
			}
			else
			{
				TempData["msg"] = "Error while confirming your email!" + result.Errors.First().Description;
			}
			return RedirectToAction("Login");
		}
		private void AddRewardTrnx(int amnt,string addrHolder)
		{
			var trns = new Models.Transaction
			{
				Id = new Guid(),
				CoinAmount = amnt,
				CreationDate = DateTime.UtcNow,
				FeeInCoinAmount = 0,
				FromKey = Admin.PublicKey,//wallet.PublicKey;
				Status = EnumType.Pending,
				ToKey = addrHolder,
				StatusType = EnumType.Reward
			};

			_ctx.Transactions.Add(trns);
		}

		[Route("ForgetPass")]
		public IActionResult ForgetPass()
		{
			return View();
		}
		[HttpPost]
		[Route("ForgetPass")]
		public async Task<IActionResult> ForgetPass(string email)
		{
			var user = _userManager.FindByNameAsync(email).Result;
			if (user == null)
			{
				TempData["msg"] = "User Not Exists";
				return RedirectToAction("ForgetPass");
			}
			var code = await _userManager.GeneratePasswordResetTokenAsync(user);
			var callbackUrl = Url.Action("ChangePass", "Account", new { email, token = code }, protocol: HttpContext.Request.Scheme);
			//await _emailSender.SendEmailAsync(model.Email, "Confirm your account",
			//   "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");

			//await SendEmail.SendEmailAsync(email, "Please change password by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");

			var model = new ViewModels.passwordReset { UserName = user.FirstName + " " + user.LastName, Link = callbackUrl };

			string viewHtml = await this.RenderViewAsync("passwordReset", model);
			await SendEmail.SendEmailAsync(user.UserName, viewHtml);


			TempData["msg"] = "Check your email!" + Admin.EmailNotice;

			return RedirectToAction("Login");
		}

		[Route("ChangePass")]
		public IActionResult ChangePass(string email, string token)
		{
			return View();
		}
		[HttpPost]
		[Route("ChangePass")]
		public async Task<IActionResult> ChangePass(string email, string token, string password)
		{
			var user = _userManager.FindByNameAsync(email).Result;


			var result = await _userManager.ResetPasswordAsync(
								user, token, password);
			if (result.Succeeded)
			{
				TempData["msg"] = "passwrd changed!";
			}
			else
			{
				TempData["msg"] = "Error while confirming your password!" + result.Errors.First().Description;
			}
			return RedirectToAction("Login");
		}
		[Authorize]
		[Route("Referral")]
		public async Task<IActionResult> Referral(string email=null)
		{
			var userId= User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value;
			if (email != null)
			{
				var refferal = _ctx.Referrals.FirstOrDefault(x => x.Email == email);
				if (refferal == null)
				{
					refferal = new Referral();
					refferal.Email = email;
					refferal.Status = "Unverified";
					refferal.Invitation = "Sent";
					refferal.Bonus = "Pending";
					refferal.UserId= userId;

					_ctx.Referrals.Add(refferal);
					_ctx.SaveChanges();
				}
				var callbackUrl = Url.Action("Register", "Account", new { referral = refferal.UserId }, protocol: HttpContext.Request.Scheme);
				//string viewHtml = "";
				await SendEmail.SendEmailAsync(email, callbackUrl);
			}
			return View(_ctx.Referrals.Where(x=>x.UserId==userId).ToList());
		}
		[Authorize]
		[Route("GetFreeCoin")]
		public IActionResult GetFreeCoin()
		{
			return View();
		}
	}
}