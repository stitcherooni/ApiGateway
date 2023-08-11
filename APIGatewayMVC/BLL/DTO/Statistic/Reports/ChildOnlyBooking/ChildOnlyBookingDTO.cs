using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.ChildOnlyBooking
{
    public class ChildOnlyBookingDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BookedBy { get; set; }
        public IEnumerable<string> Allergies { get; set; }
        public int Phone { get; set; }
        public int SoldQuantity { get; set; }
    }
}
