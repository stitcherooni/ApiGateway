using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomerConsent
{
    public int CustomerConsentId { get; set; }

    public string CustomerConsentName { get; set; }

    public int CustomerId { get; set; }

    public int ContentHashId { get; set; }

    public int CustomerConsentForeignKey { get; set; }

    public DateTime CustomerConsentCreatedDate { get; set; }
}
