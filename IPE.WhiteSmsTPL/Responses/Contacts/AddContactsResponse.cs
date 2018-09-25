using IPE.WhiteSmsTPL.Models.Contacts;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class AddContactsResponse : BaseResponse
    {
        public BaseContactDetail[] AddedList { get; set; }
        public BaseContactDetail[] ErroneousList { get; set; }
        public int GroupId { get; set; }
    }
}
