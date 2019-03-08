using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Gravity.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
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
        public IActionResult Profile()
        {
            return View();
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