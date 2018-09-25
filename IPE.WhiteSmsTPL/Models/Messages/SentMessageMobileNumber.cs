using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Models.Messages
{
    public class SentMessagesMobileNumber
    {
        public int Id { get; set; }
        public string BatchKey { get; set; }
        public long MobileNumber { get; set; }
        public DateTime SendDateTime { get; set; }
        public string persianSendDateTime { get; set; }
        public string DeliveryStatus { get; set; }
        public string SmsMessageBody { get; set; }
    }
}
