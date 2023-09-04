using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomerDevice
{
    public int CustomerDeviceId { get; set; }

    public TblCustomer Customer { get; set; }

    public string CustomerDeviceUuid { get; set; }

    public string CustomerDeviceName { get; set; }

    public TblCustomer CustomerDeviceCreatedBy { get; set; }

    public DateTime CustomerDeviceCreatedDate { get; set; }

    public TblCustomer CustomerDeviceUpdatedBy { get; set; }

    public DateTime? CustomerDeviceUpdatedDate { get; set; }

    public bool CustomerDeviceDeleted { get; set; }
}
