using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WindowsService.Entities.Utils
{
    public static class SendMail
    {
        public static void send(MailData mailToSend)
        {
            try
            {
                var fromAddress = new MailAddress(ConfigurationManager.AppSettings["MailFrom"]);
                var fromPassword = ConfigurationManager.AppSettings["MailFromPass"];
                var toAddress = new MailAddress(mailToSend.To);

                string subject = mailToSend.Subject;
                string body = "Information about application.";

                System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                {
                    Host = ConfigurationManager.AppSettings["MailServer"],
                    Port = Convert.ToInt32(ConfigurationManager.AppSettings["MailPort"]),
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

                //Send response to DB
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
