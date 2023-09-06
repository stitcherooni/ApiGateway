﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblPaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string PaymentMethodName { get; set;}

    public bool PaymentMethodDeleted { get; set; }

    public TblCustomer PaymentMethodCreatedBy { get; set; }

    public DateTime PaymentMethodCreatedDate { get; set; }

    public TblCustomer PaymentMethodUpdatedBy { get; set; }

    public DateTime? PaymentMethodUpdatedDate { get; set; }
}
