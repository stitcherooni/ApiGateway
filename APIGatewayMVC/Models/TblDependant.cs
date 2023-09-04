using System;
using System.Collections.Generic;

namespace Models;

public partial class TblDependant
{
    public int DependantId { get; set; }

    public TblCustomer Customer { get; set; }

    public string DependantFirstName { get; set;}

    public string DependantLastName { get; set;}

    public bool DependantMailingList { get; set; }

    public bool DependantShare { get; set; }

    public TblCustomer DependantApprovedBy { get; set; }

    public DateTime? DependantApprovedDate { get; set; }

    public TblClass Class { get; set; }

    public bool DependantDeleted { get; set; }

    public bool DependantGdprconsent { get; set; }

    public DateTime DependantCreatedDate { get; set; }

    public TblCustomer DependantCreatedBy { get; set; }

    public DateTime? DependantUpdatedDate { get; set; }

    public TblCustomer DependantUpdatedBy { get; set; }
}
