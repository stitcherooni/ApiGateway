using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.ProductQuestion.ForEventIdAndProductId
{
    public class GetProductQuestionsAndAnswersResponse
    {
        public IEnumerable<Questions> Questions { get; set; }
        public IEnumerable<Answers> Answers { get; set; }
    }

    public class Answers
    {
        public int QuestionId { get; set; }
        public int Id { get; set; }
        public IEnumerable<AnswerData> AnswerData{ get; set; }

        [AnswerTypes(ErrorMessage = "Type should be a valid ReportType.")]
        public string Type { get; set; }

        [ValidAnswerType]
        public object Answer { get; set; }

    }

    public class AnswerData
    {
        public string Value { get; set; }
        public string Label { get; set; }
    }
}
