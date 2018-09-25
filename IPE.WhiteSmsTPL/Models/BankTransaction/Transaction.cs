using System;

namespace IPE.WhiteSmsTPL.Models.BaskTransaction
{
    public class Transaction
    {
        public double Amount { get; set; }
        public DateTime CreationDateTime { get; set; }
        public string PersianCreationDateTime { get; set; }
        public string TransactionType { get; set; }
        public bool IsValid { get; set; }
    }
}
