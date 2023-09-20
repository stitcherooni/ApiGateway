﻿using System;

namespace Models;

public partial class TblPaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string PaymentMethodName { get; set;}

    public bool PaymentMethodDeleted { get; set; }

    public int PaymentMethodCreatedBy { get; set; }

    public DateTime PaymentMethodCreatedDate { get; set; }

    public int? PaymentMethodUpdatedBy { get; set; }

    public DateTime? PaymentMethodUpdatedDate { get; set; }

    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
