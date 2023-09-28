using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomer
{
    public int CustomerId { get; set; }

    public bool CustomerGuest { get; set; }

    public string CustomerPartnerId { get; set; }

    public int? LegacyCustomerId { get; set; }

    public int ApplicationId { get; set; }

    public int Ptaid { get; set; }

    public string CustomerUuid { get; set; }

    public string CustomerTitle { get; set; }

    public string CustomerFirstName { get; set;}

    public string CustomerLastName { get; set;}

    public string CustomerAddress1 { get; set; }

    public string CustomerAddress2 { get; set; }

    public string CustomerTown { get; set; }

    public string CustomerCounty { get; set; }

    public string CustomerPostCode { get; set; }

    public string CustomerEmail { get; set;}

    public string CustomerPassword { get; set;}

    public string CustomerSalt { get; set; }

    public string CustomerHashId { get; set; }

    public string CustomerPasswordReset { get; set; }

    public DateTime? CustomerPasswordResetDate { get; set; }

    public DateTime? CustomerLastLoginDateTime { get; set; }

    public int? CustomerLoginAttempts { get; set; }

    public DateTime? CustomerLastLoginAttemptDate { get; set; }

    public DateTime? CustomerLastLoginDate { get; set; }

    public string CustomerTelephone { get; set; }

    public string CustomerMobile { get; set; }

    public string CustomerStripeTestId { get; set; }

    public string CustomerStripeLiveId { get; set; }

    public string CustomerQflowPassword { get; set; }

    public string CustomerGeneric1 { get; set; }

    public string CustomerGeneric2 { get; set; }

    public string CustomerGeneric3 { get; set; }

    public int? CustomerSchoolId { get; set; }

    public string CustomerSchoolClass { get; set; }

    public bool? CustomerMarketingEmails { get; set; }

    public bool? CustomerPlatformArchiveReminderEmails { get; set; }

    public bool CustomerNewsLetter { get; set; }

    public DateTime? CustomerGiftAidDeclarationDate { get; set; }

    public bool CustomerDbschecked { get; set; }

    public bool CustomerFirstAider { get; set; }

    public bool? CustomerConfirmed { get; set; }

    public bool? CustomerApproved { get; set; }

    public string CustomerGoCardlessLiveMandate { get; set; }

    public string CustomerGoCardlessTestMandate { get; set; }

    public bool CustomerTerms { get; set; }

    public bool CustomerGdprconsentSent { get; set; }

    public bool? CustomerVerified { get; set; }

    public bool CustomerDeleted { get; set; }

    public DateTime? CustomerErasureDate { get; set; }

    public bool CustomerErased { get; set; }

    public DateTime CustomerCreatedDate { get; set; }

    public int CustomerCreatedBy { get; set; }

    public DateTime? CustomerUpdatedDate { get; set; }

    public int? CustomerUpdatedBy { get; set; }

    public TblSchool Application { get; set; }
    public TblSchool CustomerSchool { get; set; }
    public TblCustomer CreatedById { get; set; }
    public TblCustomer UpdatedById { get; set; }

    public List<TblSchool> SchoolsCreated { get; set; }
    public List<TblSchool> SchoolUpdatedBy { get; set; }
    public List<TblSchool> SchoolsDpasigned { get; set; }
    public List<TblSchool> SchoolsPtalotteryLicenceUploadedBy { get; set; }
    public List<TblSchool> SchoolsTermsSignedBy { get; set; }
    public List<TblCustomer> CreatedBy { get; set; }
    public List<TblCustomer> UpdatedBy { get; set; }
    public List<TblCustomerRole> CustomerRole { get; set; }
    public List<TblCustomerRole> CustomerRoleCreatedBy { get; set; }
    public List<TblCustomerRole> CustomerRoleUpdatedBy { get; set; }
    public List<TblRole> RoleCreatedBy { get; set; }
    public List<TblRole> RoleUpdatedBy { get; set; }
    public List<TblAcademicYear> AcademicYearCreatedBy { get; set; }
    public List<TblAcademicYear> AcademicYearUpdatedBy { get; set; }
    public List<TblApiAuditHistory> ApiAuditHistoryCustomer { get; set; }
    public List<TblApiAuditHistory> ApiAuditHistoryCreatedBy { get; set; }
    public List<TblAuction> AuctionUpdatedBy { get; set; }
    public List<TblAuction> AuctionCreatedBy { get; set; }
    public List<TblAuditHistory> AuditHistoryUpdatedBy { get; set; }
    public List<TblAuditHistory> AuditHistoryCreatedBy { get; set; }
    public List<TblAuditHistory> AuditHistoryCustomer { get; set; }
    public List<TblAuditHistoryType> AuditHistoryTypeUpdatedBy { get; set; }
    public List<TblAuditHistoryType> AuditHistoryTypeCreatedBy { get; set; }
    public List<TblBankedBusiness> BankedBusinessComplianceCompletedBy { get; set; }
    public List<TblBankedBusiness> BankedBusinessCreatedBy { get; set; }
    public List<TblBankedBusiness> BankedBusinessUpdatedBy { get; set; }
    public List<TblBankedBusinessApplication> BankedBusinessApplicationCreatedBy { get; set; }
    public List<TblBankedBusinessApplication> BankedBusinessApplicationUpdatedBy { get; set; }
    public List<TblBankedBusinessComplianceRule> BankedBusinessComplianceRuleCreatedBy { get; set; }
    public List<TblBankedBusinessComplianceRule> BankedBusinessComplianceRuleUpdatedBy { get; set; }
    public List<TblBid> BidCustomer { get; set; }
    public List<TblBid> BidCreatedBy { get; set; }
    public List<TblBid> BidUpdatedBy { get; set; }
    public List<TblBooking> BookingCreatedBy { get; set; }
    public List<TblBooking> BookingUpdatedBy { get; set; }
    public List<TblBusinessDirectory> BusinessDirectoryCreatedBy { get; set; }
    public List<TblBusinessDirectory> BusinessDirectoryUpdatedBy { get; set; }
    public List<TblBusinessDirectoryCategory> BusinessDirectoryCategoryCreatedBy { get; set; }
    public List<TblBusinessDirectoryCategory> BusinessDirectoryCategoryUpdatedBy { get; set; }
    public List<TblBusinessDirectoryClick> BusinessDirectoryClickCustomer { get; set; }
    public List<TblClassRep> ClassRepCustomer { get; set; }
    public List<TblClassRep> ClassRepCreatedBy { get; set; }
    public List<TblClassRep> ClassRepUpdatedBy { get; set; }
    public List<TblComplianceRule> ComplianceRuleCreatedBy { get; set; }
    public List<TblComplianceRule> ComplianceRuleUpdatedBy { get; set; }
    public List<TblComponent> ComponentCreatedBy { get; set; }
    public List<TblComponent> ComponentUpdatedBy { get; set; }
    public List<TblComponentGroup> ComponentGroupCreatedBy { get; set; }
    public List<TblComponentGroup> ComponentGroupUpdatedBy { get; set; }
    public List<TblComponentType> ComponentTypeCreatedBy { get; set; }
    public List<TblComponentType> ComponentTypeUpdatedBy { get; set; }
    public List<TblCountry> CountryCreatedBy { get; set; }
    public List<TblCountry> CountryUpdatedBy { get; set; }
    public List<TblCurrency> CurrencyCreatedBy { get; set; }
    public List<TblCurrency> CurrencyUpdatedBy { get; set; }
    public List<TblCustomerConsent> CustomerConsent { get; set; }
    public List<TblCustomerDevice> CustomerDevice { get; set; }
    public List<TblCustomerDevice> CustomerDeviceCreatedBy { get; set; }
    public List<TblCustomerDevice> CustomerDeviceUpdatedBy { get; set; }
    public List<TblDependant> DependantCustomer { get; set; }
    public List<TblDependant> DependantApprovedBy { get; set; }
    public List<TblDependant> DependantCreatedBy { get; set; }
    public List<TblDependant> DependantUpdatedBy { get; set; }
    public List<TblDiscount> DiscountCreatedBy { get; set; }
    public List<TblDiscount> DiscountUpdatedBy { get; set; }
    public List<TblEmail> EmailCreatedBy { get; set; }
    public List<TblEmail> EmailUpdatedBy { get; set; }
    public List<TblEvent> EventOrganiser { get; set; }
    public List<TblEvent> EventOrganiser2 { get; set; }
    public List<TblEvent> EventOrganiser3 { get; set; }
    public List<TblEvent> EventOrganiser4 { get; set; }
    public List<TblEvent> EventOrganiser5 { get; set; }
    public List<TblEvent> EventOrganiser6 { get; set; }
    public List<TblEvent> EventOrganiser7 { get; set; }
    public List<TblEvent> EventOrganiser8 { get; set; }
    public List<TblEvent> EventCreatedBy { get; set; }
    public List<TblEvent> EventUpdatedBy { get; set; }
    public List<TblEventFile> EventFileCreatedBy { get; set; }
    public List<TblEventFile> EventFileUpdatedBy { get; set; }
    public List<TblEventSponsor> EventSponsorCreatedBy { get; set; }
    public List<TblEventSponsor> EventSponsorUpdatedBy { get; set; }
    public List<TblEventTask> EventTaskOrganiser { get; set; }
    public List<TblEventTask> EventTaskOrganiser2 { get; set; }
    public List<TblEventTask> EventTaskOrganiser3 { get; set; }
    public List<TblEventTask> EventTaskOrganiser4 { get; set; }
    public List<TblEventTask> EventTaskCreatedBy { get; set; }
    public List<TblEventTask> EventTaskUpdatedBy { get; set; }
    public List<TblEventTaskCustomer> EventTaskCustomer { get; set; }
    public List<TblEventTaskCustomer> EventTaskCustomerCreatedBy { get; set; }
    public List<TblEventTaskCustomer> EventTaskCustomerUpdatedBy { get; set; }
    public List<TblEventTaskGroup> EventTaskGroup { get; set; }
    public List<TblEventTaskGroup> EventTaskGroupCreatedBy { get; set; }
    public List<TblEventTaskGroup> EventTaskGroupUpdatedBy { get; set; }
    public List<TblEventType> EventTypeCreatedBy { get; set; }
    public List<TblEventType> EventTypeUpdatedBy { get; set; }
    public List<TblFaq> FaqCreatedBy { get; set; }
    public List<TblFaq> FaqUpdatedBy { get; set; }
    public List<TblFile> FileCreatedBy { get; set; }
    public List<TblFile> FileUpdatedBy { get; set; }
    public List<TblFileRole> FileRoleCreatedBy { get; set; }
    public List<TblFileRole> FileRoleUpdatedBy { get; set; }
    public List<TblFileType> FileTypeCreatedBy { get; set; }
    public List<TblFileType> FileTypeUpdatedBy { get; set; }
    public List<TblLanguage> LanguageCreatedBy { get; set; }
    public List<TblLanguage> LanguageUpdatedBy { get; set; }
    public List<TblMessage> MessageCustomer { get; set; }
    public List<TblMessage> MessageCreatedBy { get; set; }
    public List<TblMessage> MessageUpdatedBy { get; set; }
    public List<TblMessageGroup> MessageGroupCreatedBy { get; set; }
    public List<TblMessageStatus> MessageStatusCreatedBy { get; set; }
    public List<TblMessageStatus> MessageStatusUpdatedBy { get; set; }
    public List<TblMessageType> MessageTypeCreatedBy { get; set; }
    public List<TblMessageType> MessageTypeUpdatedBy { get; set; }
    public List<TblNews> NewsCreatedBy { get; set; }
    public List<TblNews> NewsUpdatedBy { get; set; }
    public List<TblOrder> CustomerOrder { get; set; }
    public List<TblOrder> OrderCreatedBy { get; set; }
    public List<TblOrder> OrderUpdatedBy { get; set; }
    public List<TblOrderItem> OrderItemCreatedBy { get; set; }
    public List<TblOrderItem> OrderItemUpdatedBy { get; set; }
    public List<TblOrganisationType> OrganisationTypeCreatedBy { get; set; }
    public List<TblOrganisationType> OrganisationTypeUpdatedBy { get; set; }
    public List<TblPage> PageCreatedBy { get; set; }
    public List<TblPage> PageUpdatedBy { get; set; }
    public List<TblPartner> PartnerCreatedBy { get; set; }
    public List<TblPartner> PartnerUpdatedBy { get; set; }
    public List<TblPaymentMethod> PaymentMethodCreatedBy { get; set; }
    public List<TblPaymentMethod> PaymentMethodUpdatedBy { get; set; }
    public List<TblPaymentStatus> PaymentStatusCreatedBy { get; set; }
    public List<TblPaymentStatus> PaymentStatusUpdatedBy { get; set; }
    public List<TblPlatformPartner> PlatformPartnerCreatedBy { get; set; }
    public List<TblPlatformPartner> PlatformPartnerUpdatedBy { get; set; }
    public List<TblPoll> PollCreatedBy { get; set; }
    public List<TblPoll> PollUpdatedBy { get; set; }
    public List<TblPollAnswer> PollAnswerCustomer { get; set; }
    public List<TblPollAnswer> PollAnswerCreatedBy { get; set; }
    public List<TblPollAnswer> PollAnswerUpdatedBy { get; set; }
    public List<TblPollOption> PollOptionCreatedBy { get; set; }
    public List<TblPollOption> PollOptionUpdatedBy { get; set; }
    public List<TblProduct> ProductCreatedBy { get; set; }
    public List<TblProduct> ProductUpdatedBy { get; set; }
    public List<TblProductAttribute> ProductAttributeCreatedBy { get; set; }
    public List<TblProductAttribute> ProductAttributeUpdatedBy { get; set; }
    public List<TblProductClass> ProductClassCreatedBy { get; set; }
    public List<TblProductClass> ProductClassUpdatedBy { get; set; }
    public List<TblProductPayment> ProductPaymentCreatedBy { get; set; }
    public List<TblProductPayment> ProductPaymentUpdatedBy { get; set; }
    public List<TblProductPaymentScheme> ProductPaymentSchemeCreatedBy { get; set; }
    public List<TblProductPaymentScheme> ProductPaymentSchemeUpdatedBy { get; set; }
    public List<TblProductPaymentSchemeFrequency> ProductPaymentSchemeFrequencyCreatedBy { get; set; }
    public List<TblProductPaymentSchemeFrequency> ProductPaymentSchemeFrequencyUpdatedBy { get; set; }
    public List<TblProductQuestion> ProductQuestionCreatedBy { get; set; }
    public List<TblProductQuestion> ProductQuestionUpdatedBy { get; set; }
    public List<TblProductQuestionAnswer> ProductQuestion { get; set; }
    public List<TblProductQuestionAnswer> ProductQuestionAnswerCreatedBy { get; set; }
    public List<TblProductQuestionAnswer> ProductQuestionAnswerUpdatedBy { get; set; }
    public List<TblProductType> ProductTypeCreatedBy { get; set; }
    public List<TblProductType> ProductTypeUpdatedBy { get; set; }
    public List<TblPtamember> PtamemberCustomer { get; set; }
    public List<TblPtamember> PtamemberCreatedBy { get; set; }
    public List<TblPtamember> PtamemberUpdatedBy { get; set; }
    public List<TblRefund> RefundCreatedBy { get; set; }
    public List<TblRefund> RefundUpdatedBy { get; set; }
    public List<TblSchoolYear> SchoolYearCreatedBy { get; set; }
    public List<TblSchoolYear> SchoolYearUpdatedBy { get; set; }
    public List<TblSponsor> SponsorCreatedBy { get; set; }
    public List<TblSponsor> SponsorUpdatedBy { get; set; }
    public List<TblSponsorClick> SponsorClickCustomer { get; set; }
    public List<TblSponsorImpression> SponsorImpressionCustomer { get; set; }
    public List<TblSubGroup> SubGroupCreatedBy { get; set; }
    public List<TblSubGroup> SubGroupUpdatedBy { get; set; }
    public List<TblTicket> TicketCreatedBy { get; set; }
    public List<TblTicket> TicketUpdatedBy { get; set; }
    public List<TblTranslation> TranslationCreatedBy { get; set; }
    public List<TblTranslation> TranslationUpdatedBy { get; set; }
}
