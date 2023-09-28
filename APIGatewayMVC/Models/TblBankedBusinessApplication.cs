using System;

namespace Models;

public partial class TblBankedBusinessApplication
{
    public int BankedBusinessApplicationId { get; set; }

    public int BankedBusinessId { get; set; }

    public string BankedBusinessApplicationUuid { get; set;}

    public string BankedBusinessApplicationName { get; set;}

    public string BankedBusinessApplicationWebhookSignatureKey { get; set; }

    public bool BankedBusinessApplicationLive { get; set; }

    public bool BankedBusinessApplicationDeleted { get; set; }

    public int BankedBusinessApplicationCreatedBy { get; set; }

    public DateTime BankedBusinessApplicationCreatedDate { get; set; }

    public int? BankedBusinessApplicationUpdatedBy { get; set; }

    public DateTime? BankedBusinessApplicationUpdatedDate { get; set; }

    public TblBankedBusiness BankedBusiness { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
