using System;
using System.Collections.Generic;

namespace Models;

public partial class TblComponent
{
    public int ComponentId { get; set; }

    public string ComponentRef { get; set;}

    public string ComponentContent { get; set; }

    public string ComponentName { get; set;}

    public int ComponentTypeId { get; set; }

    public int ComponentGroupId { get; set; }

    public bool ComponentDeleted { get; set; }

    public int ComponentCreatedBy { get; set; }

    public DateTime ComponentCreatedDate { get; set; }

    public int? ComponentUpdatedBy { get; set; }

    public DateTime? ComponentUpdatedDate { get; set; }
}
