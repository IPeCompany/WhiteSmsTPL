using System;

namespace IPE.WhiteSmsTPL.Models.Contacts
{
    public class CancelledContactDetail : ContactDetail
    {
        public DateTime CancellationDateTime { get; set; }
        public string PersianCancellationDateTime { get; set; }
    }
}
