using IPE.WhiteSmsTPL.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.Message
{
    public class SendResponse : BaseResponse
    {
        public int MessageId { get; set; }
        public string BatchKey { get; set; }
        public List<MessageId> Ids { get; set; }
    }
}