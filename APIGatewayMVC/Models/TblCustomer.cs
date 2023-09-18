﻿using System;
using System.Collections.Generic;

namespace Models;

public partial class TblCustomer
{
    public int CustomerId { get; set; }

    public bool CustomerGuest { get; set; }

    public int CustomerPartnerId { get; set; }

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

    public int CustomerHashId { get; set; }

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

    public int CustomerSchoolId { get; set; }

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


    public TblPartner Partner { get; set; }
    public TblSchool Application { get; set; }
    public TblContentHash Hash { get; set; }
    public TblSchool CustomerSchool { get; set; }
    public TblCustomer CreatedById { get; set; }
    public TblCustomer UpdatedById { get; set; }
}
