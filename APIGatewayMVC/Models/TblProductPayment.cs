using System;

namespace Models;

public partial class TblProductPayment
{
    public int ProductPaymentId { get; set; }

    public int ProductId { get; set; }

    public string ProductPaymentName { get; set; }

    public DateTime? ProductPaymentDueDate { get; set; }

    public decimal ProductPaymentAmount { get; set; }

    public bool ProductPaymentDeleted { get; set; }

    public int ProductPaymentCreatedBy { get; set; }

    public DateTime ProductPaymentCreatedDate { get; set; }

    public int? ProductPaymentUpdatedBy { get; set; }

    public DateTime? ProductPaymentUpdatedDate { get; set; }

    public TblProduct Product { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
