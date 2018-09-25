using System;

namespace IPE.WhiteSmsTPL.Models.FAQ
{
    public class FrequentlyAskedQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime CreationDateTime { get; set; }
        public bool IsActive { get; set; }
        public int Priority { get; set; }
        public int PlatformKeyId { get; set; }
    }
}

