﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBooking
{
    public int BookingId { get; set; }

    public int? BookingNo { get; set; }

    public string BookingName { get; set;}

    public string BookingFirstName { get; set; }

    public string BookingLastName { get; set; }

    public int ClassId { get; set; }

    public bool BookingAttended { get; set; }

    public ulong BookingDeleted { get; set; }

    public int BookingCreatedBy { get; set; }

    public DateTime BookingCreatedDate { get; set; }

    public int? BookingUpdatedBy { get; set; }

    public DateTime? BookingUpdatedDate { get; set; }

    public int OrderItemId { get; set; }

    public int TicketId { get; set; }
}