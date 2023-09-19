using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPlatformPartner
{
    public int PlatformPartnerId { get; set; }

    public string PlatformPartnerName { get; set;}

    public decimal PlatformPartnerNationalAdvertisingRevShare { get; set; }

    public decimal PlatformPartnerLocalAdvertisingRevShare { get; set; }

    public decimal PlatformPartnerPlatformFeeRevShare { get; set; }

    public string PlatformPartnerDescription { get; set; }

    public string PlatformPartnerCode { get; set; }

    public string PlatformPartnerTelephone { get; set; }

    public string PlatformPartnerEmail { get; set; }

    public string PlatformPartnerLogo { get; set; }

    public string PlatformPartnerUrl { get; set; }

    public bool PlatformPartnerDeleted { get; set; }

    public int PlatformPartnerCreatedBy { get; set; }

    public DateTime PlatformPartnerCreatedDate { get; set; }

    public int? PlatformPartnerUpdatedBy { get; set; }

    public DateTime? PlatformPartnerUpdatedDate { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
