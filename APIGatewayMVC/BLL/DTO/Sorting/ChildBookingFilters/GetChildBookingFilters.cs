using System.Collections.Generic;

namespace BLL.DTO.Sorting.BookingFilters
{
    public class GetChildBookingsFilters
    {
        public IEnumerable<Events> Events { get; set; }
        public GroupBy GroupBy { get; set; }
    }
}
