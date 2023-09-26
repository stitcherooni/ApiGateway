using System;
using System.Collections.Generic;

namespace Models;

public partial class TblApiAuditHistory
{
    public int ApiAuditHistoryId { get; set; }

    public string ApiAuditHistoryIpaddress { get; set; }

    public string ApiAuditHistoryUri { get; set; }

    public string ApiAuditHistoryQueryString { get; set; }

    public string ApiAuditHistoryUserAgent { get; set; }

    public string ApiAuditHistoryEvent { get; set; }

    public string ApiAuditHistoryStatusCode { get; set; }

    public int? ApiAuditHistoryLoadTime { get; set; }

    public int? ApplicationId { get; set; }

    public int? CustomerId { get; set; }

    public string ApiAuditHistoryServer { get; set; }

    public DateTime ApiAuditHistoryCreatedDate { get; set; }

    public int ApiAuditHistoryCreatedBy { get; set; }
}
