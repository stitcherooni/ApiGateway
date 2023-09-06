using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventType
{
    public int EventTypeId { get; set; }

    public string EventTypeName { get; set;}

    public bool EventTypeDeleted { get; set; }

    public TblCustomer EventTypeCreatedBy { get; set; }

    public DateTime EventTypeCreatedDate { get; set; }

    public TblCustomer EventTypeUpdatedBy { get; set; }

    public DateTime? EventTypeUpdatedDate { get; set; }
}
