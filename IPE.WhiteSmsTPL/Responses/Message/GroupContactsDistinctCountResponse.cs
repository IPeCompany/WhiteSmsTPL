using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.Message
{
    public class GroupContactsDistinctCountResponse : BaseResponse
    {
        public int Count { get; set; }
        public int InvalidCount { get; set; }
    }
}