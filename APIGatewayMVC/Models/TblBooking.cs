using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBooking
{
    public int BookingId { get; set; }

    public int? BookingNo { get; set; }

    public string BookingName { get; set;}

    public string BookingFirstName { get; set; }

    public string BookingLastName { get; set; }

    public TblClass Class { get; set; }

    public bool BookingAttended { get; set; }

    public ulong BookingDeleted { get; set; }

    public TblCustomer BookingCreatedBy { get; set; }

    public DateTime BookingCreatedDate { get; set; }

    public TblCustomer BookingUpdatedBy { get; set; }

    public DateTime? BookingUpdatedDate { get; set; }

    public TblOrderItem OrderItem { get; set; }

    public TblTicket Ticket { get; set; }
}
