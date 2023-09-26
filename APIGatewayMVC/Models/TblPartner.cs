using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPartner
{
    public int PartnerId { get; set; }

    public string PartnerName { get; set; }

    public string PartnerDescription { get; set; }

    public string PartnerCode { get; set; }

    public string PartnerTelephone { get; set; }

    public string PartnerEmail { get; set; }

    public string PartnerLogo { get; set; }

    public string PartnerUrl { get; set; }

    public int SchoolId { get; set; }

    public bool PartnerDeleted { get; set; }

    public int PartnerCreatedBy { get; set; }

    public DateTime PartnerCreatedByDate { get; set; }

    public int? PartnerUpdatedBy { get; set; }

    public DateTime? PartnerUpdatedDate { get; set; }
}
