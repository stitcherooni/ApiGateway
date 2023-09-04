using System;
using System.Collections.Generic;

namespace Models;

public partial class TblAuditHistory
{
    public int AuditHistoryId { get; set; }

    public string AuditHistoryIpaddress { get; set; }

    public string AuditHistoryQueryString { get; set; }

    public string AuditHistoryUserAgent { get; set; }

    public string AuditHistoryEvent { get; set; }

    public int? AuditHistoryLoadTime { get; set; }

    public TblSchool Application { get; set; }

    public TblCustomer Customer { get; set; }

    public string AuditHistoryServer { get; set; }

    public DateTime AuditHistoryCreatedDate { get; set; }

    public TblCustomer AuditHistoryCreatedBy { get; set; }

    public DateTime? AuditHistoryUpdatedDate { get; set; }

    public TblCustomer AuditHistoryUpdatedBy { get; set; }

    public bool AuditHistoryDeleted { get; set; }
}
