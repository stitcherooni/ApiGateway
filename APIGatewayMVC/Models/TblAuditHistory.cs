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

    public int ApplicationId { get; set; }

    public int CustomerId { get; set; }

    public string AuditHistoryServer { get; set; }

    public DateTime AuditHistoryCreatedDate { get; set; }

    public int AuditHistoryCreatedBy { get; set; }

    public DateTime? AuditHistoryUpdatedDate { get; set; }

    public int? AuditHistoryUpdatedBy { get; set; }

    public bool AuditHistoryDeleted { get; set; }
    public TblSchool Application { get; set; }
    public TblCustomer Customer { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
