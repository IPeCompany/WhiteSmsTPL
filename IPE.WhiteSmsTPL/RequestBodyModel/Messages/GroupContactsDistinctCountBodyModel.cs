using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.RequestBodyModel.Messages
{
    public class GroupContactsDistinctCountBodyModel
    {
        public int[] ContactsGroupIds { get; set; }
        public int[] ContactRelationIds { get; set; }
    }
}
