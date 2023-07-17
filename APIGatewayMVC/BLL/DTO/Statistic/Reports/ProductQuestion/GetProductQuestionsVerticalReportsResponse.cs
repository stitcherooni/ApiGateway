namespace BLL.DTO.Statistic.Reports.ProductQuestion
{
    public class GetProductQuestionsVerticalReportsResponse : PagesInfoDTO
    {
        public IEnumerable<ProductQuestionVerticalDTO> Data { get; set; }
        public IEnumerable<Questions> Questions { get; set; }
    }
}
    