﻿using IPE.WhiteSmsTPL.Models.OccasionalMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPE.WhiteSmsTPL.Responses.OccasionalMessages
{
    public class GetOccasionalMessageCategoryResponse : BaseResponse
    {
        public OccasionalMessageCategory[] OccasionalMessageCategory { get; set; }
    }
}