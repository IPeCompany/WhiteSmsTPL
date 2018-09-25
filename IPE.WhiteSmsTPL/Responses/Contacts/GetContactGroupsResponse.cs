using IPE.WhiteSmsTPL.Models.Contacts;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class GetContactGroupsResponse : BaseResponse
    {
        public List<ContactGroup> ContactGroups { get; set; }
    }
}
