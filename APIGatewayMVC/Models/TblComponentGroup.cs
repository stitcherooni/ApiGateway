using System;
using System.Collections.Generic;

namespace Models;

public partial class TblComponentGroup
{
    public int ComponentGroupId { get; set; }

    public string ComponentGroupName { get; set;}

    public bool ComponentGroupDeleted { get; set; }

    public TblCustomer ComponentGroupCreatedBy { get; set; }

    public DateTime ComponentGroupCreatedDate { get; set; }

    public TblCustomer ComponentGroupUpdatedBy { get; set; }

    public DateTime? ComponentGroupUpdatedDate { get; set; }
}
