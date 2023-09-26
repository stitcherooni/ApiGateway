using System;
using System.Collections.Generic;

namespace Models;

public partial class TblStripePayout
{
    public int PayoutId { get; set; }

    public int PayoutTypeId { get; set; }

    public string PayoutReference { get; set; }

    public string PayoutBankReference { get; set; }

    public decimal PayoutAmount { get; set; }

    public int PayoutFeeCount { get; set; }

    public int PayoutRefundCount { get; set; }

    public DateTime? PayoutInitiatedDate { get; set; }

    public DateTime? PayoutPaidDate { get; set; }

    public DateTime PayoutCreatedDate { get; set; }
}
