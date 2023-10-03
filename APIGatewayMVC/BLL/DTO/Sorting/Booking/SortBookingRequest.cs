using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Sorting.Booking
{
    public class SortBookingRequest
    {
        public IEnumerable<int> EventIds { get; set; }
        public IEnumerable<int> ProductIds { get; set; }

        [RegularExpression("^(className|productName|productOrder|bookingName)$", ErrorMessage = "Filter must be 'className', 'productName', 'productOrder' or 'bookingName'.")]
        public string GroupBy { get; set; }
    }
}
