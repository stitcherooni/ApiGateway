using System;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Booking
{
    public class BookingDTO
    {
        public int Num { get; set; }
        public int Id { get; set; }
        public string Product { get; set; }
        public string CustomerName { get; set; }
        public string BookingName { get; set; }
        public DateTime Date { get; set; }
        public string Contact { get; set; }
        public IEnumerable<string> Allergies { get; set; }
    }
}
