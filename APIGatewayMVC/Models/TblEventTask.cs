using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventTask
{
    public int EventTaskId { get; set; }

    public string EventTaskName { get; set;}

    public string EventTaskDescription { get; set; }

    public string EventTaskMessage { get; set; }

    public TblEventTaskGroup EventTaskGroup { get; set; }

    public TblCustomer EventTaskOrganiser { get; set; }
           
    public TblCustomer EventTaskOrganiser2 { get; set; }
           
    public TblCustomer EventTaskOrganiser3 { get; set; }
          
    public TblCustomer EventTaskOrganiser4 { get; set; }

    public int EventTaskHelpersRequiredQty { get; set; }

    public bool EventTaskHideQty { get; set; }

    public DateTime? EventTaskRequiredByDate { get; set; }

    public DateTime EventTaskStartDate { get; set; }

    public DateTime? EventTaskFinishDate { get; set; }

    public int EventTaskSortOrder { get; set; }

    public TblEvent Event { get; set; }

    public bool EventTaskDeleted { get; set; }

    public TblCustomer EventTaskCreatedBy { get; set; }

    public DateTime EventTaskCreatedByDate { get; set; }

    public TblCustomer EventTaskUpdatedBy { get; set; }

    public DateTime? EventTaskUpdatedDate { get; set; }
}
