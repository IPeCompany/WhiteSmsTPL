using IPE.WhiteSmsTPL.Models.Contacts;

namespace IPE.WhiteSmsTPL.RequestBodyModel.Shared
{
    public class ContactInfo
    {
        public BaseContactDetail[] ContactsDetails { get; set; }
        public int GroupId { get; set; }
    }
}
