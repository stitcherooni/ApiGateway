using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Statistic.Searching.Sale
{
    public class GetSalesReportForProductRequest
    {
        [RegularExpression("^(ProductsSoldByDayItem|ProductSoldSchool|ProductOrderCount)$", ErrorMessage = "Type must be either 'ProductsSoldByDayItem', 'ProductSoldSchool' or 'ProductOrderCount'.")]
        public string Type { get; set; }
        public int ProductId { get; set; }
    }
}
