using System;

namespace BLL.DTO.Statistic.Reports.Customers
{
    public class CustomerDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Child { get; set; }
        public DateTime Date { get; set; }
        public int Orders { get; set; }
        public TotalDTO Value { get; set; }
    }
}
