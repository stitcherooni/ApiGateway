using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventTaskGroup
{
    public int EventTaskGroupId { get; set; }

    public int EventId { get; set; }

    public string EventTaskGroupName { get; set;}

    public int? EventTaskGroupSortOrder { get; set; }

    public int EventTaskGroupOrganiserId { get; set; }

    public int EventTaskGroupRepsSchoolYearId { get; set; }

    public bool EventTaskGroupDeleted { get; set; }

    public DateTime EventTaskGroupCreatedDate { get; set; }

    public int EventTaskGroupCreatedBy { get; set; }

    public DateTime? EventTaskGroupUpdatedDate { get; set; }

    public int? EventTaskGroupUpdatedBy { get; set; }

    public TblEvent Event { get; set; }
    public TblSchoolYear EventTaskGroupRepsSchoolYear { get; set; }
    public TblCustomer EventTaskGroupOrganiser { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }

    public List<TblEventTask> EventTask { get; set; }
}
