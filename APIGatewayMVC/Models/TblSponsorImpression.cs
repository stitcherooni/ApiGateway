using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSponsorImpression
{
    public int SponsorImpressionId { get; set; }

    public TblSponsor Sponsor { get; set; }

    public int SponsorImpressionOrder { get; set; }

    public DateTime SponsorImpressionCreatedDate { get; set; }

    public TblCustomer Customer { get; set; }

    public TblSchool School { get; set; }

    public string SponsorImpressionUserAgent { get; set; }
}
