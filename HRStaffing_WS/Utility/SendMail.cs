using HRS.WindowsService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HRStaffing_WS.Utility
{
    public static class SendMail
    {
        public static void send(MailData mailToSend)
        {
            try
            {
                //MailMessage mail = new MailMessage("memfard@gmail.com", "glainskurt@gmail.com");
                //SmtpClient client = new SmtpClient("smtp.gmail.com");



                //mail.Subject = "this is a test email.";
                //mail.Body = "this is my test email body";

                //client.Port = 587;
                //client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                //client.UseDefaultCredentials = false;
                //client.Credentials = new System.Net.NetworkCredential("memfard@gmail.com", "72348613*r");
                //client.EnableSsl = true;

                //client.Send(mail);

                var fromAddress = new MailAddress("infogap@hrstaffing.com");
                var fromPassword = "72348613*r";
                var toAddress = new MailAddress("glainskurt@gmail.com");

                string subject = "subject";
                string body = "body";

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };

                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })


                    smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
