using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventTaskGroup
{
    public int EventTaskGroupId { get; set; }

    public TblEvent Event { get; set; }

    public string EventTaskGroupName { get; set;}

    public int? EventTaskGroupSortOrder { get; set; }

    public TblCustomer EventTaskGroupOrganiser { get; set; }

    public TblSchoolYear EventTaskGroupRepsSchoolYear { get; set; }

    public bool EventTaskGroupDeleted { get; set; }

    public DateTime EventTaskGroupCreatedDate { get; set; }

    public TblCustomer EventTaskGroupCreatedBy { get; set; }

    public DateTime? EventTaskGroupUpdatedDate { get; set; }

    public TblCustomer EventTaskGroupUpdatedBy { get; set; }
}
