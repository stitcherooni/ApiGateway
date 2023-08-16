using System.Collections.Generic;

namespace BLL.DTO.Update.EditBooking
{
    public class EditBookingRequest
    {
        public int BookingId { get; set; }
        public int ProductId { get; set; }
        public int UpdateProductId { get; set; }
        public int SchoolId { get; set; }
        public int CustomerId { get; set; }
        public int OrderItemID { get; set; }
        public bool ShowTestOrders { get; set; }
        public string BookingName { get; set; }
        public IEnumerable<Question> Questions { get; set; }
        public IEnumerable<Answer> Answers { get; set; }
        public int ClassId { get; set; }
        public bool? Terms { get; set; }

    }

    public class Question
    {
        public int QuestionId { get; set; }
    }

    public class Answer
    {
        public int AnswerId { get; set; }
    }
}