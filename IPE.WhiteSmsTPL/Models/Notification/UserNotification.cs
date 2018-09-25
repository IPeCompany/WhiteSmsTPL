using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Models.Notification
{
    public class UserNotification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool IsRead { get; set; }
    }
}