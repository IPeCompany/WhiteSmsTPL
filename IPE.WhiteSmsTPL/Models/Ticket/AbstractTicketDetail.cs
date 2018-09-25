using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Models.Ticket
{
    public class AbstractTicketDetail
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int PriorityId { get; set; }
        public int DepartmentId { get; set; }
        public string DownloadUrl { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string PersianCreationDateTime { get; set; }
    }
}
