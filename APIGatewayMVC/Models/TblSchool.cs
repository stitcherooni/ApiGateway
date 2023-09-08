using System;
using System.Collections.Generic;

namespace Models;

public partial class TblSchool
{
    public int SchoolId { get; set; }

    public string SchoolUid { get; set; }

    public bool SchoolAppLive { get; set; }

    public int? PlatformPartnerId { get; set; }

    public bool SchoolPlatformOptIn { get; set; }

    public string PartnerOrganisationId { get; set; }

    public string PartnerMembershipNumber { get; set; }

    public TblPlanType PlanType { get; set; }

    public int SchoolPupils { get; set; }

    public decimal SchoolSubscriptionPrice { get; set; }

    public decimal? PlatformFee { get; set; }

    public DateTime? SchoolSubscriptionStartDate { get; set; }

    public DateTime? SchoolScanningStartDate { get; set; }

    public DateTime? SchoolBrandingEmailSentDate { get; set; }

    public TblCustomer SchoolTermsSignedBy { get; set; }

    public string SchoolGdprlawfulBasis { get; set; }

    public DateTime? SchoolTermsDateSigned { get; set; }

    public DateTime? SchoolGdprdateSigned { get; set; }

    public TblCustomer SchoolGdprsignedBy { get; set; }

    public DateTime? SchoolDpadateSigned { get; set; }

    public TblCustomer SchoolDpasignedBy { get; set; }

    public string SchoolDataRetentionSettings { get; set;}

    public string SchoolName { get; set; }

    public string SchoolKnownByName { get; set; }

    public string SchoolPtaname { get; set;}

    public string SchoolPtafullName { get; set; }

    public string SchoolAddress1 { get; set; }

    public string SchoolAddress2 { get; set; }

    public string SchoolTown { get; set; }

    public string SchoolCounty { get; set; }

    public string SchoolPostCode { get; set; }

    public string SchoolPtaregisteredCharityNo { get; set; }

    public bool SchoolCustomersRequireApproval { get; set; }

    public string SchoolPtafacebook { get; set; }

    public string SchoolPtatwitter { get; set; }

    public string SchoolPtatwitterWidget { get; set; }

    public bool SchoolPtadisplayFacebookWidget { get; set; }

    public bool SchoolPtadisplayTwitterWidget { get; set; }

    public string SchoolPtainstagram { get; set; }

    public string SchoolPtafooter { get; set; }

    public string SchoolPtatelephone1 { get; set; }

    public string SchoolPtaemail { get; set; }

    public string SchoolPtawebsite { get; set; }

    public string SchoolPtadirectory { get; set; }

    public string SchoolPtadomain { get; set; }

    public string SchoolPtasubDomain { get; set; }

    public string SchoolPtadefaultPage { get; set;}

    public string SchoolPtaglobalPages { get; set; }

    public bool SchoolPtaregisterToView { get; set; }

    public bool SchoolPtaregisterCollectClass { get; set; }

    public sbyte SchoolEnableGuestCheckout { get; set; }

    public string SchoolPtapaypalLiveAccount { get; set; }

    public string SchoolPtapaypalAccountType { get; set;}

    public string SchoolPtapaypalTestAccount { get; set; }

    public string SchoolPtastripeTestSecretKey { get; set; }

    public string SchoolPtastripeTestPublishableKey { get; set; }

    public string SchoolPtastripeTestRefreshToken { get; set; }

    public string SchoolPtastripeTestUserId { get; set; }

    public string SchoolPtastripeLiveSecretKey { get; set; }

    public string SchoolPtastripeLivePublishableKey { get; set; }

    public string SchoolPtastripeLiveRefreshToken { get; set; }

    public string SchoolPtastripeLiveUserId { get; set; }

    public string SchoolPtastripeLiveAccountId { get; set; }

    public string SchoolPtastripeAccountType { get; set; }

    public bool SchoolPtastripeGamblingApproved { get; set; }

    public bool SchoolPtalotteryLicenceUploaded { get; set; }

    public TblCustomer SchoolPtalotteryLicenceUploadedBy { get; set; }

    public string SchoolPtagoCardlessTestToken { get; set; }

    public string SchoolPtagoCardlessTestEndpointSecret { get; set; }

    public string SchoolPtagoCardlessTestOrganisationId { get; set; }

    public string SchoolPtagoCardlessLiveToken { get; set; }

    public string SchoolPtagoCardlessLiveEndpointSecret { get; set; }

    public string SchoolPtagoCardlessLiveOrganisationId { get; set; }

    public TblCurrency SchoolPtacurrency { get; set; }

    public TblCountry SchoolPtacountry { get; set; }

    public int TimeZoneId { get; set; }

    public DateTime? SchoolPtacloseDate { get; set; }

    public string SchoolPtafontFamily { get; set; }

    public string SchoolPtatitleFontFamily { get; set;}

    public int SchoolFontSize { get; set; }

    public string SchoolPrimaryColour { get; set; }

    public string SchoolLinkColour { get; set; }

    public string SchoolBackgroundColour { get; set; }

    public string SchoolPageBackgroundColour { get; set; }

    public string SchoolBorderColour { get; set; }

    public string SchoolNavBarColour { get; set; }

    public string SchoolNavBarTextColour { get; set; }

    public string SchoolNavBarTextHoverColour { get; set; }

    public string SchoolTextColour { get; set; }

    public string SchoolSliderType { get; set;}

    public string SchoolPtametaKeywords { get; set; }

    public string SchoolPtametaDescription { get; set; }

    public bool SchoolPtametaIndex { get; set; }

    public bool SchoolPtametaFollow { get; set; }

    public string SchoolPtagoogleAnalyticsAccount { get; set; }

    public string SchoolPtagoogleVerificationCode { get; set; }

    public TblOrganisationType OrganisationType { get; set; }

    public bool SchoolPkmember { get; set; }

    public decimal SchoolPtafundraisingTarget { get; set; }

    public decimal SchoolPtafundraisingAmount { get; set; }

    public string SchoolPtafundraisingText { get; set; }

    public bool SchoolMergeShopProductPages { get; set; }

    public bool SchoolDeleted { get; set; }

    public TblCustomer? SchoolCreatedBy { get; set; }

    public DateTime SchoolCreatedDate { get; set; }

    public TblCustomer SchoolUpdatedBy { get; set; }

    public DateTime? SchoolUpdatedDate { get; set; }

    public string SchoolCustomCss { get; set; }

    public string Lacode { get; set; }

    public int? SchoolCreatedById { get; set; }
}
