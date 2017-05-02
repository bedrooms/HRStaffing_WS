using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRS.WindowsService.Entities
{
    public class MailData
    {
        public string From { get; set; }
        public string To { get; set; }       
        public string Body { get; set; }
        public object Attachment { get; set; }
        public string Priority { get; set; }
        public string Pass { get; set; }

        private string _Subject;

        public string Subject
        {
            get
            {
                return _Subject;
            }

            set
            {
                _Subject = string.Format("You've got new application for {0}", value);
            }
        }
    }
}
