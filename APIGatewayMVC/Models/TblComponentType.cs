using System;
using System.Collections.Generic;

namespace Models;

public partial class TblComponentType
{
    public int ComponentTypeId { get; set; }

    public string ComponentTypeName { get; set;}

    public bool ComponentTypeDeleted { get; set; }

    public TblCustomer ComponentTypeCreatedBy { get; set; }

    public DateTime ComponentTypeCreatedDate { get; set; }

    public TblCustomer ComponentTypeUpdatedBy { get; set; }

    public DateTime? ComponentTypeUpdatedDate { get; set; }

    public List<TblComponent> ComponentType { get; set; }
}
