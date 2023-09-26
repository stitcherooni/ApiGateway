using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPaypal
{
    public int PaypalId { get; set; }

    public int? LegacyPaypalId { get; set; }

    public string PaypalType { get; set;}

    public string PaypalTransactionId { get; set;}

    public string PaypalParentTransactionId { get; set; }

    public string PaypalCurrency { get; set;}

    public string PaypalPaymentStatus { get; set;}

    public bool PaypalTest { get; set; }

    public string PaypalIpntrackId { get; set;}

    public decimal PaypalTransactionAmount { get; set; }

    public decimal PaypalFee { get; set; }

    public decimal? PlatformFee { get; set; }

    public string PlatformFeeInvoiceNo { get; set; }

    public bool PlatformFeeRefundDue { get; set; }

    public decimal PlatformFeeRefundAmount { get; set; }

    public int PaypalItemTotal { get; set; }

    public string PaypalReceiverId { get; set; }

    public string PaypalPayerEmail { get; set; }

    public string PaypalPayerStatus { get; set; }

    public bool PaypalCompleted { get; set; }

    public DateTime? PaypalCreatedDate { get; set; }

    public DateTime? PaypalUpdatedDate { get; set; }
}
