﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSponsor
{
    public int SponsorId { get; set; }

    public int SponsorTypeId { get; set; }

    public int CountryId { get; set; }

    public bool SponsorGlobal { get; set; }

    public bool SponsorAdmin { get; set; }

    public string SponsorName { get; set;}

    public decimal SponsorPrice { get; set; }

    public string SponsorText { get; set; }

    public string SponsorDescription { get; set; }

    public string SponsorTelephone { get; set; }

    public string SponsorEmail { get; set; }

    public string SponsorLogo { get; set; }

    public string SponsorTicketLogo { get; set; }

    public string SponsorDesktopAdvert { get; set; }

    public string SponsorMobileAdvert { get; set; }

    public string SponsorUrl { get; set; }

    public string SponsorFacebook { get; set; }

    public string SponsorTwitter { get; set; }

    public string SponsorInstagram { get; set; }

    public string SponsorPinterest { get; set; }

    public bool SponsorSite { get; set; }

    public string SponsorExcludeSites { get; set; }

    public string SponsorIncludeSites { get; set; }

    public DateTime? SponsorStartDate { get; set; }

    public DateTime? SponsorEndDate { get; set; }

    public int? SchoolId { get; set; }

    public bool SponsorDeleted { get; set; }

    public int SponsorCreatedBy { get; set; }

    public DateTime SponsorCreatedByDate { get; set; }

    public int? SponsorUpdatedBy { get; set; }

    public DateTime? SponsorUpdatedDate { get; set; }
}
