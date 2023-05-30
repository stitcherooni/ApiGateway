﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventTask
{
    public int EventTaskId { get; set; }

    public string EventTaskName { get; set;}

    public string EventTaskDescription { get; set; }

    public string EventTaskMessage { get; set; }

    public int? EventTaskGroupId { get; set; }

    public int? EventTaskOrganiserId { get; set; }

    public int? EventTaskOrganiserId2 { get; set; }

    public int? EventTaskOrganiserId3 { get; set; }

    public int? EventTaskOrganiserId4 { get; set; }

    public int EventTaskHelpersRequiredQty { get; set; }

    public bool EventTaskHideQty { get; set; }

    public DateTime? EventTaskRequiredByDate { get; set; }

    public DateTime EventTaskStartDate { get; set; }

    public DateTime? EventTaskFinishDate { get; set; }

    public int EventTaskSortOrder { get; set; }

    public int EventId { get; set; }

    public bool EventTaskDeleted { get; set; }

    public int EventTaskCreatedBy { get; set; }

    public DateTime EventTaskCreatedByDate { get; set; }

    public int? EventTaskUpdatedBy { get; set; }

    public DateTime? EventTaskUpdatedDate { get; set; }
}