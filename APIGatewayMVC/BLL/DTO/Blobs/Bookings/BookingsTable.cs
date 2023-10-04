namespace BLL.DTO.Blobs.Bookings
{
    public class BookingsTable
    {
        public int In { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SKU { get; set; }
        public string Product { get; set; }
        public int Price { get; set; }
        public string BookingInfo { get; set; }
        public int Qty { get; set; }
        public int OrderId { get; set; }
        public string BookedBy { get; set; }
        public string Telephone { get; set; }
        public string PaymentMethod { get; set; }
        public string Out { get; set; }
    }
}
