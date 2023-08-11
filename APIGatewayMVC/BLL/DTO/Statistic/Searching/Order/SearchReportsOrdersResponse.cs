using BLL.DTO.Statistic.Reports.Order;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Searching.Order
{
    public class SearchReportsOrdersResponse : PagesInfoDTO
    {
        public IEnumerable<OrderDTO> Data { get; set; }
        public TotalDTO TotalSalesAmount { get; set; }
        public TotalDTO TotalProcessingFees { get; set; }
        public TotalDTO TotalPlatformFees { get; set; }

    }
}
