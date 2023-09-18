using System;
using System.Collections.Generic;

namespace Models;

public partial class TblEvent
{
    public int EventId { get; set; }

    public int? LegacyEventId { get; set; }

    public string EventUuid { get; set; }

    public int EventOrganiserId { get; set; }

    public int? EventOrganiserId2 { get; set; }

    public int? EventOrganiserId3 { get; set; }

    public int? EventOrganiserId4 { get; set; }

    public int? EventOrganiserId5 { get; set; }
           
    public int? EventOrganiserId6 { get; set; }
           
    public int? EventOrganiserId7 { get; set; }
           
    public int? EventOrganiserId8 { get; set; }

    public string EventName { get; set;}

    public string EventDescription { get; set; }

    public bool EventShowDescriptionFirst { get; set; }

    public string EventEmailText { get; set; }

    public bool EventBccorderConfirmationEmail { get; set; }

    public bool EventBccvolunteerConfirmationEmail { get; set; }

    public string EventCarouselImage { get; set; }

    public string EventCarouselImageText { get; set;}

    public bool EventCarouselImageDisplaySalesDate { get; set; }

    public bool EventWhatsOnPanelDisplaySalesDate { get; set; }

    public int EventTypeId { get; set; }

    public DateTime? EventDate { get; set; }

    public DateTime? EventEndDate { get; set; }

    public DateTime? EventSaleStartDate { get; set; }

    public DateTime? EventSaleEndDate { get; set; }

    public DateTime? EventLastSyncedDate { get; set; }

    public string EventQflowEventId { get; set; }

    public DateTime? EventLastSyncedDateVouchers { get; set; }

    public string EventQflowEventIdvouchers { get; set; }

    public DateTime? EventLastSyncedDateBoardingPasses { get; set; }

    public string EventQflowEventIdboardingPasses { get; set; }

    public bool EventDontShowDate { get; set; }

    public bool EventDontShowTime { get; set; }

    public string EventFeeType { get; set;}

    public string EventPlatformFeeType { get; set;}

    public int? EventMaxAttendeesQty { get; set; }

    public bool EventHideEventCapacity { get; set; }

    public bool EventHideProductsOnShop { get; set; }

    public bool EventHideSoldOutProducts { get; set; }

    public bool EventAskVolunteers { get; set; }

    public bool EventDontShowTasks { get; set; }

    public bool EventIsProductGroup { get; set; }

    public bool EventAuction { get; set; }

    public string EventLocation { get; set; }

    public string EventPostCode { get; set; }

    public bool EventSponsored { get; set; }

    public string EventSponsoredByName { get; set; }

    public string EventSponsoredByLogo { get; set; }

    public string EventSponsoredByUrl { get; set; }

    public DateTime? EventPurgeDataDate { get; set; }

    public bool EventDeleted { get; set; }

    public int EventCreatedBy { get; set; }

    public DateTime EventCreatedDate { get; set; }

    public int? EventUpdatedBy { get; set; }

    public DateTime? EventUpdatedDate { get; set; }

    public int SchoolId { get; set; }

    public List<TblAuction> Event { get; set; }
    public List<TblEventFile> EventFile { get; set; }
    public List<TblEventProduct> EventProduct { get; set; }
    public List<TblEventSponsor> EventSponsor { get; set; }

    public TblCustomer EventOrganiser { get; set; }
    public TblCustomer EventOrganiser2 { get; set; }
    public TblCustomer EventOrganiser3 { get; set; }
    public TblCustomer EventOrganiser4 { get; set; }
    public TblCustomer EventOrganiser5 { get; set; }
    public TblCustomer EventOrganiser6 { get; set; }
    public TblCustomer EventOrganiser7 { get; set; }
    public TblCustomer EventOrganiser8 { get; set; }
    public TblEventType EventType { get; set; }
    public TblSchool School { get; set; }
    public TblCustomer CreatedBy { get; set; }
    public TblCustomer UpdatedBy { get; set; }
}
