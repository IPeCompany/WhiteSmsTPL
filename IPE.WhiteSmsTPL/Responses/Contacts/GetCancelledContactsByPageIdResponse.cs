using IPE.WhiteSmsTPL.Models.Contacts;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class GetCancelledContactsByPageIdResponse :BaseResponse
    {
        public List<CancelledContactDetail> ContactDetails { get; set; }
        public int CancelledContactCount { get; set; }
    }
}
