using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBankedBusinessComplianceRule
{
    public int BankedBusinessComplianceRuleId { get; set; }

    public int BankedBusinessId { get; set; }

    public int ComplianceRuleId { get; set; }

    public string BankedBusinessComplianceRuleNotes { get; set; }

    public bool BankedBusinessComplianceRuleDeleted { get; set; }

    public int BankedBusinessComplianceRuleCreatedBy { get; set; }

    public DateTime BankedBusinessComplianceRuleCreatedDate { get; set; }

    public int? BankedBusinessComplianceRuleUpdatedBy { get; set; }

    public DateTime? BankedBusinessComplianceRuleUpdatedDate { get; set; }

    public TblBankedBusiness BankedBusiness { get; set; }
    public TblComplianceRule ComplianceRule { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
