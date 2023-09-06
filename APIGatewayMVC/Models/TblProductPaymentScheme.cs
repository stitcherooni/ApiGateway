using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductPaymentScheme
{
    public int ProductPaymentSchemeId { get; set; }

    public TblProduct Product { get; set; }

    public decimal ProductPaymentSchemeAmount { get; set; }

    public TblProductPaymentSchemeFrequency ProductPaymentSchemeFrequency { get; set; }

    public DateTime? ProductPaymentSchemeStartDate { get; set; }

    public int? ProductPaymentSchemeNoPayments { get; set; }

    public bool ProductPaymentSchemeDeleted { get; set; }

    public TblCustomer ProductPaymentSchemeCreatedBy { get; set; }

    public DateTime ProductPaymentSchemeCreatedDate { get; set; }

    public TblCustomer ProductPaymentSchemeUpdatedBy { get; set; }

    public DateTime? ProductPaymentSchemeUpdatedDate { get; set; }
}
