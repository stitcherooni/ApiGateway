using System;

namespace Models;

public partial class TblSponsorClick
{
    public int SponsorClickId { get; set; }

    public int SponsorId { get; set; }

    public int CustomerId { get; set; }

    public int SchoolId { get; set; }

    public string SponsorClickFrom { get; set; }

    public string SponsorClickPage { get; set; }

    public string SponsorClickUserAgent { get; set; }

    public DateTime SponsorClickDateTime { get; set; }

    public TblSponsor Sponsor { get; set; }
    public TblSchool School { get; set; }
    public TblCustomer Customer { get; set; }
}
