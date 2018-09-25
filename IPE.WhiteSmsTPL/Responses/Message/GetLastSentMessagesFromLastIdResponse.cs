using IPE.WhiteSmsTPL.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.Message
{
    public class GetLastSentMessagesFromLastIdResponse : BaseResponse
    {
        public List<SentMessage> Messages { get; set; }
    }
}
