using IPE.WhiteSmsTPL.Models.DraftMessages;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.DraftMessages
{
    public class GetDraftMessagesResponse : BaseResponse
    {
        public List<DraftMessageDetail> DraftMessageDetails { get; set; }
    }
}
