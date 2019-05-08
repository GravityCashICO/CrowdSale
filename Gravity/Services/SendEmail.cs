using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Gravity.Services
{
    public static class SendEmail
    {
		public static async Task<bool> SendEmailAsync(string toAddress, string body)
		{
			try
			{
				var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
				var client = new SendGridClient(apiKey);
				var msg = new SendGridMessage()
				{
					From = new EmailAddress("no-reply@gravitycashonline.com", "GravityCash Team"),
					Subject = "Gravity Cash",
					//PlainTextContent = "Hello, Email!",
					HtmlContent = body
				};
				msg.AddTo(new EmailAddress(toAddress, "GravityCash User"));
				var response = await client.SendEmailAsync(msg);
			}
			catch (Exception ex)
			{

				throw ex;
			}
			return true;
		}
			public static async Task<bool> SendEmailAsyncn(string toAddress, string body)
        {
			var smtpClient = new SmtpClient
			{

				Host = "smtp-pulse.com", // set your SMTP server name here
				Port = 2525, // Port 
				EnableSsl = true,
				Credentials = new NetworkCredential("toufiqelahy3@gmail.com", "LAPLt6MbmGbTL")//"gravitycashonline@gmail.com", "yiwsebyqcwwudlmv")
            };

            using (var message = new MailMessage("support@gravitycashonline.com", toAddress)
            {
                IsBodyHtml = true,
                Subject = "Gravity Cash",
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
