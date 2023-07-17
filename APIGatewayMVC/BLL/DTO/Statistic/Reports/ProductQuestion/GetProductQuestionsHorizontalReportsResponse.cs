namespace BLL.DTO.Statistic.Reports.ProductQuestion
{
    public class GetProductQuestionsHorizontalReportsResponse : PagesInfoDTO
    {
        public IEnumerable<ProductQuestionHorizontalDTO> Data { get; set; }
        public IEnumerable<Questions> Questions { get; set; }
    }
}
