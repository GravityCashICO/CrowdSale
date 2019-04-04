using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gravity.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Gravity.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public LoginController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public IActionResult Home()
        {
            return View();
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
        public IActionResult Send()
        {
            return View();
        }
        
        public IActionResult Transactions()
        {
            return View();
        }
        public IActionResult Wallet()
        {
            return View();
        }
    }
}