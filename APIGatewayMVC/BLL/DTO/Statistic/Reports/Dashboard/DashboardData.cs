using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Dashboard
{

    public class LastOrdersList
    {
        public IEnumerable<Order> Data { get; set; }
    }

    public class CommonLiveSales
    {
        public IEnumerable<KeyValuePair<string, SalesData>> Data { get; set; }
    }

    public class CurrentLiveSales
    {
        public string ProductName { get; set; }
        public IEnumerable<CurrentSales> Data { get; set; }
        public int TotalQuantitySold { get; set; }
        public int TotalQuantityLeft { get; set; }
        public int TotalSales { get; set; }
        public string Currency { get; set; }
    }

    public class MonthlyOrders
    {
        public IEnumerable<MonthlyOrder> Data { get; set; }
        public int TotalOrders { get; set; }
        public int TotalSales { get; set; }
        public string Currency { get; set; }
    }

    public class MonthlyCustomersRegistrations
    {
        public IEnumerable<MonthlyCustomersRegistration> Data { get; set; }
        public int TotalRegistrations { get; set; }
    }
    public class SalesData
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
