using IPE.WhiteSmsTPL.Models.Ticket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.Ticket
{
    public class GetTicketByIdResponse : BaseResponse
    {
        public string Subject { get; set; }
        public string Body { get; set; }
        public string DownloadUrl { get; set; }
        public string PersianCreationDateTime { get; set; }
        public int? Status { get; set; }
        public int? PriorityId { get; set; }
        public int? DepartmentId { get; set; }
        public TicketReplyDetail[] TicketReplyDetail { get; set; }

    }
}