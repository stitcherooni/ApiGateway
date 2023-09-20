﻿using System;

namespace Models;

public partial class TblCustomerDevice
{
    public int CustomerDeviceId { get; set; }

    public int CustomerId { get; set; }

    public string CustomerDeviceUuid { get; set; }

    public string CustomerDeviceName { get; set; }

    public int CustomerDeviceCreatedBy { get; set; }

    public DateTime CustomerDeviceCreatedDate { get; set; }

    public int? CustomerDeviceUpdatedBy { get; set; }

    public DateTime? CustomerDeviceUpdatedDate { get; set; }

    public bool CustomerDeviceDeleted { get; set; }

    public TblCustomer Customer { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
