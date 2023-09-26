using System;
using System.Collections.Generic;

namespace Models;

public partial class TblOrganisationType
{
    public int OrganisationTypeId { get; set; }

    public string OrganisationTypeName { get; set;}

    public string OrganisationTypeMemberLabel { get; set;}

    public string OrganisationTypeIcon { get; set;}

    public bool OrganisationTypeDeleted { get; set; }

    public DateTime OrganisationTypeCreatedDate { get; set; }

    public int OrganisationTypeCreatedBy { get; set; }

    public DateTime? OrganisationTypeUpdatedDate { get; set; }

    public int? OrganisationTypeUpdatedBy { get; set; }
}
