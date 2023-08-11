﻿using BLL.DTO.Statistic.Searching.Sales;

namespace BLL.DTO.Statistic.Reports.Sale
{
    public class SalesDataProps
    {
        public TotalSales TotalSales { get; set; }
        public TotalSoldByDayDTO TotalSoldByDay { get; set; }
        public IDictionary<string, ProductsSoldByDayItem> ProductsSoldByDay { get; set; }
        public IDictionary<string, ProductSoldSchool> ProductsSoldBySchool { get; set; }
        public IDictionary<string, ProductOrderCount> ProductOrderCount { get; set; }
    }
    public class TotalSales:PagesInfoDTO
    {
        public IDictionary<string, int> ProductPercentage { get; set; }
        public IEnumerable<TotalSalesItem> Sales { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalSold { get; set; }
        public int TotalCount { get; set; }
    }

    public class SoldItem : PagesInfoDTO
    {
        public object Data { get; set; }
    }
}