using System;
using System.Collections.Generic;

namespace Models;

public partial class TblBankedBusinessApplication
{
    public int BankedBusinessApplicationId { get; set; }

    public TblBankedBusiness BankedBusiness { get; set; }

    public string BankedBusinessApplicationUuid { get; set;}

    public string BankedBusinessApplicationName { get; set;}

    public string BankedBusinessApplicationWebhookSignatureKey { get; set; }

    public bool BankedBusinessApplicationLive { get; set; }

    public bool BankedBusinessApplicationDeleted { get; set; }

    public TblCustomer BankedBusinessApplicationCreatedBy { get; set; }

    public DateTime BankedBusinessApplicationCreatedDate { get; set; }

    public TblCustomer BankedBusinessApplicationUpdatedBy { get; set; }

    public DateTime? BankedBusinessApplicationUpdatedDate { get; set; }
}
