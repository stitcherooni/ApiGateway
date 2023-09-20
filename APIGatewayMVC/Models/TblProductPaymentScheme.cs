using System;

namespace Models;

public partial class TblProductPaymentScheme
{
    public int ProductPaymentSchemeId { get; set; }

    public int ProductId { get; set; }

    public decimal ProductPaymentSchemeAmount { get; set; }

    public int ProductPaymentSchemeFrequencyId { get; set; }

    public DateTime? ProductPaymentSchemeStartDate { get; set; }

    public int? ProductPaymentSchemeNoPayments { get; set; }

    public bool ProductPaymentSchemeDeleted { get; set; }

    public int ProductPaymentSchemeCreatedBy { get; set; }

    public DateTime ProductPaymentSchemeCreatedDate { get; set; }

    public int? ProductPaymentSchemeUpdatedBy { get; set; }

    public DateTime? ProductPaymentSchemeUpdatedDate { get; set; }

    public TblProduct Product { get; set; }
    public TblProductPaymentSchemeFrequency ProductPaymentSchemeFrequency { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
