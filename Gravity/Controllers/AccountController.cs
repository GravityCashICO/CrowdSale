using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Gravity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gravity.Controllers
{
    [AllowAnonymous]
    [Route("Account")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("Login/{returnUrl?}")]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            return View();
        }
        [HttpPost]
        [Route("Login/{returnUrl?}")]
        public async Task<IActionResult> Login(string email, string password,string remember, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;


            var user = _userManager.FindByNameAsync(email).Result;
            if (user != null)
            {
                if (!_userManager.IsEmailConfirmedAsync
                     (user).Result)
                {
                    ModelState.AddModelError("",
                    "Email not confirmed!");
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
                var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token=code }, protocol: HttpContext.Request.Scheme);
                //await _emailSender.SendEmailAsync(model.Email, "Confirm your account",
                //   "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");

                await SendEmailAsync(email, "Please confirm your account by clicking this link: <a href=\"" + callbackUrl + "\">link</a>");
                return RedirectToAction(nameof(AccountController.Login), "Account");
                //await _signInManager.SignInAsync(user, isPersistent: false);
                //_logger.LogInformation(3, "User created a new account with password.");
                //return RedirectToAction(nameof(HomeController.Index), "Home");

                //return Content("Please check email to confirm your account ");
            }
            //AddErrors(result);


            return View();
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
                ViewBag.Message = "Email confirmed successfully!";
                return View();
            }
            else
            {
                ViewBag.Message = "Error while confirming your email!";
                return View();
            }
        }

        private async Task<bool> SendEmailAsync(string toAddress, string body)
        {
            var smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com", // set your SMTP server name here
                Port = 587, // Port 
                EnableSsl = true,
                Credentials = new NetworkCredential("telahy@gmail.com", "dhaka123")
            };

            using (var message = new MailMessage("telahy@gmail.com", toAddress)
            {
                IsBodyHtml = true,
                Subject = "Confirm your account",
                Body = body
            })
            {
                try
                {
                    await smtpClient.SendMailAsync(message);
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            return true;
        }
    }
}