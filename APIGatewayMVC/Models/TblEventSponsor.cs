using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEventSponsor
{
    public int EventSponsorId { get; set; }

    public int EventId { get; set; }

    public int SponsorId { get; set; }

    public bool EventSponsorDeleted { get; set; }

    public DateTime EventSponsorCreatedDate { get; set; }

    public int EventSponsorCreatedBy { get; set; }

    public DateTime? EventSponsorUpdatedDate { get; set; }

    public int? EventSponsorUpdatedBy { get; set; }
}
