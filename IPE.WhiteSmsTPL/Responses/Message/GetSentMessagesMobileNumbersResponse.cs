using IPE.WhiteSmsTPL.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.Message
{
    public class GetSentMessagesMobileNumbersResponse : BaseResponse
    {
        public List<SentMessagesMobileNumber> Messages { get; set; }
    }
}
