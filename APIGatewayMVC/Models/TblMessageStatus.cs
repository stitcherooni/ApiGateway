using System;
using System.Collections.Generic;

namespace Models;

public partial class TblMessageStatus
{
    public int MessageStatusId { get; set; }

    public string MessageStatus { get; set;}

    public DateTime MessageStatusCreatedDate { get; set; }

    public TblCustomer MessageStatusCreatedBy { get; set; }

    public DateTime? MessageStatusUpdatedDate { get; set; }

    public TblCustomer MessageStatusUpdatedBy { get; set; }

    public bool MessageStatusDeleted { get; set; }
}
