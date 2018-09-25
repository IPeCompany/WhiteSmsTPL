using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.RequestBodyModel.Messages
{
    public class SendBodyModel
    {
        public string Message { get; set; }
        public int[] ContactGroupIds { get; set; }
        public int[] ContactRelationIds { get; set; }
        public bool CanContinueInCaseOfError { get; set; }
    }
}