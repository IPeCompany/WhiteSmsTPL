using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.RequestBodyModel.Messages
{
    public class SendByMobileNumbersBodyModel
    {
        public string Message { get; set; }
        public string[] MobileNumbers { get; set; }
        public bool CanContinueInCaseOfError { get; set; }
    }
}