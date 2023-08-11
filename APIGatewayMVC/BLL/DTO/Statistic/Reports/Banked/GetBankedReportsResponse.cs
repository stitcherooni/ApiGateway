using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Banked
{
    public class GetBankedReportsResponse : PagesInfoDTO
    {
        public IEnumerable<BankedTransactionDTO> Data { get; set; }
        public int TotalOrdersCount { get; set; }
        public TotalDTO TotalSalesAmount { get; set; }
        public TotalDTO TotalBankedFee { get; set; }
        public TotalDTO TotalPlatformFees { get; set; }
    }
}
