using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Customers
{
    public class GetCustomersReportsResponse : PagesInfoDTO
    {
        public IEnumerable<CustomerDTO> Data { get; set; }
        public int CustomersCount { get; set; }
        public int TotalOrdersNumber { get; set; }
        public int TotalOrderValue { get; set; }
        public NotificationCounts NotificationCounts { get; set; }
        public string Currency { get; set; }
    }

    public class NotificationCounts
    {
        public int EmailCount { get; set; }
        public int PushNotificationsCount { get; set; }
    }
}
