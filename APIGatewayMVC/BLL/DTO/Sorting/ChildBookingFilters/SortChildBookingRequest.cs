using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Sorting.BookingFilters
{
    public class SortChildBookingRequest
    {
        public IEnumerable<int> EventIds { get; set; }

        [RegularExpression("^(className|productName|productOrder|bookingName)$", ErrorMessage = "Filter must be 'className', 'productName', 'productOrder' or 'bookingName'.")]
        public string GroupBy { get; set; }
    }
}
