using BLL.DTO.Statistic.Reports.ProductQuestion;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.BookingQuestionsAndAnswers
{
    public class GetBookingQuestionsAndAnswersResponse
    {
        public IEnumerable<Questions> Questions { get; set; }
        public IDictionary<int, IEnumerable<Answer>> Answers { get; set; }
    }
}
