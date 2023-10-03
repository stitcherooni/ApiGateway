using BLL.DTO.Statistic.Reports.Treasurer;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Searching.TreasurerByDate
{
    public class SearchTreasurerByDateResponse
    {
        public IEnumerable<TreasurerByDateDTO> Data { get; set; }
        public int TotalSales { get; set; }
        public int Profit { get; set; }
        public double ProcessingFeeNotPaid { get; set; }
        public double PlatformFeesNotPaid { get; set; }
    }
}