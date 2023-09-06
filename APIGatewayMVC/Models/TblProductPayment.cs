using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductPayment
{
    public int ProductPaymentId { get; set; }

    public TblProduct Product { get; set; }

    public string ProductPaymentName { get; set; }

    public DateTime? ProductPaymentDueDate { get; set; }

    public decimal ProductPaymentAmount { get; set; }

    public bool ProductPaymentDeleted { get; set; }

    public TblCustomer ProductPaymentCreatedBy { get; set; }

    public DateTime ProductPaymentCreatedDate { get; set; }

    public TblCustomer ProductPaymentUpdatedBy { get; set; }

    public DateTime? ProductPaymentUpdatedDate { get; set; }
}
