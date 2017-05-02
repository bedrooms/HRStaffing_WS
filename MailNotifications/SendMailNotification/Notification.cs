using HRS.WindowsService.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailNotifications.SendMailNotification
{
    public static class Notification
    {
        public static void SendNotifications()
        {
            JobsOfferApplyBL jobsOfferApplyBL = new JobsOfferApplyBL();
            jobsOfferApplyBL.getJobsAppliesToSend();
        }
    }
}
