namespace BLL.DTO.Statistic.Searching.Sales
{
    public class ProductsSoldBySchoolDTO
    {
        public string SchoolName { get; set; }
        public int Percentage { get; set; }
        public int Quantity { get; set; }
        public int TotalSales { get; set;}
        public string Currency { get; set; }
    }
}
