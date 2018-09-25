using IPE.WhiteSmsTPL.Models.FAQ;
using System.Collections.Generic;

namespace IPE.WhiteSmsTPL.Responses.FAQ
{
    public class GetFrequentlyAskedQuestionsResponse : BaseResponse
    {
        public List<FrequentlyAskedQuestion> FrequentlyAskedQuestions { get; set; }
    }
}
