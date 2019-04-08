using System.Threading.Tasks;
using Gravity.Models;
using Gravity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Nethereum.Hex.HexConvertors.Extensions;
using System;
using Gravity.Data;

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
                    
                    await SendEmail.SendEmailAsync(email, "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
                    TempData["msg"] = "Need Email Confirmation. A Confirmation email already sent...";
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

            var user = new ApplicationUser { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=532713
                // Send an email with this link
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = code }, protocol: HttpContext.Request.Scheme);

                var resendUrl = Url.Action("ReSendEmail", "Account", new { email }, protocol: HttpContext.Request.Scheme);


                await SendEmail.SendEmailAsync(email, "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
                TempData["msg"] = "A Confirmation email already sent... <a href=\"" + resendUrl + "\">Send Again</a>";
                return RedirectToAction(nameof(AccountController.Login), "Account");
                //await _signInManager.SignInAsync(user, isPersistent: false);
                //_logger.LogInformation(3, "User created a new account with password.");
                //return RedirectToAction(nameof(HomeController.Index), "Home");

                //return Content("Please check email to confirm your account ");
            }
            else
            {
                TempData["msg"] = Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors);
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


            await SendEmail.SendEmailAsync(email, "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
            TempData["msg"] = "A Confirmation email already sent... <a href=\"" + resendUrl + "\">Send Again</a>";
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
            IdentityResult result = _userManager.
                        ConfirmEmailAsync(user, token).Result;
            if (result.Succeeded)
            {
                
                TempData["msg"] = "Email confirmed successfully!";
            }
            else
            {
                TempData["msg"] = "Error while confirming your email!"+Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors); ;
            }
            return RedirectToAction("Login");
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
            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = Url.Action("ChangePass", "Account", new { email, token = code }, protocol: HttpContext.Request.Scheme);
            //await _emailSender.SendEmailAsync(model.Email, "Confirm your account",
            //   "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");

            await SendEmail.SendEmailAsync(email, "Please change password by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");

            TempData["msg"] = "Check your email!";
        
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
                TempData["msg"] = "Error while confirming your password!"+ Newtonsoft.Json.JsonConvert.SerializeObject(result.Errors); ;
            }
            return RedirectToAction("Login");
        }
    }
}