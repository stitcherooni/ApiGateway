using System;
using System.Collections.Generic;

namespace Models;

public partial class TblDependant
{
    public int DependantId { get; set; }

    public int CustomerId { get; set; }

    public string DependantFirstName { get; set;}

    public string DependantLastName { get; set;}

    public bool DependantMailingList { get; set; }

    public bool DependantShare { get; set; }

    public int DependantApprovedBy { get; set; }

    public DateTime? DependantApprovedDate { get; set; }

    public int ClassId { get; set; }

    public bool DependantDeleted { get; set; }

    public bool DependantGdprconsent { get; set; }

    public DateTime DependantCreatedDate { get; set; }

    public int DependantCreatedBy { get; set; }

    public DateTime? DependantUpdatedDate { get; set; }

    public int? DependantUpdatedBy { get; set; }

    public TblCustomer Customer { get; set; }
    public TblCustomer ApprovedBy { get; set; }
    public TblClass Class { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
