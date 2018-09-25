using IPE.WhiteSmsTPL.Models.DraftMessages;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.DraftMessages
{
    public class AddOrUpdateDraftMessageResponse : BaseResponse
    {
        public List<DraftMessageDetail> DraftMessageDetails { get; set; }
    }
}
