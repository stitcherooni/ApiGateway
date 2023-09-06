using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSponsorClick
{
    public int SponsorClickId { get; set; }

    public TblSponsor Sponsor { get; set; }

    public TblCustomer Customer { get; set; }

    public TblSchool School { get; set; }

    public string SponsorClickFrom { get; set; }

    public string SponsorClickPage { get; set; }

    public string SponsorClickUserAgent { get; set; }

    public DateTime SponsorClickDateTime { get; set; }
}
