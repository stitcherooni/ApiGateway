using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomerRole
{
    public int CustomerRoleId { get; set; }

    public int CustomerId { get; set; }

    public int RoleId { get; set; }

    public sbyte CustomerRoleDeleted { get; set; }

    public int CustomerRoleCreatedBy { get; set; }

    public DateTime CustomerRoleCreatedDate { get; set; }

    public int? CustomerRoleUpdatedBy { get; set; }

    public DateTime? CustomerRoleUpdatedDate { get; set; }

    public TblCustomer Customer { get; set; }
    public TblRole Role { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
