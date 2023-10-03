using BLL.DTO.Statistic.Reports.Order;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Searching.Order
{
    public class SearchReportsOrdersResponse
    {
        public IEnumerable<OrderDTO> Data { get; set; }
        public Price TotalSalesAmount { get; set; }
        public Price TotalProcessingFees { get; set; }
        public Price TotalPlatformFees { get; set; }

    }
}
