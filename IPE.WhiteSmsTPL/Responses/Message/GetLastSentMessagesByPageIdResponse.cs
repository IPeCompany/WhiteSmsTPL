using IPE.WhiteSmsTPL.Models.Contacts;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.Message
{
    public class GetLastSentMessagesByPageIdResponse : BaseResponse
    {
        public List<BaseContactDetail> ContactsDetails { get; set; }
        public int GroupId { get; set; }
    }
}
