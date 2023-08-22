using System.ComponentModel.DataAnnotations;

namespace BLL.DTO.Update.EditBooking
{
    public class EditBookingRequest
    {
        public int ProductId { get; set; }
        public string BookingName { get; set; }
        public int BookingId { get; set; }
        public string Class { get; set; }
        public Answers Answers { get; set; }
        public int OrderItemID { get; set; }
        public int OrderItemCount { get; set; }
        [RegularExpression("^(className|productName|productOrder|bookingName)$", ErrorMessage = "Filter must be 'className', 'productName', 'productOrder' or 'bookingName'.")]
        public string GroupBy { get; set; }
        public bool ShowTestOrders { get; set; }
        public int NextProductId { get; set; }
        public bool Bookings2 { get; set; }
        public string Token { get; set; }
    }

    public class Answers
    {
        public int QuestionId { get; set; }

        public object Answer { get; set; }
    }
}