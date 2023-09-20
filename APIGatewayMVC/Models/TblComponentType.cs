using System;
using System.Collections.Generic;

namespace Models;

public partial class TblComponentType
{
    public int ComponentTypeId { get; set; }

    public string ComponentTypeName { get; set;}

    public bool ComponentTypeDeleted { get; set; }

    public int ComponentTypeCreatedBy { get; set; }

    public DateTime ComponentTypeCreatedDate { get; set; }

    public int? ComponentTypeUpdatedBy { get; set; }

    public DateTime? ComponentTypeUpdatedDate { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblComponent> ComponentType { get; set; }
}
