namespace BLL.DTO.Statistic.Reports.ProductQuestion
{
    public class Answers
    {
        public int QuestionId { get; set; }
        public string Answer { get; set; }
    }

    public class Questions
    {
        public int QuestionId { get; set; }
        public string Question { get; set; }
    }

    public class Answer
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
    }

}
