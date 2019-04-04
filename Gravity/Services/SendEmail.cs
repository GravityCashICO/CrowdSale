﻿using System;
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
