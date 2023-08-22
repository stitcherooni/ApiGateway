namespace BLL.DTO.Statistic.Reports
{
    public class GetReportByTabRequest
    {
        [ReportType(ErrorMessage = "Type should be a valid ReportType.")]
        public string Type { get; set; }
    }
}
