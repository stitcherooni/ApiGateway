using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductPaymentSchemeFrequency
{
    public int ProductPaymentSchemeFrequencyId { get; set; }

    public string ProductPaymentSchemeFrequencyName { get; set;}

    public int ProductPaymentSchemeFrequencyDivisor { get; set; }

    public bool ProductPaymentSchemeFrequencyDeleted { get; set; }

    public int ProductPaymentSchemeFrequencyCreatedBy { get; set; }

    public DateTime ProductPaymentSchemeFrequencyCreatedDate { get; set; }

    public int? ProductPaymentSchemeFrequencyUpdatedBy { get; set; }

    public DateTime? ProductPaymentSchemeFrequencyUpdatedDate { get; set; }

    public List<TblProductPaymentScheme> ProductPaymentScheme { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
