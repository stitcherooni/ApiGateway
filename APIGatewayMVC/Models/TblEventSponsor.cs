using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventSponsor
{
    public int EventSponsorId { get; set; }

    public TblEvent Event { get; set; }

    public TblSponsor Sponsor { get; set; }

    public bool EventSponsorDeleted { get; set; }

    public DateTime EventSponsorCreatedDate { get; set; }

    public TblCustomer EventSponsorCreatedBy { get; set; }

    public DateTime? EventSponsorUpdatedDate { get; set; }

    public TblCustomer EventSponsorUpdatedBy { get; set; }
}
