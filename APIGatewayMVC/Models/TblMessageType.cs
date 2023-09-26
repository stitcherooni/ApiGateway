using System;
using System.Collections.Generic;

namespace Models;

public partial class TblMessageType
{
    public int MessageTypeId { get; set; }

    public string MessageTypeName { get; set; }

    public DateTime MessageTypeCreatedDate { get; set; }

    public int MessageTypeCreatedBy { get; set; }

    public DateTime? MessageTypeUpdatedDate { get; set; }

    public int? MessageTypeUpdatedBy { get; set; }

    public bool MessageTypeDeleted { get; set; }
}
