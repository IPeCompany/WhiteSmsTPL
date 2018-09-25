using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Models.Ticket
{
    public class TicketReplyDetail
    {
        public int? TicketReplyId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string DownloadUrl { get; set; }
        public string PersianCreationDateTime { get; set; }
        public bool IsAdminReply { get; set; }
    }
}