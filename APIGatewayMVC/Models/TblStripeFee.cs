using System;
using System.Collections.Generic;

namespace Models;

public partial class TblStripeFee
{
    public int StripeFeeId { get; set; }

    public string StripeFee { get; set; }

    public string StripeCharge { get; set; }

    public decimal StripeFeeAmount { get; set; }

    public int? StripePayoutId { get; set; }

    public string StripeFeeType { get; set; }

    public string StripeAccount { get; set; }

    public DateTime? StripeFeeCreatedDate { get; set; }
}
