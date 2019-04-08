using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Gravity.Models;
using Newtonsoft.Json;

namespace Gravity.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var s = "[{\"Key\":\"amount1\",\"Value\":[\"1\"]},{\"Key\":\"amount2\",\"Value\":[\"1\"]}]";
            //Dictionary<string, dynamic> vv = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(s);
            
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
