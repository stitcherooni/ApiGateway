using System;
using System.Collections.Generic;

namespace Models;

public partial class TblComponentGroup
{
    public int ComponentGroupId { get; set; }

    public string ComponentGroupName { get; set;}

    public bool ComponentGroupDeleted { get; set; }

    public int ComponentGroupCreatedBy { get; set; }

    public DateTime ComponentGroupCreatedDate { get; set; }

    public int? ComponentGroupUpdatedBy { get; set; }

    public DateTime? ComponentGroupUpdatedDate { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblComponent> ComponentGroups { get; set; }
}
