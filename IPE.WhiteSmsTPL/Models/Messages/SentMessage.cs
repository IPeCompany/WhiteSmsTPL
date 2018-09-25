using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Models.Messages
{
    public class SentMessage
    {
        public int Id { get; set; }
        public string BatchKey { get; set; }
        public DateTime SendDateTime { get; set; }
        public string PersianSendDateTime { get; set; }
        public int DistinctRecipientsCount { get; set; }
        public string Message { get; set; }
    }
}