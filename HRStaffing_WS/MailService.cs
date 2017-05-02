using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace HRStaffing_WS
{
    public partial class MailService : ServiceBase
    {        

        public MailService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Init.initSendMailNotifications();
        }

        protected override void OnStop()
        {
        }

        public void start()
        {
            OnStart(new string[] { });
        }


    }
}
