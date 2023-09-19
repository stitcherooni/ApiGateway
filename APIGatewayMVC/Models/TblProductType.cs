﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblProductType
{
    public int ProductTypeId { get; set; }

    public string ProductTypeName { get; set;}

    public string ProductTypeDescription { get; set;}

    public bool ProductTypeGambling { get; set; }

    public string ProductTypeIcon { get; set; }

    public bool ProductTypeDeleted { get; set; }

    public TblCustomer ProductTypeCreatedBy { get; set; }

    public DateTime ProductTypeCreatedDate { get; set; }

    public TblCustomer ProductTypeUpdatedBy { get; set; }

    public DateTime? ProductTypeUpdatedDate { get; set; }

    public List<TblProduct> ProductType { get; set; }
}
