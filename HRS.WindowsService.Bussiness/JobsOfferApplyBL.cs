using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRS.WebAPI.Bussiness;
using HRS.WindowsService.Entities.Utils;
using HRS.WindowsService.Entities;
using System.Configuration;

namespace HRS.WindowsService.Bussiness
{
    public class JobsOfferApplyBL
    {
        public void getJobsAppliesToSend()
        {
            JobsOfferBL jobsOfferBL = new JobsOfferBL();
            var response = jobsOfferBL.getAllJobsApplyNotifications().Data;

            foreach (var itemMail in response)
            {
                MailData mailData = new MailData();
               
                mailData.To = itemMail.ResponsibleToSend.Email;

                mailData.Subject = itemMail.JobTitleName.Trim();

                SendMail.send(mailData);
            }
        }
    }
}
