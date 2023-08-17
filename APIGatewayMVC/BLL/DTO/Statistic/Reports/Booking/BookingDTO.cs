using BLL.DTO.Statistic.Reports.Order;
using System;
using System.Collections.Generic;

namespace BLL.DTO.Statistic.Reports.Booking
{
    public class BookingDTO
    {
        public int Num { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }
        public string BookingInfo { get; set; }
        public int Sku { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int Id { get; set; }
        public BookingProduct Product { get; set; }
        public string CustomerName { get; set; }
        public string BookingName { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }
        public OrderDTO Order { get; set; }
        public IEnumerable<int> BookingsId { get; set; }
    }

    public class BookingProduct
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool Bookable { get; set; }
        public bool ProductHideClass { get; set; }
        public int QuantityInStock { get; set; }
    }
}
