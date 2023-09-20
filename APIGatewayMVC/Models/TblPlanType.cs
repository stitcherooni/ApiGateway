using System.Collections.Generic;

namespace Models;

public partial class TblPlanType
{
    public int PlanTypeId { get; set; }

    public string PlanTypeName { get; set;}

    public string PlanTypeDescription { get; set; }

    public List<TblSchool> PlanType { get; set; }
}
