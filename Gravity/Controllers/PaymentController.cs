using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Gravity.Data;
using Gravity.Helpers;
using Gravity.Models;
using Gravity.Services;
using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Signer;
using Nethereum.Web3;
using Newtonsoft.Json;

namespace Gravity.Controllers
{

    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _ctx;
        public PaymentController( ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
		public async Task<IActionResult> Custom()
		{
			return View();
		}
		public async Task<IActionResult> BuyCustom(double amnt, string code)
		{
			var wallet = _ctx.Wallets.First();

			int percentage = 0;
			if (amnt > 2000)
			{
				percentage = 22;//22%
			}

			var amount = amnt;
			var coin = (1 / Admin.CoinPriceUSD) * amount;
			var bonus = (coin * percentage) / 100;
			//amnt = amnt * .005;//fee .5% fee
			var cmd = "create_transaction";

			SortedList<string, string> sl = new SortedList<string, string>
			{
                //{ "currency", "BTC" },
                //{ "format", "json" },
                { "amount", amount.ToString() },
				{ "currency1", "USD" },
				 { "currency2", code },
				{"buyer_email","toufiqelahy@hotmail.com" },
				{"ipn_url","https://gravitycash.azurewebsites.net/Payment/IpnBack?addrHolder="+wallet.PublicKey+"&amnt="+(coin+bonus) }
			};

			var response = CoinPayments.CallAPI(cmd, sl);
			string url = response["result"]["status_url"];

			return RedirectToAction("Crypto", new { url });
		}
		public async Task<IActionResult> Package(int pkgId)
		{
			var package = await _ctx.Packages
				.FirstAsync(m => m.Id == pkgId);
			return View(package);
		}
		
		public async Task<IActionResult> BuyPackage(int pkgId, string code)
		{
			var wallet = _ctx.Wallets.First();

			var package = await _ctx.Packages
				.FirstAsync(m => m.Id == pkgId);

			var amount = package.PriceInUSD;
			var coin = (1 / Admin.CoinPriceUSD) * amount;
			var bonus = (coin * package.ExtraCoinPercentage) / 100;
			//amnt = amnt * .005;//fee .5% fee
			var cmd = "create_transaction";

			SortedList<string, string> sl = new SortedList<string, string>
			{
                //{ "currency", "BTC" },
                //{ "format", "json" },
                { "amount", amount.ToString() },
				{ "currency1", "USD" },
				 { "currency2", code },
				{"buyer_email","toufiqelahy@hotmail.com" },
				{"ipn_url","https://gravitycash.azurewebsites.net/Payment/IpnBack?addrHolder="+wallet.PublicKey+"&amnt="+(coin+bonus) }
			};
			
			var response = CoinPayments.CallAPI(cmd, sl);
			string url = response["result"]["status_url"];

			return RedirectToAction("Crypto", new { url });
		}
		

		public IActionResult Buy(string addrHolder)
        {
            //if (TempData["url"] != null)
            //{
            //    var url = TempData["url"].ToString();
            //    TempData["url"] = null;
            //    return Redirect(url);
            //}
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
        public IActionResult Buy(string addrHolder,string code, double amnt)
        {
            var amount = amnt * Admin.CoinPrice;
            //amnt = amnt * .005;//fee .5% fee
            var cmd = "create_transaction";

            SortedList<string, string> sl = new SortedList<string, string>
            {
                //{ "currency", "BTC" },
                //{ "format", "json" },
                { "amount", amount.ToString() },
                { "currency1", Admin.CoinUit },
                 { "currency2", code },
                {"buyer_email","toufiqelahy@hotmail.com" },
                {"ipn_url","https://gravitycash.azurewebsites.net/Payment/IpnBack?addrHolder="+addrHolder+"&amnt="+amnt }
            };
            //sl.Add("version", 1);

            //sl.Add("currency", "BTC");
            //sl.Add("version", 1);
            //sl.Add("currency", "BTC");
            //sl.Add("version", 1);
            var response = CoinPayments.CallAPI(cmd, sl);
            string url = response["result"]["status_url"];

            TempData["url"] = url;


            return View();
            //return RedirectToAction("Crypto", new { url });
        }

        public async Task<IActionResult> Crypto(string url)
        {
            //url= HttpUtility.UrlDecode(url);
            
            var Webget = new HtmlWeb();
            var doc = Webget.Load(url);


            //var doc = new HtmlAgilityPack.HtmlDocument();
            //doc.Load(url);

            //IList<HtmlNode> nodes = doc.QuerySelectorAll("div .my-class[data-attr=123] > ul li");
            //HtmlNode node = nodes[0].QuerySelector("p.with-this-class span[data-myattr]");
            HtmlNode node = doc.QuerySelector("div.page-row.page-row-expanded");
            ViewBag.html = node.OuterHtml;

            return View();
        }

            public async Task<IActionResult> Ipn()
        {
            //var req = Request;
            //var h = JsonConvert.SerializeObject(req.Headers);
            //var q = req.QueryString.Value;
            //var f = JsonConvert.SerializeObject(req.Form);

            //await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "get  " + q + "   headers   " + h + "   form   " + f);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Ipn(object obj)
        {
            var req = Request;
            var h = JsonConvert.SerializeObject(req.Headers);
            var q = req.QueryString.Value;
            var f = JsonConvert.SerializeObject(req.Form);
            
            //await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com","post  "+ q+ "   headers   " + h +"   form   "+f);
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> IpnBack(string addrHolder, decimal amnt)
        {
            var req = Request;
            var forms = req.Form;
            var status = Convert.ToInt32(forms["status"]);
            //var req = Request;
            var h = JsonConvert.SerializeObject(req.Headers);
            var q = req.QueryString.Value;
            var f = JsonConvert.SerializeObject(req.Form);

            //await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com","post  "+ q+ "   headers   " + h +"   form   "+f);
            if (status == 2 || status>=100)
            {
                

                var wallet = _ctx.Wallets.First(x => x.PublicKey == addrHolder);
				var user = _ctx.Users.First(x => x.Id == wallet.UserId);
				var userName = user.FirstName + " " + user.LastName;
				var received_amount = forms["received_amount"].ToString();
				var currency2 = forms["currency2"].ToString();

				var model = new ViewModels.PaymentConfirmation { UserName=userName,received_amount=received_amount,currency2=currency2};

				string viewHtml = await this.RenderViewAsync("paymentConfimation", model);
				await SendEmail.SendEmailAsync(user.UserName, viewHtml);
				await SendEmail.SendEmailAsync("toufiqelahy@hotmail.com", "postBack " + q + "  " + JsonConvert.SerializeObject(req.Form));
				wallet.TotalCoin = wallet.TotalCoin + amnt;

                var trns = new Models.Transaction
                {
                    Id = new Guid(),
                    CoinAmount = amnt,
                    CreationDate = DateTime.UtcNow,
                    FeeInCoinAmount = 0,
                    FromKey = Admin.PublicKey,//wallet.PublicKey;
                    Status = EnumType.Pending,
                    ToKey = addrHolder,
                    StatusType = EnumType.Buy
                };

                var signer = new MessageSigner();
                var digest = "0x618e860eefb172f655b56aad9bdc5685c037efba70b9c34a8e303b19778efd2c";
                trns.Signature = signer.Sign(digest.HexToByteArray(), Admin.PrivateKey);


                _ctx.Transactions.Add(trns);

                _ctx.SaveChanges();
            }
           
            
            return Ok();
        }
    }
}