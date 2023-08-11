using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Customers
{
    public class GetCustomersReportsResponse : PagesInfoDTO
    {
        public IEnumerable<CustomerDTO> Data { get; set; }
        public int TotalOrdersNumber { get; set; }
        public TotalDTO TotalOrderValue { get; set; }
    }
}
