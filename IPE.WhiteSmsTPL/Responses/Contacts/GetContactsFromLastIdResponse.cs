using IPE.WhiteSmsTPL.Models.Contacts;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class GetContactsFromLastIdResponse : BaseResponse
    {
        public List<ContactDetailFromLastId> ContactDetails { get; set; }
    }
}
