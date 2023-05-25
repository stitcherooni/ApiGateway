using System;
using System.Collections.Generic;

namespace Models;

public partial class TblOrder
{
    public int OrderId { get; set; }

    public int? LegacyOrderId { get; set; }

    public string OrderUuid { get; set;}

    public int OrderTypeId { get; set; }

    public string OrderReference { get; set; }

    public decimal OrderValue { get; set; }

    public DateTime? OrderDate { get; set; }

    public bool OrderCompleted { get; set; }

    public DateTime? OrderCompletedDate { get; set; }

    public bool? OrderReserved { get; set; }

    public DateTime? OrderReservedDate { get; set; }

    public bool OrderRefunded { get; set; }

    public int? OrderTransactionId { get; set; }

    public string OrderTransactionType { get; set; }

    public bool OrderDeleted { get; set; }

    public bool OrderTest { get; set; }

    public bool OrderFailed { get; set; }

    public bool OrderDespatched { get; set; }

    public string OrderConfirmationEmail { get; set; }

    public string OrderConfirmationName { get; set; }

    public string OrderPaymentIntent { get; set; }

    public string OrderPaymentIntention { get; set; }

    public DateTime? OrderCreatedDate { get; set; }

    public int OrderCreatedBy { get; set; }

    public DateTime? OrderUpdatedDate { get; set; }

    public int? OrderUpdatedBy { get; set; }

    public int? CustomerId { get; set; }
}
