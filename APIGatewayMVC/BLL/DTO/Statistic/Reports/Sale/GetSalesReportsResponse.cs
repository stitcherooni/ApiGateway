using BLL.DTO.Statistic.Reports.Sale;

namespace BLL.DTO.Statistic.Reports.Sales
{
    public class GetSalesReportsResponse : PagesInfoDTO
    {
        public IEnumerable<SaleDTO> Data { get; set; }
    }
}
