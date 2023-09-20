using System;

namespace Models;

public partial class TblSponsorImpression
{
    public int SponsorImpressionId { get; set; }

    public int SponsorId { get; set; }

    public int SponsorImpressionOrder { get; set; }

    public DateTime SponsorImpressionCreatedDate { get; set; }

    public int CustomerId { get; set; }

    public int SchoolId { get; set; }

    public string SponsorImpressionUserAgent { get; set; }

    public TblSponsor Sponsor { get; set; }
    public TblSchool School { get; set; }
    public TblCustomer Customer { get; set; }
}
