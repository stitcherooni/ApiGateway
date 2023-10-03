using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.TreasurerByEvent
{
    public class GetTreasurerByEventReportsResponse
    {
        public IEnumerable<TreasurerByEventDTO> Data { get; set; }
        public int TotalSales { get; set; }
        public int Profit { get; set; }
        public double ProcessingFeeNotPaid { get; set; }
        public double PlatformFeesNotPaid { get; set; }
    }
}
