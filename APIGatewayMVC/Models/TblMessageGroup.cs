using System;
using System.Collections.Generic;

namespace Models;

public partial class TblMessageGroup
{
    public int MessageGroupId { get; set; }

    public TblEvent Event { get; set; }

    public TblClass Class { get; set; }

    public string MessageGroupType { get; set;}

    public DateTime MessageGroupCreatedDate { get; set; }

    public TblCustomer MessageGroupCreatedBy { get; set; }

    public List<TblMessage> MessageGroupMessage { get; set; }
}
