using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPaymentStatus
{
    public int PaymentStatusId { get; set; }

    public string PaymentStatusName { get; set; }

    public bool PaymentStatusDeleted { get; set; }

    public int PaymentStatusCreatedBy { get; set; }

    public DateTime PaymentStatusCreatedDate { get; set; }

    public int? PaymentStatusUpdatedBy { get; set; }

    public DateTime? PaymentStatusUpdatedDate { get; set; }
}
