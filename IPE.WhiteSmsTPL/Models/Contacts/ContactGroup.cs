namespace IPE.WhiteSmsTPL.Models.Contacts
{
    public class ContactGroup
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int ContactsCount { get; set; }
        public int InvalidContactsCount { get; set; }
    }
}