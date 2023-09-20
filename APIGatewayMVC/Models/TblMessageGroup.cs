﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblMessageGroup
{
    public int MessageGroupId { get; set; }

    public int EventId { get; set; }

    public int ClassId { get; set; }

    public string MessageGroupType { get; set;}

    public DateTime MessageGroupCreatedDate { get; set; }

    public int MessageGroupCreatedBy { get; set; }

    public TblEvent Event { get; set; }
    public TblClass Class { get; set; }
    public TblCustomer CreatedBy { get; set; }

    public List<TblMessage> MessageGroupMessage { get; set; }
}
