using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBankedBusiness
{
    public int BankedBusinessId { get; set; }

    public int SchoolId { get; set; }

    public string BankedBusinessUuid { get; set;}

    public string Kycid { get; set; }

    public bool BankedBusinessIdchecked { get; set; }

    public bool BankedBusinessBankStatementChecked { get; set; }

    public bool BankedBusinessLotteryLicenseChecked { get; set; }

    public bool BankedBusinessComplianceCompleted { get; set; }

    public int BankedBusinessComplianceCompletedBy { get; set; }

    public DateTime? BankedBusinessComplianceCompletedDate { get; set; }

    public bool BankedBusinessDeleted { get; set; }

    public bool BankedBusinessComplianceBlocked { get; set; }

    public int BankedBusinessCreatedBy { get; set; }

    public DateTime BankedBusinessCreatedDate { get; set; }

    public int? BankedBusinessUpdatedBy { get; set; }

    public DateTime? BankedBusinessUpdatedDate { get; set; }

    public TblSchool School { get; set; }
    public TblCustomer ComplianceCompletedBy { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
