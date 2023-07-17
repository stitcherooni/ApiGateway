namespace BLL.DTO.Statistic.Reports
{
    public class GetReportByTabRequest
    {
        public int SchoolId { get; set; }

        [ReportType(ErrorMessage = "Type should be a valid ReportType.")]
        public string Type { get; set; }
    }
}
