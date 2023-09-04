using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomerConsent
{
    public int CustomerConsentId { get; set; }

    public string CustomerConsentName { get; set;}

    public TblCustomer Customer { get; set; }

    public TblContentHash ContentHash { get; set; }

    public TblCustomerConsent CustomerConsentForeignKey { get; set; }

    public DateTime CustomerConsentCreatedDate { get; set; }
}
