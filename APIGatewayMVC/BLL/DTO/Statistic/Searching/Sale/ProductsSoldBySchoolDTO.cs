using BLL.DTO.Statistic.Reports.Sale;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Searching.Sales
{
    public class ProductSoldSchool: SoldItem
    {
        public IEnumerable<ProductSoldSchoolItem> Data { get; set; }
        public int TotalPercentage { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalSales { get; set;}
    }

    public class ProductSoldSchoolItem
    {
        public int Num { get; set; }
        public string SchoolName { get; set; }
        public int Percentage { get; set; }
        public int Quantity { get; set; }
        public int TotalSales { get; set; }
    }
}
