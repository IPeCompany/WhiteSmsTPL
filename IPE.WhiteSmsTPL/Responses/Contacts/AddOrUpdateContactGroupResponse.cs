
namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class AddOrUpdateContactGroupResponse : BaseResponse
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public string CreationDateTime { get; set; }
        public int ContactsCount { get; set; }
    }
}
