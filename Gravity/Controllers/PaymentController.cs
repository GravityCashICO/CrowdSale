using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gravity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Gravity.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        public IActionResult Buy()
        {
            if (TempData["url"] != null)
            {
                var url = TempData["url"].ToString();
                TempData["url"] = null;
                return Redirect(url);
            }
            return View();
        }
        //public IActionResult Index(string code,string price="0")

        //{
        //    var cmd = "create_transaction";

        //    SortedList<string, string> sl = new SortedList<string, string>
        //    {
        //        //{ "currency", "BTC" },
        //        //{ "format", "json" },
        //        { "amount", price },
        //        { "currency1", code },
        //         { "currency2", code },
        //        {"buyer_email","toufiqelahy@hotmail.com" },
        //        {"ipn_url","https://gravitycash.azurewebsites.net/Payment/IpnBack" }
        //    };
        //    //sl.Add("version", 1);

        //    //sl.Add("currency", "BTC");
        //    //sl.Add("version", 1);
        //    //sl.Add("currency", "BTC");
        //    //sl.Add("version", 1);
        //    var response= CoinPayments.CallAPI(cmd, sl);


        //    return Redirect(sl["ipn_url"]);
        //}
        [HttpPost]
        public IActionResult Buy(string code, string amnt)
        {
            var cmd = "create_transaction";

            SortedList<string, string> sl = new SortedList<string, string>
            {
                //{ "currency", "BTC" },
                //{ "format", "json" },
                { "amount", amnt },
                { "currency1", code },
                 { "currency2", code },
                {"buyer_email","toufiqelahy@hotmail.com" },
                {"ipn_url","https://gravitycash.azurewebsites.net/Payment/IpnBack" }
            };
            //sl.Add("version", 1);

            //sl.Add("currency", "BTC");
            //sl.Add("version", 1);
            //sl.Add("currency", "BTC");
            //sl.Add("version", 1);
            var response = CoinPayments.CallAPI(cmd, sl);
            string url = response["result"]["status_url"];

            TempData["url"] = url;

           return Redirect(url);

        }
        public async Task<IActionResult> Ipn()
        {
            var req = Request;
            var h = JsonConvert.SerializeObject(req.Headers);
            var q = req.QueryString.Value;
            var f = JsonConvert.SerializeObject(req.Form);

            await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "get  " + q + "   headers   " + h + "   form   " + f);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Ipn(object obj)
        {
            var req = Request;
            var h = JsonConvert.SerializeObject(req.Headers);
            var q = req.QueryString.Value;
            var f = JsonConvert.SerializeObject(req.Form);
            
            await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com","post  "+ q+ "   headers   " + h +"   form   "+f);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> IpnBack()
        {
            var req = Request;
            var h = JsonConvert.SerializeObject(req.Headers);
            var q = req.QueryString.Value;
            var f = JsonConvert.SerializeObject(req.Form);

            await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "postBack  " + q + "   headers   " + h + "   form   " + f);
            return Ok();
        }
    }
}