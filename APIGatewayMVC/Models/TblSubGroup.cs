using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSubGroup
{
    public int SubGroupId { get; set; }

    public TblEvent Event { get; set; }

    public string SubGroupName { get; set;}

    public string SubGroupDescription { get; set;}

    public string SubGroupImage { get; set; }

    public bool SubGroupDeleted { get; set; }

    public TblCustomer SubGroupCreatedBy { get; set; }

    public DateTime SubGroupCreatedDate { get; set; }

    public TblCustomer SubGroupUpdatedBy { get; set; }

    public DateTime? SubGroupUpdatedDate { get; set; }
}
