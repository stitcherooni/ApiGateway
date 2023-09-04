using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomerRole
{
    public int CustomerRoleId { get; set; }

    public TblCustomer Customer { get; set; }

    public TblRole Role { get; set; }

    public sbyte CustomerRoleDeleted { get; set; }

    public TblCustomer CustomerRoleCreatedBy { get; set; }

    public DateTime CustomerRoleCreatedDate { get; set; }

    public TblCustomer CustomerRoleUpdatedBy { get; set; }

    public DateTime? CustomerRoleUpdatedDate { get; set; }
}
