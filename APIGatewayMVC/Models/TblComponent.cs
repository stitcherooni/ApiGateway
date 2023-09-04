﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblComponent
{
    public int ComponentId { get; set; }

    public string ComponentRef { get; set;}

    public string ComponentContent { get; set; }

    public string ComponentName { get; set;}

    public TblComponentType ComponentType { get; set; }

    public TblComponentGroup ComponentGroup { get; set; }

    public bool ComponentDeleted { get; set; }

    public TblCustomer ComponentCreatedBy { get; set; }

    public DateTime ComponentCreatedDate { get; set; }

    public TblCustomer ComponentUpdatedBy { get; set; }

    public DateTime? ComponentUpdatedDate { get; set; }
}
