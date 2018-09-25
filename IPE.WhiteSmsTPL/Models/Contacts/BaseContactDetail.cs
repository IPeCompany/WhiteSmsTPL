using IPE.WhiteSmsTPL.Consts;

namespace IPE.WhiteSmsTPL.Models.Contacts
{
    public class BaseContactDetail
    {
        public string Prefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public Emoji? EmojiId { get; set; }
    }
}
