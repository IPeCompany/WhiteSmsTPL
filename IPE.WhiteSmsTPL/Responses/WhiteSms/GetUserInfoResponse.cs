using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.WhiteSms
{
    public class GetUserInfoResponse : BaseResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BusinessName { get; set; }
        public string PersianExpirationDateTime { get; set; }
        public bool IsExpired { get; set; }
        public bool IsTrial { get; set; }
        public int SentCount { get; set; }
        public DateTime ExpirationDateTime { get; set; }
        public string MembershipKeyword { get; set; }
        public string CancelMembershipKeyword { get; set; }
        public int Credit { get; set; }
        public bool HasUploadedNationalCard { get; set; }
        public string MobileNumber { get; set; }
        public string ReagentCode { get; set; }
        public int ExpirationLeftDays { get; set; }
    }
}