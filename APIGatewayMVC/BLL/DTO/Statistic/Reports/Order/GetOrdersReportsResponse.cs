using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Order
{
    public class GetOrdersReportsResponse
    {
        public IEnumerable<OrderDTO> Data { get; set; }
        public int TotalOrdersCount { get; set; }
        public int AvgOrderValue { get; set; }
        public int TotalOrderValue { get; set; }
        public int Refunded { get; set; }
        public string Currency { get; set; }

    }
}
