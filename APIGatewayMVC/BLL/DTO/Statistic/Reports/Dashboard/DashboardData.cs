namespace BLL.DTO.Statistic.Reports.Dashboard
{

    public class LastOrdersList : PagesInfoDTO
    {
        public IEnumerable<Order> Data { get; set; }
    }

    public class CommonLiveSales
    {
        public IEnumerable<KeyValuePair<string, SalesData>> Data { get; set; }
    }

    public class CurrentLiveSales : PagesInfoDTO
    {
        public string ProductName { get; set; }
        public IEnumerable<CurrentSales> Data { get; set; }
    }

    public class MonthlyOrders : PagesInfoDTO
    {
        public IEnumerable<MonthlyOrder> Data { get; set; }
        public int TotalOrders { get; set; }
        public int TotalSales { get; set; }
        public string Currency { get; set; }
    }

    public class MonthlyCustomersRegistrations : PagesInfoDTO
    {
        public IEnumerable<MonthlyCustomersRegistration> Data { get; set; }
        public int TotalRegistrations { get; set; }
    }
    public class SalesData : PagesInfoDTO
    {
        public IEnumerable<CurrentSales> Data { get; set; }
        public int TotalQuantitySold { get; set; }
        public int TotalQuantityLeft { get; set; }
        public decimal TotalSales { get; set; }
        public string Currency { get; set; }
    }

    public class CurrentSalesData
    {
        public IEnumerable<CurrentSales> Data { get; set; }
        public int TotalQuantitySold { get; set; }
        public int TotalQuantityLeft { get; set; }
        public decimal TotalSales { get; set; }
        public string Currency { get; set; }
    }
}
