using HRS.WindowsService.Bussiness;
using HRStaffing_WS.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRStaffing_WS
{
    public static class Init
    {

        public static void initSendMailNotifications()
        {
            SendMail.send(new HRS.WindowsService.Entities.MailData());



            JobsOfferApplyBL jobsOfferApplyBL = new JobsOfferApplyBL();
            jobsOfferApplyBL.getJobsAppliesToSend();
        }

        
    }
}
