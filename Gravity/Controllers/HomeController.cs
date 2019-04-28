using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gravity.Models;
using Newtonsoft.Json;
using Gravity.Helpers;
using Gravity.Services;

namespace Gravity.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
			//var s = "[{\"Key\":\"amount1\",\"Value\":[\"1\"]},{\"Key\":\"amount2\",\"Value\":[\"1\"]}]";
			//Dictionary<string, dynamic> vv = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(s);
			var model = new ViewModels.PaymentConfirmation { UserName = "tou", received_amount = "2.1", currency2 = "BTC" };

			string viewHtml = await this.RenderViewAsync("paymentConfimation", model);
			await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", viewHtml);

			return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
