using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace Models;

public partial class PtaeventContext : DbContext
{

    public PtaeventContext(DbContextOptions<PtaeventContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAcademicYear> TblAcademicYears { get; set; }

    public virtual DbSet<TblApiAuditHistory> TblApiAuditHistories { get; set; }

    public virtual DbSet<TblAuction> TblAuctions { get; set; }

    public virtual DbSet<TblAuditHistory> TblAuditHistories { get; set; }

    public virtual DbSet<TblAuditHistoryType> TblAuditHistoryTypes { get; set; }

    public virtual DbSet<TblBankedBusiness> TblBankedBusinesses { get; set; }

    public virtual DbSet<TblBankedBusinessApplication> TblBankedBusinessApplications { get; set; }

    public virtual DbSet<TblBankedBusinessComplianceRule> TblBankedBusinessComplianceRules { get; set; }

    public virtual DbSet<TblBankedWebHook> TblBankedWebHooks { get; set; }

    public virtual DbSet<TblBid> TblBids { get; set; }

    public virtual DbSet<TblBooking> TblBookings { get; set; }

    public virtual DbSet<TblBusinessDirectory> TblBusinessDirectories { get; set; }

    public virtual DbSet<TblBusinessDirectoryCategory> TblBusinessDirectoryCategories { get; set; }

    public virtual DbSet<TblBusinessDirectoryClick> TblBusinessDirectoryClicks { get; set; }

    public virtual DbSet<TblClass> TblClasses { get; set; }

    public virtual DbSet<TblClassRep> TblClassReps { get; set; }

    public virtual DbSet<TblComplianceRule> TblComplianceRules { get; set; }

    public virtual DbSet<TblComponent> TblComponents { get; set; }

    public virtual DbSet<TblComponentGroup> TblComponentGroups { get; set; }

    public virtual DbSet<TblComponentType> TblComponentTypes { get; set; }

    public virtual DbSet<TblContentHash> TblContentHashes { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblCurrency> TblCurrencies { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblCustomerConsent> TblCustomerConsents { get; set; }

    public virtual DbSet<TblCustomerDevice> TblCustomerDevices { get; set; }

    public virtual DbSet<TblCustomerRole> TblCustomerRoles { get; set; }

    public virtual DbSet<TblDependant> TblDependants { get; set; }

    public virtual DbSet<TblDiscount> TblDiscounts { get; set; }

    public virtual DbSet<TblEmail> TblEmails { get; set; }

    public virtual DbSet<TblEmailEvent> TblEmailEvents { get; set; }

    public virtual DbSet<TblEvent> TblEvents { get; set; }

    public virtual DbSet<TblEventFile> TblEventFiles { get; set; }

    public virtual DbSet<TblEventProduct> TblEventProducts { get; set; }

    public virtual DbSet<TblEventSponsor> TblEventSponsors { get; set; }

    public virtual DbSet<TblEventTask> TblEventTasks { get; set; }

    public virtual DbSet<TblEventTaskCustomer> TblEventTaskCustomers { get; set; }

    public virtual DbSet<TblEventTaskGroup> TblEventTaskGroups { get; set; }

    public virtual DbSet<TblEventType> TblEventTypes { get; set; }

    public virtual DbSet<TblException> TblExceptions { get; set; }

    public virtual DbSet<TblFaq> TblFaqs { get; set; }

    public virtual DbSet<TblFile> TblFiles { get; set; }

    public virtual DbSet<TblFileRole> TblFileRoles { get; set; }

    public virtual DbSet<TblFileType> TblFileTypes { get; set; }

    public virtual DbSet<TblIplookUp> TblIplookUps { get; set; }

    public virtual DbSet<TblLanguage> TblLanguages { get; set; }

    public virtual DbSet<TblLocalAuthority> TblLocalAuthorities { get; set; }

    public virtual DbSet<TblMessage> TblMessages { get; set; }

    public virtual DbSet<TblMessageGroup> TblMessageGroups { get; set; }

    public virtual DbSet<TblMessageStatus> TblMessageStatuses { get; set; }

    public virtual DbSet<TblMessageType> TblMessageTypes { get; set; }

    public virtual DbSet<TblNews> TblNews { get; set; }

    public virtual DbSet<TblOrder> TblOrders { get; set; }

    public virtual DbSet<TblOrderItem> TblOrderItems { get; set; }

    public virtual DbSet<TblOrganisationType> TblOrganisationTypes { get; set; }

    public virtual DbSet<TblPage> TblPages { get; set; }

    public virtual DbSet<TblPartner> TblPartners { get; set; }

    public virtual DbSet<TblPaymentMethod> TblPaymentMethods { get; set; }

    public virtual DbSet<TblPaymentStatus> TblPaymentStatuses { get; set; }

    public virtual DbSet<TblPaypal> TblPaypals { get; set; }

    public virtual DbSet<TblPlanType> TblPlanTypes { get; set; }

    public virtual DbSet<TblPlatformPartner> TblPlatformPartners { get; set; }

    public virtual DbSet<TblPoll> TblPolls { get; set; }

    public virtual DbSet<TblPollAnswer> TblPollAnswers { get; set; }

    public virtual DbSet<TblPollOption> TblPollOptions { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductAttribute> TblProductAttributes { get; set; }

    public virtual DbSet<TblProductClass> TblProductClasses { get; set; }

    public virtual DbSet<TblProductPayment> TblProductPayments { get; set; }

    public virtual DbSet<TblProductPaymentScheme> TblProductPaymentSchemes { get; set; }

    public virtual DbSet<TblProductPaymentSchemeFrequency> TblProductPaymentSchemeFrequencies { get; set; }

    public virtual DbSet<TblProductQuestion> TblProductQuestions { get; set; }

    public virtual DbSet<TblProductQuestionAnswer> TblProductQuestionAnswers { get; set; }

    public virtual DbSet<TblProductType> TblProductTypes { get; set; }

    public virtual DbSet<TblPtamember> TblPtamembers { get; set; }

    public virtual DbSet<TblRefund> TblRefunds { get; set; }

    public virtual DbSet<TblRole> TblRoles { get; set; }

    public virtual DbSet<TblSchool> TblSchools { get; set; }

    public virtual DbSet<TblSchoolYear> TblSchoolYears { get; set; }

    public virtual DbSet<TblSponsor> TblSponsors { get; set; }

    public virtual DbSet<TblSponsorClick> TblSponsorClicks { get; set; }

    public virtual DbSet<TblSponsorImpression> TblSponsorImpressions { get; set; }

    public virtual DbSet<TblStripeFee> TblStripeFees { get; set; }

    public virtual DbSet<TblStripePayout> TblStripePayouts { get; set; }

    public virtual DbSet<TblStripeWebHook> TblStripeWebHooks { get; set; }

    public virtual DbSet<TblSubGroup> TblSubGroups { get; set; }

    public virtual DbSet<TblTicket> TblTickets { get; set; }

    public virtual DbSet<TblTimeZone> TblTimeZones { get; set; }

    public virtual DbSet<TblTranslation> TblTranslations { get; set; }

    public virtual DbSet<VersionInfo> VersionInfos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("latin1_swedish_ci")
            .HasCharSet("latin1");

        modelBuilder.Entity<TblAcademicYear>(entity =>
        {
            entity.HasKey(e => e.AcademicYearId).HasName("PRIMARY");

            entity.ToTable("tblAcademicYear");

            entity.Property(e => e.AcademicYearId)
                .HasColumnType("int(11)")
                .HasColumnName("AcademicYearID");

            entity.Property(e => e.AcademicYearCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.AcademicYearEndDate).HasColumnType("timestamp");
            entity.Property(e => e.AcademicYearName).HasMaxLength(20);
            entity.Property(e => e.AcademicYearStartDate).HasColumnType("timestamp");
            entity.Property(e => e.AcademicYearUpdatedDate).HasColumnType("timestamp");

            entity.Property(e => e.AcademicYearCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.AcademicYearUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CountryId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("CountryID");

            entity.HasOne(academicYear => academicYear.Country)
                .WithMany(country => country.AcademicCountry)
                .HasForeignKey(academicYear => academicYear.CountryId)
                .IsRequired(false);
            entity.HasOne(academicYear => academicYear.CreatedBy)
                .WithMany(customer => customer.AcademicYearCreatedBy)
                .HasForeignKey(academicYear => academicYear.AcademicYearCreatedBy)
                .IsRequired(false);
            entity.HasOne(academicYear => academicYear.UpdatedBy)
                .WithMany(customer => customer.AcademicYearUpdatedBy)
                .HasForeignKey(academicYear => academicYear.AcademicYearUpdatedBy)
                .IsRequired(false);

            entity.HasMany(academicYear => academicYear.AcademicYearClass)
                .WithOne(classes => classes.AcademicYear)
                .HasForeignKey(classes => classes.AcademicYearId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblApiAuditHistory>(entity =>
        {
            entity.HasKey(e => e.ApiAuditHistoryId).HasName("PRIMARY");

            entity.ToTable("tblApiAuditHistory");

            entity.HasIndex(e => e.ApiAuditHistoryCreatedDate, "ApiAuditHistoryCreatedDate");

            entity.HasIndex(e => e.ApiAuditHistoryIpaddress, "ApiAuditHistoryIPAddress");

            entity.HasIndex(e => e.ApplicationId, "ApplicationID");
            entity.HasIndex(e => e.CustomerId, "CustomerID");
            entity.Property(e => e.ApiAuditHistoryCreatedBy).HasColumnType("int(11)");

            entity.Property(e => e.ApiAuditHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("ApiAuditHistoryID");
            entity.Property(e => e.ApiAuditHistoryCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ApiAuditHistoryEvent).HasMaxLength(50);
            entity.Property(e => e.ApiAuditHistoryIpaddress)
                .HasMaxLength(50)
                .HasColumnName("ApiAuditHistoryIPAddress");
            entity.Property(e => e.ApiAuditHistoryLoadTime).HasColumnType("int(11)");
            entity.Property(e => e.ApiAuditHistoryQueryString).HasMaxLength(500);
            entity.Property(e => e.ApiAuditHistoryServer).HasMaxLength(50);
            entity.Property(e => e.ApiAuditHistoryStatusCode).HasMaxLength(20);
            entity.Property(e => e.ApiAuditHistoryUri).HasMaxLength(500);
            entity.Property(e => e.ApiAuditHistoryUserAgent).HasMaxLength(500);
            entity.Property(e => e.ApplicationId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("ApplicationID");
            entity.Property(e => e.CustomerId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");

            entity.HasOne(apiAuditHistory => apiAuditHistory.Application)
                .WithMany(school => school.ApiAuditHistoryApplication)
                .HasForeignKey(apiAuditHistory => apiAuditHistory.ApplicationId)
                .IsRequired(false);
            entity.HasOne(apiAuditHistory => apiAuditHistory.Customer)
                .WithMany(customer => customer.ApiAuditHistoryCustomer)
                .HasForeignKey(apiAuditHistory => apiAuditHistory.CustomerId)
                .IsRequired(false);
            entity.HasOne(apiAuditHistory => apiAuditHistory.CreatedBy)
                .WithMany(customer => customer.ApiAuditHistoryCreatedBy)
                .HasForeignKey(apiAuditHistory => apiAuditHistory.ApiAuditHistoryCreatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblAuction>(entity =>
        {
            entity.HasKey(e => e.AuctionId).HasName("PRIMARY");

            entity.ToTable("tblAuction");

            entity.HasIndex(e => e.AuctionStartDate, "AuctionStartDate");

            entity.HasIndex(e => e.EventId, "EventID");

            entity.Property(e => e.AuctionId)
                .HasColumnType("int(11)")
                .HasColumnName("AuctionID");
            entity.Property(e => e.AuctionBuyNowPrice).HasPrecision(10, 2);
            entity.Property(e => e.AuctionCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.AuctionCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.AuctionDescription).HasColumnType("text");
            entity.Property(e => e.AuctionDisplay)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.AuctionEndDate).HasColumnType("datetime");
            entity.Property(e => e.AuctionImage).HasMaxLength(200);
            entity.Property(e => e.AuctionName).HasMaxLength(250);
            entity.Property(e => e.AuctionOrder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.AuctionReservePrice).HasPrecision(10, 2);
            entity.Property(e => e.AuctionStartDate).HasColumnType("datetime");
            entity.Property(e => e.AuctionStartPrice).HasPrecision(10, 2);
            entity.Property(e => e.AuctionStockQty).HasColumnType("int(11)");
            entity.Property(e => e.AuctionUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.AuctionUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.AuctionUuid)
                .HasMaxLength(50)
                .HasColumnName("AuctionUUID");
            entity.Property(e => e.EventId)
                .HasColumnType("int(11)")
                .HasColumnName("EventID");

            entity.HasOne(auction => auction.Event)
                .WithMany(events => events.Event)
                .HasForeignKey(auction => auction.EventId)
                .IsRequired(false);
            entity.HasOne(auction => auction.CreatedBy)
                .WithMany(customer => customer.AuctionCreatedBy)
                .HasForeignKey(auction => auction.AuctionCreatedBy)
                .IsRequired(false);
            entity.HasOne(auction => auction.UpdatedBy)
                .WithMany(customer => customer.AuctionUpdatedBy)
                .HasForeignKey(auction => auction.AuctionUpdatedBy)
                .IsRequired(false);

            entity.HasMany(auction => auction.BidAuction)
                .WithOne(bid => bid.Auction)
                .HasForeignKey(bid => bid.AuctionId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblAuditHistory>(entity =>
        {
            entity.HasKey(e => e.AuditHistoryId).HasName("PRIMARY");

            entity.ToTable("tblAuditHistory");

            entity.HasIndex(e => e.ApplicationId, "ApplicationID");
            entity.HasIndex(e => e.CustomerId, "CustomerID");
            entity.HasIndex(e => new { e.AuditHistoryUserAgent, e.ApplicationId }, "idx");
            entity.HasIndex(e => new { e.ApplicationId, e.AuditHistoryCreatedDate, e.AuditHistoryUserAgent }, "idx2");

            entity.Property(e => e.AuditHistoryId)
                .HasColumnType("int(11)")
                .HasColumnName("AuditHistoryID");
            entity.Property(e => e.ApplicationId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("ApplicationID");
            entity.Property(e => e.AuditHistoryCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.AuditHistoryCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.AuditHistoryEvent).HasMaxLength(50);
            entity.Property(e => e.AuditHistoryIpaddress)
                .HasMaxLength(50)
                .HasColumnName("AuditHistoryIPAddress");
            entity.Property(e => e.AuditHistoryLoadTime).HasColumnType("int(11)");
            entity.Property(e => e.AuditHistoryQueryString).HasMaxLength(500);
            entity.Property(e => e.AuditHistoryServer).HasMaxLength(50);
            entity.Property(e => e.AuditHistoryUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.AuditHistoryUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.AuditHistoryUserAgent).HasMaxLength(500);
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");

            entity.HasOne(auditHistory => auditHistory.Application)
                .WithMany(school => school.AuditHistoryApplication)
                .HasForeignKey(auditHistory => auditHistory.ApplicationId)
                .IsRequired(false);
            entity.HasOne(auditHistory => auditHistory.Customer)
                .WithMany(customer => customer.AuditHistoryCustomer)
                .HasForeignKey(auditHistory => auditHistory.CustomerId)
                .IsRequired(false);
            entity.HasOne(auditHistory => auditHistory.CreatedBy)
                .WithMany(customer => customer.AuditHistoryCreatedBy)
                .HasForeignKey(auditHistory => auditHistory.AuditHistoryCreatedBy)
                .IsRequired(false);
            entity.HasOne(auditHistory => auditHistory.UpdatedBy)
                .WithMany(customer => customer.AuditHistoryUpdatedBy)
                .HasForeignKey(auditHistory => auditHistory.AuditHistoryUpdatedBy)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblAuditHistoryType>(entity =>
        {
            entity.HasKey(e => e.AuditHistoryTypeId).HasName("PRIMARY");

            entity.ToTable("tblAuditHistoryType");

            entity.Property(e => e.AuditHistoryTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("AuditHistoryTypeID");
            entity.Property(e => e.AuditHistoryTypeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.AuditHistoryTypeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.AuditHistoryTypeName).HasMaxLength(200);
            entity.Property(e => e.AuditHistoryTypeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.AuditHistoryTypeUpdatedDate).HasColumnType("timestamp");
            entity.HasOne(auditHistoryType => auditHistoryType.CreatedBy)
                .WithMany(customer => customer.AuditHistoryTypeCreatedBy)
                .HasForeignKey(auditHistoryType => auditHistoryType.AuditHistoryTypeCreatedBy)
                .IsRequired(false);
            entity.HasOne(auditHistoryType => auditHistoryType.UpdatedBy)
                .WithMany(customer => customer.AuditHistoryTypeUpdatedBy)
                .HasForeignKey(auditHistoryType => auditHistoryType.AuditHistoryTypeUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblBankedBusiness>(entity =>
        {
            entity.HasKey(e => e.BankedBusinessId).HasName("PRIMARY");

            entity.ToTable("tblBankedBusiness");

            entity.HasIndex(e => e.SchoolId, "SchoolID");

            entity.Property(e => e.BankedBusinessId)
                .HasColumnType("int(11)")
                .HasColumnName("BankedBusinessID");
            entity.Property(e => e.BankedBusinessComplianceCompletedBy).HasColumnType("int(11)");
            entity.Property(e => e.BankedBusinessComplianceCompletedDate).HasColumnType("datetime");
            entity.Property(e => e.BankedBusinessCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BankedBusinessCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BankedBusinessIdchecked).HasColumnName("BankedBusinessIDChecked");
            entity.Property(e => e.BankedBusinessUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BankedBusinessUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.BankedBusinessUuid)
                .HasMaxLength(50)
                .HasColumnName("BankedBusinessUUID");
            entity.Property(e => e.Kycid)
                .HasMaxLength(50)
                .HasColumnName("KYCID");
            entity.Property(e => e.SchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolID");

            entity.HasOne(bankedBusiness => bankedBusiness.School)
                .WithMany(school => school.BankedBusinessSchool)
                .HasForeignKey(bankedBusiness => bankedBusiness.SchoolId)
                .IsRequired(false);
            entity.HasOne(bankedBusiness => bankedBusiness.ComplianceCompletedBy)
                .WithMany(customer => customer.BankedBusinessComplianceCompletedBy)
                .HasForeignKey(bankedBusiness => bankedBusiness.BankedBusinessComplianceCompletedBy)
                .IsRequired(false);
            entity.HasOne(bankedBusiness => bankedBusiness.CreatedBy)
                .WithMany(customer => customer.BankedBusinessCreatedBy)
                .HasForeignKey(bankedBusiness => bankedBusiness.BankedBusinessCreatedBy)
                .IsRequired(false);
            entity.HasOne(bankedBusiness => bankedBusiness.UpdatedBy)
                .WithMany(customer => customer.BankedBusinessUpdatedBy)
                .HasForeignKey(bankedBusiness => bankedBusiness.BankedBusinessUpdatedBy)
                .IsRequired(false);

            entity.HasMany(bankedBusiness => bankedBusiness.BankedBusinessApplication)
                .WithOne(bankedBusinessApplication => bankedBusinessApplication.BankedBusiness)
                .HasForeignKey(bankedBusinessApplication => bankedBusinessApplication.BankedBusinessId)
                .IsRequired(false);
            entity.HasMany(bankedBusiness => bankedBusiness.BankedBusinessComplianceRule)
                .WithOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusiness)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusinessId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblBankedBusinessApplication>(entity =>
        {
            entity.HasKey(e => e.BankedBusinessApplicationId).HasName("PRIMARY");

            entity.ToTable("tblBankedBusinessApplication");

            entity.Property(e => e.BankedBusinessApplicationId)
                .HasColumnType("int(11)")
                .HasColumnName("BankedBusinessApplicationID");
            entity.Property(e => e.BankedBusinessApplicationCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BankedBusinessApplicationCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BankedBusinessApplicationName).HasMaxLength(50);
            entity.Property(e => e.BankedBusinessApplicationUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BankedBusinessApplicationUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.BankedBusinessApplicationUuid)
                .HasMaxLength(50)
                .HasColumnName("BankedBusinessApplicationUUID");
            entity.Property(e => e.BankedBusinessApplicationWebhookSignatureKey).HasMaxLength(500);
            entity.Property(e => e.BankedBusinessId)
                .HasColumnType("int(11)")
                .HasColumnName("BankedBusinessID");

            entity.HasOne(bankedBusinessApplication => bankedBusinessApplication.BankedBusiness)
                .WithMany(bankedBusiness => bankedBusiness.BankedBusinessApplication)
                .HasForeignKey(bankedBusinessApplication => bankedBusinessApplication.BankedBusinessId)
                .IsRequired(false);
            entity.HasOne(bankedBusinessApplication => bankedBusinessApplication.CreatedBy)
                .WithMany(customer => customer.BankedBusinessApplicationCreatedBy)
                .HasForeignKey(bankedBusinessApplication => bankedBusinessApplication.BankedBusinessApplicationCreatedBy)
                .IsRequired(false);
            entity.HasOne(bankedBusinessApplication => bankedBusinessApplication.UpdatedBy)
                .WithMany(customer => customer.BankedBusinessApplicationUpdatedBy)
                .HasForeignKey(bankedBusinessApplication => bankedBusinessApplication.BankedBusinessApplicationUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblBankedBusinessComplianceRule>(entity =>
        {
            entity.HasKey(e => e.BankedBusinessComplianceRuleId).HasName("PRIMARY");

            entity.ToTable("tblBankedBusinessComplianceRule");

            entity.HasIndex(e => e.BankedBusinessId, "BankedBusinessID");

            entity.Property(e => e.BankedBusinessComplianceRuleId)
                .HasColumnType("int(11)")
                .HasColumnName("BankedBusinessComplianceRuleID");
            entity.Property(e => e.BankedBusinessComplianceRuleCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BankedBusinessComplianceRuleCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BankedBusinessComplianceRuleNotes).HasColumnType("text");
            entity.Property(e => e.BankedBusinessComplianceRuleUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BankedBusinessComplianceRuleUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.BankedBusinessId)
                .HasColumnType("int(11)")
                .HasColumnName("BankedBusinessID");
            entity.Property(e => e.ComplianceRuleId)
                .HasColumnType("int(11)")
                .HasColumnName("ComplianceRuleID");

            entity.HasOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusiness)
                .WithMany(bankedBusiness => bankedBusiness.BankedBusinessComplianceRule)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusinessId)
                .IsRequired(false);
            entity.HasOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.ComplianceRule)
                .WithMany(complianceRule => complianceRule.BankedBusinessComplianceRule)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.ComplianceRuleId)
                .IsRequired(false);
            entity.HasOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.CreatedBy)
                .WithMany(customer => customer.BankedBusinessComplianceRuleCreatedBy)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusinessComplianceRuleCreatedBy)
                .IsRequired(false);
            entity.HasOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.UpdatedBy)
                .WithMany(customer => customer.BankedBusinessComplianceRuleUpdatedBy)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusinessComplianceRuleUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblBankedWebHook>(entity =>
        {
            entity.HasKey(e => e.BankedWebHookId).HasName("PRIMARY");

            entity.ToTable("tblBankedWebHook");

            entity.HasIndex(e => e.BankedWebHookBankedId, "BankedWebHookBankedID");

            entity.HasIndex(e => e.BankedWebHookEndToEndId, "BankedWebHookRequestID");

            entity.HasIndex(e => e.OrderId, "OrderID");

            entity.Property(e => e.BankedWebHookId)
                .HasColumnType("int(11)")
                .HasColumnName("BankedWebHookID");
            entity.Property(e => e.BankedWebHookBankedId)
                .HasMaxLength(50)
                .HasColumnName("BankedWebHookBankedID");
            entity.Property(e => e.BankedWebHookCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BankedWebHookEndToEndId)
                .HasMaxLength(50)
                .HasColumnName("BankedWebHookEndToEndID");
            entity.Property(e => e.BankedWebHookEvent).HasMaxLength(50);
            entity.Property(e => e.BankedWebHookStatus).HasMaxLength(50);
            entity.Property(e => e.BankedWebHookType).HasMaxLength(50);
            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("OrderID");

            entity.HasOne(bankedWebHook => bankedWebHook.Order)
                .WithMany(order => order.BankedWebHookOrder)
                .HasForeignKey(bankedWebHook => bankedWebHook.OrderId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblBid>(entity =>
        {
            entity.HasKey(e => e.BidId).HasName("PRIMARY");

            entity.ToTable("tblBid");

            entity.HasIndex(e => e.AuctionId, "AuctionID");

            entity.HasIndex(e => e.BidAmount, "BidAmount");

            entity.HasIndex(e => e.BidDateTime, "BidDateTime");

            entity.Property(e => e.BidId)
                .HasColumnType("int(11)")
                .HasColumnName("BidID");
            entity.Property(e => e.AuctionId)
                .HasColumnType("int(11)")
                .HasColumnName("AuctionID");
            entity.Property(e => e.BidAmount).HasPrecision(10, 2);
            entity.Property(e => e.BidCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BidCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BidDateTime).HasColumnType("datetime");
            entity.Property(e => e.BidUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BidUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");

            entity.HasOne(bid => bid.Auction)
                .WithMany(auction => auction.BidAuction)
                .HasForeignKey(bid => bid.AuctionId)
                .IsRequired(false);
            entity.HasOne(bid => bid.Customer)
                .WithMany(customer => customer.BidCustomer)
                .HasForeignKey(bid => bid.CustomerId)
                .IsRequired(false);
            entity.HasOne(bid => bid.CreatedBy)
                .WithMany(customer => customer.BidCreatedBy)
                .HasForeignKey(bid => bid.BidCreatedBy)
                .IsRequired(false);
            entity.HasOne(bid => bid.UpdatedBy)
                .WithMany(customer => customer.BidUpdatedBy)
                .HasForeignKey(bid => bid.BidUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblBooking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PRIMARY");

            entity.ToTable("tblBooking");

            entity.HasIndex(e => e.BookingName, "BookingName");

            entity.HasIndex(e => e.ClassId, "ClassID");

            entity.HasIndex(e => e.OrderItemId, "OrderItemID");

            entity.HasIndex(e => e.TicketId, "TicketID");

            entity.HasIndex(e => new { e.OrderItemId, e.BookingNo, e.ClassId }, "idx_bookings");

            entity.Property(e => e.BookingId)
                .HasColumnType("int(11)")
                .HasColumnName("BookingID");
            entity.Property(e => e.BookingCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BookingCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BookingDeleted)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.BookingFirstName).HasMaxLength(100);
            entity.Property(e => e.BookingLastName).HasMaxLength(100);
            entity.Property(e => e.BookingName).HasMaxLength(200);
            entity.Property(e => e.BookingNo).HasColumnType("int(11)");
            entity.Property(e => e.BookingUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BookingUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.ClassId)
                .HasColumnType("int(11)")
                .HasColumnName("ClassID");
            entity.Property(e => e.OrderItemId)
                .HasColumnType("int(11)")
                .HasColumnName("OrderItemID");
            entity.Property(e => e.TicketId)
                .HasColumnType("int(11)")
                .HasColumnName("TicketID");

            entity.HasOne(booking => booking.Class)
                .WithMany(classes => classes.BookingClass)
                .HasForeignKey(booking => booking.ClassId)
                .IsRequired(false);
            entity.HasOne(booking => booking.OrderItem)
                .WithMany(orderItem => orderItem.BookingOrderItem)
                .HasForeignKey(booking => booking.OrderItemId)
                .IsRequired(false);
            entity.HasOne(booking => booking.Ticket)
                .WithMany(ticket => ticket.BookingTicket)
                .HasForeignKey(booking => booking.TicketId)
                .IsRequired(false);
            entity.HasOne(booking => booking.CreatedBy)
                .WithMany(customer => customer.BookingCreatedBy)
                .HasForeignKey(booking => booking.BookingCreatedBy)
                .IsRequired(false);
            entity.HasOne(booking => booking.UpdatedBy)
                .WithMany(customer => customer.BookingUpdatedBy)
                .HasForeignKey(booking => booking.BookingUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblBusinessDirectory>(entity =>
        {
            entity.HasKey(e => e.BusinessDirectoryId).HasName("PRIMARY");

            entity.ToTable("tblBusinessDirectory");

            entity.Property(e => e.BusinessDirectoryId)
                .HasColumnType("int(11)")
                .HasColumnName("BusinessDirectoryID");
            entity.Property(e => e.BusinessDirectoryCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("BusinessDirectoryCategoryID");
            entity.Property(e => e.BusinessDirectoryCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BusinessDirectoryCreatedByDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BusinessDirectoryDescription).HasColumnType("text");
            entity.Property(e => e.BusinessDirectoryEmail).HasMaxLength(250);
            entity.Property(e => e.BusinessDirectoryEndDate).HasColumnType("datetime");
            entity.Property(e => e.BusinessDirectoryFacebook).HasMaxLength(255);
            entity.Property(e => e.BusinessDirectoryInstagram).HasMaxLength(255);
            entity.Property(e => e.BusinessDirectoryLogo).HasMaxLength(255);
            entity.Property(e => e.BusinessDirectoryName).HasMaxLength(100);
            entity.Property(e => e.BusinessDirectoryPinterest).HasMaxLength(255);
            entity.Property(e => e.BusinessDirectoryStartDate).HasColumnType("datetime");
            entity.Property(e => e.BusinessDirectoryTelephone).HasMaxLength(50);
            entity.Property(e => e.BusinessDirectoryTwitter).HasMaxLength(255);
            entity.Property(e => e.BusinessDirectoryUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BusinessDirectoryUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.BusinessDirectoryUrl)
                .HasMaxLength(255)
                .HasColumnName("BusinessDirectoryURL");
            entity.Property(e => e.SchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolID");

            entity.HasOne(businessDirectory => businessDirectory.BusinessDirectoryCategory)
                .WithMany(businessDirectoryCategory => businessDirectoryCategory.BusinessDirectoryCategory)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryCategoryId)
                .IsRequired(false);
            entity.HasOne(businessDirectory => businessDirectory.School)
                .WithMany(school => school.BusinessDirectorySchool)
                .HasForeignKey(businessDirectory => businessDirectory.SchoolId)
                .IsRequired(false);
            entity.HasOne(businessDirectory => businessDirectory.CreatedBy)
                .WithMany(customer => customer.BusinessDirectoryCreatedBy)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryCreatedBy)
                .IsRequired(false);
            entity.HasOne(businessDirectory => businessDirectory.UpdatedBy)
                .WithMany(customer => customer.BusinessDirectoryUpdatedBy)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryUpdatedBy)
                .IsRequired(false);

            entity.HasMany(businessDirectory => businessDirectory.BusinessDirectoryClick)
                .WithOne(businessDirectoryClick => businessDirectoryClick.BusinessDirectory)
                .HasForeignKey(businessDirectoryClick => businessDirectoryClick.BusinessDirectoryId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblBusinessDirectoryCategory>(entity =>
        {
            entity.HasKey(e => e.BusinessDirectoryCategoryId).HasName("PRIMARY");

            entity.ToTable("tblBusinessDirectoryCategory");

            entity.Property(e => e.BusinessDirectoryCategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("BusinessDirectoryCategoryID");
            entity.Property(e => e.BusinessDirectoryCategoryCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BusinessDirectoryCategoryCreatedByDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BusinessDirectoryCategoryIcon).HasMaxLength(50);
            entity.Property(e => e.BusinessDirectoryCategoryName).HasMaxLength(100);
            entity.Property(e => e.BusinessDirectoryCategoryUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.BusinessDirectoryCategoryUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.SchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolID");

            entity.HasOne(businessDirectoryCategory => businessDirectoryCategory.School)
                .WithMany(school => school.BusinessDirectoryCategorySchool)
                .HasForeignKey(businessDirectoryCategory => businessDirectoryCategory.SchoolId)
                .IsRequired(false);
            entity.HasOne(businessDirectory => businessDirectory.CreatedBy)
                .WithMany(customer => customer.BusinessDirectoryCategoryCreatedBy)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryCategoryCreatedBy)
                .IsRequired(false);
            entity.HasOne(businessDirectory => businessDirectory.UpdatedBy)
                .WithMany(customer => customer.BusinessDirectoryCategoryUpdatedBy)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryCategoryUpdatedBy)
                .IsRequired(false);

            entity.HasMany(businessDirectoryCategory => businessDirectoryCategory.BusinessDirectoryCategory)
                .WithOne(businessDirectory => businessDirectory.BusinessDirectoryCategory)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryCategoryId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblBusinessDirectoryClick>(entity =>
        {
            entity.HasKey(e => e.BusinessDirectoryClickId).HasName("PRIMARY");

            entity.ToTable("tblBusinessDirectoryClick");

            entity.HasIndex(e => e.SchoolId, "SchoolID");

            entity.HasIndex(e => e.BusinessDirectoryId, "SponsorID");

            entity.Property(e => e.BusinessDirectoryClickId)
                .HasColumnType("int(11)")
                .HasColumnName("BusinessDirectoryClickID");
            entity.Property(e => e.BusinessDirectoryClickDateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.BusinessDirectoryClickFrom).HasMaxLength(50);
            entity.Property(e => e.BusinessDirectoryClickPage).HasMaxLength(50);
            entity.Property(e => e.BusinessDirectoryClickUserAgent).HasMaxLength(1000);
            entity.Property(e => e.BusinessDirectoryId)
                .HasColumnType("int(11)")
                .HasColumnName("BusinessDirectoryID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");
            entity.Property(e => e.SchoolId)
                .HasColumnType("int(10)")
                .HasColumnName("SchoolID");

            entity.HasOne(businessDirectoryClick => businessDirectoryClick.BusinessDirectory)
                .WithMany(businessDirectory => businessDirectory.BusinessDirectoryClick)
                .HasForeignKey(businessDirectoryClick => businessDirectoryClick.BusinessDirectoryId)
                .IsRequired(false);
            entity.HasOne(businessDirectoryClick => businessDirectoryClick.Customer)
                .WithMany(customer => customer.BusinessDirectoryClickCustomer)
                .HasForeignKey(businessDirectoryClick => businessDirectoryClick.CustomerId)
                .IsRequired(false);
            entity.HasOne(businessDirectoryClick => businessDirectoryClick.School)
                .WithMany(school => school.BusinessDirectoryClickSchool)
                .HasForeignKey(businessDirectoryClick => businessDirectoryClick.SchoolId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblClass>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PRIMARY");

            entity.ToTable("tblClass");

            entity.Property(e => e.ClassId)
                .HasColumnType("int(11)")
                .HasColumnName("ClassID");
            entity.Property(e => e.AcademicYearId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("AcademicYearID");
            entity.Property(e => e.ClassAllowParentsEmail)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.ClassAllowShare)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.ClassFilter).HasMaxLength(500);
            entity.Property(e => e.ClassName).HasMaxLength(50);
            entity.Property(e => e.ClassPassword).HasMaxLength(250);
            entity.Property(e => e.ClassTeacherEmail).HasMaxLength(250);
            entity.Property(e => e.ClassTeacherName).HasMaxLength(250);
            entity.Property(e => e.ClassTeacherTelephone).HasMaxLength(30);
            entity.Property(e => e.SchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolID");
            entity.Property(e => e.SchoolYearId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolYearID");

            entity.HasOne(classes => classes.School)
                .WithMany(school => school.SchoolClass)
                .HasForeignKey(classes => classes.SchoolId)
                .IsRequired(false);
            entity.HasOne(classes => classes.AcademicYear)
                .WithMany(academicYear => academicYear.AcademicYearClass)
                .HasForeignKey(classes => classes.AcademicYearId)
                .IsRequired(false);
            entity.HasOne(classes => classes.SchoolYear)
                .WithMany(schoolYear => schoolYear.SchoolYearClass)
                .HasForeignKey(classes => classes.SchoolYearId)
                .IsRequired(false);

            entity.HasMany(classes => classes.BookingClass)
                .WithOne(booking => booking.Class)
                .HasForeignKey(booking => booking.ClassId)
                .IsRequired(false);
            entity.HasMany(classes => classes.ClassRepClass)
                .WithOne(classRep => classRep.Class)
                .HasForeignKey(classRep => classRep.ClassId)
                .IsRequired(false);
            entity.HasMany(classes => classes.DependantClass)
                .WithOne(dependant => dependant.Class)
                .HasForeignKey(classRep => classRep.ClassId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblClassRep>(entity =>
        {
            entity.HasKey(e => e.ClassRepId).HasName("PRIMARY");

            entity.ToTable("tblClassRep");

            entity.Property(e => e.ClassRepId)
                .HasColumnType("int(11)")
                .HasColumnName("ClassRepID");
            entity.Property(e => e.ClassId)
                .HasColumnType("int(11)")
                .HasColumnName("ClassID");
            entity.Property(e => e.ClassRepCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ClassRepCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ClassRepUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ClassRepUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");

            entity.HasOne(classRep => classRep.Class)
                .WithMany(classes => classes.ClassRepClass)
                .HasForeignKey(classRep => classRep.ClassId)
                .IsRequired(false);
            entity.HasOne(classRep => classRep.Customer)
                .WithMany(customer => customer.ClassRepCustomer)
                .HasForeignKey(classRep => classRep.CustomerId)
                .IsRequired(false);
            entity.HasOne(classRep => classRep.CreatedBy)
                .WithMany(customer => customer.ClassRepCreatedBy)
                .HasForeignKey(classRep => classRep.ClassRepCreatedBy)
                .IsRequired(false);
            entity.HasOne(classRep => classRep.UpdatedBy)
                .WithMany(customer => customer.ClassRepUpdatedBy)
                .HasForeignKey(classRep => classRep.ClassRepUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblComplianceRule>(entity =>
        {
            entity.HasKey(e => e.ComplianceRuleId).HasName("PRIMARY");

            entity.ToTable("tblComplianceRule");

            entity.Property(e => e.ComplianceRuleId)
                .HasColumnType("int(11)")
                .HasColumnName("ComplianceRuleID");
            entity.Property(e => e.ComplianceRuleCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComplianceRuleCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ComplianceRuleDescription).HasColumnType("text");
            entity.Property(e => e.ComplianceRuleName).HasMaxLength(250);
            entity.Property(e => e.ComplianceRuleType).HasMaxLength(40);
            entity.Property(e => e.ComplianceRuleUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComplianceRuleUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(complianceRule => complianceRule.CreatedBy)
                .WithMany(customer => customer.ComplianceRuleCreatedBy)
                .HasForeignKey(complianceRule => complianceRule.ComplianceRuleCreatedBy)
                .IsRequired(false);
            entity.HasOne(complianceRule => complianceRule.UpdatedBy)
                .WithMany(customer => customer.ComplianceRuleUpdatedBy)
                .HasForeignKey(complianceRule => complianceRule.ComplianceRuleUpdatedBy)
                .IsRequired(false);

            entity.HasMany(complianceRule => complianceRule.BankedBusinessComplianceRule)
                .WithOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.ComplianceRule)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.ComplianceRuleId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblComponent>(entity =>
        {
            entity.HasKey(e => e.ComponentId).HasName("PRIMARY");

            entity.ToTable("tblComponent");

            entity.Property(e => e.ComponentId)
                .HasColumnType("int(11)")
                .HasColumnName("ComponentID");
            entity.Property(e => e.ComponentContent).HasColumnType("text");
            entity.Property(e => e.ComponentCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComponentCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ComponentGroupId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("ComponentGroupID");
            entity.Property(e => e.ComponentName).HasMaxLength(100);
            entity.Property(e => e.ComponentRef).HasMaxLength(100);
            entity.Property(e => e.ComponentTypeId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("ComponentTypeID");
            entity.Property(e => e.ComponentUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComponentUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(component => component.ComponentType)
                .WithMany(componentType => componentType.ComponentType)
                .HasForeignKey(component => component.ComponentTypeId)
                .IsRequired(false);
            entity.HasOne(component => component.ComponentGroup)
                .WithMany(componentGroup => componentGroup.ComponentGroups)
                .HasForeignKey(component => component.ComponentGroupId)
                .IsRequired(false);
            entity.HasOne(component => component.CreatedBy)
                .WithMany(customer => customer.ComponentCreatedBy)
                .HasForeignKey(component => component.ComponentCreatedBy)
                .IsRequired(false);
            entity.HasOne(component => component.UpdatedBy)
                .WithMany(customer => customer.ComponentUpdatedBy)
                .HasForeignKey(component => component.ComponentUpdatedBy)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblComponentGroup>(entity =>
        {
            entity.HasKey(e => e.ComponentGroupId).HasName("PRIMARY");

            entity.ToTable("tblComponentGroup");

            entity.Property(e => e.ComponentGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("ComponentGroupID");
            entity.Property(e => e.ComponentGroupCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComponentGroupCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ComponentGroupName).HasMaxLength(100);
            entity.Property(e => e.ComponentGroupUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComponentGroupUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(componentGroup => componentGroup.CreatedBy)
                .WithMany(customer => customer.ComponentGroupCreatedBy)
                .HasForeignKey(componentGroup => componentGroup.ComponentGroupCreatedBy)
                .IsRequired(false);
            entity.HasOne(componentGroup => componentGroup.UpdatedBy)
                .WithMany(customer => customer.ComponentGroupUpdatedBy)
                .HasForeignKey(componentGroup => componentGroup.ComponentGroupUpdatedBy)
                .IsRequired(false);

            entity.HasMany(componentGroup => componentGroup.ComponentGroups)
                .WithOne(component => component.ComponentGroup)
                .HasForeignKey(component => component.ComponentGroupId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblComponentType>(entity =>
        {
            entity.HasKey(e => e.ComponentTypeId).HasName("PRIMARY");

            entity.ToTable("tblComponentType");

            entity.Property(e => e.ComponentTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("ComponentTypeID");
            entity.Property(e => e.ComponentTypeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComponentTypeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ComponentTypeName).HasMaxLength(100);
            entity.Property(e => e.ComponentTypeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ComponentTypeUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(componentType => componentType.CreatedBy)
                .WithMany(customer => customer.ComponentTypeCreatedBy)
                .HasForeignKey(componentType => componentType.ComponentTypeCreatedBy)
                .IsRequired(false);
            entity.HasOne(componentType => componentType.UpdatedBy)
                .WithMany(customer => customer.ComponentTypeUpdatedBy)
                .HasForeignKey(componentType => componentType.ComponentTypeUpdatedBy)
                .IsRequired(false);

            entity.HasMany(componentType => componentType.ComponentType)
                .WithOne(component => component.ComponentType)
                .HasForeignKey(component => component.ComponentTypeId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblContentHash>(entity =>
        {
            entity.HasKey(e => e.ContentHashId).HasName("PRIMARY");

            entity.ToTable("tblContentHash");

            entity.HasIndex(e => e.ContentHashName, "ContentHashName");

            entity.HasIndex(e => e.ContentHashValue, "ContentHashValue");

            entity.Property(e => e.ContentHashId)
                .HasColumnType("int(11)")
                .HasColumnName("ContentHashID");
            entity.Property(e => e.ContentHashCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ContentHashName).HasMaxLength(50);
            entity.Property(e => e.ContentHashValue).HasMaxLength(32);

            entity.HasMany(contentHash => contentHash.CustomerHash)
                .WithOne(customer => customer.Hash)
                .HasForeignKey(customer => customer.CustomerHashId)
                .IsRequired(false);
            entity.HasMany(contentHash => contentHash.CustomerConsentCustomerHash)
                .WithOne(customerConsent => customerConsent.ContentHash)
                .HasForeignKey(customerConsent => customerConsent.ContentHashId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PRIMARY");

            entity.ToTable("tblCountry");

            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("CountryID");
            entity.Property(e => e.CountryCode).HasMaxLength(4);
            entity.Property(e => e.CountryCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CountryCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.CountryDateFormat)
                .HasMaxLength(20)
                .HasDefaultValueSql("'dd/mm/yyyy'");
            entity.Property(e => e.CountryName).HasMaxLength(100);
            entity.Property(e => e.CountryUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CountryUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(country => country.CreatedBy)
                .WithMany(customer => customer.CountryCreatedBy)
                .HasForeignKey(country => country.CountryCreatedBy)
                .IsRequired(false);
            entity.HasOne(country => country.UpdatedBy)
                .WithMany(customer => customer.CountryUpdatedBy)
                .HasForeignKey(country => country.CountryUpdatedBy)
                .IsRequired(false);

            entity.HasMany(country => country.SchoolsPtacountry)
                .WithOne(school => school.Ptacountry)
                .HasForeignKey(school => school.SchoolPtacountryId)
                .IsRequired(false);
            entity.HasMany(country => country.AcademicCountry)
                .WithOne(academicYear => academicYear.Country)
                .HasForeignKey(academicYear => academicYear.CountryId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblCurrency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PRIMARY");

            entity.ToTable("tblCurrency");

            entity.Property(e => e.CurrencyId)
                .HasColumnType("int(11)")
                .HasColumnName("CurrencyID");
            entity.Property(e => e.CurrencyCode).HasMaxLength(4);
            entity.Property(e => e.CurrencyCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CurrencyCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.CurrencyIconCode).HasMaxLength(4);
            entity.Property(e => e.CurrencyName).HasMaxLength(100);
            entity.Property(e => e.CurrencySign).HasMaxLength(10);
            entity.Property(e => e.CurrencyUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CurrencyUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(currency => currency.CreatedBy)
                .WithMany(customer => customer.CurrencyCreatedBy)
                .HasForeignKey(currency => currency.CurrencyCreatedBy)
                .IsRequired(false);
            entity.HasOne(currency => currency.UpdatedBy)
                .WithMany(customer => customer.CurrencyUpdatedBy)
                .HasForeignKey(currency => currency.CurrencyUpdatedBy)
                .IsRequired(false);

            entity.HasMany(currency => currency.SchoolPtacurrency)
                .WithOne(school => school.Ptacurrency)
                .HasForeignKey(school => school.SchoolPtacurrencyId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PRIMARY");

            entity.ToTable("tblCustomer");

            entity.HasIndex(e => e.ApplicationId, "ApplicationID");

            entity.HasIndex(e => e.CustomerDeleted, "CustomerDeleted");

            entity.HasIndex(e => e.CustomerEmail, "CustomerEmail");

            entity.HasIndex(e => e.CustomerSchoolId, "CustomerSchoolID");

            entity.HasIndex(e => e.CustomerUuid, "CustomerUUID");

            entity.HasIndex(e => new { e.ApplicationId, e.CustomerSchoolId }, "idx_customerappschool");

            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");
            entity.Property(e => e.ApplicationId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("ApplicationID");
            entity.Property(e => e.CustomerAddress1).HasMaxLength(250);
            entity.Property(e => e.CustomerAddress2).HasMaxLength(250);
            entity.Property(e => e.CustomerApproved)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.CustomerConfirmed)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.CustomerCounty).HasMaxLength(100);
            entity.Property(e => e.CustomerCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CustomerCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.CustomerDbschecked).HasColumnName("CustomerDBSChecked");
            entity.Property(e => e.CustomerEmail).HasMaxLength(250);
            entity.Property(e => e.CustomerErasureDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerFirstName).HasMaxLength(50);
            entity.Property(e => e.CustomerGdprconsentSent).HasColumnName("CustomerGDPRConsentSent");
            entity.Property(e => e.CustomerGeneric1).HasMaxLength(500);
            entity.Property(e => e.CustomerGeneric2).HasMaxLength(500);
            entity.Property(e => e.CustomerGeneric3).HasMaxLength(500);
            entity.Property(e => e.CustomerGiftAidDeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerGoCardlessLiveMandate).HasMaxLength(100);
            entity.Property(e => e.CustomerGoCardlessTestMandate).HasMaxLength(100);
            entity.Property(e => e.CustomerHashId)
                .HasMaxLength(250)
                .HasColumnName("CustomerHashID");
            entity.Property(e => e.CustomerLastLoginAttemptDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerLastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerLastLoginDateTime).HasColumnType("timestamp");
            entity.Property(e => e.CustomerLastName).HasMaxLength(50);
            entity.Property(e => e.CustomerLoginAttempts)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.CustomerMarketingEmails)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.CustomerMobile).HasMaxLength(50);
            entity.Property(e => e.CustomerPartnerId)
                .HasMaxLength(50)
                .HasColumnName("CustomerPartnerID");
            entity.Property(e => e.CustomerPassword).HasMaxLength(250);
            entity.Property(e => e.CustomerPasswordReset).HasMaxLength(100);
            entity.Property(e => e.CustomerPasswordResetDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerPlatformArchiveReminderEmails)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.CustomerPostCode).HasMaxLength(50);
            entity.Property(e => e.CustomerQflowPassword).HasMaxLength(10);
            entity.Property(e => e.CustomerSalt).HasMaxLength(250);
            entity.Property(e => e.CustomerSchoolClass).HasMaxLength(100);
            entity.Property(e => e.CustomerSchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerSchoolID");
            entity.Property(e => e.CustomerStripeLiveId)
                .HasMaxLength(100)
                .HasColumnName("CustomerStripeLiveID");
            entity.Property(e => e.CustomerStripeTestId)
                .HasMaxLength(100)
                .HasColumnName("CustomerStripeTestID");
            entity.Property(e => e.CustomerTelephone).HasMaxLength(50);
            entity.Property(e => e.CustomerTitle).HasMaxLength(50);
            entity.Property(e => e.CustomerTown).HasMaxLength(250);
            entity.Property(e => e.CustomerUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CustomerUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.CustomerUuid)
                .HasMaxLength(100)
                .HasColumnName("CustomerUUID");
            entity.Property(e => e.CustomerVerified)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.LegacyCustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("LegacyCustomerID");
            entity.Property(e => e.Ptaid)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("PTAID");

            entity.HasMany(customer => customer.SchoolsCreated)
                .WithOne(school => school.CreatedBy)
                .HasForeignKey(school => school.SchoolCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.SchoolsDpasigned)
                .WithOne(school => school.DpasignedBy)
                .HasForeignKey(school => school.SchoolDpasignedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.SchoolsPtalotteryLicenceUploadedBy)
                .WithOne(school => school.PtalotteryLicenceUploadedBy)
                .HasForeignKey(school => school.SchoolPtalotteryLicenceUploadedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.SchoolUpdatedBy)
                .WithOne(school => school.UpdatedBy)
                .HasForeignKey(school => school.SchoolUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.SchoolsTermsSignedBy)
                .WithOne(school => school.TermsSignedBy)
                .HasForeignKey(school => school.SchoolTermsSignedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.UpdatedBy)
                .WithOne(customer => customer.UpdatedById)
                .HasForeignKey(customer => customer.CustomerUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CreatedBy)
                .WithOne(customer => customer.CreatedById)
                .HasForeignKey(customer => customer.CustomerCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CustomerRole)
                .WithOne(customerRole => customerRole.Customer)
                .HasForeignKey(customerRole => customerRole.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.CustomerRoleUpdatedBy)
                .WithOne(customerRole => customerRole.UpdatedBy)
                .HasForeignKey(customerRole => customerRole.CustomerRoleUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CustomerRoleCreatedBy)
                .WithOne(customerRole => customerRole.CreatedBy)
                .HasForeignKey(customerRole => customerRole.CustomerRoleCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.RoleUpdatedBy)
                .WithOne(role => role.UpdatedBy)
                .HasForeignKey(role => role.RoleUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.RoleCreatedBy)
                .WithOne(role => role.CreatedBy)
                .HasForeignKey(role => role.RoleCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ApiAuditHistoryCustomer)
                .WithOne(apiAuditHistory => apiAuditHistory.Customer)
                .HasForeignKey(apiAuditHistory => apiAuditHistory.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.ApiAuditHistoryCreatedBy)
                .WithOne(apiAuditHistory => apiAuditHistory.CreatedBy)
                .HasForeignKey(apiAuditHistory => apiAuditHistory.ApiAuditHistoryCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AuctionUpdatedBy)
                .WithOne(auction => auction.UpdatedBy)
                .HasForeignKey(auction => auction.AuctionUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AuctionCreatedBy)
                .WithOne(auction => auction.CreatedBy)
                .HasForeignKey(auction => auction.AuctionCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AuditHistoryTypeUpdatedBy)
                .WithOne(auction => auction.UpdatedBy)
                .HasForeignKey(auction => auction.AuditHistoryTypeUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AuditHistoryTypeCreatedBy)
                .WithOne(auction => auction.CreatedBy)
                .HasForeignKey(auction => auction.AuditHistoryTypeCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BidCustomer)
                .WithOne(bid => bid.Customer)
                .HasForeignKey(bid => bid.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.BidUpdatedBy)
                .WithOne(bid => bid.UpdatedBy)
                .HasForeignKey(bid => bid.BidUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BidCreatedBy)
                .WithOne(bid => bid.CreatedBy)
                .HasForeignKey(bid => bid.BidCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BookingUpdatedBy)
                .WithOne(booking => booking.UpdatedBy)
                .HasForeignKey(booking => booking.BookingUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BookingCreatedBy)
                .WithOne(booking => booking.CreatedBy)
                .HasForeignKey(booking => booking.BookingCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BusinessDirectoryUpdatedBy)
                .WithOne(businessDirectory => businessDirectory.UpdatedBy)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BusinessDirectoryCreatedBy)
                .WithOne(businessDirectory => businessDirectory.CreatedBy)
                .HasForeignKey(businessDirectory => businessDirectory.BusinessDirectoryCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BusinessDirectoryCategoryUpdatedBy)
                .WithOne(businessDirectoryCategory => businessDirectoryCategory.UpdatedBy)
                .HasForeignKey(businessDirectoryCategory => businessDirectoryCategory.BusinessDirectoryCategoryUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BusinessDirectoryCategoryCreatedBy)
                .WithOne(businessDirectoryCategory => businessDirectoryCategory.CreatedBy)
                .HasForeignKey(businessDirectoryCategory => businessDirectoryCategory.BusinessDirectoryCategoryCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BusinessDirectoryClickCustomer)
                .WithOne(businessDirectoryClick => businessDirectoryClick.Customer)
                .HasForeignKey(businessDirectoryClick => businessDirectoryClick.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.ClassRepUpdatedBy)
                .WithOne(classRep => classRep.UpdatedBy)
                .HasForeignKey(classRep => classRep.ClassRepUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ClassRepCreatedBy)
                .WithOne(classRep => classRep.CreatedBy)
                .HasForeignKey(classRep => classRep.ClassRepCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ClassRepCustomer)
                .WithOne(classRep => classRep.Customer)
                .HasForeignKey(classRep => classRep.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.ComponentTypeUpdatedBy)
                .WithOne(componentType => componentType.UpdatedBy)
                .HasForeignKey(componentType => componentType.ComponentTypeUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ComponentTypeCreatedBy)
                .WithOne(componentType => componentType.CreatedBy)
                .HasForeignKey(componentType => componentType.ComponentTypeCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CountryUpdatedBy)
                .WithOne(country => country.UpdatedBy)
                .HasForeignKey(country => country.CountryUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CountryCreatedBy)
                .WithOne(country => country.CreatedBy)
                .HasForeignKey(country => country.CountryCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CurrencyUpdatedBy)
                .WithOne(currency => currency.UpdatedBy)
                .HasForeignKey(currency => currency.CurrencyUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CurrencyCreatedBy)
                .WithOne(currency => currency.CreatedBy)
                .HasForeignKey(currency => currency.CurrencyCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CustomerConsent)
                .WithOne(customerConsent => customerConsent.Customer)
                .HasForeignKey(customerConsent => customerConsent.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.CustomerDevice)
                .WithOne(customerDevice => customerDevice.Customer)
                .HasForeignKey(customerDevice => customerDevice.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.CustomerDeviceUpdatedBy)
                .WithOne(customerDevice => customerDevice.UpdatedBy)
                .HasForeignKey(customerDevice => customerDevice.CustomerDeviceUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.CustomerDeviceCreatedBy)
                .WithOne(customerDevice => customerDevice.CreatedBy)
                .HasForeignKey(customerDevice => customerDevice.CustomerDeviceCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.DependantCustomer)
                .WithOne(dependant => dependant.Customer)
                .HasForeignKey(dependant => dependant.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.DependantApprovedBy)
                .WithOne(dependant => dependant.ApprovedBy)
                .HasForeignKey(dependant => dependant.DependantApprovedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.DependantUpdatedBy)
                .WithOne(dependant => dependant.UpdatedBy)
                .HasForeignKey(dependant => dependant.DependantUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.DependantCreatedBy)
                .WithOne(dependant => dependant.CreatedBy)
                .HasForeignKey(dependant => dependant.DependantCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.DiscountUpdatedBy)
                .WithOne(discount => discount.UpdatedBy)
                .HasForeignKey(discount => discount.DiscountUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.DiscountCreatedBy)
                .WithOne(discount => discount.CreatedBy)
                .HasForeignKey(discount => discount.DiscountCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EmailUpdatedBy)
                .WithOne(email => email.UpdatedBy)
                .HasForeignKey(email => email.EmailUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EmailCreatedBy)
                .WithOne(email => email.CreatedBy)
                .HasForeignKey(email => email.EmailCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser)
                .WithOne(events => events.EventOrganiser)
                .HasForeignKey(events => events.EventOrganiserId)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser2)
                .WithOne(events => events.EventOrganiser2)
                .HasForeignKey(events => events.EventOrganiserId2)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser3)
                .WithOne(events => events.EventOrganiser3)
                .HasForeignKey(events => events.EventOrganiserId3)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser4)
                .WithOne(events => events.EventOrganiser4)
                .HasForeignKey(events => events.EventOrganiserId4)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser5)
                .WithOne(events => events.EventOrganiser5)
                .HasForeignKey(events => events.EventOrganiserId5)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser6)
                .WithOne(events => events.EventOrganiser6)
                .HasForeignKey(events => events.EventOrganiserId6)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser7)
                .WithOne(events => events.EventOrganiser7)
                .HasForeignKey(events => events.EventOrganiserId7)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventOrganiser8)
                .WithOne(events => events.EventOrganiser8)
                .HasForeignKey(events => events.EventOrganiserId8)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventUpdatedBy)
                .WithOne(events => events.UpdatedBy)
                .HasForeignKey(events => events.EventUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventCreatedBy)
                .WithOne(events => events.CreatedBy)
                .HasForeignKey(events => events.EventCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventFileUpdatedBy)
                .WithOne(eventFile => eventFile.UpdatedBy)
                .HasForeignKey(eventFile => eventFile.EventFileUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventFileCreatedBy)
                .WithOne(eventFile => eventFile.CreatedBy)
                .HasForeignKey(eventFile => eventFile.EventFileCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventSponsorUpdatedBy)
                .WithOne(eventSponsor => eventSponsor.UpdatedBy)
                .HasForeignKey(eventSponsor => eventSponsor.EventSponsorUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.EventSponsorCreatedBy)
                .WithOne(eventSponsor => eventSponsor.CreatedBy)
                .HasForeignKey(eventSponsor => eventSponsor.EventSponsorCreatedBy)
                .IsRequired(false);

            entity.HasOne(customer => customer.Application)
                .WithMany(school => school.Application)
                .HasForeignKey(customer => customer.ApplicationId)
                .IsRequired(false);
            entity.HasOne(customer => customer.Hash)
                .WithMany(contentHash => contentHash.CustomerHash)
                .HasForeignKey(customer => customer.CustomerHashId)
                .IsRequired(false);
            entity.HasOne(customer => customer.Partner)
                .WithMany(partner => partner.CustomerPartner)
                .HasForeignKey(customer => customer.CustomerPartnerId)
                .IsRequired(false);
            entity.HasOne(customer => customer.CustomerSchool)
                .WithMany(school => school.CustomerSchool)
                .HasForeignKey(customer => customer.CustomerSchoolId)
                .IsRequired(false);
            entity.HasOne(customer => customer.UpdatedById)
                .WithMany(customer => customer.UpdatedBy)
                .HasForeignKey(school => school.CustomerUpdatedBy)
                .IsRequired(false);
            entity.HasOne(customer => customer.CreatedById)
                .WithMany(customer => customer.CreatedBy)
                .HasForeignKey(customer => customer.CustomerCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AcademicYearUpdatedBy)
                .WithOne(school => school.UpdatedBy)
                .HasForeignKey(school => school.AcademicYearUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AcademicYearCreatedBy)
                .WithOne(academicYear => academicYear.CreatedBy)
                .HasForeignKey(academicYear => academicYear.AcademicYearUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ApiAuditHistoryCustomer)
                .WithOne(apiAuditHistory => apiAuditHistory.Customer)
                .HasForeignKey(apiAuditHistory => apiAuditHistory.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.AuditHistoryUpdatedBy)
                .WithOne(auditHistory => auditHistory.UpdatedBy)
                .HasForeignKey(auditHistory => auditHistory.AuditHistoryUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AuditHistoryCreatedBy)
                .WithOne(auditHistory => auditHistory.CreatedBy)
                .HasForeignKey(auditHistory => auditHistory.AuditHistoryCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.AuditHistoryCustomer)
                .WithOne(auditHistory => auditHistory.Customer)
                .HasForeignKey(auditHistory => auditHistory.CustomerId)
                .IsRequired(false);
            entity.HasMany(customer => customer.BankedBusinessComplianceCompletedBy)
                .WithOne(bankedBusiness => bankedBusiness.ComplianceCompletedBy)
                .HasForeignKey(bankedBusiness => bankedBusiness.BankedBusinessComplianceCompletedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BankedBusinessUpdatedBy)
                .WithOne(bankedBusiness => bankedBusiness.UpdatedBy)
                .HasForeignKey(bankedBusiness => bankedBusiness.BankedBusinessUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BankedBusinessCreatedBy)
                .WithOne(bankedBusiness => bankedBusiness.CreatedBy)
                .HasForeignKey(bankedBusiness => bankedBusiness.BankedBusinessCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BankedBusinessApplicationUpdatedBy)
                .WithOne(bankedBusinessApplication => bankedBusinessApplication.UpdatedBy)
                .HasForeignKey(bankedBusinessApplication => bankedBusinessApplication.BankedBusinessApplicationUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BankedBusinessApplicationCreatedBy)
                .WithOne(bankedBusinessApplication => bankedBusinessApplication.CreatedBy)
                .HasForeignKey(bankedBusinessApplication => bankedBusinessApplication.BankedBusinessApplicationCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BankedBusinessComplianceRuleUpdatedBy)
                .WithOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.UpdatedBy)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusinessComplianceRuleUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.BankedBusinessComplianceRuleCreatedBy)
                .WithOne(bankedBusinessComplianceRule => bankedBusinessComplianceRule.CreatedBy)
                .HasForeignKey(bankedBusinessComplianceRule => bankedBusinessComplianceRule.BankedBusinessComplianceRuleCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ComplianceRuleUpdatedBy)
                .WithOne(complianceRule => complianceRule.UpdatedBy)
                .HasForeignKey(complianceRule => complianceRule.ComplianceRuleUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ComplianceRuleCreatedBy)
                .WithOne(complianceRule => complianceRule.CreatedBy)
                .HasForeignKey(complianceRule => complianceRule.ComplianceRuleCreatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ComponentGroupUpdatedBy)
                .WithOne(componentGroup => componentGroup.UpdatedBy)
                .HasForeignKey(componentGroup => componentGroup.ComponentGroupUpdatedBy)
                .IsRequired(false);
            entity.HasMany(customer => customer.ComponentGroupCreatedBy)
                .WithOne(componentGroup => componentGroup.CreatedBy)
                .HasForeignKey(componentGroup => componentGroup.ComponentGroupCreatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblCustomerConsent>(entity =>
        {
            entity.HasKey(e => e.CustomerConsentId).HasName("PRIMARY");

            entity.ToTable("tblCustomerConsent");

            entity.Property(e => e.CustomerConsentId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerConsentID");
            entity.Property(e => e.ContentHashId)
                .HasColumnType("int(11)")
                .HasColumnName("ContentHashID");
            entity.Property(e => e.CustomerConsentCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.CustomerConsentForeignKey).HasColumnType("int(11)");
            entity.Property(e => e.CustomerConsentName).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");

            entity.HasOne(customerConsent => customerConsent.Customer)
                .WithMany(customer => customer.CustomerConsent)
                .HasForeignKey(customerConsent => customerConsent.CustomerId)
                .IsRequired(false);
            entity.HasOne(customerConsent => customerConsent.ContentHash)
                .WithMany(customerHash => customerHash.CustomerConsentCustomerHash)
                .HasForeignKey(customerConsent => customerConsent.ContentHashId)
                .IsRequired(false);
            entity.HasOne(customerConsent => customerConsent.ForeignKey)
                .WithMany(customerConsent => customerConsent.ForeignKeys)
                .HasForeignKey(customerConsent => customerConsent.CustomerConsentForeignKey)
                .IsRequired(false);

            entity.HasMany(customerConsent => customerConsent.ForeignKeys)
                .WithOne(customerConsent => customerConsent.ForeignKey)
                .HasForeignKey(customerConsent => customerConsent.CustomerConsentForeignKey)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblCustomerDevice>(entity =>
        {
            entity.HasKey(e => e.CustomerDeviceId).HasName("PRIMARY");

            entity.ToTable("tblCustomerDevice");

            entity.HasIndex(e => e.CustomerDeviceName, "CustomerDeviceName");

            entity.HasIndex(e => e.CustomerDeviceUuid, "CustomerDeviceUUID");

            entity.HasIndex(e => e.CustomerId, "CustomerID");

            entity.Property(e => e.CustomerDeviceId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerDeviceID");
            entity.Property(e => e.CustomerDeviceCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CustomerDeviceCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.CustomerDeviceName).HasMaxLength(250);
            entity.Property(e => e.CustomerDeviceUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CustomerDeviceUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.CustomerDeviceUuid)
                .HasMaxLength(50)
                .HasColumnName("CustomerDeviceUUID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");

            entity.HasOne(customerDevice => customerDevice.Customer)
                .WithMany(customer => customer.CustomerDevice)
                .HasForeignKey(customerDevice => customerDevice.CustomerId)
                .IsRequired(false);
            entity.HasOne(customerDevice => customerDevice.CreatedBy)
                .WithMany(customer => customer.CustomerDeviceCreatedBy)
                .HasForeignKey(customerDevice => customerDevice.CustomerDeviceCreatedBy)
                .IsRequired(false);
            entity.HasOne(customerDevice => customerDevice.UpdatedBy)
                .WithMany(customer => customer.CustomerDeviceUpdatedBy)
                .HasForeignKey(customerDevice => customerDevice.CustomerDeviceUpdatedBy)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblCustomerRole>(entity =>
        {
            entity.HasKey(e => e.CustomerRoleId).HasName("PRIMARY");

            entity.ToTable("tblCustomerRole");

            entity.HasIndex(e => e.CustomerId, "CustomerID");

            entity.HasIndex(e => e.RoleId, "RoleID");

            entity.Property(e => e.CustomerRoleId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerRoleID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerRoleCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CustomerRoleCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.CustomerRoleDeleted).HasColumnType("tinyint(4)");
            entity.Property(e => e.CustomerRoleUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.CustomerRoleUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.RoleId)
                .HasColumnType("int(11)")
                .HasColumnName("RoleID");

            entity.HasOne(customerRole => customerRole.Customer)
                .WithMany(customer => customer.CustomerRole)
                .HasForeignKey(customerRole => customerRole.CustomerId)
                .IsRequired(false);
            entity.HasOne(customerRole => customerRole.Role)
                .WithMany(role => role.CustomerRole)
                .HasForeignKey(customerRole => customerRole.RoleId)
                .IsRequired(false);
            entity.HasOne(customerRole => customerRole.CreatedBy)
                .WithMany(customer => customer.CustomerRoleCreatedBy)
                .HasForeignKey(customerRole => customerRole.CustomerRoleCreatedBy)
                .IsRequired(false);
            entity.HasOne(customerRole => customerRole.UpdatedBy)
                .WithMany(customer => customer.CustomerRoleUpdatedBy)
                .HasForeignKey(customerRole => customerRole.CustomerRoleUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblDependant>(entity =>
        {
            entity.HasKey(e => e.DependantId).HasName("PRIMARY");

            entity.ToTable("tblDependant");

            entity.Property(e => e.DependantId)
                .HasColumnType("int(11)")
                .HasColumnName("DependantID");
            entity.Property(e => e.ClassId)
                .HasColumnType("int(11)")
                .HasColumnName("ClassID");
            entity.Property(e => e.CustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("CustomerID");
            entity.Property(e => e.DependantApprovedBy).HasColumnType("int(11)");
            entity.Property(e => e.DependantApprovedDate).HasColumnType("timestamp");
            entity.Property(e => e.DependantCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.DependantCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.DependantFirstName).HasMaxLength(100);
            entity.Property(e => e.DependantGdprconsent).HasColumnName("DependantGDPRConsent");
            entity.Property(e => e.DependantLastName).HasMaxLength(100);
            entity.Property(e => e.DependantUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.DependantUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(dependant => dependant.Customer)
                .WithMany(customer => customer.DependantCustomer)
                .HasForeignKey(dependant => dependant.CustomerId)
                .IsRequired(false);
            entity.HasOne(dependant => dependant.ApprovedBy)
                .WithMany(customer => customer.DependantApprovedBy)
                .HasForeignKey(dependant => dependant.DependantApprovedBy)
                .IsRequired(false);
            entity.HasOne(dependant => dependant.Class)
                .WithMany(classes => classes.DependantClass)
                .HasForeignKey(dependant => dependant.ClassId)
                .IsRequired(false);
            entity.HasOne(dependant => dependant.CreatedBy)
                .WithMany(customer => customer.DependantCreatedBy)
                .HasForeignKey(dependant => dependant.DependantCreatedBy)
                .IsRequired(false);
            entity.HasOne(dependant => dependant.UpdatedBy)
                .WithMany(customer => customer.DependantUpdatedBy)
                .HasForeignKey(dependant => dependant.DependantUpdatedBy)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblDiscount>(entity =>
        {
            entity.HasKey(e => e.DiscountId).HasName("PRIMARY");

            entity
                .ToTable("tblDiscount")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.DiscountId)
                .HasColumnType("int(11)")
                .HasColumnName("DiscountID");
            entity.Property(e => e.DiscountAmount).HasPrecision(10, 2);
            entity.Property(e => e.DiscountCode).HasMaxLength(50);
            entity.Property(e => e.DiscountCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.DiscountCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.DiscountDeleted).HasColumnType("int(11)");
            entity.Property(e => e.DiscountEffectiveQty).HasColumnType("int(11)");
            entity.Property(e => e.DiscountMaxPurchaseQty).HasColumnType("int(11)");
            entity.Property(e => e.DiscountMinPurchaseQty).HasColumnType("int(11)");
            entity.Property(e => e.DiscountName).HasMaxLength(200);
            entity.Property(e => e.DiscountPercentage).HasColumnType("int(11)");
            entity.Property(e => e.DiscountProductIds)
                .HasMaxLength(15000)
                .HasColumnName("DiscountProductIDs");
            entity.Property(e => e.DiscountPurchaseQty).HasColumnType("int(11)");
            entity.Property(e => e.DiscountTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("DiscountTypeID");
            entity.Property(e => e.DiscountUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.DiscountUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.SchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolID");

            entity.HasOne(discount => discount.School)
                .WithMany(school => school.DiscountSchool)
                .HasForeignKey(discount => discount.SchoolId)
                .IsRequired(false);
            entity.HasOne(discount => discount.CreatedBy)
                .WithMany(customer => customer.DiscountCreatedBy)
                .HasForeignKey(discount => discount.DiscountCreatedBy)
                .IsRequired(false);
            entity.HasOne(discount => discount.UpdatedBy)
                .WithMany(customer => customer.DiscountUpdatedBy)
                .HasForeignKey(discount => discount.DiscountUpdatedBy)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblEmail>(entity =>
        {
            entity.HasKey(e => e.EmailId).HasName("PRIMARY");

            entity.ToTable("tblEmail");

            entity.HasIndex(e => e.EmailCreatedBy, "EmailCreatedBy");

            entity.HasIndex(e => e.EmailMailGunId, "EmailMailGunID");

            entity.HasIndex(e => e.EmailTo, "EmailTo");

            entity.HasIndex(e => e.MessageId, "MessageID");

            entity.HasIndex(e => new { e.MessageId, e.EmailTo }, "idx_email_emailto");

            entity.HasIndex(e => new { e.EmailCreatedBy, e.EmailMailGunId }, "spoolIndex");

            entity.Property(e => e.EmailId)
                .HasColumnType("int(11)")
                .HasColumnName("EmailID");
            entity.Property(e => e.EmailAttachment1).HasMaxLength(500);
            entity.Property(e => e.EmailAttachment2).HasMaxLength(500);
            entity.Property(e => e.EmailCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EmailCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EmailFrom).HasMaxLength(250);
            entity.Property(e => e.EmailMailGunId)
                .HasMaxLength(250)
                .HasColumnName("EmailMailGunID");
            entity.Property(e => e.EmailReplyTo).HasMaxLength(250);
            entity.Property(e => e.EmailSubject).HasMaxLength(250);
            entity.Property(e => e.EmailTemplateId)
                .HasColumnType("int(11)")
                .HasColumnName("EmailTemplateID");
            entity.Property(e => e.EmailTo).HasMaxLength(250);
            entity.Property(e => e.EmailUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EmailUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.MessageId)
                .HasColumnType("int(11)")
                .HasColumnName("MessageID");

            entity.HasOne(email => email.Message)
                .WithMany(message => message.EmailMessage)
                .HasForeignKey(email => email.MessageId)
                .IsRequired(false);
            entity.HasOne(email => email.CreatedBy)
                .WithMany(customer => customer.EmailCreatedBy)
                .HasForeignKey(email => email.EmailCreatedBy)
                .IsRequired(false);
            entity.HasOne(email => email.UpdatedBy)
                .WithMany(customer => customer.EmailUpdatedBy)
                .HasForeignKey(email => email.EmailUpdatedBy)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblEmailEvent>(entity =>
        {
            entity.HasKey(e => e.EmailEventId).HasName("PRIMARY");

            entity.ToTable("tblEmailEvent");

            entity.HasIndex(e => e.EmailEventRecipient, "EmailEventRecipient");

            entity.HasIndex(e => e.EmailMailGunId, "EmailMailGunID");

            entity.Property(e => e.EmailEventId)
                .HasColumnType("int(11)")
                .HasColumnName("EmailEventID");
            entity.Property(e => e.EmailEvent).HasMaxLength(50);
            entity.Property(e => e.EmailEventCity).HasMaxLength(255);
            entity.Property(e => e.EmailEventClientName).HasMaxLength(255);
            entity.Property(e => e.EmailEventClientOs)
                .HasMaxLength(255)
                .HasColumnName("EmailEventClientOS");
            entity.Property(e => e.EmailEventClientType).HasMaxLength(255);
            entity.Property(e => e.EmailEventCode).HasMaxLength(1000);
            entity.Property(e => e.EmailEventCountry).HasMaxLength(255);
            entity.Property(e => e.EmailEventDescription).HasMaxLength(2000);
            entity.Property(e => e.EmailEventDeviceType).HasMaxLength(255);
            entity.Property(e => e.EmailEventDomain).HasMaxLength(255);
            entity.Property(e => e.EmailEventError).HasMaxLength(1000);
            entity.Property(e => e.EmailEventIp)
                .HasMaxLength(255)
                .HasColumnName("EmailEventIP");
            entity.Property(e => e.EmailEventMailingList).HasMaxLength(255);
            entity.Property(e => e.EmailEventNotification).HasMaxLength(255);
            entity.Property(e => e.EmailEventReason).HasMaxLength(2000);
            entity.Property(e => e.EmailEventRegion).HasMaxLength(255);
            entity.Property(e => e.EmailEventTimeStamp).HasColumnType("timestamp");
            entity.Property(e => e.EmailEventUrl)
                .HasMaxLength(1000)
                .HasColumnName("EmailEventURL");
            entity.Property(e => e.EmailEventUserAgent).HasMaxLength(500);
            entity.Property(e => e.EmailMailGunId)
                .HasMaxLength(150)
                .HasColumnName("EmailMailGunID");
        });

        modelBuilder.Entity<TblEvent>(entity =>
        {
            entity.HasKey(e => e.EventId).HasName("PRIMARY");

            entity.ToTable("tblEvent");

            entity.HasIndex(e => e.EventDate, "EventDate");

            entity.HasIndex(e => e.EventDeleted, "EventDeleted");

            entity.HasIndex(e => e.EventOrganiserId, "EventOrganiserID");

            entity.HasIndex(e => e.EventTypeId, "EventTypeID");

            entity.HasIndex(e => e.SchoolId, "SchoolID");

            entity.HasIndex(e => new { e.EventSaleEndDate, e.EventSaleStartDate, e.SchoolId }, "idx_event_salesdates");

            entity.Property(e => e.EventId)
                .HasColumnType("int(11)")
                .HasColumnName("EventID");
            entity.Property(e => e.EventBccorderConfirmationEmail).HasColumnName("EventBCCOrderConfirmationEmail");
            entity.Property(e => e.EventBccvolunteerConfirmationEmail).HasColumnName("EventBCCVolunteerConfirmationEmail");
            entity.Property(e => e.EventCarouselImage).HasMaxLength(500);
            entity.Property(e => e.EventCarouselImageText).HasMaxLength(150);
            entity.Property(e => e.EventCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EventDate).HasColumnType("datetime");
            entity.Property(e => e.EventDescription).HasColumnType("text");
            entity.Property(e => e.EventEmailText).HasColumnType("text");
            entity.Property(e => e.EventEndDate).HasColumnType("datetime");
            entity.Property(e => e.EventFeeType)
                .HasMaxLength(15)
                .HasDefaultValueSql("'Voluntary'");
            entity.Property(e => e.EventLastSyncedDate).HasColumnType("datetime");
            entity.Property(e => e.EventLastSyncedDateBoardingPasses).HasColumnType("datetime");
            entity.Property(e => e.EventLastSyncedDateVouchers).HasColumnType("datetime");
            entity.Property(e => e.EventLocation).HasMaxLength(250);
            entity.Property(e => e.EventMaxAttendeesQty).HasColumnType("int(11)");
            entity.Property(e => e.EventName).HasMaxLength(250);
            entity.Property(e => e.EventOrganiserId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID");
            entity.Property(e => e.EventOrganiserId2)
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID2");
            entity.Property(e => e.EventOrganiserId3)
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID3");
            entity.Property(e => e.EventOrganiserId4)
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID4");
            entity.Property(e => e.EventOrganiserId5)
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID5");
            entity.Property(e => e.EventOrganiserId6)
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID6");
            entity.Property(e => e.EventOrganiserId7)
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID7");
            entity.Property(e => e.EventOrganiserId8)
                .HasColumnType("int(11)")
                .HasColumnName("EventOrganiserID8");
            entity.Property(e => e.EventPlatformFeeType)
                .HasMaxLength(15)
                .HasDefaultValueSql("'Voluntary'");
            entity.Property(e => e.EventPostCode).HasMaxLength(20);
            entity.Property(e => e.EventPurgeDataDate).HasColumnType("datetime");
            entity.Property(e => e.EventQflowEventId)
                .HasMaxLength(50)
                .HasColumnName("EventQFlowEventID");
            entity.Property(e => e.EventQflowEventIdboardingPasses)
                .HasMaxLength(50)
                .HasColumnName("EventQFlowEventIDBoardingPasses");
            entity.Property(e => e.EventQflowEventIdvouchers)
                .HasMaxLength(50)
                .HasColumnName("EventQFlowEventIDVouchers");
            entity.Property(e => e.EventSaleEndDate).HasColumnType("datetime");
            entity.Property(e => e.EventSaleStartDate).HasColumnType("datetime");
            entity.Property(e => e.EventSponsoredByLogo).HasMaxLength(100);
            entity.Property(e => e.EventSponsoredByName).HasMaxLength(100);
            entity.Property(e => e.EventSponsoredByUrl)
                .HasMaxLength(100)
                .HasColumnName("EventSponsoredByURL");
            entity.Property(e => e.EventTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("EventTypeID");
            entity.Property(e => e.EventUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.EventUuid)
                .HasMaxLength(100)
                .HasColumnName("EventUUID");
            entity.Property(e => e.LegacyEventId)
                .HasColumnType("int(11)")
                .HasColumnName("LegacyEventID");
            entity.Property(e => e.SchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolID");

            entity.HasOne(events => events.EventOrganiser)
                .WithMany(customer => customer.EventOrganiser)
                .HasForeignKey(events => events.EventOrganiserId)
                .IsRequired(false);
            entity.HasOne(events => events.EventOrganiser2)
                .WithMany(customer => customer.EventOrganiser2)
                .HasForeignKey(events => events.EventOrganiserId2)
                .IsRequired(false);
            entity.HasOne(events => events.EventOrganiser3)
                .WithMany(customer => customer.EventOrganiser3)
                .HasForeignKey(events => events.EventOrganiserId3)
                .IsRequired(false);
            entity.HasOne(events => events.EventOrganiser4)
                .WithMany(customer => customer.EventOrganiser4)
                .HasForeignKey(events => events.EventOrganiserId4)
                .IsRequired(false);
            entity.HasOne(events => events.EventOrganiser5)
                .WithMany(customer => customer.EventOrganiser5)
                .HasForeignKey(events => events.EventOrganiserId5)
                .IsRequired(false);
            entity.HasOne(events => events.EventOrganiser6)
                .WithMany(customer => customer.EventOrganiser6)
                .HasForeignKey(events => events.EventOrganiserId6)
                .IsRequired(false);
            entity.HasOne(events => events.EventOrganiser7)
                .WithMany(customer => customer.EventOrganiser7)
                .HasForeignKey(events => events.EventOrganiserId7)
                .IsRequired(false);
            entity.HasOne(events => events.EventOrganiser8)
                .WithMany(customer => customer.EventOrganiser8)
                .HasForeignKey(events => events.EventOrganiserId8)
                .IsRequired(false);
            entity.HasOne(events => events.EventType)
                .WithMany(eventType => eventType.EventType)
                .HasForeignKey(events => events.EventTypeId)
                .IsRequired(false);
            entity.HasOne(events => events.School)
                .WithMany(school => school.EventSchool)
                .HasForeignKey(events => events.SchoolId)
                .IsRequired(false);
            entity.HasOne(events => events.CreatedBy)
                .WithMany(customer => customer.EventCreatedBy)
                .HasForeignKey(events => events.EventCreatedBy)
                .IsRequired(false);
            entity.HasOne(events => events.UpdatedBy)
                .WithMany(customer => customer.EventUpdatedBy)
                .HasForeignKey(events => events.EventUpdatedBy)
                .IsRequired(false);

            entity.HasMany(events => events.Event)
                .WithOne(auction => auction.Event)
                .HasForeignKey(auction => auction.EventId)
                .IsRequired(false);
            entity.HasMany(events => events.EventFile)
                .WithOne(eventFile => eventFile.Event)
                .HasForeignKey(eventFile => eventFile.EventId)
                .IsRequired(false);
            entity.HasMany(events => events.EventProduct)
                .WithOne(eventProduct => eventProduct.Event)
                .HasForeignKey(eventFile => eventFile.EventId)
    .           IsRequired(false);
            entity.HasMany(events => events.EventSponsor)
                .WithOne(eventSponsor => eventSponsor.Event)
                .HasForeignKey(eventFile => eventFile.EventId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblEventFile>(entity =>
        {
            entity.HasKey(e => e.EventFileId).HasName("PRIMARY");

            entity.ToTable("tblEventFile");

            entity.Property(e => e.EventFileId)
                .HasColumnType("int(11)")
                .HasColumnName("EventFileID");
            entity.Property(e => e.EventFileCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventFileCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EventFileUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventFileUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.EventId)
                .HasColumnType("int(11)")
                .HasColumnName("EventID");
            entity.Property(e => e.FileId)
                .HasColumnType("int(11)")
                .HasColumnName("FileID");

            entity.HasOne(eventFile => eventFile.Event)
                .WithMany(events => events.EventFile)
                .HasForeignKey(eventFile => eventFile.EventId)
                .IsRequired(false);
            entity.HasOne(eventFile => eventFile.File)
                .WithMany(file => file.EventFile)
                .HasForeignKey(eventFile => eventFile.FileId)
                .IsRequired(false);
            entity.HasOne(eventFile => eventFile.CreatedBy)
                .WithMany(customer => customer.EventFileCreatedBy)
                .HasForeignKey(eventFile => eventFile.EventFileCreatedBy)
                .IsRequired(false);
            entity.HasOne(eventFile => eventFile.UpdatedBy)
                .WithMany(customer => customer.EventFileUpdatedBy)
                .HasForeignKey(eventFile => eventFile.EventFileUpdatedBy)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblEventProduct>(entity =>
        {
            entity.HasKey(e => e.EventProductId).HasName("PRIMARY");

            entity.ToTable("tblEventProduct");

            entity.HasIndex(e => e.EventId, "EventID");

            entity.HasIndex(e => e.ProductId, "ProductID");

            entity.Property(e => e.EventProductId)
                .HasColumnType("int(11)")
                .HasColumnName("EventProductID");
            entity.Property(e => e.EventId)
                .HasColumnType("int(11)")
                .HasColumnName("EventID");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductID");

            entity.HasOne(eventProduct => eventProduct.Event)
                .WithMany(events => events.EventProduct)
                .HasForeignKey(eventProduct => eventProduct.EventId)
                .IsRequired(false);
            entity.HasOne(eventProduct => eventProduct.Product)
                .WithMany(events => events.EventProduct)
                .HasForeignKey(eventProduct => eventProduct.ProductId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblEventSponsor>(entity =>
        {
            entity.HasKey(e => e.EventSponsorId).HasName("PRIMARY");

            entity.ToTable("tblEventSponsor");

            entity.Property(e => e.EventSponsorId)
                .HasColumnType("int(11)")
                .HasColumnName("EventSponsorID");
            entity.Property(e => e.EventId)
                .HasColumnType("int(11)")
                .HasColumnName("EventID");
            entity.Property(e => e.EventSponsorCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventSponsorCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EventSponsorUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventSponsorUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.SponsorId)
                .HasColumnType("int(11)")
                .HasColumnName("SponsorID");

            entity.HasOne(eventSponsor => eventSponsor.Event)
                .WithMany(events => events.EventSponsor)
                .HasForeignKey(eventSponsor => eventSponsor.EventId)
                .IsRequired(false);
            entity.HasOne(eventSponsor => eventSponsor.Sponsor)
                .WithMany(sponsor => sponsor.EventSponsor)
                .HasForeignKey(eventSponsor => eventSponsor.SponsorId)
                .IsRequired(false);
            entity.HasOne(eventSponsor => eventSponsor.CreatedBy)
                .WithMany(customer => customer.EventSponsorCreatedBy)
                .HasForeignKey(eventSponsor => eventSponsor.EventSponsorCreatedBy)
                .IsRequired(false);
            entity.HasOne(eventSponsor => eventSponsor.UpdatedBy)
                .WithMany(customer => customer.EventSponsorUpdatedBy)
                .HasForeignKey(eventSponsor => eventSponsor.EventSponsorUpdatedBy)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblEventTask>(entity =>
        {
            entity.HasKey(e => e.EventTaskId).HasName("PRIMARY");

            entity.ToTable("tblEventTask");

            //entity.HasIndex(e => e.EventId, "EventID");

            //entity.HasIndex(e => e.EventTaskGroupId, "EventTaskGroupID");

            entity.HasIndex(e => e.EventTaskRequiredByDate, "EventTaskRequiredByDate");

            entity.Property(e => e.EventTaskId)
                .HasColumnType("int(11)")
                .HasColumnName("EventTaskID");
            //entity.Property(e => e.EventId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventID");
            //entity.Property(e => e.EventTaskCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskCreatedByDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EventTaskDescription).HasColumnType("text");
            entity.Property(e => e.EventTaskFinishDate).HasColumnType("timestamp");
            //entity.Property(e => e.EventTaskGroupId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventTaskGroupID");
            entity.Property(e => e.EventTaskHelpersRequiredQty).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskMessage).HasColumnType("text");
            entity.Property(e => e.EventTaskName).HasMaxLength(100);
            //entity.Property(e => e.EventTaskOrganiserId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventTaskOrganiserID");
            //entity.Property(e => e.EventTaskOrganiserId2)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventTaskOrganiserID2");
            //entity.Property(e => e.EventTaskOrganiserId3)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventTaskOrganiserID3");
            //entity.Property(e => e.EventTaskOrganiserId4)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventTaskOrganiserID4");
            entity.Property(e => e.EventTaskRequiredByDate).HasColumnType("timestamp");
            entity.Property(e => e.EventTaskSortOrder).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskStartDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp");
            //entity.Property(e => e.EventTaskUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.Event)
                .WithMany()
                ////.HasForeignKey(d => d.Event)

                .HasConstraintName("FK_tblEventTask_tblEvent");

            entity.HasOne(d => d.EventTaskGroup)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskGroup)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTask_tblEventTaskGroup");

            entity.HasOne(d => d.EventTaskOrganiser)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskOrganiser)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTask.EventTaskOrganiser_tblCustomer");

            entity.HasOne(d => d.EventTaskOrganiser2)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskOrganiser2)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTask.EventTaskOrganiser2_tblCustomer");

            entity.HasOne(d => d.EventTaskOrganiser3)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskOrganiser3)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTask.EventTaskOrganiser3_tblCustomer");

            entity.HasOne(d => d.EventTaskOrganiser4)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskOrganiser4)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTask.EventTaskOrganiser4_tblCustomer");

            entity.HasOne(d => d.EventTaskCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskCreatedBy)

                .HasConstraintName("FK_tblEventTask.CreatedBy_tblCustomer");

            entity.HasOne(d => d.EventTaskUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTask.UpdatedBy_tblCustomer");





        });

        modelBuilder.Entity<TblEventTaskCustomer>(entity =>
        {
            entity.HasKey(e => e.EventTaskCustomerId).HasName("PRIMARY");

            entity.ToTable("tblEventTaskCustomer");

            //entity.HasIndex(e => e.EventTaskId, "EventTaskID");

            entity.Property(e => e.EventTaskCustomerId)
                .HasColumnType("int(11)")
                .HasColumnName("EventTaskCustomerID");
            //entity.Property(e => e.CustomerId)
            //.HasColumnType("int(11)")
            //.HasColumnName("CustomerID");
            //entity.Property(e => e.EventTaskCustomerCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskCustomerCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EventTaskCustomerDbschecked).HasColumnName("EventTaskCustomerDBSChecked");
            entity.Property(e => e.EventTaskCustomerEmail).HasMaxLength(250);
            entity.Property(e => e.EventTaskCustomerFirstName).HasMaxLength(100);
            entity.Property(e => e.EventTaskCustomerLastName).HasMaxLength(100);
            entity.Property(e => e.EventTaskCustomerMessage).HasMaxLength(2500);
            entity.Property(e => e.EventTaskCustomerTelephone).HasMaxLength(100);
            //entity.Property(e => e.EventTaskCustomerUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskCustomerUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.EventTaskId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventTaskID");

            entity.HasOne(d => d.EventTask)
                .WithMany()
                ////.HasForeignKey(d => d.EventTask)                
                .HasConstraintName("FK_tblEventTaskCustomer_tblEventTask");

            entity.HasOne(d => d.Customer)
                .WithMany()
                ////.HasForeignKey(d => d.Customer)               
                .HasConstraintName("FK_tblEventTaskCustomer_tblCustomer");

            //entity.HasOne(d => d.EventTaskCustomerCreatedBy)
            //    .WithMany()
            //    ////.HasForeignKey(d => d.EventTaskCustomerCreatedBy)
            //    .HasConstraintName("FK_tblEventTaskCustomer.CreatedBy_tblCustomer");

            entity.HasOne(d => d.EventTaskCustomerUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskCustomerUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTaskCustomer.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblEventTaskGroup>(entity =>
        {
            entity.HasKey(e => e.EventTaskGroupId).HasName("PRIMARY");

            entity.ToTable("tblEventTaskGroup");

            entity.Property(e => e.EventTaskGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("EventTaskGroupID");
            //entity.Property(e => e.EventId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventID");
            //entity.Property(e => e.EventTaskGroupCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskGroupCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EventTaskGroupName).HasMaxLength(100);
            //entity.Property(e => e.EventTaskGroupOrganiserId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventTaskGroupOrganiserID");
            //entity.Property(e => e.EventTaskGroupRepsSchoolYearId)
            //    .HasMaxLength(250)
            //    .HasColumnName("EventTaskGroupRepsSchoolYearID");
            entity.Property(e => e.EventTaskGroupSortOrder).HasColumnType("int(11)");
            //entity.Property(e => e.EventTaskGroupUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTaskGroupUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.Event)
                .WithMany()
                ////.HasForeignKey(d => d.Event)

                .HasConstraintName("FK_tblEventTaskGroup_tblEvent");

            entity.HasOne(d => d.EventTaskGroupOrganiser)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskGroupOrganiser)

                .HasConstraintName("FK_tblEventTaskGroup_tblCustomer");

            entity.HasOne(d => d.EventTaskGroupRepsSchoolYear)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskGroupRepsSchoolYear)
                .HasConstraintName("FK_tblEventTaskGroup_tblSchoolYear");

            entity.HasOne(d => d.EventTaskGroupCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskGroupCreatedBy)

                .HasConstraintName("FK_tblEventTaskGroup.CreatedBy_tblCustomer");

            entity.HasOne(d => d.EventTaskGroupUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.EventTaskGroupUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventTaskGroup.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblEventType>(entity =>
        {
            entity.HasKey(e => e.EventTypeId).HasName("PRIMARY");

            entity.ToTable("tblEventType");

            entity.Property(e => e.EventTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("EventTypeID");
            //entity.Property(e => e.EventTypeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTypeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.EventTypeName).HasMaxLength(50);
            //entity.Property(e => e.EventTypeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.EventTypeUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.EventTypeCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.EventTypeCreatedBy)

                .HasConstraintName("FK_tblEventType.CreatedBy_tblCustomer");

            entity.HasOne(d => d.EventTypeUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.EventTypeUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblEventType.UpdatedBy_tblCustomer");


            entity.HasMany(eventType => eventType.EventType)
                .WithOne(events => events.EventType)
                .HasForeignKey(events => events.EventTypeId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblException>(entity =>
        {
            entity.HasKey(e => e.ExceptionId).HasName("PRIMARY");

            entity.ToTable("tblException");

            entity.HasIndex(e => e.ExceptionApplication, "ExceptionApplication");

            entity.Property(e => e.ExceptionId)
                .HasColumnType("int(11)")
                .HasColumnName("ExceptionID");
            entity.Property(e => e.ExceptionApplication).HasMaxLength(150);
            entity.Property(e => e.ExceptionCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ExceptionDetail).HasMaxLength(2000);
            entity.Property(e => e.ExceptionEvent).HasMaxLength(100);
            entity.Property(e => e.ExceptionForm).HasColumnType("mediumtext");
            entity.Property(e => e.ExceptionIpaddress)
                .HasMaxLength(100)
                .HasColumnName("ExceptionIPAddress");
            entity.Property(e => e.ExceptionMachineName).HasMaxLength(100);
            entity.Property(e => e.ExceptionMessage).HasMaxLength(1000);
            entity.Property(e => e.ExceptionQueryString).HasMaxLength(500);
            entity.Property(e => e.ExceptionStackTrace).HasColumnType("mediumtext");
            entity.Property(e => e.ExceptionTagContext).HasColumnType("mediumtext");
            entity.Property(e => e.ExceptionTypeId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("ExceptionTypeID");
        });

        modelBuilder.Entity<TblFaq>(entity =>
        {
            entity.HasKey(e => e.FaqId).HasName("PRIMARY");

            entity.ToTable("tblFAQ");

            entity.Property(e => e.FaqId)
                .HasColumnType("int(11)")
                .HasColumnName("FAQID");
            //entity.Property(e => e.FaqcreatedBy)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("FAQCreatedBy");
            entity.Property(e => e.FaqCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("FAQCreatedDate");
            entity.Property(e => e.FaqDeleted).HasColumnName("FAQDeleted");
            entity.Property(e => e.FaqEndDate)
                .HasColumnType("datetime")
                .HasColumnName("FAQEndDate");
            entity.Property(e => e.FaqSortOrder)
                .HasColumnType("int(11)")
                .HasColumnName("FAQSortOrder");
            entity.Property(e => e.FaqStartDate)
                .HasColumnType("datetime")
                .HasColumnName("FAQStartDate");
            entity.Property(e => e.FaqText)
                .HasColumnType("text")
                .HasColumnName("FAQText");
            entity.Property(e => e.FaqTitle)
                .HasMaxLength(200)
                .HasColumnName("FAQTitle");
            //entity.Property(e => e.FaqUpdatedBy)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("FAQUpdatedBy");
            entity.Property(e => e.FaqUpdatedDate)
                .HasColumnType("timestamp")
                .HasColumnName("FAQUpdatedDate");
            //entity.Property(e => e.School
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");

            entity.HasOne(d => d.School)
                 .WithMany()
                 ////.HasForeignKey(d => d.School)     
                 .HasConstraintName("FK_tblFaq_tblSchool");

            entity.HasOne(d => d.FaqCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FaqCreatedBy)

                .HasConstraintName("FK_tblFaq.CreatedBy_tblCustomer");

            entity.HasOne(d => d.FaqUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FaqUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblFaq.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblFile>(entity =>
        {
            entity.HasKey(e => e.FileId).HasName("PRIMARY");

            entity.ToTable("tblFile");

            entity.HasIndex(e => e.FileDeleted, "FileDeleted");

            //entity.HasIndex(e => e.SchoolId, "SchoolID");

            entity.Property(e => e.FileId)
                .HasColumnType("int(11)")
                .HasColumnName("FileID");
            //entity.Property(e => e.FileCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.FileCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.FileDescription).HasMaxLength(500);
            entity.Property(e => e.FileName).HasMaxLength(100);
            //entity.Property(e => e.FileTypeId)
            //    .HasDefaultValueSql("'1'")
            //    .HasColumnType("int(11)")
            //    .HasColumnName("FileTypeID");
            //entity.Property(e => e.FileUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.FileUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");

            entity.HasOne(d => d.FileType)
                .WithMany()
                ////.HasForeignKey(d => d.FileType)
                .HasConstraintName("FK_tblFile>_tblFileType");

            entity.HasOne(d => d.School)
                .WithMany()
                ////.HasForeignKey(d => d.School)
                .HasConstraintName("FK_tblFile>_tblSchool");

            entity.HasOne(d => d.FileCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FileCreatedBy)
                .HasConstraintName("FK_tblFile.CreatedBy_tblCustomer");

            entity.HasOne(d => d.FileUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FileUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblFile.UpdatedBy_tblCustomer");


            entity.HasMany(file => file.EventFile)
                .WithOne(events => events.File)
                .HasForeignKey(events => events.FileId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblFileRole>(entity =>
        {
            entity.HasKey(e => e.FileRoleId).HasName("PRIMARY");

            entity.ToTable("tblFileRole");

            entity.Property(e => e.FileRoleId)
                .HasColumnType("int(11)")
                .HasColumnName("FileRoleID");
            //entity.Property(e => e.FileId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("FileID");
            //entity.Property(e => e.FileRoleCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.FileRoleCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            //entity.Property(e => e.FileRoleUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.FileRoleUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.RoleId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("RoleID");

            entity.HasOne(d => d.File)
                .WithMany()
                ////.HasForeignKey(d => d.File)

                .HasConstraintName("FK_tblFileRole_tblFile");

            entity.HasOne(d => d.Role)
                .WithMany()
                ////.HasForeignKey(d => d.Role)

                .HasConstraintName("FK_tblFileRole_tblRole");

            entity.HasOne(d => d.FileRoleCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FileRoleCreatedBy)
                .HasConstraintName("FK_tblFileRole.CreatedBy_tblCustomer");

            entity.HasOne(d => d.FileRoleUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FileRoleUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblFileRole.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblFileType>(entity =>
        {
            entity.HasKey(e => e.FileTypeId).HasName("PRIMARY");

            entity.ToTable("tblFileType");

            entity.Property(e => e.FileTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("FileTypeID");
            //entity.Property(e => e.FileTypeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.FileTypeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.FileTypeExtension).HasMaxLength(200);
            entity.Property(e => e.FileTypeIcon).HasMaxLength(20);
            entity.Property(e => e.FileTypeMimeType).HasMaxLength(200);
            entity.Property(e => e.FileTypeName).HasMaxLength(100);
            //entity.Property(e => e.FileTypeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.FileTypeUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.FileTypeCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FileTypeCreatedBy)

                .HasConstraintName("FK_tblFileType.CreatedBy_tblCustomer");

            entity.HasOne(d => d.FileTypeUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.FileTypeUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblFileType.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblIplookUp>(entity =>
        {
            entity.HasKey(e => e.IplookUpId).HasName("PRIMARY");

            entity.ToTable("tblIPLookUp");

            entity.HasIndex(e => e.IplookUpBlocked, "IPLookUpBlocked");

            entity.HasIndex(e => e.IplookUpIpaddress, "IPLookUpIPAddress");

            entity.HasIndex(e => e.IplookUpWhiteListed, "IPLookUpWhiteListed");

            entity.HasIndex(e => new { e.IplookUpId, e.IplookUpIpaddress }, "idx_ipaddress").IsUnique();

            entity.Property(e => e.IplookUpId)
                .HasColumnType("int(11)")
                .HasColumnName("IPLookUpID");
            entity.Property(e => e.IplookUpBlocked).HasColumnName("IPLookUpBlocked");
            entity.Property(e => e.IplookUpCity)
                .HasMaxLength(200)
                .HasColumnName("IPLookUpCity");
            entity.Property(e => e.IplookUpCountryCode)
                .HasMaxLength(5)
                .HasColumnName("IPLookUpCountryCode");
            entity.Property(e => e.IplookUpCountryName)
                .HasMaxLength(200)
                .HasColumnName("IPLookUpCountryName");
            entity.Property(e => e.IplookUpCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("IPLookUpCreatedDate");
            entity.Property(e => e.IplookUpIpaddress)
                .HasMaxLength(100)
                .HasColumnName("IPLookUpIPAddress");
            entity.Property(e => e.IplookUpLatitude)
                .HasMaxLength(100)
                .HasColumnName("IPLookUpLatitude");
            entity.Property(e => e.IplookUpLongitude)
                .HasMaxLength(100)
                .HasColumnName("IPLookUpLongitude");
            entity.Property(e => e.IplookUpRegionCode)
                .HasMaxLength(200)
                .HasColumnName("IPLookUpRegionCode");
            entity.Property(e => e.IplookUpRegionName)
                .HasMaxLength(200)
                .HasColumnName("IPLookUpRegionName");
            entity.Property(e => e.IplookUpTimeZone)
                .HasMaxLength(200)
                .HasColumnName("IPLookUpTimeZone");
            entity.Property(e => e.IplookUpUpdatedDate)
                .HasColumnType("timestamp")
                .HasColumnName("IPLookUpUpdatedDate");
            entity.Property(e => e.IplookUpWhiteListed).HasColumnName("IPLookUpWhiteListed");
            entity.Property(e => e.IplookUpZipCode)
                .HasMaxLength(100)
                .HasColumnName("IPLookUpZipCode");
        });

        modelBuilder.Entity<TblLanguage>(entity =>
        {
            entity.HasKey(e => e.LanguageId).HasName("PRIMARY");

            entity.ToTable("tblLanguage");

            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("LanguageID");
            entity.Property(e => e.LanguageCode).HasMaxLength(4);
            //entity.Property(e => e.LanguageCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.LanguageCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.LanguageName).HasMaxLength(100);
            //entity.Property(e => e.LanguageUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.LanguageUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.LanguageCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.LanguageCreatedBy)

                .HasConstraintName("FK_tblLanguage.CreatedBy_tblCustomer");

            entity.HasOne(d => d.LanguageUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.LanguageUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblLanguage.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblLocalAuthority>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblLocalAuthority")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.Code).HasMaxLength(3);
            entity.Property(e => e.LocalAuthority).HasMaxLength(55);
            entity.Property(e => e.Region).HasMaxLength(20);
        });

        modelBuilder.Entity<TblMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PRIMARY");

            entity.ToTable("tblMessage");

            //entity.HasIndex(e => e.Customer, "Customer");

            entity.HasIndex(e => e.MessageCreatedDate, "MessageCreatedDate");

            entity.HasIndex(e => e.MessageMailGunId, "MessageMailGunID");

            entity.HasIndex(e => e.MessageTypeId, "MessageTypeID");

            //entity.HasIndex(e => new { e.Customer, e.MessageTypeId, e.MessageCreatedDate }, "idx_message_customermessagetype");

            //entity.HasIndex(e => new { e.MessageTypeId, e.Customer, e.MessageMailGunId, e.MessageCreatedDate }, "idx_message_email_tracker");

            entity.Property(e => e.MessageId)
                .HasColumnType("int(11)")
                .HasColumnName("MessageID");
            //entity.Property(e => e.Customer)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("CustomerD");
            entity.Property(e => e.MessageAttachment1).HasMaxLength(500);
            entity.Property(e => e.MessageAttachment2).HasMaxLength(500);
            //entity.Property(e => e.MessageCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.MessageCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.MessageCustomerEmail).HasMaxLength(250);
            entity.Property(e => e.MessageCustomerName).HasMaxLength(250);
            //entity.Property(e => e.MessageGroup)
            //.HasColumnType("int(11)")
            //.HasColumnName("MessageGroup");
            entity.Property(e => e.MessageMailGunId)
                .HasMaxLength(250)
                .HasColumnName("MessageMailGunID");
            entity.Property(e => e.MessageTeaser)
                .HasMaxLength(297)
                .HasDefaultValueSql("''");
            entity.Property(e => e.MessageText).HasColumnType("text");
            entity.Property(e => e.MessageTitle).HasMaxLength(200);
            entity.Property(e => e.MessageTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("MessageTypeID");
            //entity.Property(e => e.MessageUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.MessageUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.Customer)
                .WithMany()
                ////.HasForeignKey(d => d.Customer)

                .HasConstraintName("FK_tblMessage_tblCustomer");

            entity.HasOne(d => d.MessageGroup)
                .WithMany()
                ////.HasForeignKey(d => d.MessageGroup)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblMessage_tblMessageGroup");

            entity.HasOne(d => d.MessageCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.MessageCreatedBy)

                .HasConstraintName("FK_tblMessage.CreatedBy_tblCustomer");

            entity.HasOne(d => d.MessageUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.MessageUpdatedBy)
                .HasConstraintName("FK_tblMessage.UpdatedBy_tblCustomer");


            entity.HasMany(message => message.EmailMessage)
                .WithOne(email => email.Message)
                .HasForeignKey(email => email.MessageId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblMessageGroup>(entity =>
        {
            entity.HasKey(e => e.MessageGroupId).HasName("PRIMARY");

            entity.ToTable("tblMessageGroup");

            //entity.HasIndex(e => e.MessageGroupCreatedBy, "MessageGroupCreatedBy");

            entity.Property(e => e.MessageGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("MessageGroupID");
            //entity.Property(e => e.ClassId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ClassID");
            //entity.Property(e => e.EventId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventID");
            //entity.Property(e => e.MessageGroupCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.MessageGroupCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.MessageGroupType).HasMaxLength(50);

            entity.HasOne(d => d.Class)
                .WithMany()
                ////.HasForeignKey(d => d.Class)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblMessageGroup_tblClass");

            entity.HasOne(d => d.Event)
                .WithMany()
                ////.HasForeignKey(d => d.Event)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblMessageGroup_tblEvent");

            entity.HasOne(d => d.MessageGroupCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.MessageGroupCreatedBy)
                .HasConstraintName("FK_tblMessageGroup.CreatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblMessageStatus>(entity =>
        {
            entity.HasKey(e => e.MessageStatusId).HasName("PRIMARY");

            entity.ToTable("tblMessageStatus");

            entity.Property(e => e.MessageStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("MessageStatusID");
            entity.Property(e => e.MessageStatus).HasMaxLength(200);
            //entity.Property(e => e.MessageStatusCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.MessageStatusCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            //entity.Property(e => e.MessageStatusUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.MessageStatusUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.MessageStatusCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.MessageStatusCreatedBy)

                .HasConstraintName("FK_tblMessageStatus.CreatedBy_tblCustomer");

            entity.HasOne(d => d.MessageStatusUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.MessageStatusUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblMessageStatus.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblMessageType>(entity =>
        {
            entity.HasKey(e => e.MessageTypeId).HasName("PRIMARY");

            entity.ToTable("tblMessageType");

            entity.Property(e => e.MessageTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("MessageTypeID");
            //entity.Property(e => e.MessageTypeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.MessageTypeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.MessageTypeName).HasMaxLength(50);
            //entity.Property(e => e.MessageTypeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.MessageTypeUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.MessageTypeCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.MessageTypeCreatedBy)

                .HasConstraintName("FK_tblMessageType.CreatedBy_tblCustomer");

            entity.HasOne(d => d.MessageTypeUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.MessageTypeUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblMessageType.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblNews>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("PRIMARY");

            entity.ToTable("tblNews");

            entity.Property(e => e.NewsId)
                .HasColumnType("int(11)")
                .HasColumnName("NewsID");
            //entity.Property(e => e.NewsCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.NewsCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.NewsEndDate).HasColumnType("datetime");
            entity.Property(e => e.NewsImage).HasMaxLength(250);
            entity.Property(e => e.NewsShowTime)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.NewsStartDate).HasColumnType("datetime");
            entity.Property(e => e.NewsTeaser).HasMaxLength(250);
            entity.Property(e => e.NewsText).HasColumnType("text");
            entity.Property(e => e.NewsTitle).HasMaxLength(100);
            //entity.Property(e => e.NewsUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.NewsUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");

            entity.HasOne(d => d.School)
                .WithMany()
                ////.HasForeignKey(d => d.School)

                .HasConstraintName("FK_tblNews_tblSchool");

            entity.HasOne(d => d.NewsCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.NewsCreatedBy)

                .HasConstraintName("FK_tblNews.CreatedBy_tblCustomer");

            entity.HasOne(d => d.NewsUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.NewsUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblNews.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PRIMARY");

            entity.ToTable("tblOrder");

            //entity.HasIndex(e => e.CustomerId, "CustomerID");

            entity.HasIndex(e => e.OrderCompletedDate, "OrderCompletedDate");

            entity.HasIndex(e => e.OrderDeleted, "OrderDeleted");

            entity.HasIndex(e => e.OrderPaymentIntent, "OrderPaymentIntent");

            entity.HasIndex(e => e.OrderPaymentIntention, "OrderPaymentIntention");

            entity.HasIndex(e => e.OrderRefunded, "OrderRefunded");

            entity.HasIndex(e => e.OrderTest, "OrderTest");

            //entity.HasIndex(e => e.OrderTransactionId, "OrderTransactionID");

            entity.HasIndex(e => e.OrderUuid, "OrderUUID");

            //entity.HasIndex(e => new { e.OrderTransactionId, e.OrderCompleted, e.OrderTest, e.OrderDeleted, e.OrderCompletedDate }, "idx_orders");

            entity.Property(e => e.OrderId)
                .HasColumnType("int(11)")
                .HasColumnName("OrderID");
            //entity.Property(e => e.CustomerId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("CustomerID");
            entity.Property(e => e.LegacyOrderId)
                .HasColumnType("int(11)")
                .HasColumnName("LegacyOrderID");
            entity.Property(e => e.OrderCompletedDate).HasColumnType("timestamp");
            entity.Property(e => e.OrderConfirmationEmail).HasMaxLength(250);
            entity.Property(e => e.OrderConfirmationName).HasMaxLength(250);
            //entity.Property(e => e.OrderCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.OrderCreatedDate).HasColumnType("timestamp");
            entity.Property(e => e.OrderDate).HasColumnType("timestamp");
            entity.Property(e => e.OrderPaymentIntent).HasMaxLength(50);
            entity.Property(e => e.OrderPaymentIntention).HasMaxLength(50);
            entity.Property(e => e.OrderReference).HasMaxLength(15);
            entity.Property(e => e.OrderReserved)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.OrderReservedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            //entity.Property(e => e.OrderTransactionId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("OrderTransactionID");
            //entity.Property(e => e.OrderTransactionType).HasMaxLength(50);
            //entity.Property(e => e.OrderTypeId)
            //    .HasDefaultValueSql("'1'")
            //    .HasColumnType("int(11)")
            //    .HasColumnName("OrderTypeID");
            //entity.Property(e => e.OrderUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.OrderUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.OrderUuid)
                .HasMaxLength(50)
                .HasColumnName("OrderUUID");
            entity.Property(e => e.OrderValue).HasPrecision(10, 2);

            entity.HasOne(d => d.Customer)
                .WithMany()
                ////.HasForeignKey(d => d.Customer)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblOrder_tblCustomer");

            entity.HasOne(d => d.OrderTransaction)
                .WithMany()
                ////.HasForeignKey(d => d.OrderTransaction)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblOrder.OrderTransaction_tblCustomer");

            entity.HasOne(d => d.OrderType)
                .WithMany()
                ////.HasForeignKey(d => d.OrderType)
                .HasConstraintName("FK_tblOrder.OrderType_tblCustomer");

            entity.HasOne(d => d.OrderCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.OrderCreatedBy)

                .HasConstraintName("FK_tblOrder.CreatedBy_tblCustomer");

            entity.HasOne(d => d.OrderUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.OrderUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblOrder.UpdatedBy_tblCustomer");


            entity.HasMany(order => order.BankedWebHookOrder)
                .WithOne(bankedWebHook => bankedWebHook.Order)
                .HasForeignKey(bankedWebHook => bankedWebHook.OrderId)
                .IsRequired(false);


        });

        modelBuilder.Entity<TblOrderItem>(entity =>
        {
            entity.HasKey(e => e.OrderItemId).HasName("PRIMARY");

            entity.ToTable("tblOrderItem");

            //entity.HasIndex(e => e.ItemId, "ItemID");

            //entity.HasIndex(e => e.OrderId, "OrderID");

            entity.HasIndex(e => e.OrderItemCompleted, "OrderItemCompleted");

            entity.HasIndex(e => e.OrderItemDeleted, "OrderItemDeleted");

            entity.Property(e => e.OrderItemId)
                .HasColumnType("int(11)")
                .HasColumnName("OrderItemID");
            //entity.Property(e => e.ItemId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ItemID");
            entity.Property(e => e.LegacyOrderItemId)
                .HasColumnType("int(11)")
                .HasColumnName("LegacyOrderItemID");
            //entity.Property(e => e.OrderId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("OrderID");
            //entity.Property(e => e.OrderItemCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.OrderItemCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.OrderItemDespatched)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.OrderItemLinePrice).HasPrecision(10, 2);
            entity.Property(e => e.OrderItemName).HasMaxLength(250);
            entity.Property(e => e.OrderItemPrice).HasPrecision(10, 2);
            entity.Property(e => e.OrderItemQty).HasColumnType("int(11)");
            entity.Property(e => e.OrderItemRefundQty).HasColumnType("int(11)");
            entity.Property(e => e.OrderItemRefundValue).HasPrecision(10, 2);
            entity.Property(e => e.OrderItemReserved)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.OrderItemReservedDate).HasColumnType("timestamp");
            //entity.Property(e => e.OrderItemUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.OrderItemUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.ProductPaymentSchemeId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductPaymentSchemeID");

            entity.HasOne(d => d.Item)
                .WithMany()
                ////.HasForeignKey(d => d.Item)

                .HasConstraintName("FK_tblOrderItem.Item_tblCustomer");

            entity.HasOne(d => d.Order)
                .WithMany()
                ////.HasForeignKey(d => d.Order)

                .HasConstraintName("FK_tblOrderItem.Order_tblCustomer");

            entity.HasOne(d => d.ProductPaymentScheme)
                .WithMany()
                ////.HasForeignKey(d => d.ProductPaymentScheme)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblOrderItem.ProductPaymentScheme_tblCustomer");

            entity.HasOne(d => d.OrderItemCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.OrderItemCreatedBy)

                .HasConstraintName("FK_tblOrderItem.CreatedBy_tblCustomer");

            entity.HasOne(d => d.OrderItemUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.OrderItemUpdatedBy)

                .HasConstraintName("FK_tblOrderItem.UpdatedBy_tblCustomer");


            entity.HasMany(orderItem => orderItem.BookingOrderItem)
                .WithOne(booking => booking.OrderItem)
                .HasForeignKey(booking => booking.OrderItemId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblOrganisationType>(entity =>
        {
            entity.HasKey(e => e.OrganisationTypeId).HasName("PRIMARY");

            entity.ToTable("tblOrganisationType");

            entity.Property(e => e.OrganisationTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("OrganisationTypeID");
            //entity.Property(e => e.OrganisationTypeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.OrganisationTypeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.OrganisationTypeIcon)
                .HasMaxLength(50)
                .HasDefaultValueSql("'users'");
            entity.Property(e => e.OrganisationTypeMemberLabel)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Your PTA'");
            entity.Property(e => e.OrganisationTypeName).HasMaxLength(50);
            //entity.Property(e => e.OrganisationTypeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.OrganisationTypeUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.OrganisationTypeCreatedBy)
               .WithMany()
               ////.HasForeignKey(d => d.OrganisationTypeCreatedBy)

               .HasConstraintName("FK_tbllOrganisationType.CreatedBy_tblCustomer");

            entity.HasOne(d => d.OrganisationTypeUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.OrganisationTypeUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tbllOrganisationType.UpdatedBy_tblCustomer");

            entity.HasMany(organisation => organisation.OrganisationType)
.WithOne(school => school.OrganisationType)
.HasForeignKey(school => school.OrganisationTypeId)
.IsRequired(false);

        });

        modelBuilder.Entity<TblPage>(entity =>
        {
            entity.HasKey(e => e.PageId).HasName("PRIMARY");

            entity.ToTable("tblPage");

            //entity.HasIndex(e => new { e.PageId, e.SchoolId }, "PageID");

            entity.Property(e => e.PageId)
                .HasColumnType("int(11)")
                .HasColumnName("PageID");
            entity.Property(e => e.PageContent).HasColumnType("text");
            //entity.Property(e => e.PageCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PageCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PageEndDate).HasColumnType("datetime");
            entity.Property(e => e.PageName).HasMaxLength(250);
            entity.Property(e => e.PageStartDate).HasColumnType("datetime");
            //entity.Property(e => e.PageUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PageUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");

            entity.HasOne(d => d.School)
                .WithMany()
                ////.HasForeignKey(d => d.School)

                .HasConstraintName("FK_tblPage_tblCustomer");

            entity.HasOne(d => d.PageCreatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.PageCreatedBy)
                .HasConstraintName("FK_tblPage.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PageUpdatedBy)
                .WithMany()
                ////.HasForeignKey(d => d.PageUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblPage.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblPartner>(entity =>
        {
            entity.HasKey(e => e.PartnerId).HasName("PRIMARY");

            entity.ToTable("tblPartner");

            entity.Property(e => e.PartnerId)
                .HasColumnType("int(11)")
                .HasColumnName("PartnerID");
            entity.Property(e => e.PartnerCode).HasMaxLength(100);
            //entity.Property(e => e.PartnerCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PartnerCreatedByDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PartnerDescription).HasColumnType("text");
            entity.Property(e => e.PartnerEmail).HasMaxLength(250);
            entity.Property(e => e.PartnerLogo).HasMaxLength(255);
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.PartnerTelephone).HasMaxLength(100);
            //entity.Property(e => e.PartnerUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PartnerUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.PartnerUrl)
                .HasMaxLength(255)
                .HasColumnName("PartnerURL");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");

            entity.HasOne(d => d.School)
                .WithMany()
                ////.HasForeignKey(d => d.School)

                .HasConstraintName("FK_tblPartner_tblSchool");

            entity.HasOne(d => d.PartnerCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PartnerCreatedBy)

                .HasConstraintName("FK_tblPartner.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PartnerUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PartnerUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblPartner.UpdatedBy_tblCustomer");

            entity.HasMany(partner => partner.CustomerPartner)
.WithOne(customer => customer.Partner)
.HasForeignKey(customer => customer.CustomerPartnerId)
.IsRequired(false);

        });

        modelBuilder.Entity<TblPaymentMethod>(entity =>
        {
            entity.HasKey(e => e.PaymentMethodId).HasName("PRIMARY");

            entity.ToTable("tblPaymentMethod");

            entity.Property(e => e.PaymentMethodId)
                .HasColumnType("int(11)")
                .HasColumnName("PaymentMethodID");
            //entity.Property(e => e.PaymentMethodCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PaymentMethodCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PaymentMethodName).HasMaxLength(50);
            //entity.Property(e => e.PaymentMethodUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PaymentMethodUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.PaymentMethodCreatedBy)
              .WithMany()
              //.HasForeignKey(d => d.PaymentMethodCreatedBy)

              .HasConstraintName("FK_tblPaymentMethod.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PaymentMethodUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PaymentMethodUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblPaymentMethod.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblPaymentStatus>(entity =>
        {
            entity.HasKey(e => e.PaymentStatusId).HasName("PRIMARY");

            entity.ToTable("tblPaymentStatus");

            entity.Property(e => e.PaymentStatusId)
                .HasColumnType("int(11)")
                .HasColumnName("PaymentStatusID");
            //entity.Property(e => e.PaymentStatusCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PaymentStatusCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PaymentStatusName).HasMaxLength(50);
            //entity.Property(e => e.PaymentStatusUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PaymentStatusUpdatedDate).HasColumnType("timestamp");
            entity.HasOne(d => d.PaymentStatusCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PaymentStatusCreatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tbllPaymentStatus.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PaymentStatusUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PaymentStatusUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tbllPaymentStatus.UpdatedBy_tblCustomer");


        });

        modelBuilder.Entity<TblPaypal>(entity =>
        {
            entity.HasKey(e => e.PaypalId).HasName("PRIMARY");

            entity.ToTable("tblPaypal");

            entity.HasIndex(e => e.PaypalTransactionId, "PaypalTransactionID");

            entity.HasIndex(e => e.PaypalType, "PaypalType");

            entity.Property(e => e.PaypalId)
                .HasColumnType("int(11)")
                .HasColumnName("PaypalID");
            entity.Property(e => e.LegacyPaypalId)
                .HasColumnType("int(11)")
                .HasColumnName("LegacyPaypalID");
            entity.Property(e => e.PaypalCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PaypalCurrency).HasMaxLength(3);
            entity.Property(e => e.PaypalFee).HasPrecision(10, 2);
            entity.Property(e => e.PaypalIpntrackId)
                .HasMaxLength(50)
                .HasColumnName("PaypalIPNTrackID");
            entity.Property(e => e.PaypalItemTotal)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            //entity.Property(e => e.PaypalParentTransactionId)
            //    .HasMaxLength(50)
            //    .HasColumnName("PaypalParentTransactionID");
            entity.Property(e => e.PaypalPayerEmail).HasMaxLength(250);
            entity.Property(e => e.PaypalPayerStatus).HasMaxLength(50);
            entity.Property(e => e.PaypalPaymentStatus).HasMaxLength(50);
            entity.Property(e => e.PaypalReceiverId)
                .HasMaxLength(250)
                .HasColumnName("PaypalReceiverID");
            entity.Property(e => e.PaypalTransactionAmount).HasPrecision(10, 2);
            entity.Property(e => e.PaypalTransactionId)
                .HasMaxLength(50)
                .HasColumnName("PaypalTransactionID");
            entity.Property(e => e.PaypalType).HasMaxLength(50);
            entity.Property(e => e.PaypalUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.PlatformFee)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("'0.00'");
            entity.Property(e => e.PlatformFeeInvoiceNo).HasMaxLength(20);
            entity.Property(e => e.PlatformFeeRefundAmount).HasPrecision(10, 2);

            entity.HasOne(d => d.PaypalParentTransaction)
                .WithMany()
                //.HasForeignKey(d => d.PaypalParentTransaction)
                .HasConstraintName("FK_tblPaypal_tblPaypal");

        });

        modelBuilder.Entity<TblPlanType>(entity =>
        {
            entity.HasKey(e => e.PlanTypeId).HasName("PRIMARY");

            entity.ToTable("tblPlanType");

            entity.HasIndex(e => e.PlanTypeId, "PlanTypeID").IsUnique();

            entity.Property(e => e.PlanTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("PlanTypeID");
            entity.Property(e => e.PlanTypeDescription).HasMaxLength(250);
            entity.Property(e => e.PlanTypeName).HasMaxLength(50);

            entity.HasMany(plantype => plantype.PlanType)
                .WithOne(school => school.PlanType)
                .HasForeignKey(school => school.PlanTypeId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblPlatformPartner>(entity =>
        {
            entity.HasKey(e => e.PlatformPartnerId).HasName("PRIMARY");

            entity.ToTable("tblPlatformPartner");

            entity.Property(e => e.PlatformPartnerId)
                .HasColumnType("int(11)")
                .HasColumnName("PlatformPartnerID");
            entity.Property(e => e.PlatformPartnerCode).HasMaxLength(100);
            //entity.Property(e => e.PlatformPartnerCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PlatformPartnerCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PlatformPartnerDescription).HasColumnType("text");
            entity.Property(e => e.PlatformPartnerEmail).HasMaxLength(250);
            entity.Property(e => e.PlatformPartnerLocalAdvertisingRevShare).HasPrecision(10);
            entity.Property(e => e.PlatformPartnerLogo).HasMaxLength(255);
            entity.Property(e => e.PlatformPartnerName).HasMaxLength(100);
            entity.Property(e => e.PlatformPartnerNationalAdvertisingRevShare).HasPrecision(10);
            entity.Property(e => e.PlatformPartnerPlatformFeeRevShare).HasPrecision(10);
            entity.Property(e => e.PlatformPartnerTelephone).HasMaxLength(100);
            //entity.Property(e => e.PlatformPartnerUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PlatformPartnerUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.PlatformPartnerUrl)
                .HasMaxLength(255)
                .HasColumnName("PlatformPartnerURL");

            entity.HasOne(d => d.PlatformPartnerCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PlatformPartnerCreatedBy)

                .HasConstraintName("FK_tblPlatformPartner.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PlatformPartnerUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PlatformPartnerUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblPlatformPartner.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblPoll>(entity =>
        {
            entity.HasKey(e => e.PollId).HasName("PRIMARY");

            entity.ToTable("tblPoll");

            entity.Property(e => e.PollId)
                .HasColumnType("int(11)")
                .HasColumnName("PollID");
            //entity.Property(e => e.PollCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PollCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PollDescription).HasMaxLength(1000);
            entity.Property(e => e.PollEndDate).HasColumnType("datetime");
            entity.Property(e => e.PollImage).HasMaxLength(250);
            entity.Property(e => e.PollQuestion).HasMaxLength(250);
            entity.Property(e => e.PollStartDate).HasColumnType("datetime");
            //entity.Property(e => e.PollUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PollUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");

            entity.HasOne(d => d.School)
                .WithMany()
                //.HasForeignKey(d => d.School)
                .HasConstraintName("FK_tblPoll_tblSchool");

            entity.HasOne(d => d.PollCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PollCreatedBy)
                .HasConstraintName("FK_tblPoll.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PollUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PollUpdatedBy)
                .HasConstraintName("FK_tblPoll.UpdatedBy_tblCustomer");


        });

        modelBuilder.Entity<TblPollAnswer>(entity =>
        {
            entity.HasKey(e => e.PollAnswerId).HasName("PRIMARY");

            entity.ToTable("tblPollAnswer");

            entity.Property(e => e.PollAnswerId)
                .HasColumnType("int(11)")
                .HasColumnName("PollAnswerID");
            //entity.Property(e => e.CustomerId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("CustomerID");
            //entity.Property(e => e.PollAnswerCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PollAnswerCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PollAnswerOther).HasMaxLength(150);
            //entity.Property(e => e.PollAnswerUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PollAnswerUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.PollOptionId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("PollOptionID");

            entity.HasOne(d => d.PollOption)
                .WithMany()
                //.HasForeignKey(d => d.PollOption)
                .HasConstraintName("FK_tblPollAnswer_tblPollOption");

            entity.HasOne(d => d.Customer)
                .WithMany()
                //.HasForeignKey(d => d.Customer)
                .HasConstraintName("FK_tblPollAnswer_tblCustomer");

            entity.HasOne(d => d.PollAnswerCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PollAnswerCreatedBy)
                .HasConstraintName("FK_tblPollAnswer.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PollAnswerUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PollAnswerUpdatedBy)
                .HasConstraintName("FK_tblPollAnswer.UpdatedBy_tblCustomer");


        });

        modelBuilder.Entity<TblPollOption>(entity =>
        {
            entity.HasKey(e => e.PollOptionId).HasName("PRIMARY");

            entity.ToTable("tblPollOption");

            entity.Property(e => e.PollOptionId)
                .HasColumnType("int(11)")
                .HasColumnName("PollOptionID");
            //entity.Property(e => e.Poll)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("Poll");
            entity.Property(e => e.PollOption).HasMaxLength(150);
            //entity.Property(e => e.PollOptionCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PollOptionCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            //entity.Property(e => e.PollOptionUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.PollOptionUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.Poll)
                .WithMany()
                //.HasForeignKey(d => d.Poll)

                .HasConstraintName("FK_tblPollOption_tblPoll");

            entity.HasOne(d => d.PollOptionCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PollOptionCreatedBy)

                .HasConstraintName("FK_tblPollOption.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PollOptionUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.PollOptionUpdatedBy)
                .HasConstraintName("FK_tblPollOption.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PRIMARY");

            entity.ToTable("tblProduct");

            //entity.HasIndex(e => e.AuctionId, "AuctionID");

            entity.HasIndex(e => e.ProductDeleted, "ProductDeleted");

            entity.HasIndex(e => e.ProductSku, "ProductSKU");

            //entity.HasIndex(e => e.ProductTypeId, "ProductTypeID");

            //entity.HasIndex(e => e.SchoolId, "SchoolID");

            //entity.HasIndex(e => e.SubGroupId, "SubGroupID");

            //entity.HasIndex(e => new { e.ProductTypeId, e.ProductSaleEndDate, e.ProductSaleStartDate }, "idx_product_productdates");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductID");
            //entity.Property(e => e.AuctionId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("AuctionID");
            entity.Property(e => e.LegacyProductId)
                .HasColumnType("int(11)")
                .HasColumnName("LegacyProductID");
            entity.Property(e => e.ProductBookingLabel).HasMaxLength(100);
            entity.Property(e => e.ProductComplimentaryFor).HasColumnType("int(11)");
            entity.Property(e => e.ProductCost).HasPrecision(10, 2);
            //entity.Property(e => e.ProductCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ProductDescription).HasColumnType("text");
            entity.Property(e => e.ProductDisplay)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.ProductDisplayStockQty)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.ProductEmailText).HasColumnType("text");
            entity.Property(e => e.ProductImage).HasMaxLength(250);
            entity.Property(e => e.ProductMaxQty).HasColumnType("int(11)");
            entity.Property(e => e.ProductMinPrice).HasPrecision(10, 2);
            entity.Property(e => e.ProductMinQty).HasColumnType("int(11)");
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.ProductOrder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ProductPrice).HasPrecision(10, 2);
            entity.Property(e => e.ProductQty)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ProductRequiredInformation).HasMaxLength(200);
            entity.Property(e => e.ProductSaleEndDate).HasColumnType("datetime");
            entity.Property(e => e.ProductSaleStartDate).HasColumnType("datetime");
            entity.Property(e => e.ProductSku)
                .HasMaxLength(100)
                .HasColumnName("ProductSKU");
            entity.Property(e => e.ProductStockQty).HasColumnType("int(11)");
            entity.Property(e => e.ProductTargetQty).HasColumnType("int(11)");
            entity.Property(e => e.ProductTime).HasMaxLength(10);
            //entity.Property(e => e.ProductTypeId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductTypeID");
            //entity.Property(e => e.ProductUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");
            //entity.Property(e => e.SubGroupId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SubGroupID");

            entity.HasOne(d => d.Auction)
                .WithMany()
                //.HasForeignKey(d => d.Auction)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblProduct_tblAuction");

            entity.HasOne(d => d.ProductType)
                .WithMany()
                //.HasForeignKey(d => d.ProductType)

                .HasConstraintName("FK_tblProduct_tblProductType");

            entity.HasOne(d => d.School)
                .WithMany()
                //.HasForeignKey(d => d.School)
                .HasConstraintName("FK_tblProduct_tblSchool");

            entity.HasOne(d => d.SubGroup)
                .WithMany()
                //.HasForeignKey(d => d.SubGroup)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblProduct_tblSubGroup");

            entity.HasOne(d => d.ProductCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductCreatedBy)

                .HasConstraintName("FK_tblProduct.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblProduct.UpdatedBy_tblCustomer");


            entity.HasMany(product => product.EventProduct)
                .WithOne(eventProduct => eventProduct.Product)
                .HasForeignKey(eventProduct => eventProduct.ProductId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblProductAttribute>(entity =>
        {
            entity.HasKey(e => e.ProductAttributeId).HasName("PRIMARY");

            entity.ToTable("tblProductAttribute");

            //entity.HasIndex(e => e.ProductId, "ProductID");

            entity.Property(e => e.ProductAttributeId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductAttributeID");
            //entity.Property(e => e.ProductAttributeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductAttributeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ProductAttributeDisplay)
                .IsRequired()
                .HasDefaultValueSql("'1'");
            entity.Property(e => e.ProductAttributeImage).HasMaxLength(250);
            entity.Property(e => e.ProductAttributeName).HasMaxLength(250);
            entity.Property(e => e.ProductAttributeOrder)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ProductAttributePrice).HasPrecision(10, 2);
            entity.Property(e => e.ProductAttributeSaleEndDate).HasColumnType("datetime");
            entity.Property(e => e.ProductAttributeSaleStartDate).HasColumnType("datetime");
            entity.Property(e => e.ProductAttributeStockQty).HasColumnType("int(11)");
            //entity.Property(e => e.ProductAttributeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductAttributeUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.ProductId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductID");

            entity.HasOne(d => d.Product)
                .WithMany()
                //.HasForeignKey(d => d.Product)

                .HasConstraintName("FK_tblProductAttribute_tblProduct");

            entity.HasOne(d => d.ProductAttributeCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductAttributeCreatedBy)

                .HasConstraintName("FK_tblProductAttribute.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductAttributeUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductAttributeUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblProductAttribute.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblProductClass>(entity =>
        {
            entity.HasKey(e => e.ProductClassId).HasName("PRIMARY");

            entity.ToTable("tblProductClass");

            //entity.HasIndex(e => e.ProductId, "ProductID");

            entity.Property(e => e.ProductClassId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductClassID");
            //entity.Property(e => e.ClassId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ClassID");
            //entity.Property(e => e.ProductClassCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductClassCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            //entity.Property(e => e.ProductClassUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductClassUpdatedDate).HasColumnType("int(11)");
            //entity.Property(e => e.ProductId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductID");

            entity.HasOne(d => d.Class)
                .WithMany()
                //.HasForeignKey(d => d.Class)

                .HasConstraintName("FK_tbllProductClass_tblClass");

            entity.HasOne(d => d.Product)
                .WithMany()
                //.HasForeignKey(d => d.Product)

                .HasConstraintName("FK_tbllProductClass_tblProduct");

            entity.HasOne(d => d.ProductClassCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductClassCreatedBy)
                .HasConstraintName("FK_tbllProductClass.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductClassUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductClassUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tbllProductClass.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblProductPayment>(entity =>
        {
            entity.HasKey(e => e.ProductPaymentId).HasName("PRIMARY");

            entity.ToTable("tblProductPayment");

            entity.Property(e => e.ProductPaymentId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductPaymentID");
            //entity.Property(e => e.Product)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("Product");
            entity.Property(e => e.ProductPaymentAmount).HasPrecision(10, 2);
            //entity.Property(e => e.ProductPaymentCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductPaymentCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ProductPaymentDueDate).HasColumnType("timestamp");
            entity.Property(e => e.ProductPaymentName).HasMaxLength(100);
            //entity.Property(e => e.ProductPaymentUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductPaymentUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.Product)
                .WithMany()
                //.HasForeignKey(d => d.Product)

                .HasConstraintName("FK_tblProductPayment_tblProduct");

            entity.HasOne(d => d.ProductPaymentCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductPaymentCreatedBy)

                .HasConstraintName("FK_tblProductPayment.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductPaymentUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductPaymentUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblProductPayment.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblProductPaymentScheme>(entity =>
        {
            entity.HasKey(e => e.ProductPaymentSchemeId).HasName("PRIMARY");

            entity.ToTable("tblProductPaymentScheme");

            entity.Property(e => e.ProductPaymentSchemeId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductPaymentSchemeID");
            //entity.Property(e => e.ProductId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductID");
            entity.Property(e => e.ProductPaymentSchemeAmount).HasPrecision(10);
            //entity.Property(e => e.ProductPaymentSchemeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductPaymentSchemeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            //entity.Property(e => e.ProductPaymentSchemeFrequencyId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductPaymentSchemeFrequencyID");
            entity.Property(e => e.ProductPaymentSchemeNoPayments).HasColumnType("int(11)");
            entity.Property(e => e.ProductPaymentSchemeStartDate).HasColumnType("timestamp");
            //entity.Property(e => e.ProductPaymentSchemeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductPaymentSchemeUpdatedDate).HasColumnType("timestamp");
        });

        modelBuilder.Entity<TblProductPaymentSchemeFrequency>(entity =>
        {
            entity.HasKey(e => e.ProductPaymentSchemeFrequencyId).HasName("PRIMARY");

            entity.ToTable("tblProductPaymentSchemeFrequency");

            entity.Property(e => e.ProductPaymentSchemeFrequencyId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductPaymentSchemeFrequencyID");
            //entity.Property(e => e.ProductPaymentSchemeFrequencyCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductPaymentSchemeFrequencyCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ProductPaymentSchemeFrequencyDivisor).HasColumnType("int(11)");
            entity.Property(e => e.ProductPaymentSchemeFrequencyName).HasMaxLength(50);
            //entity.Property(e => e.ProductPaymentSchemeFrequencyUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.ProductPaymentSchemeFrequencyUpdatedBy).HasColumnType("int(11)");

            entity.HasOne(d => d.ProductPaymentSchemeFrequencyCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductPaymentSchemeFrequencyCreatedBy)
                .HasConstraintName("FK_tblProductPaymentSchemeFrequency.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductPaymentSchemeFrequencyUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductPaymentSchemeFrequencyUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblProductPaymentSchemeFrequency.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblProductQuestion>(entity =>
        {
            entity.HasKey(e => e.ProductQuestionId).HasName("PRIMARY");

            entity.ToTable("tblProductQuestion");

            //entity.HasIndex(e => e.ProductId, "ProductID");

            entity.HasIndex(e => e.ProductQuestionOrder, "ProductQuestionOrder");

            entity.HasIndex(e => e.ProductQuestionType, "ProductQuestionType");

            entity.Property(e => e.ProductQuestionId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductQuestionID");
            //entity.Property(e => e.ProductId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductID");
            //entity.Property(e => e.ProductQuestionCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ProductQuestionDatasource).HasMaxLength(500);
            entity.Property(e => e.ProductQuestionDeleted)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.ProductQuestionDescription).HasMaxLength(1000);
            entity.Property(e => e.ProductQuestionImage).HasMaxLength(250);
            entity.Property(e => e.ProductQuestionMaxLength).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionMaxValue).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionMinLength).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionMinValue).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionName).HasMaxLength(250);
            entity.Property(e => e.ProductQuestionOptions).HasMaxLength(5000);
            entity.Property(e => e.ProductQuestionOrder)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionRequired)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.ProductQuestionType).HasMaxLength(20);
            //entity.Property(e => e.ProductQuestionUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.Product)
                .WithMany()
                //.HasForeignKey(d => d.Product)

                .HasConstraintName("FK_tblProductQuestion_tblProduct");

            entity.HasOne(d => d.ProductQuestionCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductQuestionCreatedBy)

                .HasConstraintName("FK_tblProductQuestion.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductQuestionUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductQuestionUpdatedBy)
                .HasConstraintName("FK_tblProductQuestion.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblProductQuestionAnswer>(entity =>
        {
            entity.HasKey(e => e.ProductQuestionAnswerId).HasName("PRIMARY");

            entity.ToTable("tblProductQuestionAnswer");

            entity.HasIndex(e => e.BookingNo, "BookingNo");

            entity.HasIndex(e => e.OrderItemId, "OrderItemID");

            //entity.HasIndex(e => e.ProductQuestionId, "ProductQuestionID");

            //entity.HasIndex(e => new { e.OrderItemId, e.BookingNo, e.ProductQuestionId }, "idx_productquestionanswers");

            entity.Property(e => e.ProductQuestionAnswerId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductQuestionAnswerID");
            entity.Property(e => e.BookingNo).HasColumnType("int(11)");
            entity.Property(e => e.OrderItemId)
                .HasColumnType("int(11)")
                .HasColumnName("OrderItemID");
            entity.Property(e => e.ProductQuestionAnswer).HasMaxLength(2000);
            //entity.Property(e => e.ProductQuestionAnswerCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionAnswerCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ProductQuestionAnswerDeleted)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)");
            //entity.Property(e => e.ProductQuestionAnswerUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductQuestionAnswerUpdatedDate).HasColumnType("timestamp");
            //entity.Property(e => e.ProductQuestionId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("ProductQuestionID");

            entity.HasOne(d => d.ProductQuestion)
                .WithMany()
                //.HasForeignKey(d => d.ProductQuestion)

                .HasConstraintName("FK_tblProductQuestionAnswer_tblCustomer");

            entity.HasOne(d => d.ProductQuestionAnswerCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductQuestionAnswerCreatedBy)

                .HasConstraintName("FK_tblProductQuestionAnswer.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductQuestionAnswerUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductQuestionAnswerUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblProductQuestionAnswer.UpdatedBy_tblCustomer");

        });

        modelBuilder.Entity<TblProductType>(entity =>
        {
            entity.HasKey(e => e.ProductTypeId).HasName("PRIMARY");

            entity.ToTable("tblProductType");

            entity.Property(e => e.ProductTypeId)
                .HasColumnType("int(11)")
                .HasColumnName("ProductTypeID");
            //entity.Property(e => e.ProductTypeCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductTypeCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.ProductTypeDescription).HasMaxLength(250);
            entity.Property(e => e.ProductTypeIcon).HasMaxLength(50);
            entity.Property(e => e.ProductTypeName).HasMaxLength(50);
            //entity.Property(e => e.ProductTypeUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.ProductTypeUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.ProductTypeCreatedBy)
                  .WithMany()
                      //.HasForeignKey(d => d.ProductTypeCreatedBy)   
                      .HasConstraintName("FK_tblProductType.CreatedBy_tblCustomer");

            entity.HasOne(d => d.ProductTypeUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.ProductTypeUpdatedBy)

                .HasConstraintName("FK_tblProductType.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblPtamember>(entity =>
        {
            entity.HasKey(e => e.PtamemberId).HasName("PRIMARY");

            entity.ToTable("tblPTAMember");

            entity.Property(e => e.PtamemberId)
                .HasColumnType("int(11)")
                .HasColumnName("PTAMemberID");
            //entity.Property(e => e.AcademicYearId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("AcademicYearID");
            //entity.Property(e => e.CustomerId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("CustomerID");
            //entity.Property(e => e.PtamemberCreatedBy)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("PTAMemberCreatedBy");
            entity.Property(e => e.PtamemberCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp")
                .HasColumnName("PTAMemberCreatedDate");
            entity.Property(e => e.PtamemberDeleted).HasColumnName("PTAMemberDeleted");
            entity.Property(e => e.PtamemberInfo)
                .HasMaxLength(500)
                .HasColumnName("PTAMemberInfo");
            //entity.Property(e => e.PtamemberUpdatedBy)
            //.HasColumnType("int(11)")
            //.HasColumnName("PTAMemberUpdatedBy");
            entity.Property(e => e.PtamemberUpdatedDate)
                .HasColumnType("timestamp")
                .HasColumnName("PTAMemberUpdatedDate");
            //entity.Property(e => e.RoleId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("RoleID");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");

            entity.HasOne(d => d.AcademicYear)
           .WithMany()
           //.HasForeignKey(d => d.AcademicYear)

           .HasConstraintName("FK_tblPtamember_tblAcademicYear");

            entity.HasOne(d => d.Role)
                .WithMany()
                //.HasForeignKey(d => d.Role)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblPtamember_tblRole");

            entity.HasOne(d => d.School)
                .WithMany()
                //.HasForeignKey(d => d.School)
                .HasConstraintName("FK_tblPtamember_tblSchool");

            entity.HasOne(d => d.Customer)
               .WithMany()
               //.HasForeignKey(d => d.Customer)

               .HasConstraintName("FK_tblPtamember_tblCustomer");

            entity.HasOne(d => d.PtamemberCreatedBy)
              .WithMany()
              //.HasForeignKey(d => d.PtamemberCreatedBy)

              .HasConstraintName("FK_tblPtamember.CreatedBy_tblCustomer");

            entity.HasOne(d => d.PtamemberUpdatedBy)
              .WithMany()
              //.HasForeignKey(d => d.PtamemberUpdatedBy)

              .HasConstraintName("FK_tblPtamember.UpdatedBy_tblCustomer");


        });

        modelBuilder.Entity<TblRefund>(entity =>
        {
            entity.HasKey(e => e.RefundId).HasName("PRIMARY");

            entity.ToTable("tblRefund");

            entity.Property(e => e.RefundId)
                .HasColumnType("int(11)")
                .HasColumnName("RefundID");
            //entity.Property(e => e.OrderId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("OrderID");
            //entity.Property(e => e.RefundCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.RefundCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.RefundDescription).HasMaxLength(1000);
            //entity.Property(e => e.RefundUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.RefundUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.RefundValue).HasPrecision(10, 2);

            entity.HasOne(d => d.Order)
           .WithMany()
           //.HasForeignKey(d => d.Order)

           .HasConstraintName("FK_tblRefund_tblOrdr");

            entity.HasOne(d => d.RefundCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.RefundCreatedBy)

                .HasConstraintName("FK_tblRefund.CreatedBy_tblCustomer");

            entity.HasOne(d => d.RefundUpdatedBy)
                .WithMany()
                 //.HasForeignKey(d => d.RefundUpdatedBy)
                 .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblRefund.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PRIMARY");

            entity.ToTable("tblRole");

            entity.Property(e => e.RoleId)
                .HasColumnType("int(11)")
                .HasColumnName("RoleID");
            entity.Property(e => e.RoleCode).HasMaxLength(25);
            entity.Property(e => e.RoleCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.RoleCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.RoleDescription).HasMaxLength(1000);
            entity.Property(e => e.RoleName).HasMaxLength(50);
            entity.Property(e => e.RoleSortOrder).HasColumnType("int(11)");
            entity.Property(e => e.RoleUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.RoleUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(role => role.CreatedBy)
                .WithMany(customer => customer.RoleCreatedBy)
                .HasForeignKey(role => role.RoleCreatedBy)
                .IsRequired(false);
            entity.HasOne(role => role.UpdatedBy)
                .WithMany(customer => customer.RoleUpdatedBy)
                .HasForeignKey(role => role.RoleUpdatedBy)
                .IsRequired(false);

            entity.HasMany(role => role.CustomerRole)
                .WithOne(customerRole => customerRole.Role)
                .HasForeignKey(customerRole => customerRole.RoleId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblSchool>(entity =>
        {
            entity.HasKey(e => e.SchoolId).HasName("PRIMARY");

            entity.ToTable("tblSchool");

            entity.HasIndex(e => e.OrganisationTypeId, "OrganisationTypeID");

            entity.HasIndex(e => e.PlatformPartnerId, "PlatformPartnerID");

            entity.HasIndex(e => e.SchoolCreatedDate, "SchoolCreatedDate");

            entity.HasIndex(e => e.SchoolPtadirectory, "SchoolPTADirectory");

            entity.HasIndex(e => e.SchoolPtastripeLiveAccountId, "SchoolPTAStripeLiveAccountID");

            entity.HasIndex(e => e.SchoolUid, "SchoolUID");

            entity.Property(e => e.SchoolId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolID");
            entity.Property(e => e.Lacode)
                .HasMaxLength(3)
                .HasColumnName("LACode");
            entity.Property(e => e.OrganisationTypeId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("OrganisationTypeID");
            entity.Property(e => e.PartnerMembershipNumber).HasMaxLength(20);
            entity.Property(e => e.PartnerOrganisationId)
                .HasMaxLength(50)
                .HasColumnName("PartnerOrganisationID");
            entity.Property(e => e.PlanTypeId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("PlanTypeID");
            entity.Property(e => e.PlatformFee)
                .HasPrecision(10, 2)
                .HasDefaultValueSql("'2.95'");
            entity.Property(e => e.PlatformPartnerId)
                .HasColumnType("int(11)")
                .HasColumnName("PlatformPartnerID");
            entity.Property(e => e.SchoolAddress1).HasMaxLength(100);
            entity.Property(e => e.SchoolAddress2).HasMaxLength(100);
            entity.Property(e => e.SchoolBackgroundColour).HasMaxLength(10);
            entity.Property(e => e.SchoolBorderColour).HasMaxLength(10);
            entity.Property(e => e.SchoolBrandingEmailSentDate).HasColumnType("timestamp");
            entity.Property(e => e.SchoolCounty).HasMaxLength(100);
            entity.Property(e => e.SchoolCreatedBy)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)");
            entity.Property(e => e.SchoolCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.SchoolCustomCss)
                .HasMaxLength(1000)
                .HasColumnName("SchoolCustomCSS");
            entity.Property(e => e.SchoolDataRetentionSettings)
                .HasMaxLength(100)
                .HasDefaultValueSql("'2|y'");
            entity.Property(e => e.SchoolDpadateSigned)
                .HasColumnType("datetime")
                .HasColumnName("SchoolDPADateSigned");
            entity.Property(e => e.SchoolDpasignedBy)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolDPASignedBy");
            entity.Property(e => e.SchoolEnableGuestCheckout).HasColumnType("tinyint(4)");
            entity.Property(e => e.SchoolFontSize)
                .HasDefaultValueSql("'13'")
                .HasColumnType("int(2)");
            entity.Property(e => e.SchoolGdprdateSigned)
                .HasColumnType("datetime")
                .HasColumnName("SchoolGDPRDateSigned");
            entity.Property(e => e.SchoolGdprlawfulBasis)
                .HasMaxLength(200)
                .HasColumnName("SchoolGDPRLawfulBasis");
            entity.Property(e => e.SchoolGdprsignedBy)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolGDPRSignedBy");
            entity.Property(e => e.SchoolKnownByName).HasMaxLength(250);
            entity.Property(e => e.SchoolLinkColour).HasMaxLength(10);
            entity.Property(e => e.SchoolName).HasMaxLength(250);
            entity.Property(e => e.SchoolNavBarColour).HasMaxLength(10);
            entity.Property(e => e.SchoolNavBarTextColour).HasMaxLength(10);
            entity.Property(e => e.SchoolNavBarTextHoverColour).HasMaxLength(10);
            entity.Property(e => e.SchoolPageBackgroundColour)
                .HasMaxLength(10)
                .HasDefaultValueSql("'#ffffff'");
            entity.Property(e => e.SchoolPkmember).HasColumnName("SchoolPKMember");
            entity.Property(e => e.SchoolPostCode).HasMaxLength(100);
            entity.Property(e => e.SchoolPrimaryColour).HasMaxLength(10);
            entity.Property(e => e.SchoolPtacloseDate)
                .HasColumnType("datetime")
                .HasColumnName("SchoolPTACloseDate");
            entity.Property(e => e.SchoolPtacountryId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("SchoolPTACountryID");
            entity.Property(e => e.SchoolPtacurrencyId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("SchoolPTACurrencyID");
            entity.Property(e => e.SchoolPtadefaultPage)
                .HasMaxLength(200)
                .HasDefaultValueSql("'Shop'")
                .HasColumnName("SchoolPTADefaultPage");
            entity.Property(e => e.SchoolPtadirectory)
                .HasMaxLength(100)
                .HasColumnName("SchoolPTADirectory");
            entity.Property(e => e.SchoolPtadisplayFacebookWidget).HasColumnName("SchoolPTADisplayFacebookWidget");
            entity.Property(e => e.SchoolPtadisplayTwitterWidget).HasColumnName("SchoolPTADisplayTwitterWidget");
            entity.Property(e => e.SchoolPtadomain)
                .HasMaxLength(500)
                .HasColumnName("SchoolPTADomain");
            entity.Property(e => e.SchoolPtaemail)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAEmail");
            entity.Property(e => e.SchoolPtafacebook)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAFacebook");
            entity.Property(e => e.SchoolPtafontFamily)
                .HasMaxLength(150)
                .HasDefaultValueSql("'Ubuntu'")
                .HasColumnName("SchoolPTAFontFamily");
            entity.Property(e => e.SchoolPtafooter)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAFooter");
            entity.Property(e => e.SchoolPtafullName)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAFullName");
            entity.Property(e => e.SchoolPtafundraisingAmount)
                .HasPrecision(10)
                .HasColumnName("SchoolPTAFundraisingAmount");
            entity.Property(e => e.SchoolPtafundraisingTarget)
                .HasPrecision(10)
                .HasColumnName("SchoolPTAFundraisingTarget");
            entity.Property(e => e.SchoolPtafundraisingText)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAFundraisingText");
            entity.Property(e => e.SchoolPtaglobalPages)
                .HasMaxLength(500)
                .HasColumnName("SchoolPTAGlobalPages");
            entity.Property(e => e.SchoolPtagoCardlessLiveEndpointSecret)
                .HasMaxLength(100)
                .HasColumnName("SchoolPTAGoCardlessLiveEndpointSecret");
            entity.Property(e => e.SchoolPtagoCardlessLiveOrganisationId)
                .HasMaxLength(20)
                .HasColumnName("SchoolPTAGoCardlessLiveOrganisationID");
            entity.Property(e => e.SchoolPtagoCardlessLiveToken)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAGoCardlessLiveToken");
            entity.Property(e => e.SchoolPtagoCardlessTestEndpointSecret)
                .HasMaxLength(100)
                .HasColumnName("SchoolPTAGoCardlessTestEndpointSecret");
            entity.Property(e => e.SchoolPtagoCardlessTestOrganisationId)
                .HasMaxLength(20)
                .HasColumnName("SchoolPTAGoCardlessTestOrganisationID");
            entity.Property(e => e.SchoolPtagoCardlessTestToken)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAGoCardlessTestToken");
            entity.Property(e => e.SchoolPtagoogleAnalyticsAccount)
                .HasMaxLength(20)
                .HasColumnName("SchoolPTAGoogleAnalyticsAccount");
            entity.Property(e => e.SchoolPtagoogleVerificationCode)
                .HasMaxLength(200)
                .HasColumnName("SchoolPTAGoogleVerificationCode");
            entity.Property(e => e.SchoolPtainstagram)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAInstagram");
            entity.Property(e => e.SchoolPtalotteryLicenceUploaded).HasColumnName("SchoolPTALotteryLicenceUploaded");
            entity.Property(e => e.SchoolPtalotteryLicenceUploadedBy)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolPTALotteryLicenceUploadedBy");
            entity.Property(e => e.SchoolPtametaDescription)
                .HasMaxLength(500)
                .HasColumnName("SchoolPTAMetaDescription");
            entity.Property(e => e.SchoolPtametaFollow).HasColumnName("SchoolPTAMetaFollow");
            entity.Property(e => e.SchoolPtametaIndex).HasColumnName("SchoolPTAMetaIndex");
            entity.Property(e => e.SchoolPtametaKeywords)
                .HasMaxLength(500)
                .HasColumnName("SchoolPTAMetaKeywords");
            entity.Property(e => e.SchoolPtaname)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAName");
            entity.Property(e => e.SchoolPtapaypalAccountType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Business'")
                .HasColumnName("SchoolPTAPaypalAccountType");
            entity.Property(e => e.SchoolPtapaypalLiveAccount)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAPaypalLiveAccount");
            entity.Property(e => e.SchoolPtapaypalTestAccount)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTAPaypalTestAccount");
            entity.Property(e => e.SchoolPtaregisterCollectClass).HasColumnName("SchoolPTARegisterCollectClass");
            entity.Property(e => e.SchoolPtaregisterToView).HasColumnName("SchoolPTARegisterToView");
            entity.Property(e => e.SchoolPtaregisteredCharityNo)
                .HasMaxLength(100)
                .HasColumnName("SchoolPTARegisteredCharityNo");
            entity.Property(e => e.SchoolPtastripeAccountType)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Business'")
                .HasColumnName("SchoolPTAStripeAccountType");
            entity.Property(e => e.SchoolPtastripeGamblingApproved).HasColumnName("SchoolPTAStripeGamblingApproved");
            entity.Property(e => e.SchoolPtastripeLiveAccountId)
                .HasMaxLength(100)
                .HasColumnName("SchoolPTAStripeLiveAccountID");
            entity.Property(e => e.SchoolPtastripeLivePublishableKey)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeLivePublishableKey");
            entity.Property(e => e.SchoolPtastripeLiveRefreshToken)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeLiveRefreshToken");
            entity.Property(e => e.SchoolPtastripeLiveSecretKey)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeLiveSecretKey");
            entity.Property(e => e.SchoolPtastripeLiveUserId)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeLiveUserID");
            entity.Property(e => e.SchoolPtastripeTestPublishableKey)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeTestPublishableKey");
            entity.Property(e => e.SchoolPtastripeTestRefreshToken)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeTestRefreshToken");
            entity.Property(e => e.SchoolPtastripeTestSecretKey)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeTestSecretKey");
            entity.Property(e => e.SchoolPtastripeTestUserId)
                .HasMaxLength(1000)
                .HasColumnName("SchoolPTAStripeTestUserID");
            entity.Property(e => e.SchoolPtasubDomain)
                .HasMaxLength(100)
                .HasColumnName("SchoolPTASubDomain");
            entity.Property(e => e.SchoolPtatelephone1)
                .HasMaxLength(50)
                .HasColumnName("SchoolPTATelephone1");
            entity.Property(e => e.SchoolPtatitleFontFamily)
                .HasMaxLength(150)
                .HasDefaultValueSql("'Ubuntu'")
                .HasColumnName("SchoolPTATitleFontFamily");
            entity.Property(e => e.SchoolPtatwitter)
                .HasMaxLength(250)
                .HasColumnName("SchoolPTATwitter");
            entity.Property(e => e.SchoolPtatwitterWidget)
                .HasMaxLength(50)
                .HasColumnName("SchoolPTATwitterWidget");
            entity.Property(e => e.SchoolPtawebsite)
                .HasMaxLength(255)
                .HasColumnName("SchoolPTAWebsite");
            entity.Property(e => e.SchoolPupils).HasColumnType("int(11)");
            entity.Property(e => e.SchoolScanningStartDate).HasColumnType("timestamp");
            entity.Property(e => e.SchoolSliderType)
                .HasMaxLength(50)
                .HasDefaultValueSql("'Original'");
            entity.Property(e => e.SchoolSubscriptionPrice).HasPrecision(10, 2);
            entity.Property(e => e.SchoolSubscriptionStartDate).HasColumnType("timestamp");
            entity.Property(e => e.SchoolTermsDateSigned).HasColumnType("datetime");
            entity.Property(e => e.SchoolTermsSignedBy).HasColumnType("int(11)");
            entity.Property(e => e.SchoolTextColour).HasMaxLength(10);
            entity.Property(e => e.SchoolTown).HasMaxLength(100);
            entity.Property(e => e.SchoolUid)
                .HasMaxLength(15)
                .HasColumnName("SchoolUID");
            entity.Property(e => e.SchoolUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.SchoolUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.TimeZoneId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("TimeZoneID");

            entity.HasOne(school => school.OrganisationType)
                .WithMany(organisation => organisation.OrganisationType)
                .HasForeignKey(school => school.OrganisationTypeId)
                .IsRequired(false);
            entity.HasOne(school => school.PlanType)
                .WithMany(plantype => plantype.PlanType)
                .HasForeignKey(school => school.PlanTypeId)
                .IsRequired(false);
            entity.HasOne(school => school.CreatedBy)
                .WithMany(customer => customer.SchoolsCreated)
                .HasForeignKey(school => school.SchoolCreatedBy)
                .IsRequired(false);
            entity.HasOne(school => school.DpasignedBy)
                .WithMany(customer => customer.SchoolsDpasigned)
                .HasForeignKey(school => school.SchoolDpasignedBy)
                .IsRequired(false);
            entity.HasOne(school => school.Ptacountry)
                .WithMany(country => country.SchoolsPtacountry)
                .HasForeignKey(school => school.SchoolPtacountryId)
                .IsRequired(false);
           entity.HasOne(school => school.Ptacurrency)
                .WithMany(сurrency => сurrency.SchoolPtacurrency)
                .HasForeignKey(school => school.SchoolPtacurrencyId)
                .IsRequired(false);
            entity.HasOne(school => school.PtalotteryLicenceUploadedBy)
                .WithMany(customer => customer.SchoolsPtalotteryLicenceUploadedBy)
                .HasForeignKey(school => school.SchoolPtalotteryLicenceUploadedBy)
                .IsRequired(false);
            entity.HasOne(school => school.TermsSignedBy)
                .WithMany(customer => customer.SchoolsTermsSignedBy)
                .HasForeignKey(school => school.SchoolTermsSignedBy)
                .IsRequired(false);
            entity.HasOne(school => school.UpdatedBy)
                .WithMany(customer => customer.SchoolUpdatedBy)
                .HasForeignKey(school => school.SchoolUpdatedBy)
                .IsRequired(false);

            entity.HasMany(school => school.Application)
                .WithOne(customer => customer.Application)
                .HasForeignKey(customer => customer.ApplicationId)
                .IsRequired(false);
            entity.HasMany(school => school.CustomerSchool)
                .WithOne(customer => customer.CustomerSchool)
                .HasForeignKey(customer => customer.CustomerSchoolId)
                .IsRequired(false);
            entity.HasMany(school => school.ApiAuditHistoryApplication)
                .WithOne(apiAuditHistory => apiAuditHistory.Application)
                .HasForeignKey(apiAuditHistory => apiAuditHistory.ApplicationId)
                .IsRequired(false);
            entity.HasMany(school => school.AuditHistoryApplication)
                .WithOne(auditHistory => auditHistory.Application)
                .HasForeignKey(auditHistory => auditHistory.ApplicationId)
                .IsRequired(false);
            entity.HasMany(school => school.BankedBusinessSchool)
                .WithOne(bankedBusiness => bankedBusiness.School)
                .HasForeignKey(auditHistory => auditHistory.SchoolId)
                .IsRequired(false);
            entity.HasMany(school => school.BusinessDirectorySchool)
                .WithOne(businessDirectory => businessDirectory.School)
                .HasForeignKey(businessDirectory => businessDirectory.SchoolId)
                .IsRequired(false);
            entity.HasMany(school => school.BusinessDirectoryCategorySchool)
                .WithOne(businessDirectoryCategory => businessDirectoryCategory.School)
                .HasForeignKey(businessDirectoryCategory => businessDirectoryCategory.SchoolId)
                .IsRequired(false);
            entity.HasMany(school => school.BusinessDirectoryClickSchool)
                .WithOne(businessDirectoryClick => businessDirectoryClick.School)
                .HasForeignKey(businessDirectoryClick => businessDirectoryClick.SchoolId)
                .IsRequired(false);
            entity.HasMany(school => school.SchoolClass)
                .WithOne(classes => classes.School)
                .HasForeignKey(classes => classes.SchoolId)
                .IsRequired(false);
            entity.HasMany(school => school.DiscountSchool)
                .WithOne(discount => discount.School)
                .HasForeignKey(discount => discount.SchoolId)
                .IsRequired(false);
            entity.HasMany(school => school.EventSchool)
                .WithOne(events => events.School)
                .HasForeignKey(events => events.SchoolId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblSchoolYear>(entity =>
        {
            entity.HasKey(e => e.SchoolYearId).HasName("PRIMARY");

            entity.ToTable("tblSchoolYear");

            entity.Property(e => e.SchoolYearId)
                .HasColumnType("int(11)")
                .HasColumnName("SchoolYearID");
            //entity.Property(e => e.SchoolYearCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.SchoolYearCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.SchoolYearDeleted).HasColumnType("bit(1)");
            entity.Property(e => e.SchoolYearName).HasMaxLength(25);
            entity.Property(e => e.SchoolYearOrder).HasColumnType("int(11)");
            //entity.Property(e => e.SchoolYearUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.SchoolYearUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.SchoolYearCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.SchoolYearCreatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblSchoolYear.CreatedBy_tblCustomer");

            entity.HasOne(d => d.SchoolYearUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.SchoolYearUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblSchoolYear.UpdatedBy_tblCustomer");

            entity.HasMany(schoolYear => schoolYear.SchoolYearClass)
                .WithOne(casses => casses.SchoolYear)
                .HasForeignKey(casses => casses.SchoolYearId)
                .IsRequired(false);
        });

        modelBuilder.Entity<TblSponsor>(entity =>
        {
            entity.HasKey(e => e.SponsorId).HasName("PRIMARY");

            entity.ToTable("tblSponsor");

            entity.Property(e => e.SponsorId)
                .HasColumnType("int(11)")
                .HasColumnName("SponsorID");
            //entity.Property(e => e.CountryId)
            //    .HasDefaultValueSql("'1'")
            //    .HasColumnType("int(11)")
            //    .HasColumnName("CountryID");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");
            //entity.Property(e => e.SponsorCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.SponsorCreatedByDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.SponsorDescription).HasColumnType("text");
            entity.Property(e => e.SponsorDesktopAdvert).HasMaxLength(255);
            entity.Property(e => e.SponsorEmail).HasMaxLength(250);
            entity.Property(e => e.SponsorEndDate).HasColumnType("datetime");
            entity.Property(e => e.SponsorExcludeSites).HasMaxLength(2500);
            entity.Property(e => e.SponsorFacebook).HasMaxLength(255);
            entity.Property(e => e.SponsorIncludeSites).HasMaxLength(2500);
            entity.Property(e => e.SponsorInstagram).HasMaxLength(255);
            entity.Property(e => e.SponsorLogo).HasMaxLength(255);
            entity.Property(e => e.SponsorMobileAdvert).HasMaxLength(255);
            entity.Property(e => e.SponsorName).HasMaxLength(100);
            entity.Property(e => e.SponsorPinterest).HasMaxLength(255);
            entity.Property(e => e.SponsorPrice).HasPrecision(10);
            entity.Property(e => e.SponsorStartDate).HasColumnType("datetime");
            entity.Property(e => e.SponsorTelephone).HasMaxLength(50);
            entity.Property(e => e.SponsorText).HasMaxLength(500);
            entity.Property(e => e.SponsorTicketLogo).HasMaxLength(250);
            entity.Property(e => e.SponsorTwitter).HasMaxLength(255);
            entity.Property(e => e.SponsorTypeId)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(10)")
                .HasColumnName("SponsorTypeID");
            //entity.Property(e => e.SponsorUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.SponsorUpdatedDate).HasColumnType("timestamp");
            entity.Property(e => e.SponsorUrl)
                .HasMaxLength(255)
                .HasColumnName("SponsorURL");

            entity.HasOne(d => d.Country)
                .WithMany()
                //.HasForeignKey(d => d.Country)

                .HasConstraintName("FK_tblSponsor_tblCountry");

            entity.HasOne(d => d.School)
                .WithMany()
                //.HasForeignKey(d => d.School)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblSponsor_tblSchool");

            entity.HasOne(d => d.SponsorCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.SponsorCreatedBy)

                .HasConstraintName("FK_tblSponsor.CreatedBy_tblCustomer");

            entity.HasOne(d => d.SponsorUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.SponsorUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblSponsor.UpdatedBy_tblCustomer");


            entity.HasMany(sponsor => sponsor.EventSponsor)
                .WithOne(eventSponsor => eventSponsor.Sponsor)
                .HasForeignKey(eventSponsor => eventSponsor.SponsorId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblSponsorClick>(entity =>
        {
            entity.HasKey(e => e.SponsorClickId).HasName("PRIMARY");

            entity.ToTable("tblSponsorClick");

            //entity.HasIndex(e => e.SchoolId, "SchoolID");

            //entity.HasIndex(e => e.SponsorId, "SponsorID");

            entity.Property(e => e.SponsorClickId)
                .HasColumnType("int(11)")
                .HasColumnName("SponsorClickID");
            //entity.Property(e => e.CustomerId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("CustomerID");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(10)")
            //    .HasColumnName("SchoolID");
            entity.Property(e => e.SponsorClickDateTime)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.SponsorClickFrom).HasMaxLength(50);
            entity.Property(e => e.SponsorClickPage).HasMaxLength(50);
            entity.Property(e => e.SponsorClickUserAgent).HasMaxLength(1000);
            //entity.Property(e => e.SponsorId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SponsorID");

            entity.HasOne(d => d.Customer)
                .WithMany()
                //.HasForeignKey(d => d.Customer)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblSponsorClick_tblCustomer");

            entity.HasOne(d => d.School)
                .WithMany()
                //.HasForeignKey(d => d.School)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblSponsorClick_tblSchool");

            entity.HasOne(d => d.Sponsor)
                .WithMany()
                //.HasForeignKey(d => d.Sponsor)
                .HasConstraintName("FK_tblSponsorClick_tblSponsor");
        });

        modelBuilder.Entity<TblSponsorImpression>(entity =>
        {
            entity.HasKey(e => e.SponsorImpressionId).HasName("PRIMARY");

            entity.ToTable("tblSponsorImpression");

            //entity.HasIndex(e => e.SchoolId, "SchoolID");

            entity.HasIndex(e => new { e.SponsorImpressionId, e.SponsorImpressionUserAgent }, "SponsorImpressionIDUserAgent").HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 767 });

            entity.Property(e => e.SponsorImpressionId)
                .HasColumnType("int(11)")
                .HasColumnName("SponsorImpressionID");
            //entity.Property(e => e.CustomerId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("CustomerID");
            //entity.Property(e => e.SchoolId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SchoolID");
            //entity.Property(e => e.SponsorId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("SponsorID");
            entity.Property(e => e.SponsorImpressionCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.SponsorImpressionOrder).HasColumnType("int(11)");
            entity.Property(e => e.SponsorImpressionUserAgent).HasMaxLength(1000);

            entity.HasOne(d => d.Customer)
                .WithMany()
                //.HasForeignKey(d => d.Customer)

                .HasConstraintName("FK_tblSponsorImpression_tblCustomer");

            entity.HasOne(d => d.Sponsor)
                .WithMany()
                //.HasForeignKey(d => d.Sponsor)

                .HasConstraintName("FK_tblSponsorImpression_tblSponsor");

            entity.HasOne(d => d.School)
                .WithMany()
                //.HasForeignKey(d => d.School)
                .HasConstraintName("FK_tblSponsorImpression_tblSchool");

        });

        modelBuilder.Entity<TblStripeFee>(entity =>
        {
            entity.HasKey(e => e.StripeFeeId).HasName("PRIMARY");

            entity.ToTable("tblStripeFee");

            entity.HasIndex(e => e.StripeAccount, "StripeAccount");

            entity.HasIndex(e => e.StripeCharge, "StripeCharge");

            entity.HasIndex(e => e.StripeFee, "StripeFee");

            entity.HasIndex(e => e.StripeFeeType, "StripeFeeType");

            //entity.HasIndex(e => e.StripePayoutId, "StripePayoutID");

            entity.Property(e => e.StripeFeeId)
                .HasColumnType("int(11)")
                .HasColumnName("StripeFeeID");
            entity.Property(e => e.StripeAccount)
                .HasMaxLength(50)
                .HasDefaultValueSql("''");
            entity.Property(e => e.StripeCharge).HasMaxLength(50);
            entity.Property(e => e.StripeFee).HasMaxLength(50);
            entity.Property(e => e.StripeFeeAmount).HasPrecision(10, 2);
            entity.Property(e => e.StripeFeeCreatedDate).HasColumnType("timestamp");
            entity.Property(e => e.StripeFeeType).HasMaxLength(50);
            //entity.Property(e => e.StripePayoutId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("StripePayoutID");
            entity.HasOne(d => d.StripePayout)
                .WithMany()
                //.HasForeignKey(d => d.StripePayout)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblStripeFee_tblStripePayout");

        });

        modelBuilder.Entity<TblStripePayout>(entity =>
        {
            entity.HasKey(e => e.PayoutId).HasName("PRIMARY");

            entity.ToTable("tblStripePayout");

            entity.HasIndex(e => e.PayoutReference, "StripePayout");

            entity.Property(e => e.PayoutId)
                .HasColumnType("int(11)")
                .HasColumnName("PayoutID");
            entity.Property(e => e.PayoutAmount).HasPrecision(10, 2);
            entity.Property(e => e.PayoutBankReference).HasMaxLength(50);
            entity.Property(e => e.PayoutCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.PayoutFeeCount).HasColumnType("int(11)");
            entity.Property(e => e.PayoutInitiatedDate).HasColumnType("timestamp");
            entity.Property(e => e.PayoutPaidDate).HasColumnType("timestamp");
            entity.Property(e => e.PayoutReference).HasMaxLength(50);
            entity.Property(e => e.PayoutRefundCount).HasColumnType("int(11)");
            entity.Property(e => e.PayoutTypeId)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(11)")
                .HasColumnName("PayoutTypeID");
        });

        modelBuilder.Entity<TblStripeWebHook>(entity =>
        {
            entity.HasKey(e => e.StripeWebHookId).HasName("PRIMARY");

            entity.ToTable("tblStripeWebHook");

            //entity.HasIndex(e => e.OrderId, "OrderID");

            entity.HasIndex(e => e.StripeWebHookEventId, "StripeWebHookEventID");

            entity.HasIndex(e => e.StripeWebHookId, "StripeWebHookID");

            entity.HasIndex(e => e.StripeWebHookRequestId, "StripeWebHookRequestID");

            entity.Property(e => e.StripeWebHookId)
                .HasColumnType("int(11)")
                .HasColumnName("StripeWebHookID");
            //entity.Property(e => e.OrderId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("OrderID");
            entity.Property(e => e.StripeWebHookAccountId)
                .HasMaxLength(50)
                .HasColumnName("StripeWebHookAccountID");
            entity.Property(e => e.StripeWebHookCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.StripeWebHookEventId)
                .HasMaxLength(50)
                .HasColumnName("StripeWebHookEventID");
            entity.Property(e => e.StripeWebHookObjectStatus).HasMaxLength(50);
            entity.Property(e => e.StripeWebHookObjectType).HasMaxLength(50);
            entity.Property(e => e.StripeWebHookObjectTypeId)
                .HasMaxLength(50)
                .HasColumnName("StripeWebHookObjectTypeID");
            entity.Property(e => e.StripeWebHookRequestId)
                .HasMaxLength(50)
                .HasColumnName("StripeWebHookRequestID");

            entity.HasOne(d => d.Order)
                .WithMany()
                //.HasForeignKey(d => d.Order)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblStripeWebHook_tblOrder");
        });

        modelBuilder.Entity<TblSubGroup>(entity =>
        {
            entity.HasKey(e => e.SubGroupId).HasName("PRIMARY");

            entity.ToTable("tblSubGroup");

            entity.Property(e => e.SubGroupId)
                .HasColumnType("int(11)")
                .HasColumnName("SubGroupID");
            //entity.Property(e => e.EventId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("EventID");
            //entity.Property(e => e.SubGroupCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.SubGroupCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.SubGroupDescription).HasMaxLength(250);
            entity.Property(e => e.SubGroupImage).HasMaxLength(250);
            entity.Property(e => e.SubGroupName).HasMaxLength(50);
            //entity.Property(e => e.SubGroupUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.SubGroupUpdatedDate).HasColumnType("timestamp");


            entity.HasOne(d => d.Event)
                .WithMany()
                //.HasForeignKey(d => d.Event)

                .HasConstraintName("FK_tblSubGroup_tblEvent");

            entity.HasOne(d => d.SubGroupCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.SubGroupCreatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblSubGroup.CreatedBy_tblCustomer");

            entity.HasOne(d => d.SubGroupUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.SubGroupUpdatedBy)
                .HasConstraintName("FK_tblSubGroup.UpdatedBy_tblCustomer");
        });

        modelBuilder.Entity<TblTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PRIMARY");

            entity.ToTable("tblTicket");

            //entity.HasIndex(e => e.OrderItemId, "OrderItemID");

            entity.HasIndex(e => e.TicketDeleted, "TicketDeleted");

            entity.HasIndex(e => e.TicketHasQrcode, "TicketHasQRCode");

            entity.HasIndex(e => e.TicketNumber, "TicketNumber");

            entity.HasIndex(e => e.TicketQflowTicketId, "TicketQFlowTicketID");

            entity.Property(e => e.TicketId)
                .HasColumnType("int(11)")
                .HasColumnName("TicketID");
            //entity.Property(e => e.OrderItemId)
            //    .HasColumnType("int(11)")
            //    .HasColumnName("OrderItemID");
            //entity.Property(e => e.TicketCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.TicketCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.TicketDeleted)
                .HasDefaultValueSql("b'0'")
                .HasColumnType("bit(1)");
            entity.Property(e => e.TicketHasQrcode).HasColumnName("TicketHasQRCode");
            entity.Property(e => e.TicketNumber).HasMaxLength(12);
            entity.Property(e => e.TicketQflowScanDate)
                .HasColumnType("timestamp")
                .HasColumnName("TicketQFlowScanDate");
            entity.Property(e => e.TicketQflowTicketId)
                .HasMaxLength(50)
                .HasColumnName("TicketQFlowTicketID");
            //entity.Property(e => e.TicketUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.TicketUpdatedDate).HasColumnType("timestamp");

            entity.HasOne(d => d.OrderItem)
                .WithMany()
                //.HasForeignKey(d => d.OrderItem)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblTicket_tblOrder");

            entity.HasOne(d => d.TicketCreatedBy)
                .WithMany()
                //.HasForeignKey(d => d.TicketCreatedBy)

                .HasConstraintName("FK_tblTicket.CreatedBy_tblCustomer");

            entity.HasOne(d => d.TicketUpdatedBy)
                .WithMany()
                //.HasForeignKey(d => d.TicketUpdatedBy)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_tblTicket.UpdatedBy_tblCustomer");

            entity.HasMany(ticket => ticket.BookingTicket)
                .WithOne(booking => booking.Ticket)
                .HasForeignKey(booking => booking.TicketId)
                .IsRequired(false);

        });

        modelBuilder.Entity<TblTimeZone>(entity =>
        {
            entity.HasKey(e => e.TimeZoneId).HasName("PRIMARY");

            entity
                .ToTable("tblTimeZone")
                .HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            entity.Property(e => e.TimeZoneId)
                .HasColumnType("int(11)")
                .HasColumnName("TimeZoneID");
            entity.Property(e => e.TimeZoneDateFormat).HasMaxLength(20);
            entity.Property(e => e.TimeZoneDescription).HasMaxLength(200);
            entity.Property(e => e.TimeZoneName).HasMaxLength(100);
            entity.Property(e => e.TimeZoneOffset).HasPrecision(10, 2);
        });

        modelBuilder.Entity<TblTranslation>(entity =>
        {
            entity.HasKey(e => e.TranslationId).HasName("PRIMARY");

            entity.ToTable("tblTranslation");

            entity.Property(e => e.TranslationId)
                .HasColumnType("int(11)")
                .HasColumnName("TranslationID");
            entity.Property(e => e.ApplicationId)
                .HasColumnType("int(11)")
                .HasColumnName("ApplicationID");
            entity.Property(e => e.ComponentId)
                .HasColumnType("int(11)")
                .HasColumnName("ComponentID");
            entity.Property(e => e.LanguageId)
                .HasColumnType("int(11)")
                .HasColumnName("LanguageID");
            entity.Property(e => e.TranslationContent).HasColumnType("text");
            entity.Property(e => e.TranslationCreatedBy).HasColumnType("int(11)");
            entity.Property(e => e.TranslationCreatedDate)
                .HasDefaultValueSql("current_timestamp()")
                .HasColumnType("timestamp");
            entity.Property(e => e.TranslationUpdatedBy).HasColumnType("int(11)");
            entity.Property(e => e.TranslationUpdatedDate).HasColumnType("timestamp");
        });

        modelBuilder.Entity<VersionInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VersionInfo");

            entity.HasIndex(e => e.Version, "UC_Version").IsUnique();

            entity.Property(e => e.AppliedOn).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(1024)
                .UseCollation("utf8_general_ci")
                .HasCharSet("utf8");
            entity.Property(e => e.Version).HasColumnType("bigint(20)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
