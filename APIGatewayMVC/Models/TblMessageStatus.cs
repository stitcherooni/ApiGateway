using System;
using System.Collections.Generic;

namespace Models;

public partial class TblMessageStatus
{
    public int MessageStatusId { get; set; }

    public string MessageStatus { get; set;}

    public DateTime MessageStatusCreatedDate { get; set; }

    public int MessageStatusCreatedBy { get; set; }

    public DateTime? MessageStatusUpdatedDate { get; set; }

    public int? MessageStatusUpdatedBy { get; set; }

    public bool MessageStatusDeleted { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
