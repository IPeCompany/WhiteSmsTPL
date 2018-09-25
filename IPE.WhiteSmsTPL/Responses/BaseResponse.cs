namespace IPE.WhiteSmsTPL.Responses
{
    public class BaseResponse
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public int ErrorCode { get; set; }
    }
}
