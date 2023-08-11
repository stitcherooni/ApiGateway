using System;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Searching.Sales
{
    public class TotalSoldByDayDTO : PagesInfoDTO
    {
        public IEnumerable<TotalSoldByDayItem> Data { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalQuantityToDate { get; set; }
        public int TotalSales { get; set; }
        public int TotalSalesToDate { get; set; }
    }

    public class TotalSoldByDayItem 
    {
        public int Num { get; set; }
        public DateTime Date { get; set; }
        public int Percentage { get; set; }
        public int Quantity { get; set; }
        public int QuantityToDate { get; set; }
        public int TotalSales { get; set; }
        public int ToDate { get; set; }
    }
}
