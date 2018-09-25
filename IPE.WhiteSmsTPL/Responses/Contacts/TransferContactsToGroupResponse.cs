namespace IPE.WhiteSmsTPL.Responses.Contacts
{
    public class TransferContactsToGroupResponse : BaseResponse
    {
        public int MovedCount { get; set; }
        public int DuplicateCount { get; set; }
    }
}

