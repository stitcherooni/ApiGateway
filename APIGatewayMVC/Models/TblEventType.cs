using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventType
{
    public int EventTypeId { get; set; }

    public string EventTypeName { get; set;}

    public bool EventTypeDeleted { get; set; }

    public int EventTypeCreatedBy { get; set; }

    public DateTime EventTypeCreatedDate { get; set; }

    public int? EventTypeUpdatedBy { get; set; }

    public DateTime? EventTypeUpdatedDate { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblEvent> EventType { get; set; }
}
