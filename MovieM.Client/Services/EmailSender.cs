using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MovieM.Client.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            try
            {
                using var msg = new MailMessage();
                msg.To.Add(new MailAddress(email));
                msg.From = new MailAddress("tgm.muzaffer.deveci@gmail.com", "MovieM");
                msg.Subject = subject;
                msg.Body = htmlMessage;
                msg.IsBodyHtml = true;

                using var client = new SmtpClient("smtp.gmail.com", 587);
                client.Port = 587;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("tgm.muzaffer.deveci@gmail.com", "Yamahar123+-*/");
                client.EnableSsl = true;
                client.Send(msg);

            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }
            return Task.CompletedTask;
        }
    }
}
