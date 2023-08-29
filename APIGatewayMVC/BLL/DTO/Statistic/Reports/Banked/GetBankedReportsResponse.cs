using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Banked
{
    public class GetBankedReportsResponse
    {
        public IEnumerable<BankedTransactionDTO> Data { get; set; }
        public int TotalOrdersCount { get; set; }
        public Price TotalSalesAmount { get; set; }
        public Price TotalBankedFee { get; set; }
        public Price TotalPlatformFees { get; set; }
        public string Currency { get; set; }
    }
}
