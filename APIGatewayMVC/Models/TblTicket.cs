using System;
using System.Collections.Generic;

namespace Models;

public partial class TblTicket
{
    public int TicketId { get; set; }

    public string TicketNumber { get; set;}

    public bool TicketHasQrcode { get; set; }

    public int OrderItemId { get; set; }

    public string TicketQflowTicketId { get; set; }

    public DateTime? TicketQflowScanDate { get; set; }

    public ulong TicketDeleted { get; set; }

    public int TicketCreatedBy { get; set; }

    public DateTime TicketCreatedDate { get; set; }

    public int? TicketUpdatedBy { get; set; }

    public DateTime? TicketUpdatedDate { get; set; }
}
