using IPE.WhiteSmsTPL.Models.Contacts;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class SearchContactsResponse : BaseResponse
    {
        public List<Contact> Contacts { get; set; }
    }
}
