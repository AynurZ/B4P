using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace B4P.Services
{
    public class EmailService
    {
        public async Task SendMailAsync(string email, string subject, string message) 
        {
            //try { 
                MimeMessage emailMessage = new MimeMessage();

                emailMessage.From.Add(new MailboxAddress("Администрация сайта", "19capral95@gmail.com"));
                emailMessage.To.Add(new MailboxAddress("zamain88@yandex.ru"));
                emailMessage.Subject = subject;
                emailMessage.Body = new BodyBuilder() { HtmlBody = "<div style=\"color: green;\">TExt</div>" }.ToMessageBody();

                using (SmtpClient client = new SmtpClient())
                {

                     client.ConnectAsync("smtp.gmail.com", 465, true);
                     client.AuthenticateAsync("19capral95@gmail.com", "");
                     client.SendAsync(emailMessage);
                     client.DisconnectAsync(true);
                }
            //}
            //catch (Exception e)
            //{
            //    //куда нить ошибку записать
            //}

        }
    }
}
