using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSubGroup
{
    public int SubGroupId { get; set; }

    public int EventId { get; set; }

    public string SubGroupName { get; set;}

    public string SubGroupDescription { get; set;}

    public string SubGroupImage { get; set; }

    public bool SubGroupDeleted { get; set; }

    public int? SubGroupCreatedBy { get; set; }

    public DateTime SubGroupCreatedDate { get; set; }

    public int SubGroupUpdatedBy { get; set; }

    public DateTime? SubGroupUpdatedDate { get; set; }

    public TblEvent Event { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblProduct> ProductSubGroup { get; set; }
}
