using System;
using System.Collections.Generic;

namespace Models;

public partial class TblAuditHistoryType
{
    public int AuditHistoryTypeId { get; set; }

    public string AuditHistoryTypeName { get; set;}

    public DateTime AuditHistoryTypeCreatedDate { get; set; }

    public TblCustomer AuditHistoryTypeCreatedBy { get; set; }

    public DateTime? AuditHistoryTypeUpdatedDate { get; set; }

    public TblCustomer AuditHistoryTypeUpdatedBy { get; set; }

    public bool AuditHistoryTypeDeleted { get; set; }
}
