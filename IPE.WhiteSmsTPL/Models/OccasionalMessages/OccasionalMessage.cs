using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Models.OccasionalMessages
{
    public class OccasionalMessage
    {
        public string Message { get; set; }
        public int OccasionalMessageCategoryId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime ExpirationDateTime { get; set; }
    }
}