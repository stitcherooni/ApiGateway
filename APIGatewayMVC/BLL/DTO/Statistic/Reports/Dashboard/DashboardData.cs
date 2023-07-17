namespace BLL.DTO.Statistic.Reports.Dashboard
{
    public class DashboardData
    {
        public DashboardStatistic Stat { get; set; }
        public CurrentLiveSales CurrentLiveSales { get; set; }
        public MonthlyOrders MonthlyOrders { get; set; }
        public MonthlyCustomersRegistrations MonthlyCustomersRegistrations { get; set; }
        public IEnumerable<Order> LastOrders { get; set; }

    }

    public class CurrentLiveSales : PagesInfoDTO
    {
        public IEnumerable<KeyValuePair<string, SalesData>> Data { get; set; }
    }

    public class MonthlyOrders : PagesInfoDTO
    {
        public IEnumerable<MonthlyOrder> Data { get; set; }
        public int TotqalOrders { get; set; }
        public int TotalSales { get; set; }
        public string Currency { get; set; }
    }

    public class MonthlyCustomersRegistrations : PagesInfoDTO
    {
        public IEnumerable<MonthlyCustomersRegistration> Data { get; set; }
        public int TotalRegistrations { get; set; }
    }
    public class SalesData
    {
        public CurrentSales[] Data { get; set; }
        public int TotalQuantitySold { get; set; }
        public int TotalQuantityLeft { get; set; }
        public decimal TotalSales { get; set; }
        public string Currency { get; set; }
    }

    public class MonthlyReport
    {
        public MonthlyOrders MonthlyOrders { get; set; }
        public MonthlyCustomersRegistrations MonthlyCustomersRegistrations { get; set; }
    }
}
