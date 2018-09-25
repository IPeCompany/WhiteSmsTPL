using System;

namespace IPE.WhiteSmsTPL.Models.Contacts
{
    public class ContactDetail : BaseContactDetail
    {
        public int ContactRelationId { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public string PersianCreationDateTime { get; set; }
    }
}