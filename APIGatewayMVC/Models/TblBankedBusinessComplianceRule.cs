using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBankedBusinessComplianceRule
{
    public int BankedBusinessComplianceRuleId { get; set; }

    public TblBankedBusiness BankedBusiness { get; set; }

    public TblComplianceRule ComplianceRule { get; set; }

    public string BankedBusinessComplianceRuleNotes { get; set; }

    public bool BankedBusinessComplianceRuleDeleted { get; set; }

    public TblCustomer BankedBusinessComplianceRuleCreatedBy { get; set; }

    public DateTime BankedBusinessComplianceRuleCreatedDate { get; set; }

    public TblCustomer BankedBusinessComplianceRuleUpdatedBy { get; set; }

    public DateTime? BankedBusinessComplianceRuleUpdatedDate { get; set; }
}
