using IPE.WhiteSmsTPL.Models.BaskTransaction;
using System.Collections.Generic;


namespace IPE.WhiteSmsTPL.Responses.BankTransaction
{
    public class GetBankTransaction : BaseResponse
    {
        public Transaction[] Transaction { get; set; }
    }
}
