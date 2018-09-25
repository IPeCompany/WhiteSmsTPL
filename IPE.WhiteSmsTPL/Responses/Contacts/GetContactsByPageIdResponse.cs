using IPE.WhiteSmsTPL.Models.Contacts;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class GetContactsByPageIdResponse : BaseResponse
    {
        public List<ContactDetailByGroupId> ContactDetails { get; set; }
    }
}
