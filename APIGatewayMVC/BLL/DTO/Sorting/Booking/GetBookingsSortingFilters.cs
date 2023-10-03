using System.Collections.Generic;

namespace BLL.DTO.Sorting.Booking
{
    public class GetBookingsSortingFilters
    {
        public IEnumerable<Events> Events { get; set; }
        public IEnumerable<Products> Products { get; set; }
        public IEnumerable<GroupBy> GroupBy { get; set; }
    }
}
