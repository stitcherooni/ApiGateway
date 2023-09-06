using System;
using System.Collections.Generic;

namespace Models;

public partial class TblStripeWebHook
{
    public int StripeWebHookId { get; set; }

    public TblOrder Order { get; set; }

    public string StripeWebHookEventId { get; set;}

    public string StripeWebHookAccountId { get; set;}

    public string StripeWebHookObjectTypeId { get; set;}

    public string StripeWebHookObjectType { get; set;}

    public string StripeWebHookObjectStatus { get; set; }

    public string StripeWebHookRequestId { get; set; }

    public string StripeWebHookContent { get; set; }

    public DateTime StripeWebHookCreatedDate { get; set; }
}
