using System;
using System.Collections.Generic;

namespace Models;

public partial class TblComplianceRule
{
    public int ComplianceRuleId { get; set; }

    public string ComplianceRuleName { get; set;}

    public string ComplianceRuleDescription { get; set; }

    public string ComplianceRuleType { get; set; }

    public bool ComplianceRuleDeleted { get; set; }

    public TblCustomer ComplianceRuleCreatedBy { get; set; }

    public DateTime ComplianceRuleCreatedDate { get; set; }

    public TblCustomer ComplianceRuleUpdatedBy { get; set; }

    public DateTime? ComplianceRuleUpdatedDate { get; set; }
}
