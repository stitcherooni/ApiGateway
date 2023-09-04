using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBankedBusiness
{
    public int BankedBusinessId { get; set; }

    public TblSchool School { get; set; }

    public string BankedBusinessUuid { get; set;}

    public string Kycid { get; set; }

    public bool BankedBusinessIdchecked { get; set; }

    public bool BankedBusinessBankStatementChecked { get; set; }

    public bool BankedBusinessLotteryLicenseChecked { get; set; }

    public bool BankedBusinessComplianceCompleted { get; set; }

    public TblCustomer BankedBusinessComplianceCompletedBy { get; set; }

    public DateTime? BankedBusinessComplianceCompletedDate { get; set; }

    public bool BankedBusinessDeleted { get; set; }

    public bool BankedBusinessComplianceBlocked { get; set; }

    public TblCustomer BankedBusinessCreatedBy { get; set; }

    public DateTime BankedBusinessCreatedDate { get; set; }

    public TblCustomer BankedBusinessUpdatedBy { get; set; }

    public DateTime? BankedBusinessUpdatedDate { get; set; }
}
