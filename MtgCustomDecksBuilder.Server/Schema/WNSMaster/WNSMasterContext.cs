using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WNSMasterContext : DbContext
    {
        public WNSMasterContext()
        {
        }

        public WNSMasterContext(DbContextOptions<WNSMasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountingSale> AccountingSales { get; set; } = null!;
        public virtual DbSet<AccountingSalesCogsDetail> AccountingSalesCogsDetails { get; set; } = null!;
        public virtual DbSet<AccountingTaxId> AccountingTaxIds { get; set; } = null!;
        public virtual DbSet<AdminsPiecework> AdminsPieceworks { get; set; } = null!;
        public virtual DbSet<AdminsPieceworkLog> AdminsPieceworkLogs { get; set; } = null!;
        public virtual DbSet<AdminsProvider> AdminsProviders { get; set; } = null!;
        public virtual DbSet<AdminsProviderCommission> AdminsProviderCommissions { get; set; } = null!;
        public virtual DbSet<AdminsProviderWarehouseAssignment> AdminsProviderWarehouseAssignments { get; set; } = null!;
        public virtual DbSet<AdminsStorefront> AdminsStorefronts { get; set; } = null!;
        public virtual DbSet<AdminsStorefrontsAdminPermission> AdminsStorefrontsAdminPermissions { get; set; } = null!;
        public virtual DbSet<AdminsStorefrontsPermission> AdminsStorefrontsPermissions { get; set; } = null!;
        public virtual DbSet<AdminsTimeClock> AdminsTimeClocks { get; set; } = null!;
        public virtual DbSet<Affiliate> Affiliates { get; set; } = null!;
        public virtual DbSet<AffiliatesCampaign> AffiliatesCampaigns { get; set; } = null!;
        public virtual DbSet<AffiliatesCommissionOverride> AffiliatesCommissionOverrides { get; set; } = null!;
        public virtual DbSet<AffiliatesPayment> AffiliatesPayments { get; set; } = null!;
        public virtual DbSet<AffiliatesRecommendedCart> AffiliatesRecommendedCarts { get; set; } = null!;
        public virtual DbSet<AffiliatesRecommendedCartsProd> AffiliatesRecommendedCartsProds { get; set; } = null!;
        public virtual DbSet<AffiliatesStatus> AffiliatesStatuses { get; set; } = null!;
        public virtual DbSet<AffiliatesTransaction> AffiliatesTransactions { get; set; } = null!;
        public virtual DbSet<AffiliatesTransactionsAction> AffiliatesTransactionsActions { get; set; } = null!;
        public virtual DbSet<AffiliatesTransactionsStatus> AffiliatesTransactionsStatuses { get; set; } = null!;
        public virtual DbSet<AlturaShipInfo> AlturaShipInfos { get; set; } = null!;
        public virtual DbSet<AmazonFbaInboundShipmentPlan> AmazonFbaInboundShipmentPlans { get; set; } = null!;
        public virtual DbSet<AmazonFbaInboundShipmentPlanItem> AmazonFbaInboundShipmentPlanItems { get; set; } = null!;
        public virtual DbSet<AmazonFeedsProcess> AmazonFeedsProcesses { get; set; } = null!;
        public virtual DbSet<AmazonProcessCategory> AmazonProcessCategories { get; set; } = null!;
        public virtual DbSet<AmazonProcessType> AmazonProcessTypes { get; set; } = null!;
        public virtual DbSet<AmazonSettlementReport> AmazonSettlementReports { get; set; } = null!;
        public virtual DbSet<Aporderdetail> Aporderdetails { get; set; } = null!;
        public virtual DbSet<AuthNetCommLog> AuthNetCommLogs { get; set; } = null!;
        public virtual DbSet<AutoGenReport> AutoGenReports { get; set; } = null!;
        public virtual DbSet<AutoGenReportsAbandonCartsProcess> AutoGenReportsAbandonCartsProcesses { get; set; } = null!;
        public virtual DbSet<AutoGenReportsAlturaPriceSpPrice> AutoGenReportsAlturaPriceSpPrices { get; set; } = null!;
        public virtual DbSet<AutoGenReportsDtsPackageOlap> AutoGenReportsDtsPackageOlaps { get; set; } = null!;
        public virtual DbSet<AutoGenReportsOrdersChannelsCountDaily> AutoGenReportsOrdersChannelsCountDailies { get; set; } = null!;
        public virtual DbSet<AutoGenReportsOrdersShipNetChargeShipAmount> AutoGenReportsOrdersShipNetChargeShipAmounts { get; set; } = null!;
        public virtual DbSet<AutoGenReportsOrdersUnitCostSfPrice> AutoGenReportsOrdersUnitCostSfPrices { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductPopularityScoresUpdated> AutoGenReportsProductPopularityScoresUpdateds { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductsDetail> AutoGenReportsProductsDetails { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductsDetailsCostDetail> AutoGenReportsProductsDetailsCostDetails { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductsFeedsResult> AutoGenReportsProductsFeedsResults { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductsNotShownToAllSf> AutoGenReportsProductsNotShownToAllSfs { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductsNotShownToSf> AutoGenReportsProductsNotShownToSfs { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductsOver6Month> AutoGenReportsProductsOver6Months { get; set; } = null!;
        public virtual DbSet<AutoGenReportsProductsTotal> AutoGenReportsProductsTotals { get; set; } = null!;
        public virtual DbSet<AutoGenReportsRefillReminder> AutoGenReportsRefillReminders { get; set; } = null!;
        public virtual DbSet<AutoGenReportsScriptGroupsPricing> AutoGenReportsScriptGroupsPricings { get; set; } = null!;
        public virtual DbSet<AutoGenReportsScriptMakeAshWsAlturaW> AutoGenReportsScriptMakeAshWsAlturaWs { get; set; } = null!;
        public virtual DbSet<AutoGenReportsSpPricePublicPrice> AutoGenReportsSpPricePublicPrices { get; set; } = null!;
        public virtual DbSet<AutoGenReportsUnsuccessfulAlturaCpLogin> AutoGenReportsUnsuccessfulAlturaCpLogins { get; set; } = null!;
        public virtual DbSet<AutoGenReportsUnsuccessfulPublicSiteLogin> AutoGenReportsUnsuccessfulPublicSiteLogins { get; set; } = null!;
        public virtual DbSet<AutoGenReportsUnsuccessfulStorefrontCpLogin> AutoGenReportsUnsuccessfulStorefrontCpLogins { get; set; } = null!;
        public virtual DbSet<Bin> Bins { get; set; } = null!;
        public virtual DbSet<BinProdRelationship> BinProdRelationships { get; set; } = null!;
        public virtual DbSet<BinsFilterTemp> BinsFilterTemps { get; set; } = null!;
        public virtual DbSet<BinsSortIndex> BinsSortIndices { get; set; } = null!;
        public virtual DbSet<CarrierRate> CarrierRates { get; set; } = null!;
        public virtual DbSet<CarrierRatePeriod> CarrierRatePeriods { get; set; } = null!;
        public virtual DbSet<CarriersAndClass> CarriersAndClasses { get; set; } = null!;
        public virtual DbSet<Cart> Carts { get; set; } = null!;
        public virtual DbSet<CartsGiftCertificate> CartsGiftCertificates { get; set; } = null!;
        public virtual DbSet<CartsLineItem> CartsLineItems { get; set; } = null!;
        public virtual DbSet<CartsProductView> CartsProductViews { get; set; } = null!;
        public virtual DbSet<CartsReplenishment> CartsReplenishments { get; set; } = null!;
        public virtual DbSet<CartsStorefrontOrder> CartsStorefrontOrders { get; set; } = null!;
        public virtual DbSet<CartsStorefrontOrdersGiftCertificate> CartsStorefrontOrdersGiftCertificates { get; set; } = null!;
        public virtual DbSet<CartsViewedProduct> CartsViewedProducts { get; set; } = null!;
        public virtual DbSet<CartsWholesaleOrder> CartsWholesaleOrders { get; set; } = null!;
        public virtual DbSet<ChargeBridgeCommLog> ChargeBridgeCommLogs { get; set; } = null!;
        public virtual DbSet<CopyOfHealthZoneUkMatch> CopyOfHealthZoneUkMatches { get; set; } = null!;
        public virtual DbSet<Coupon> Coupons { get; set; } = null!;
        public virtual DbSet<CouponsProdAddToCart> CouponsProdAddToCarts { get; set; } = null!;
        public virtual DbSet<CouponsProdGroup> CouponsProdGroups { get; set; } = null!;
        public virtual DbSet<CouponsProdGroupsType> CouponsProdGroupsTypes { get; set; } = null!;
        public virtual DbSet<Culture> Cultures { get; set; } = null!;
        public virtual DbSet<CurrenciesExchangeRate> CurrenciesExchangeRates { get; set; } = null!;
        public virtual DbSet<Currency> Currencies { get; set; } = null!;
        public virtual DbSet<DeptsDepartment> DeptsDepartments { get; set; } = null!;
        public virtual DbSet<DeptsSpellingVariation> DeptsSpellingVariations { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailManifest> DhlGlobalMailManifests { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailRatesPacketPriorityDdu> DhlGlobalMailRatesPacketPriorityDdus { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailRatesParcelPriority> DhlGlobalMailRatesParcelPriorities { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailRatesParcelPriorityDdu> DhlGlobalMailRatesParcelPriorityDdus { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailRatesParcelPriorityV2> DhlGlobalMailRatesParcelPriorityV2s { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailRatesPeriod> DhlGlobalMailRatesPeriods { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailShipment> DhlGlobalMailShipments { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailShippingSetting> DhlGlobalMailShippingSettings { get; set; } = null!;
        public virtual DbSet<DhlGlobalMailZone> DhlGlobalMailZones { get; set; } = null!;
        public virtual DbSet<DhlRatesParcelPlusExpedited> DhlRatesParcelPlusExpediteds { get; set; } = null!;
        public virtual DbSet<DhlRatesParcelPlusGround> DhlRatesParcelPlusGrounds { get; set; } = null!;
        public virtual DbSet<DhlRatesPeriod> DhlRatesPeriods { get; set; } = null!;
        public virtual DbSet<DhlRatesSmartMailExpedited> DhlRatesSmartMailExpediteds { get; set; } = null!;
        public virtual DbSet<DhlRatesSmartMailGround> DhlRatesSmartMailGrounds { get; set; } = null!;
        public virtual DbSet<DhlShippingSetting> DhlShippingSettings { get; set; } = null!;
        public virtual DbSet<EBayLmsJob> EBayLmsJobs { get; set; } = null!;
        public virtual DbSet<EBayOrder> EBayOrders { get; set; } = null!;
        public virtual DbSet<EBayOrderLine> EBayOrderLines { get; set; } = null!;
        public virtual DbSet<EBayPayout> EBayPayouts { get; set; } = null!;
        public virtual DbSet<EBayPayoutTransaction> EBayPayoutTransactions { get; set; } = null!;
        public virtual DbSet<EBayPayoutTransactionLine> EBayPayoutTransactionLines { get; set; } = null!;
        public virtual DbSet<EancGroundGuide201210> EancGroundGuide201210s { get; set; } = null!;
        public virtual DbSet<EcmsManifest> EcmsManifests { get; set; } = null!;
        public virtual DbSet<EcmsShipment> EcmsShipments { get; set; } = null!;
        public virtual DbSet<EmailBounceLog> EmailBounceLogs { get; set; } = null!;
        public virtual DbSet<EmailProviderAction> EmailProviderActions { get; set; } = null!;
        public virtual DbSet<EmailProviderActionType> EmailProviderActionTypes { get; set; } = null!;
        public virtual DbSet<EmailSendingAccount> EmailSendingAccounts { get; set; } = null!;
        public virtual DbSet<FedExCafeLookuptable> FedExCafeLookuptables { get; set; } = null!;
        public virtual DbSet<FedexFimsManifest> FedexFimsManifests { get; set; } = null!;
        public virtual DbSet<FedexFimsPrmFuelSurcharge> FedexFimsPrmFuelSurcharges { get; set; } = null!;
        public virtual DbSet<FedexFimsPrmRatesOverride> FedexFimsPrmRatesOverrides { get; set; } = null!;
        public virtual DbSet<FedexFimsPrmRatesPeriod> FedexFimsPrmRatesPeriods { get; set; } = null!;
        public virtual DbSet<FedexFimsShipment> FedexFimsShipments { get; set; } = null!;
        public virtual DbSet<FedexFimsShippingSetting> FedexFimsShippingSettings { get; set; } = null!;
        public virtual DbSet<FedexFimsStdFuelSurcharge> FedexFimsStdFuelSurcharges { get; set; } = null!;
        public virtual DbSet<FedexFimsStdRatesOverride> FedexFimsStdRatesOverrides { get; set; } = null!;
        public virtual DbSet<FedexFimsStdRatesPeriod> FedexFimsStdRatesPeriods { get; set; } = null!;
        public virtual DbSet<FedexShippingSetting> FedexShippingSettings { get; set; } = null!;
        public virtual DbSet<FedexStatusCode> FedexStatusCodes { get; set; } = null!;
        public virtual DbSet<Gbk> Gbks { get; set; } = null!;
        public virtual DbSet<GbksTemp> GbksTemps { get; set; } = null!;
        public virtual DbSet<Gbp> Gbps { get; set; } = null!;
        public virtual DbSet<GbpsTemp> GbpsTemps { get; set; } = null!;
        public virtual DbSet<GiftCertificate> GiftCertificates { get; set; } = null!;
        public virtual DbSet<GiftCertificatesCampaign> GiftCertificatesCampaigns { get; set; } = null!;
        public virtual DbSet<GiftCertificatesRedemption> GiftCertificatesRedemptions { get; set; } = null!;
        public virtual DbSet<GiftCertificatesRestriction> GiftCertificatesRestrictions { get; set; } = null!;
        public virtual DbSet<GoogleExclusions2> GoogleExclusions2s { get; set; } = null!;
        public virtual DbSet<GoogleShoppingOrder> GoogleShoppingOrders { get; set; } = null!;
        public virtual DbSet<GoogleShoppingOrderLine> GoogleShoppingOrderLines { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<GrouponOrderLine> GrouponOrderLines { get; set; } = null!;
        public virtual DbSet<GrouponOrdersFile> GrouponOrdersFiles { get; set; } = null!;
        public virtual DbSet<GrouponSetting> GrouponSettings { get; set; } = null!;
        public virtual DbSet<GrouponTrackingFile> GrouponTrackingFiles { get; set; } = null!;
        public virtual DbSet<GroupsDiscountsBrand> GroupsDiscountsBrands { get; set; } = null!;
        public virtual DbSet<GroupsDiscountsProdOverride> GroupsDiscountsProdOverrides { get; set; } = null!;
        public virtual DbSet<GsoExtendedAreaZipCode> GsoExtendedAreaZipCodes { get; set; } = null!;
        public virtual DbSet<GsoRate> GsoRates { get; set; } = null!;
        public virtual DbSet<GsoRatesPeriod> GsoRatesPeriods { get; set; } = null!;
        public virtual DbSet<GsoShippingSetting> GsoShippingSettings { get; set; } = null!;
        public virtual DbSet<GsoZipCode> GsoZipCodes { get; set; } = null!;
        public virtual DbSet<GsoZipCodesOriginal> GsoZipCodesOriginals { get; set; } = null!;
        public virtual DbSet<HeartbeatPrimaryAgent> HeartbeatPrimaryAgents { get; set; } = null!;
        public virtual DbSet<HeartbeatUrl> HeartbeatUrls { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<ImgGen> ImgGens { get; set; } = null!;
        public virtual DbSet<InterProviderBillingClass> InterProviderBillingClasses { get; set; } = null!;
        public virtual DbSet<InterProviderBillingInvoice> InterProviderBillingInvoices { get; set; } = null!;
        public virtual DbSet<InterProviderBillingPayment> InterProviderBillingPayments { get; set; } = null!;
        public virtual DbSet<InterProviderBillingPaymentToInvoiceRelationship> InterProviderBillingPaymentToInvoiceRelationships { get; set; } = null!;
        public virtual DbSet<InterProviderBillingTransaction> InterProviderBillingTransactions { get; set; } = null!;
        public virtual DbSet<InventoryAdjustment> InventoryAdjustments { get; set; } = null!;
        public virtual DbSet<InventoryLog> InventoryLogs { get; set; } = null!;
        public virtual DbSet<IterableActionObsolete> IterableActionObsoletes { get; set; } = null!;
        public virtual DbSet<IterableActionTypeObsolete> IterableActionTypeObsoletes { get; set; } = null!;
        public virtual DbSet<IterableSetting> IterableSettings { get; set; } = null!;
        public virtual DbSet<JetFileUpload> JetFileUploads { get; set; } = null!;
        public virtual DbSet<JetMerchantSkusAvailable> JetMerchantSkusAvailables { get; set; } = null!;
        public virtual DbSet<JetOrder> JetOrders { get; set; } = null!;
        public virtual DbSet<JetOrderLine> JetOrderLines { get; set; } = null!;
        public virtual DbSet<JetOrderLineFeeAdjustment> JetOrderLineFeeAdjustments { get; set; } = null!;
        public virtual DbSet<JetProductMissingDatum> JetProductMissingData { get; set; } = null!;
        public virtual DbSet<JetReturn> JetReturns { get; set; } = null!;
        public virtual DbSet<JetReturnLine> JetReturnLines { get; set; } = null!;
        public virtual DbSet<JetSetting> JetSettings { get; set; } = null!;
        public virtual DbSet<JetSettlement> JetSettlements { get; set; } = null!;
        public virtual DbSet<JetSettlementOrder> JetSettlementOrders { get; set; } = null!;
        public virtual DbSet<JetSettlementOrderItem> JetSettlementOrderItems { get; set; } = null!;
        public virtual DbSet<JetSettlementReturn> JetSettlementReturns { get; set; } = null!;
        public virtual DbSet<JetSettlementReturnItem> JetSettlementReturnItems { get; set; } = null!;
        public virtual DbSet<KeywordsSpellingVariation> KeywordsSpellingVariations { get; set; } = null!;
        public virtual DbSet<KeywordsStandard> KeywordsStandards { get; set; } = null!;
        public virtual DbSet<LandmarkGlobalManifest> LandmarkGlobalManifests { get; set; } = null!;
        public virtual DbSet<LandmarkGlobalShipment> LandmarkGlobalShipments { get; set; } = null!;
        public virtual DbSet<LandmarkGlobalShippingSetting> LandmarkGlobalShippingSettings { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<LaserShipRate> LaserShipRates { get; set; } = null!;
        public virtual DbSet<LaserShipRatesPeriod> LaserShipRatesPeriods { get; set; } = null!;
        public virtual DbSet<LaserShipShippingSetting> LaserShipShippingSettings { get; set; } = null!;
        public virtual DbSet<LaserShipZipCode> LaserShipZipCodes { get; set; } = null!;
        public virtual DbSet<LegitScriptResultProductMatch> LegitScriptResultProductMatches { get; set; } = null!;
        public virtual DbSet<LinkShareTransaction> LinkShareTransactions { get; set; } = null!;
        public virtual DbSet<LinkShareTransactionsStatus> LinkShareTransactionsStatuses { get; set; } = null!;
        public virtual DbSet<MailExpressClass> MailExpressClasses { get; set; } = null!;
        public virtual DbSet<MailExpressRatesParcelSelect> MailExpressRatesParcelSelects { get; set; } = null!;
        public virtual DbSet<MailExpressRatesPeriod> MailExpressRatesPeriods { get; set; } = null!;
        public virtual DbSet<MailExpressRatesPresortedStd> MailExpressRatesPresortedStds { get; set; } = null!;
        public virtual DbSet<MailExpressShippingSetting> MailExpressShippingSettings { get; set; } = null!;
        public virtual DbSet<MailExpressSortCode> MailExpressSortCodes { get; set; } = null!;
        public virtual DbSet<MailExpressSortCodePeriod> MailExpressSortCodePeriods { get; set; } = null!;
        public virtual DbSet<MailExpressTrackingEvent> MailExpressTrackingEvents { get; set; } = null!;
        public virtual DbSet<MailExpressTrackingEventCode> MailExpressTrackingEventCodes { get; set; } = null!;
        public virtual DbSet<MailExpressTrackingImport> MailExpressTrackingImports { get; set; } = null!;
        public virtual DbSet<MarketingDealOfTheDay> MarketingDealOfTheDays { get; set; } = null!;
        public virtual DbSet<MarketingDealOfTheDayProd> MarketingDealOfTheDayProds { get; set; } = null!;
        public virtual DbSet<MarketingEmailCampaign> MarketingEmailCampaigns { get; set; } = null!;
        public virtual DbSet<MarketingEmailLink> MarketingEmailLinks { get; set; } = null!;
        public virtual DbSet<MarketingEmailsIterableStaging> MarketingEmailsIterableStagings { get; set; } = null!;
        public virtual DbSet<MarketingEmailsMetadatum> MarketingEmailsMetadata { get; set; } = null!;
        public virtual DbSet<MarketingEmailsSerial> MarketingEmailsSerials { get; set; } = null!;
        public virtual DbSet<MarketingEmailsTemplateDatum> MarketingEmailsTemplateData { get; set; } = null!;
        public virtual DbSet<MarketingPreference> MarketingPreferences { get; set; } = null!;
        public virtual DbSet<MetatagsBrand> MetatagsBrands { get; set; } = null!;
        public virtual DbSet<MetatagsDept> MetatagsDepts { get; set; } = null!;
        public virtual DbSet<MetatagsFam> MetatagsFams { get; set; } = null!;
        public virtual DbSet<MetatagsFamsOverride> MetatagsFamsOverrides { get; set; } = null!;
        public virtual DbSet<MetatagsKeyword> MetatagsKeywords { get; set; } = null!;
        public virtual DbSet<NackOrder> NackOrders { get; set; } = null!;
        public virtual DbSet<NackPriceControl> NackPriceControls { get; set; } = null!;
        public virtual DbSet<NackStorefront> NackStorefronts { get; set; } = null!;
        public virtual DbSet<NgsFee> NgsFees { get; set; } = null!;
        public virtual DbSet<NgsManifest> NgsManifests { get; set; } = null!;
        public virtual DbSet<NgsRatesParcelSelectObsolete> NgsRatesParcelSelectObsoletes { get; set; } = null!;
        public virtual DbSet<NgsRatesPeriod> NgsRatesPeriods { get; set; } = null!;
        public virtual DbSet<NgsRatesStandardMailParcel> NgsRatesStandardMailParcels { get; set; } = null!;
        public virtual DbSet<NgsShipment> NgsShipments { get; set; } = null!;
        public virtual DbSet<NgsShippingSetting> NgsShippingSettings { get; set; } = null!;
        public virtual DbSet<NgsTransitTime> NgsTransitTimes { get; set; } = null!;
        public virtual DbSet<NorcoShippingSetting> NorcoShippingSettings { get; set; } = null!;
        public virtual DbSet<NorcoZipCode> NorcoZipCodes { get; set; } = null!;
        public virtual DbSet<NorcoZipCodes20150113> NorcoZipCodes20150113s { get; set; } = null!;
        public virtual DbSet<ObsoleteContent> ObsoleteContents { get; set; } = null!;
        public virtual DbSet<OnTracShippingSetting> OnTracShippingSettings { get; set; } = null!;
        public virtual DbSet<OnTracZipCode> OnTracZipCodes { get; set; } = null!;
        public virtual DbSet<OnTracZipCodesInfo> OnTracZipCodesInfos { get; set; } = null!;
        public virtual DbSet<OnTracZipCodesNew> OnTracZipCodesNews { get; set; } = null!;
        public virtual DbSet<OnTracZipCodesOld> OnTracZipCodesOlds { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrdersAction> OrdersActions { get; set; } = null!;
        public virtual DbSet<OrdersActionsLog> OrdersActionsLogs { get; set; } = null!;
        public virtual DbSet<OrdersAmazonFulfillment> OrdersAmazonFulfillments { get; set; } = null!;
        public virtual DbSet<OrdersAutoCaptureCondition> OrdersAutoCaptureConditions { get; set; } = null!;
        public virtual DbSet<OrdersAutoCaptureUserAccount> OrdersAutoCaptureUserAccounts { get; set; } = null!;
        public virtual DbSet<OrdersBatchesPrinting> OrdersBatchesPrintings { get; set; } = null!;
        public virtual DbSet<OrdersBlacklist> OrdersBlacklists { get; set; } = null!;
        public virtual DbSet<OrdersLineItem> OrdersLineItems { get; set; } = null!;
        public virtual DbSet<OrdersMass119Info> OrdersMass119Infos { get; set; } = null!;
        public virtual DbSet<OrdersMass119InfoStaging> OrdersMass119InfoStagings { get; set; } = null!;
        public virtual DbSet<OrdersNote> OrdersNotes { get; set; } = null!;
        public virtual DbSet<OrdersNotesType> OrdersNotesTypes { get; set; } = null!;
        public virtual DbSet<OrdersPlacedTask> OrdersPlacedTasks { get; set; } = null!;
        public virtual DbSet<OrdersPlacedTaskType> OrdersPlacedTaskTypes { get; set; } = null!;
        public virtual DbSet<OrdersPreliminaryShippingDataUp> OrdersPreliminaryShippingDataUps { get; set; } = null!;
        public virtual DbSet<OrdersProvider> OrdersProviders { get; set; } = null!;
        public virtual DbSet<OrdersProviderConsumerPaymentsAndCredit> OrdersProviderConsumerPaymentsAndCredits { get; set; } = null!;
        public virtual DbSet<OrdersProviderDropshippingIgnoreBilling> OrdersProviderDropshippingIgnoreBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderDropshippingInvoice> OrdersProviderDropshippingInvoices { get; set; } = null!;
        public virtual DbSet<OrdersProviderDropshippingPayment> OrdersProviderDropshippingPayments { get; set; } = null!;
        public virtual DbSet<OrdersProviderDropshippingPaymentToInvoiceRelationship> OrdersProviderDropshippingPaymentToInvoiceRelationships { get; set; } = null!;
        public virtual DbSet<OrdersProviderDropshippingTransaction> OrdersProviderDropshippingTransactions { get; set; } = null!;
        public virtual DbSet<OrdersProviderDropshippingTransactionsArchive> OrdersProviderDropshippingTransactionsArchives { get; set; } = null!;
        public virtual DbSet<OrdersProviderDropshippingTransactionsClass> OrdersProviderDropshippingTransactionsClasses { get; set; } = null!;
        public virtual DbSet<OrdersProviderExtension> OrdersProviderExtensions { get; set; } = null!;
        public virtual DbSet<OrdersProviderKountRisresult> OrdersProviderKountRisresults { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItem> OrdersProviderLineItems { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsAmazon> OrdersProviderLineItemsAmazons { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsCalculatedCostMethodsLegend> OrdersProviderLineItemsCalculatedCostMethodsLegends { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsInventoryAllocation> OrdersProviderLineItemsInventoryAllocations { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsOutOfStock> OrdersProviderLineItemsOutOfStocks { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsShipment> OrdersProviderLineItemsShipments { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsTax> OrdersProviderLineItemsTaxes { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsTaxShipping> OrdersProviderLineItemsTaxShippings { get; set; } = null!;
        public virtual DbSet<OrdersProviderLineItemsTempVelocity> OrdersProviderLineItemsTempVelocities { get; set; } = null!;
        public virtual DbSet<OrdersProviderMaxMindFraudResult> OrdersProviderMaxMindFraudResults { get; set; } = null!;
        public virtual DbSet<OrdersProviderPrintedOutputType> OrdersProviderPrintedOutputTypes { get; set; } = null!;
        public virtual DbSet<OrdersProviderProcessingType> OrdersProviderProcessingTypes { get; set; } = null!;
        public virtual DbSet<OrdersProviderSampleLineItem> OrdersProviderSampleLineItems { get; set; } = null!;
        public virtual DbSet<OrdersProviderShipping> OrdersProviderShippings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingBoxSuggestionsGroup> OrdersProviderShippingBoxSuggestionsGroups { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingBoxSuggestionsSuggestGroup> OrdersProviderShippingBoxSuggestionsSuggestGroups { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingBoxSuggestionsV3> OrdersProviderShippingBoxSuggestionsV3s { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingClaim> OrdersProviderShippingClaims { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingClaimsNote> OrdersProviderShippingClaimsNotes { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingClaimsReason> OrdersProviderShippingClaimsReasons { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingClaimsStatus> OrdersProviderShippingClaimsStatuses { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingDhlexpressBilling> OrdersProviderShippingDhlexpressBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingDhlexpressBillingImport> OrdersProviderShippingDhlexpressBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingDhlglobalMailBilling> OrdersProviderShippingDhlglobalMailBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingDhlglobalMailBillingImport> OrdersProviderShippingDhlglobalMailBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingEcmsBilling> OrdersProviderShippingEcmsBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingEcmsBillingImport> OrdersProviderShippingEcmsBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingFedexActivity> OrdersProviderShippingFedexActivities { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingFedexBilling> OrdersProviderShippingFedexBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingFedexBillingCharge> OrdersProviderShippingFedexBillingCharges { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingGsoBilling> OrdersProviderShippingGsoBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingGsoBillingAdjustment> OrdersProviderShippingGsoBillingAdjustments { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingGsoBillingImport> OrdersProviderShippingGsoBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingLaserShipBilling> OrdersProviderShippingLaserShipBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingLaserShipBillingImport> OrdersProviderShippingLaserShipBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingMailExpressBilling> OrdersProviderShippingMailExpressBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingMailExpressBillingImport> OrdersProviderShippingMailExpressBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingMiscCarriersBilling> OrdersProviderShippingMiscCarriersBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingNewgisticsActivity> OrdersProviderShippingNewgisticsActivities { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingNewgisticsBilling> OrdersProviderShippingNewgisticsBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingNewgisticsBillingImport> OrdersProviderShippingNewgisticsBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingNorcoBilling> OrdersProviderShippingNorcoBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingNorcoBillingImport> OrdersProviderShippingNorcoBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingOnTracBilling> OrdersProviderShippingOnTracBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingOnTracBillingImport> OrdersProviderShippingOnTracBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingProcessType> OrdersProviderShippingProcessTypes { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingSagawaBilling> OrdersProviderShippingSagawaBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingSagawaBillingImport> OrdersProviderShippingSagawaBillingImports { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingUpsActivity> OrdersProviderShippingUpsActivities { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingUpsBilling> OrdersProviderShippingUpsBillings { get; set; } = null!;
        public virtual DbSet<OrdersProviderShippingUspsActivity> OrdersProviderShippingUspsActivities { get; set; } = null!;
        public virtual DbSet<OrdersProviderThirdPartyBillingUp> OrdersProviderThirdPartyBillingUps { get; set; } = null!;
        public virtual DbSet<OrdersProviderWholesalePayment> OrdersProviderWholesalePayments { get; set; } = null!;
        public virtual DbSet<OrdersProviderWholesalePaymentsCreditMemoLineItem> OrdersProviderWholesalePaymentsCreditMemoLineItems { get; set; } = null!;
        public virtual DbSet<OrdersProviderWholesalePaymentsPaymentToOrderRelationship> OrdersProviderWholesalePaymentsPaymentToOrderRelationships { get; set; } = null!;
        public virtual DbSet<OrdersProviderWholesalePaymentsTest> OrdersProviderWholesalePaymentsTests { get; set; } = null!;
        public virtual DbSet<OrdersRefillRemindersStatus> OrdersRefillRemindersStatuses { get; set; } = null!;
        public virtual DbSet<OrdersRefillRemindersV2> OrdersRefillRemindersV2s { get; set; } = null!;
        public virtual DbSet<OrdersReturnBatch> OrdersReturnBatches { get; set; } = null!;
        public virtual DbSet<OrdersReturnBatchesLineItem> OrdersReturnBatchesLineItems { get; set; } = null!;
        public virtual DbSet<OrdersReturnRequest> OrdersReturnRequests { get; set; } = null!;
        public virtual DbSet<OrdersReturnRequestLine> OrdersReturnRequestLines { get; set; } = null!;
        public virtual DbSet<OrdersReturnRequestReason> OrdersReturnRequestReasons { get; set; } = null!;
        public virtual DbSet<OrdersShopDotComFulfillment> OrdersShopDotComFulfillments { get; set; } = null!;
        public virtual DbSet<OrdersSource> OrdersSources { get; set; } = null!;
        public virtual DbSet<PayPalSetting> PayPalSettings { get; set; } = null!;
        public virtual DbSet<PayPalSettlement> PayPalSettlements { get; set; } = null!;
        public virtual DbSet<PayPalSettlementTransaction> PayPalSettlementTransactions { get; set; } = null!;
        public virtual DbSet<PaymentechSubmission> PaymentechSubmissions { get; set; } = null!;
        public virtual DbSet<PickupGroup> PickupGroups { get; set; } = null!;
        public virtual DbSet<PickupGroupsMapping> PickupGroupsMappings { get; set; } = null!;
        public virtual DbSet<ProdsBatch> ProdsBatches { get; set; } = null!;
        public virtual DbSet<ProdsBatchLog> ProdsBatchLogs { get; set; } = null!;
        public virtual DbSet<ProdsBatchType> ProdsBatchTypes { get; set; } = null!;
        public virtual DbSet<ProdsBrand> ProdsBrands { get; set; } = null!;
        public virtual DbSet<ProdsBrandsSpellingVariation> ProdsBrandsSpellingVariations { get; set; } = null!;
        public virtual DbSet<ProdsBundlesMapping> ProdsBundlesMappings { get; set; } = null!;
        public virtual DbSet<ProdsCountryExclusion> ProdsCountryExclusions { get; set; } = null!;
        public virtual DbSet<ProdsCountryIngredientsExclusion> ProdsCountryIngredientsExclusions { get; set; } = null!;
        public virtual DbSet<ProdsCountryIngredientsExclusionsNote> ProdsCountryIngredientsExclusionsNotes { get; set; } = null!;
        public virtual DbSet<ProdsDamagedShelf> ProdsDamagedShelves { get; set; } = null!;
        public virtual DbSet<ProdsDictionary> ProdsDictionaries { get; set; } = null!;
        public virtual DbSet<ProdsFamiliesReview> ProdsFamiliesReviews { get; set; } = null!;
        public virtual DbSet<ProdsFamiliesTranslation> ProdsFamiliesTranslations { get; set; } = null!;
        public virtual DbSet<ProdsFamily> ProdsFamilies { get; set; } = null!;
        public virtual DbSet<ProdsLeadTime> ProdsLeadTimes { get; set; } = null!;
        public virtual DbSet<ProdsPrimaryVendor> ProdsPrimaryVendors { get; set; } = null!;
        public virtual DbSet<ProdsProdManager> ProdsProdManagers { get; set; } = null!;
        public virtual DbSet<ProdsProduct> ProdsProducts { get; set; } = null!;
        public virtual DbSet<ProdsProductsAvailability> ProdsProductsAvailabilities { get; set; } = null!;
        public virtual DbSet<ProdsProductsDiscoAlternate> ProdsProductsDiscoAlternates { get; set; } = null!;
        public virtual DbSet<ProdsProductsExt1Translation> ProdsProductsExt1Translations { get; set; } = null!;
        public virtual DbSet<ProdsProductsExt2Translation> ProdsProductsExt2Translations { get; set; } = null!;
        public virtual DbSet<ProdsProductsExt3Translation> ProdsProductsExt3Translations { get; set; } = null!;
        public virtual DbSet<ProdsProductsFeaturedMapping> ProdsProductsFeaturedMappings { get; set; } = null!;
        public virtual DbSet<ProdsProductsInStockNotification> ProdsProductsInStockNotifications { get; set; } = null!;
        public virtual DbSet<ProdsProductsPriceChangeLog> ProdsProductsPriceChangeLogs { get; set; } = null!;
        public virtual DbSet<ProdsProductsPriceChangeReasonLog> ProdsProductsPriceChangeReasonLogs { get; set; } = null!;
        public virtual DbSet<ProdsProductsProp65Log> ProdsProductsProp65Logs { get; set; } = null!;
        public virtual DbSet<ProdsProductsProp65LogStatus> ProdsProductsProp65LogStatuses { get; set; } = null!;
        public virtual DbSet<ProdsProductsRecount> ProdsProductsRecounts { get; set; } = null!;
        public virtual DbSet<ProdsProductsSpecialNotice> ProdsProductsSpecialNotices { get; set; } = null!;
        public virtual DbSet<ProdsProductsSpecialNoticesLegend> ProdsProductsSpecialNoticesLegends { get; set; } = null!;
        public virtual DbSet<ProdsProductsTranslation> ProdsProductsTranslations { get; set; } = null!;
        public virtual DbSet<ProdsProductsTranslationsOverride> ProdsProductsTranslationsOverrides { get; set; } = null!;
        public virtual DbSet<ProdsSample> ProdsSamples { get; set; } = null!;
        public virtual DbSet<ProdsSamplesInbound> ProdsSamplesInbounds { get; set; } = null!;
        public virtual DbSet<ProdsSamplesInventory> ProdsSamplesInventories { get; set; } = null!;
        public virtual DbSet<ProdsSamplesProdsRelationship> ProdsSamplesProdsRelationships { get; set; } = null!;
        public virtual DbSet<ProdsSamplesProdsRelationshipExclude> ProdsSamplesProdsRelationshipExcludes { get; set; } = null!;
        public virtual DbSet<ProdsSamplesStorefront> ProdsSamplesStorefronts { get; set; } = null!;
        public virtual DbSet<ProdsServingsTranslation> ProdsServingsTranslations { get; set; } = null!;
        public virtual DbSet<ProdsSupplementFactsTranslation> ProdsSupplementFactsTranslations { get; set; } = null!;
        public virtual DbSet<ProdsUnassignedToGroup> ProdsUnassignedToGroups { get; set; } = null!;
        public virtual DbSet<ProdsUnitTypesTranslation> ProdsUnitTypesTranslations { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;
        public virtual DbSet<PurchaseAutomationExclusion> PurchaseAutomationExclusions { get; set; } = null!;
        public virtual DbSet<PurchaseList> PurchaseLists { get; set; } = null!;
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } = null!;
        public virtual DbSet<PurchaseOrderAction> PurchaseOrderActions { get; set; } = null!;
        public virtual DbSet<PurchaseOrderActionsLog> PurchaseOrderActionsLogs { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersLineItem> PurchaseOrdersLineItems { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersLineItemsExpectedDate> PurchaseOrdersLineItemsExpectedDates { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersLineItemsExpirationDate> PurchaseOrdersLineItemsExpirationDates { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersLineItemsPallet> PurchaseOrdersLineItemsPallets { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersLineItemsRackingGroup> PurchaseOrdersLineItemsRackingGroups { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersLineItemsRackingGroupsPallet> PurchaseOrdersLineItemsRackingGroupsPallets { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersLineItemsReceivedDate> PurchaseOrdersLineItemsReceivedDates { get; set; } = null!;
        public virtual DbSet<PurchaseOrdersUnrecognizedProd> PurchaseOrdersUnrecognizedProds { get; set; } = null!;
        public virtual DbSet<PurchasePricing> PurchasePricings { get; set; } = null!;
        public virtual DbSet<PurchasePricingBrandNote> PurchasePricingBrandNotes { get; set; } = null!;
        public virtual DbSet<PurchasePricingCorrupted> PurchasePricingCorrupteds { get; set; } = null!;
        public virtual DbSet<Redirect> Redirects { get; set; } = null!;
        public virtual DbSet<RemoteAreaSurchargeCarrier> RemoteAreaSurchargeCarriers { get; set; } = null!;
        public virtual DbSet<RemoteAreaSurchargeZipCode> RemoteAreaSurchargeZipCodes { get; set; } = null!;
        public virtual DbSet<RemoteAreaSurchargeZipCodes2015> RemoteAreaSurchargeZipCodes2015s { get; set; } = null!;
        public virtual DbSet<ReturnOrder> ReturnOrders { get; set; } = null!;
        public virtual DbSet<ReturnOrderAction> ReturnOrderActions { get; set; } = null!;
        public virtual DbSet<ReturnOrderActionsLog> ReturnOrderActionsLogs { get; set; } = null!;
        public virtual DbSet<ReturnOrdersLineItem> ReturnOrdersLineItems { get; set; } = null!;
        public virtual DbSet<ReturnsShelf> ReturnsShelves { get; set; } = null!;
        public virtual DbSet<SagawaManifest> SagawaManifests { get; set; } = null!;
        public virtual DbSet<SagawaRate> SagawaRates { get; set; } = null!;
        public virtual DbSet<SagawaRatesPeriod> SagawaRatesPeriods { get; set; } = null!;
        public virtual DbSet<SagawaShipment> SagawaShipments { get; set; } = null!;
        public virtual DbSet<SagawaShippingSetting> SagawaShippingSettings { get; set; } = null!;
        public virtual DbSet<SalesRepCommissionsLineItem> SalesRepCommissionsLineItems { get; set; } = null!;
        public virtual DbSet<SalesRepCommissionsStatement> SalesRepCommissionsStatements { get; set; } = null!;
        public virtual DbSet<SalesTaxFamSetting> SalesTaxFamSettings { get; set; } = null!;
        public virtual DbSet<SalesTaxSetting> SalesTaxSettings { get; set; } = null!;
        public virtual DbSet<ShipToCountry> ShipToCountries { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsIntl> ShippingExtAreaSurchargeZipsIntls { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsIntl20090401Obsoletedatum> ShippingExtAreaSurchargeZipsIntl20090401Obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsIntl2010obsoletedatum> ShippingExtAreaSurchargeZipsIntl2010obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsIntl20150403Obsoletedatum> ShippingExtAreaSurchargeZipsIntl20150403Obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsIntl2015obsoletedatum> ShippingExtAreaSurchargeZipsIntl2015obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsUp> ShippingExtAreaSurchargeZipsUps { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsUps2007obsoletedatum> ShippingExtAreaSurchargeZipsUps2007obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsUps20090216Obsoletedatum> ShippingExtAreaSurchargeZipsUps20090216Obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsUps2010obsoletedatum> ShippingExtAreaSurchargeZipsUps2010obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingExtAreaSurchargeZipsUps2015obsoletedatum> ShippingExtAreaSurchargeZipsUps2015obsoletedata { get; set; } = null!;
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; } = null!;
        public virtual DbSet<ShippingTransitTime> ShippingTransitTimes { get; set; } = null!;
        public virtual DbSet<ShippingUpsbasicZipDeliveredBy> ShippingUpsbasicZipDeliveredBies { get; set; } = null!;
        public virtual DbSet<ShippingZone> ShippingZones { get; set; } = null!;
        public virtual DbSet<ShippingZonesOld> ShippingZonesOlds { get; set; } = null!;
        public virtual DbSet<SpamComplaintAddress> SpamComplaintAddresses { get; set; } = null!;
        public virtual DbSet<StandardUrl> StandardUrls { get; set; } = null!;
        public virtual DbSet<StorefrontBrandInfo> StorefrontBrandInfos { get; set; } = null!;
        public virtual DbSet<StorefrontCcinfo> StorefrontCcinfos { get; set; } = null!;
        public virtual DbSet<StorefrontControlPanelLink> StorefrontControlPanelLinks { get; set; } = null!;
        public virtual DbSet<StorefrontCustomerMessage> StorefrontCustomerMessages { get; set; } = null!;
        public virtual DbSet<StorefrontInfo> StorefrontInfos { get; set; } = null!;
        public virtual DbSet<StorefrontInfoMerchantId> StorefrontInfoMerchantIds { get; set; } = null!;
        public virtual DbSet<StorefrontInfoXmlmessageAccess> StorefrontInfoXmlmessageAccesses { get; set; } = null!;
        public virtual DbSet<StorefrontNoteLog> StorefrontNoteLogs { get; set; } = null!;
        public virtual DbSet<StorefrontNoteLogNoteType> StorefrontNoteLogNoteTypes { get; set; } = null!;
        public virtual DbSet<StorefrontProdInfo> StorefrontProdInfos { get; set; } = null!;
        public virtual DbSet<StorefrontProdInfoChangeLog> StorefrontProdInfoChangeLogs { get; set; } = null!;
        public virtual DbSet<StorefrontProdInfoPricerLog> StorefrontProdInfoPricerLogs { get; set; } = null!;
        public virtual DbSet<StorefrontShipToInfo> StorefrontShipToInfos { get; set; } = null!;
        public virtual DbSet<StorefrontShippingMethod> StorefrontShippingMethods { get; set; } = null!;
        public virtual DbSet<StorefrontShippingMethodsCarrierandClass> StorefrontShippingMethodsCarrierandClasses { get; set; } = null!;
        public virtual DbSet<StorefrontShippingMethodsMessage> StorefrontShippingMethodsMessages { get; set; } = null!;
        public virtual DbSet<StorefrontShippingMethodsShipInfo> StorefrontShippingMethodsShipInfos { get; set; } = null!;
        public virtual DbSet<StorefrontShippingMethodsShipInfoFeeOverride> StorefrontShippingMethodsShipInfoFeeOverrides { get; set; } = null!;
        public virtual DbSet<StorefrontWebRequestFilter> StorefrontWebRequestFilters { get; set; } = null!;
        public virtual DbSet<StorefrontsPubSiteKeywordRedirect> StorefrontsPubSiteKeywordRedirects { get; set; } = null!;
        public virtual DbSet<SyndicationAllNutriCategory> SyndicationAllNutriCategories { get; set; } = null!;
        public virtual DbSet<SyndicationAllNutriProd> SyndicationAllNutriProds { get; set; } = null!;
        public virtual DbSet<SyndicationAllNutriSetting> SyndicationAllNutriSettings { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonDiscod> SyndicationAmazonDiscods { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonItemType> SyndicationAmazonItemTypes { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonProd> SyndicationAmazonProds { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonProdAdsProd> SyndicationAmazonProdAdsProds { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonProdAdsProductType> SyndicationAmazonProdAdsProductTypes { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonProdAdsSetting> SyndicationAmazonProdAdsSettings { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonProductType> SyndicationAmazonProductTypes { get; set; } = null!;
        public virtual DbSet<SyndicationAmazonSetting> SyndicationAmazonSettings { get; set; } = null!;
        public virtual DbSet<SyndicationBingProd> SyndicationBingProds { get; set; } = null!;
        public virtual DbSet<SyndicationBingSetting> SyndicationBingSettings { get; set; } = null!;
        public virtual DbSet<SyndicationBizRateCategory> SyndicationBizRateCategories { get; set; } = null!;
        public virtual DbSet<SyndicationBizRateProd> SyndicationBizRateProds { get; set; } = null!;
        public virtual DbSet<SyndicationBizRateSetting> SyndicationBizRateSettings { get; set; } = null!;
        public virtual DbSet<SyndicationEBayProd> SyndicationEBayProds { get; set; } = null!;
        public virtual DbSet<SyndicationFacebookProd> SyndicationFacebookProds { get; set; } = null!;
        public virtual DbSet<SyndicationFacebookSetting> SyndicationFacebookSettings { get; set; } = null!;
        public virtual DbSet<SyndicationGeneralSetting> SyndicationGeneralSettings { get; set; } = null!;
        public virtual DbSet<SyndicationGoogleCountry> SyndicationGoogleCountries { get; set; } = null!;
        public virtual DbSet<SyndicationGoogleDisapproval> SyndicationGoogleDisapprovals { get; set; } = null!;
        public virtual DbSet<SyndicationGoogleProd> SyndicationGoogleProds { get; set; } = null!;
        public virtual DbSet<SyndicationGoogleProdsStaging> SyndicationGoogleProdsStagings { get; set; } = null!;
        public virtual DbSet<SyndicationGoogleProductType> SyndicationGoogleProductTypes { get; set; } = null!;
        public virtual DbSet<SyndicationGoogleSetting> SyndicationGoogleSettings { get; set; } = null!;
        public virtual DbSet<SyndicationHealthPricerProd> SyndicationHealthPricerProds { get; set; } = null!;
        public virtual DbSet<SyndicationHealthPricerSetting> SyndicationHealthPricerSettings { get; set; } = null!;
        public virtual DbSet<SyndicationJetProd> SyndicationJetProds { get; set; } = null!;
        public virtual DbSet<SyndicationNextagCategory> SyndicationNextagCategories { get; set; } = null!;
        public virtual DbSet<SyndicationNextagProd> SyndicationNextagProds { get; set; } = null!;
        public virtual DbSet<SyndicationNextagSetting> SyndicationNextagSettings { get; set; } = null!;
        public virtual DbSet<SyndicationPriceGrabberCategory> SyndicationPriceGrabberCategories { get; set; } = null!;
        public virtual DbSet<SyndicationPriceGrabberProd> SyndicationPriceGrabberProds { get; set; } = null!;
        public virtual DbSet<SyndicationPriceGrabberSetting> SyndicationPriceGrabberSettings { get; set; } = null!;
        public virtual DbSet<SyndicationShopComAttribute> SyndicationShopComAttributes { get; set; } = null!;
        public virtual DbSet<SyndicationShopComProd> SyndicationShopComProds { get; set; } = null!;
        public virtual DbSet<SyndicationShopComSetting> SyndicationShopComSettings { get; set; } = null!;
        public virtual DbSet<SyndicationShoppingCategory> SyndicationShoppingCategories { get; set; } = null!;
        public virtual DbSet<SyndicationShoppingProd> SyndicationShoppingProds { get; set; } = null!;
        public virtual DbSet<SyndicationShoppingSetting> SyndicationShoppingSettings { get; set; } = null!;
        public virtual DbSet<SyndicationTheFindProd> SyndicationTheFindProds { get; set; } = null!;
        public virtual DbSet<SyndicationTheFindProductType> SyndicationTheFindProductTypes { get; set; } = null!;
        public virtual DbSet<SyndicationTheFindSetting> SyndicationTheFindSettings { get; set; } = null!;
        public virtual DbSet<SyndicationWalmartProd> SyndicationWalmartProds { get; set; } = null!;
        public virtual DbSet<SyndicationYahooShoppingCategory> SyndicationYahooShoppingCategories { get; set; } = null!;
        public virtual DbSet<SyndicationYahooShoppingMerchantCategory> SyndicationYahooShoppingMerchantCategories { get; set; } = null!;
        public virtual DbSet<SyndicationYahooShoppingProd> SyndicationYahooShoppingProds { get; set; } = null!;
        public virtual DbSet<SyndicationYahooShoppingSetting> SyndicationYahooShoppingSettings { get; set; } = null!;
        public virtual DbSet<SystemSetting> SystemSettings { get; set; } = null!;
        public virtual DbSet<TaxLookup> TaxLookups { get; set; } = null!;
        public virtual DbSet<TaxLookupLine> TaxLookupLines { get; set; } = null!;
        public virtual DbSet<TempAccountingSalesFix20200110> TempAccountingSalesFix20200110s { get; set; } = null!;
        public virtual DbSet<TempAddressApiLog> TempAddressApiLogs { get; set; } = null!;
        public virtual DbSet<TempCaseQtyEntry> TempCaseQtyEntries { get; set; } = null!;
        public virtual DbSet<TempGoogleAnalyticsConversion> TempGoogleAnalyticsConversions { get; set; } = null!;
        public virtual DbSet<TempGoogleBannedKeyword> TempGoogleBannedKeywords { get; set; } = null!;
        public virtual DbSet<TempHealthZoneUkMatch> TempHealthZoneUkMatches { get; set; } = null!;
        public virtual DbSet<TempHealthZoneUkMatchesPart2> TempHealthZoneUkMatchesPart2s { get; set; } = null!;
        public virtual DbSet<TempJetSkusAvailable20160920> TempJetSkusAvailable20160920s { get; set; } = null!;
        public virtual DbSet<TempJetTax> TempJetTaxes { get; set; } = null!;
        public virtual DbSet<TempProjectWiltCategory> TempProjectWiltCategories { get; set; } = null!;
        public virtual DbSet<TempRefTrackPerformanceResult> TempRefTrackPerformanceResults { get; set; } = null!;
        public virtual DbSet<TempTopSellersOct2015> TempTopSellersOct2015s { get; set; } = null!;
        public virtual DbSet<TempTrung> TempTrungs { get; set; } = null!;
        public virtual DbSet<TempWorkingAverageShippingCost> TempWorkingAverageShippingCosts { get; set; } = null!;
        public virtual DbSet<TempWorkingProdsShippingCost> TempWorkingProdsShippingCosts { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<TransferOrder> TransferOrders { get; set; } = null!;
        public virtual DbSet<TransferOrdersLineItem> TransferOrdersLineItems { get; set; } = null!;
        public virtual DbSet<Translation> Translations { get; set; } = null!;
        public virtual DbSet<UpsBasicRate> UpsBasicRates { get; set; } = null!;
        public virtual DbSet<UpsBasicRatesPeriod> UpsBasicRatesPeriods { get; set; } = null!;
        public virtual DbSet<UpsGroundRate> UpsGroundRates { get; set; } = null!;
        public virtual DbSet<UpsGroundRatesPeriod> UpsGroundRatesPeriods { get; set; } = null!;
        public virtual DbSet<UpsMiIpaFuelSurcharge> UpsMiIpaFuelSurcharges { get; set; } = null!;
        public virtual DbSet<UpsMiIsalFuelSurcharge> UpsMiIsalFuelSurcharges { get; set; } = null!;
        public virtual DbSet<UpsQuantumView> UpsQuantumViews { get; set; } = null!;
        public virtual DbSet<UpsQuantumViewFile> UpsQuantumViewFiles { get; set; } = null!;
        public virtual DbSet<UpsQuantumViewReference> UpsQuantumViewReferences { get; set; } = null!;
        public virtual DbSet<UpsShippingSetting> UpsShippingSettings { get; set; } = null!;
        public virtual DbSet<UpsShippingStatus> UpsShippingStatuses { get; set; } = null!;
        public virtual DbSet<UpsStatusCode> UpsStatusCodes { get; set; } = null!;
        public virtual DbSet<UpsSurePostRate> UpsSurePostRates { get; set; } = null!;
        public virtual DbSet<UpsSurePostRatesPeriod> UpsSurePostRatesPeriods { get; set; } = null!;
        public virtual DbSet<UpsSurepostZipCodeSurcharge> UpsSurepostZipCodeSurcharges { get; set; } = null!;
        public virtual DbSet<UpsworldshipLookuptable> UpsworldshipLookuptables { get; set; } = null!;
        public virtual DbSet<UrlMapping> UrlMappings { get; set; } = null!;
        public virtual DbSet<UserAccount> UserAccounts { get; set; } = null!;
        public virtual DbSet<UserAccountsNote> UserAccountsNotes { get; set; } = null!;
        public virtual DbSet<UserAccountsPwreset> UserAccountsPwresets { get; set; } = null!;
        public virtual DbSet<UserAgent> UserAgents { get; set; } = null!;
        public virtual DbSet<UspsFee> UspsFees { get; set; } = null!;
        public virtual DbSet<UspsMailXmlAction> UspsMailXmlActions { get; set; } = null!;
        public virtual DbSet<UspsManifest> UspsManifests { get; set; } = null!;
        public virtual DbSet<UspsRatesFirstClass> UspsRatesFirstClasses { get; set; } = null!;
        public virtual DbSet<UspsRatesPeriod> UspsRatesPeriods { get; set; } = null!;
        public virtual DbSet<UspsRatesPriorityMail> UspsRatesPriorityMails { get; set; } = null!;
        public virtual DbSet<UspsScanFile> UspsScanFiles { get; set; } = null!;
        public virtual DbSet<UspsScanFileEvent> UspsScanFileEvents { get; set; } = null!;
        public virtual DbSet<UspsShippingSetting> UspsShippingSettings { get; set; } = null!;
        public virtual DbSet<UspsTransitTime> UspsTransitTimes { get; set; } = null!;
        public virtual DbSet<VelocityBoostRange> VelocityBoostRanges { get; set; } = null!;
        public virtual DbSet<Vendor> Vendors { get; set; } = null!;
        public virtual DbSet<ViewDhleasyShipOrders2> ViewDhleasyShipOrders2s { get; set; } = null!;
        public virtual DbSet<ViewDhleasyShipOrdersLineItems2> ViewDhleasyShipOrdersLineItems2s { get; set; } = null!;
        public virtual DbSet<ViewDhlshipOrder> ViewDhlshipOrders { get; set; } = null!;
        public virtual DbSet<ViewDhlshipOrdersLineItem> ViewDhlshipOrdersLineItems { get; set; } = null!;
        public virtual DbSet<ViewFedExCafeOrder> ViewFedExCafeOrders { get; set; } = null!;
        public virtual DbSet<ViewFedExCafeOrdersLineItem> ViewFedExCafeOrdersLineItems { get; set; } = null!;
        public virtual DbSet<ViewGsoshipOrder> ViewGsoshipOrders { get; set; } = null!;
        public virtual DbSet<ViewGsoshipOrdersLineItem> ViewGsoshipOrdersLineItems { get; set; } = null!;
        public virtual DbSet<ViewProductsEnglish> ViewProductsEnglishes { get; set; } = null!;
        public virtual DbSet<ViewProductsEnglishAsh> ViewProductsEnglishAshes { get; set; } = null!;
        public virtual DbSet<ViewProductsInventoryAvailable> ViewProductsInventoryAvailables { get; set; } = null!;
        public virtual DbSet<ViewProductsInventoryInInv> ViewProductsInventoryInInvs { get; set; } = null!;
        public virtual DbSet<ViewProductsInventoryOnShelf> ViewProductsInventoryOnShelves { get; set; } = null!;
        public virtual DbSet<ViewUpsShipmentCostsByWarehouse> ViewUpsShipmentCostsByWarehouses { get; set; } = null!;
        public virtual DbSet<ViewUpsworldshipOrder> ViewUpsworldshipOrders { get; set; } = null!;
        public virtual DbSet<ViewUpsworldshipOrdersLineItem> ViewUpsworldshipOrdersLineItems { get; set; } = null!;
        public virtual DbSet<ViewUpsworldshipOrdersObsolete> ViewUpsworldshipOrdersObsoletes { get; set; } = null!;
        public virtual DbSet<WalmartFeed> WalmartFeeds { get; set; } = null!;
        public virtual DbSet<WalmartOrder> WalmartOrders { get; set; } = null!;
        public virtual DbSet<WalmartOrderLine> WalmartOrderLines { get; set; } = null!;
        public virtual DbSet<WalmartPayment> WalmartPayments { get; set; } = null!;
        public virtual DbSet<WalmartPaymentLine> WalmartPaymentLines { get; set; } = null!;
        public virtual DbSet<WalmartReportItem> WalmartReportItems { get; set; } = null!;
        public virtual DbSet<Warehouse> Warehouses { get; set; } = null!;
        public virtual DbSet<WarehouseDhlShippingSetting> WarehouseDhlShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseFedexShippingSetting> WarehouseFedexShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseGsoShippingSetting> WarehouseGsoShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseLaserShipShippingSetting> WarehouseLaserShipShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseMailExpressShippingSetting> WarehouseMailExpressShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseNgsShippingSetting> WarehouseNgsShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseOnTracShippingSetting> WarehouseOnTracShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseUpsShippingSetting> WarehouseUpsShippingSettings { get; set; } = null!;
        public virtual DbSet<WarehouseUspsShippingSetting> WarehouseUspsShippingSettings { get; set; } = null!;
        public virtual DbSet<WorkingTableProdsToPurchase> WorkingTableProdsToPurchases { get; set; } = null!;
        public virtual DbSet<WorkingTableSfmanageProductsPage> WorkingTableSfmanageProductsPages { get; set; } = null!;
        public virtual DbSet<ZipCodeDatum> ZipCodeData { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=216.74.27.142;Initial Catalog=WNS_master_DEV;User ID=vsuser1;Password=p98htsh;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountingSale>(entity =>
            {
                entity.HasKey(e => e.TransNum)
                    .IsClustered(false);

                entity.ToTable("Accounting_Sales");

                entity.HasIndex(e => e.TransTime, "PK_AccountSales_TransTime_CLUST")
                    .IsClustered()
                    .HasFillFactor(99);

                entity.Property(e => e.CalculatedCostMethodId).HasColumnName("CalculatedCostMethodID");

                entity.Property(e => e.CalculatedCostToProviderUpdatable)
                    .HasColumnType("smallmoney")
                    .HasColumnName("CalculatedCostToProvider_updatable");

                entity.Property(e => e.DateCostToProviderCalculated).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.SalesTypeId).HasColumnName("SalesTypeID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.TransClassId).HasColumnName("TransClassID");

                entity.Property(e => e.TransTime).HasColumnType("datetime");

                entity.Property(e => e.UnitApproxAverageCost).HasColumnType("smallmoney");

                entity.Property(e => e.UnitSalePrice).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<AccountingSalesCogsDetail>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("Accounting_Sales_COGS_Detail");

                entity.Property(e => e.AccountingSalesTransNum).HasColumnName("Accounting_Sales_TransNum");

                entity.Property(e => e.CostDetermination)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GrossUnitCost).HasColumnType("smallmoney");

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.RebatePercent).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<AccountingTaxId>(entity =>
            {
                entity.HasKey(e => e.TaxId);

                entity.ToTable("Accounting_TaxIDs");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxDescObsolete)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("TaxDesc_OBSOLETE");
            });

            modelBuilder.Entity<AdminsPiecework>(entity =>
            {
                entity.HasKey(e => e.PieceworkId);

                entity.ToTable("Admins_Piecework");

                entity.Property(e => e.PieceworkId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PieceworkID");

                entity.Property(e => e.Piecework)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminsPieceworkLog>(entity =>
            {
                entity.ToTable("Admins_Piecework_Log");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.PieceworkId).HasColumnName("PieceworkID");

                entity.Property(e => e.StartedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<AdminsProvider>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .HasName("PK_Admins")
                    .IsClustered(false);

                entity.ToTable("Admins_Provider");

                entity.HasIndex(e => e.Username, "IX_Admins_Provider_Username")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firtext)
                    .IsUnicode(false)
                    .HasColumnName("FIRText");

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PermAddEditProdsExceptPrice).HasColumnName("Perm_AddEditProdsExceptPrice");

                entity.Property(e => e.PermAddEditProdsIncludingPrice).HasColumnName("Perm_AddEditProdsIncludingPrice");

                entity.Property(e => e.PermAdjustInventory).HasColumnName("Perm_AdjustInventory");

                entity.Property(e => e.PermCreateBoxSuggestions).HasColumnName("Perm_CreateBoxSuggestions");

                entity.Property(e => e.PermCreateEditDropshipBillingInfo).HasColumnName("Perm_CreateEditDropshipBillingInfo");

                entity.Property(e => e.PermCreateEditInterProviderBillingInfo).HasColumnName("Perm_CreateEditInterProviderBillingInfo");

                entity.Property(e => e.PermCreateEditPo).HasColumnName("Perm_CreateEditPO");

                entity.Property(e => e.PermCreateEditRo).HasColumnName("Perm_CreateEditRO");

                entity.Property(e => e.PermCreateEditWholesaleOrders).HasColumnName("Perm_CreateEditWholesaleOrders");

                entity.Property(e => e.PermCreateEditWholesaleOrdersWithSensitiveInfo).HasColumnName("Perm_CreateEditWholesaleOrdersWithSensitiveInfo");

                entity.Property(e => e.PermCreateOrderBatches).HasColumnName("Perm_CreateOrderBatches");

                entity.Property(e => e.PermEditShipTypes).HasColumnName("Perm_EditShipTypes");

                entity.Property(e => e.PermEditTimeSheets).HasColumnName("Perm_EditTimeSheets");

                entity.Property(e => e.PermEditVendors).HasColumnName("Perm_EditVendors");

                entity.Property(e => e.PermEditWholesaleOrdersPayments).HasColumnName("Perm_EditWholesaleOrdersPayments");

                entity.Property(e => e.PermPickPack).HasColumnName("Perm_PickPack");

                entity.Property(e => e.PermProcessCustomerReturns).HasColumnName("Perm_ProcessCustomerReturns");

                entity.Property(e => e.PermReceiveInvForPo).HasColumnName("Perm_ReceiveInvForPO");

                entity.Property(e => e.PermSalesRepBasic).HasColumnName("Perm_SalesRepBasic");

                entity.Property(e => e.PermSalesSupervisor).HasColumnName("Perm_SalesSupervisor");

                entity.Property(e => e.PermStorefrontManagement).HasColumnName("Perm_StorefrontManagement");

                entity.Property(e => e.PermSupervisor).HasColumnName("Perm_Supervisor");

                entity.Property(e => e.PermSysAdmin).HasColumnName("Perm_SysAdmin");

                entity.Property(e => e.PermViewDropshipBillingInfo).HasColumnName("Perm_ViewDropshipBillingInfo");

                entity.Property(e => e.PermViewMarketingInfo).HasColumnName("Perm_ViewMarketingInfo");

                entity.Property(e => e.PermViewPo).HasColumnName("Perm_ViewPO");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.PublicName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.Property(e => e.Username)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminsProviderCommission>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("Admins_Provider_Commissions");

                entity.Property(e => e.AdminIdgettingCommission).HasColumnName("AdminIDGettingCommission");

                entity.Property(e => e.CommissionPercent).HasColumnType("smallmoney");

                entity.Property(e => e.EndOfTheLineAdminId).HasColumnName("EndOfTheLineAdminID");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");
            });

            modelBuilder.Entity<AdminsProviderWarehouseAssignment>(entity =>
            {
                entity.HasKey(e => e.AdminId);

                entity.ToTable("Admins_Provider_WarehouseAssignments");

                entity.Property(e => e.AdminId)
                    .ValueGeneratedNever()
                    .HasColumnName("AdminID");

                entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

                entity.HasOne(d => d.Admin)
                    .WithOne(p => p.AdminsProviderWarehouseAssignment)
                    .HasForeignKey<AdminsProviderWarehouseAssignment>(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admins_Provider_WarehouseAssignments_Admins_Provider");
            });

            modelBuilder.Entity<AdminsStorefront>(entity =>
            {
                entity.HasKey(e => e.AdminId)
                    .IsClustered(false);

                entity.ToTable("Admins_Storefronts");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminsStorefrontsAdminPermission>(entity =>
            {
                entity.HasKey(e => e.AdminPermId);

                entity.ToTable("Admins_Storefronts_AdminPermissions");

                entity.Property(e => e.AdminPermId).HasColumnName("AdminPermID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.AdminsStorefrontsAdminPermissions)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admins_Storefronts_AdminPermissions_Admins_Storefronts");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AdminsStorefrontsAdminPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admins_Storefronts_AdminPermissions_Admins_Storefronts_Permissions");
            });

            modelBuilder.Entity<AdminsStorefrontsPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("Admins_Storefronts_Permissions");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.PermissionDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdminsTimeClock>(entity =>
            {
                entity.ToTable("Admins_TimeClock");

                entity.HasIndex(e => e.AdminId, "IX_Admins_TimeClock_AdminID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TimeIn, "IX_Admins_TimeClock_TimeIn")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TimeOut, "IX_Admins_TimeClock_TimeOut")
                    .HasFillFactor(90);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.PieceworkDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PieceworkId).HasColumnName("PieceworkID");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.AdminsTimeClocks)
                    .HasForeignKey(d => d.AdminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admins_TimeClock_Admins_Provider");

                entity.HasOne(d => d.Piecework)
                    .WithMany(p => p.AdminsTimeClocks)
                    .HasForeignKey(d => d.PieceworkId)
                    .HasConstraintName("FK_Admins_TimeClock_Admins_Piecework");
            });

            modelBuilder.Entity<Affiliate>(entity =>
            {
                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.AvgClients)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateJoined).HasColumnType("datetime");

                entity.Property(e => e.DateLastModified).HasColumnType("datetime");

                entity.Property(e => e.DefaultCommissionPercent).HasColumnType("smallmoney");

                entity.Property(e => e.Notes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PayableTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxReferenceType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TrainerFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrainerLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.Username)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Affiliates)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliates_Affiliates_Status");
            });

            modelBuilder.Entity<AffiliatesCampaign>(entity =>
            {
                entity.HasKey(e => e.CampaignCode);

                entity.ToTable("Affiliates_Campaigns");

                entity.Property(e => e.CampaignCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliatesCampaigns)
                    .HasForeignKey(d => d.AffiliateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliates_Campaigns_Affiliates");
            });

            modelBuilder.Entity<AffiliatesCommissionOverride>(entity =>
            {
                entity.HasKey(e => e.OverrideId);

                entity.ToTable("Affiliates_Commission_Overrides");

                entity.Property(e => e.OverrideId).HasColumnName("OverrideID");

                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.CommissionPercent).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliatesCommissionOverrides)
                    .HasForeignKey(d => d.AffiliateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliates_Commission_Overrides_Affiliates");
            });

            modelBuilder.Entity<AffiliatesPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("Affiliates_Payments");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.AffiliateId).HasColumnName("AffiliateID");

                entity.Property(e => e.PaymentAmount).HasColumnType("smallmoney");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.HasOne(d => d.Affiliate)
                    .WithMany(p => p.AffiliatesPayments)
                    .HasForeignKey(d => d.AffiliateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliates_Payments_Affiliates");
            });

            modelBuilder.Entity<AffiliatesRecommendedCart>(entity =>
            {
                entity.HasKey(e => e.RecommendedCartId);

                entity.ToTable("Affiliates_Recommended_Carts");

                entity.Property(e => e.RecommendedCartId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("RecommendedCartID");

                entity.Property(e => e.CampaignCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RecommendedCartName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CampaignCodeNavigation)
                    .WithMany(p => p.AffiliatesRecommendedCarts)
                    .HasForeignKey(d => d.CampaignCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliates_Recommended_Carts_Affiliates_Campaigns");
            });

            modelBuilder.Entity<AffiliatesRecommendedCartsProd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Affiliates_Recommended_Carts_Prods");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.RecommendedCartId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("RecommendedCartID");

                entity.HasOne(d => d.RecommendedCart)
                    .WithMany()
                    .HasForeignKey(d => d.RecommendedCartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliates_Recommended_Carts_Prods_Affiliates_Recommended_Carts");
            });

            modelBuilder.Entity<AffiliatesStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Affiliates_Status");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatusID");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AffiliatesTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Affiliates_Transactions");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.CampaignCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionAmount).HasColumnType("smallmoney");

                entity.Property(e => e.DateLastModified).HasColumnType("datetime");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");

                entity.Property(e => e.DateTimeEntered).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.CampaignCodeNavigation)
                    .WithMany(p => p.AffiliatesTransactions)
                    .HasForeignKey(d => d.CampaignCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Affiliates_Transactions_Affiliates_Campaigns");
            });

            modelBuilder.Entity<AffiliatesTransactionsAction>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("Affiliates_Transactions_Actions");

                entity.Property(e => e.ActionId)
                    .ValueGeneratedNever()
                    .HasColumnName("ActionID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AffiliatesTransactionsStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Affiliates_Transactions_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlturaShipInfo>(entity =>
            {
                entity.HasKey(e => new { e.ShipMethodId, e.CountryId, e.ZoneId });

                entity.ToTable("AlturaShipInfo");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.Property(e => e.FlatOrZipDependent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PerItemFee).HasColumnType("smallmoney");

                entity.Property(e => e.PerOrderFee).HasColumnType("smallmoney");

                entity.Property(e => e.PerOunceFee).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<AmazonFbaInboundShipmentPlan>(entity =>
            {
                entity.ToTable("Amazon_FBA_InboundShipmentPlan");

                entity.HasIndex(e => e.ShipmentId, "IX_Amazon_FBA_InboundShipmentPlan_ShipmentId")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedOn).HasColumnType("datetime");

                entity.Property(e => e.DestinationFulfillmentCenterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderPlacedOn).HasColumnType("datetime");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ShipFromAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFromStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToStateCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedOn).HasColumnType("datetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<AmazonFbaInboundShipmentPlanItem>(entity =>
            {
                entity.ToTable("Amazon_FBA_InboundShipmentPlan_Item");

                entity.Property(e => e.Fnsku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FNSKU");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SellerSku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SellerSKU");

                entity.HasOne(d => d.InboundShipmentPlan)
                    .WithMany(p => p.AmazonFbaInboundShipmentPlanItems)
                    .HasForeignKey(d => d.InboundShipmentPlanId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Amazon_FBA_InboundShipmentPlan_Item_Amazon_FBA_InboundShipmentPlan");
            });

            modelBuilder.Entity<AmazonFeedsProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("Amazon_Feeds_Process");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.DateCompleted).HasColumnType("datetime");

                entity.Property(e => e.DateErrored).HasColumnType("datetime");

                entity.Property(e => e.DateLastChecked).HasColumnType("datetime");

                entity.Property(e => e.DateStarted).HasColumnType("datetime");

                entity.Property(e => e.DocId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DocID");

                entity.Property(e => e.ErrorMsg)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCatId).HasColumnName("ProcessCatID");

                entity.Property(e => e.ProcessTypeId).HasColumnName("ProcessTypeID");

                entity.HasOne(d => d.ProcessCat)
                    .WithMany(p => p.AmazonFeedsProcesses)
                    .HasForeignKey(d => d.ProcessCatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Amazon_Feeds_Process_Amazon_Process_Categories");

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.AmazonFeedsProcesses)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Amazon_Feeds_Process_Amazon_Process_Types");
            });

            modelBuilder.Entity<AmazonProcessCategory>(entity =>
            {
                entity.HasKey(e => e.ProcessCatId);

                entity.ToTable("Amazon_Process_Categories");

                entity.Property(e => e.ProcessCatId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProcessCatID");

                entity.Property(e => e.ProcessCatName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmazonProcessType>(entity =>
            {
                entity.HasKey(e => e.ProcessTypeId);

                entity.ToTable("Amazon_Process_Types");

                entity.Property(e => e.ProcessTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProcessTypeID");

                entity.Property(e => e.ProcessTypeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AmazonSettlementReport>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Amazon_Settlement_Reports");

                entity.HasIndex(e => e.MarketplaceName, "IX_Amazon_Settlement_Reports_MarketplaceName")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.OrderId, "IX_Amazon_Settlement_Reports_OrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SettlementId, "IX_Amazon_Settlement_Reports_SettlementID")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepositDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 7)");

                entity.Property(e => e.GoodwillCredit).HasColumnType("smallmoney");

                entity.Property(e => e.ItemPriceCredit).HasColumnType("smallmoney");

                entity.Property(e => e.ItemTaxCredit).HasColumnType("smallmoney");

                entity.Property(e => e.MarketplaceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID");

                entity.Property(e => e.OrderRelatedFees).HasColumnType("smallmoney");

                entity.Property(e => e.OtherFees).HasColumnType("smallmoney");

                entity.Property(e => e.PostedDate).HasColumnType("datetime");

                entity.Property(e => e.SettlementId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SettlementID");

                entity.Property(e => e.ShippingPriceCredit).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTaxCredit).HasColumnType("smallmoney");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Aporderdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("APorderdetails");

                entity.Property(e => e.PriceToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<AuthNetCommLog>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("AuthNetCommLog");

                entity.Property(e => e.Uniquefier).ValueGeneratedNever();

                entity.Property(e => e.Ccexp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCExp");

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.Ccrequest)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("CCRequest");

                entity.Property(e => e.Ccresponse)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("CCResponse");

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.TimeSaved).HasColumnType("datetime");
            });

            modelBuilder.Entity<AutoGenReport>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.DateTimeGenerated).HasColumnType("smalldatetime");

                entity.Property(e => e.ReportDesc)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsAbandonCartsProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Abandon_Carts_Processes");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Abandon_Carts_Processes_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ProcessDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsAlturaPriceSpPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Altura_Price_SP_Price");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Altura_Price_SP_Price_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.AvgCostToAltura).HasColumnType("smallmoney");

                entity.Property(e => e.Column1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.LegalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.PriceToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StdPubPrice).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<AutoGenReportsDtsPackageOlap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_DTS_Package_OLAP");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_DTS_Package_OLAP_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.EmailDateSentAfter).HasColumnType("datetime");

                entity.Property(e => e.EmailDateSentBefore).HasColumnType("datetime");

                entity.Property(e => e.EmailIdafter)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmailIDAfter");

                entity.Property(e => e.EmailIdbefore)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmailIDBefore");

                entity.Property(e => e.ExecDateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecId).HasColumnName("ExecID");

                entity.Property(e => e.HitDateAfter).HasColumnType("datetime");

                entity.Property(e => e.HitDateBefore).HasColumnType("datetime");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.RetValExec)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueIdafter).HasColumnName("UniqueIDAfter");

                entity.Property(e => e.UniqueIdbefore).HasColumnName("UniqueIDBefore");
            });

            modelBuilder.Entity<AutoGenReportsOrdersChannelsCountDaily>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Orders_Channels_Count_Daily");

                entity.Property(e => e.Channel)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<AutoGenReportsOrdersShipNetChargeShipAmount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Orders_Ship_Net_Charge_Ship_Amount");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Orders_Ship_Net_Charge_Ship_Amount_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.NetChargePlusSurcharge).HasColumnType("money");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ServiceDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAmount).HasColumnType("money");
            });

            modelBuilder.Entity<AutoGenReportsOrdersUnitCostSfPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Orders_Unit_Cost_SF_Price");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Orders_Unit_Cost_SF_Price_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.PercentLoss).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.PriceToStorefront).HasColumnType("money");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.UnitCost).HasColumnType("money");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<AutoGenReportsProductPopularityScoresUpdated>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Product_Popularity_Scores_Updated");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Product_Popularity_Scores_Updated_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.UpdproductPopularity)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("UPDProductPopularity");
            });

            modelBuilder.Entity<AutoGenReportsProductsDetail>(entity =>
            {
                entity.HasKey(e => new { e.ReportNumber, e.WrhsId, e.ProdId });

                entity.ToTable("AutoGenReports_Products_Details");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.AvailabilityAvailable).HasColumnName("Availability_Available");

                entity.Property(e => e.AvailabilityExpectedDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Availability_ExpectedDate");

                entity.Property(e => e.AvailabilityInv).HasColumnName("Availability_Inv");

                entity.Property(e => e.AvailabilityShelf).HasColumnName("Availability_Shelf");

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PoUnits).HasColumnName("PO_Units");

                entity.Property(e => e.PoValue)
                    .HasColumnType("money")
                    .HasColumnName("PO_Value");
            });

            modelBuilder.Entity<AutoGenReportsProductsDetailsCostDetail>(entity =>
            {
                entity.HasKey(e => e.Uniquefier)
                    .HasName("PK_AutoGenReports_Products_Details_CostDetails_1");

                entity.ToTable("AutoGenReports_Products_Details_CostDetails");

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.RebatePercent).HasColumnType("smallmoney");

                entity.Property(e => e.UnitCost).HasColumnType("smallmoney");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<AutoGenReportsProductsFeedsResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Products_Feeds_Results");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Products_Feeds_Results_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ProcessDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDetails).IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsProductsNotShownToAllSf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Products_Not_Shown_To_All_SFs");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Products_Not_Shown_To_All_SFs_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.Column1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<AutoGenReportsProductsNotShownToSf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Products_Not_Shown_To_SF");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Products_Not_Shown_To_SF_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.Column1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Discontinued)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayToStorefronts)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.ProviderAllowDisplayToPublic)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StorefrontDisplayToPublic)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsProductsOver6Month>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Products_Over_6_Months");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Products_Over_6_Months_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.Column1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FourWeekVel).HasColumnType("money");

                entity.Property(e => e.Qty4WkVel).HasColumnType("money");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<AutoGenReportsProductsTotal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Products_Totals");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Products_Totals_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.ActualAdvantisCost).HasColumnType("money");

                entity.Property(e => e.ActualAlturaCost).HasColumnType("money");

                entity.Property(e => e.CurAshpubPriceTot)
                    .HasColumnType("money")
                    .HasColumnName("CurASHPubPriceTot");

                entity.Property(e => e.CurAshpubPriceTotAdvantis)
                    .HasColumnType("money")
                    .HasColumnName("CurASHPubPriceTotAdvantis");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StdAshpubPriceTot)
                    .HasColumnType("money")
                    .HasColumnName("StdASHPubPriceTot");

                entity.Property(e => e.StdAshpubPriceTotAdvantis)
                    .HasColumnType("money")
                    .HasColumnName("StdASHPubPriceTotAdvantis");

                entity.Property(e => e.StdCostToAdvantis).HasColumnType("money");

                entity.Property(e => e.StdCostToAltura).HasColumnType("money");
            });

            modelBuilder.Entity<AutoGenReportsRefillReminder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Refill_Reminders");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Refill_Reminders_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ProcessDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsScriptGroupsPricing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Script_Groups_Pricing");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Script_Groups_Pricing_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.DefaultPricingGroupId).HasColumnName("DefaultPricingGroupID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExclusiveToAdminId).HasColumnName("ExclusiveToAdminID");

                entity.Property(e => e.GroupDescription).IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastRunDate).HasColumnType("datetime");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsScriptMakeAshWsAlturaW>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Script_Make_ASH_WS_Altura_WS");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Script_Make_ASH_WS_Altura_WS_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.UpdpriceToStoreFront)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPDPriceToStoreFront");
            });

            modelBuilder.Entity<AutoGenReportsSpPricePublicPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_SP_Price_Public_Price");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_SP_Price_Public_Price_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.Column1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.PriceToStoreFront).HasColumnType("smallmoney");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.StdPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.StoreNameOnSlip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsUnsuccessfulAlturaCpLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Unsuccessful_Altura_CP_Logins");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Unsuccessful_Altura_CP_Logins_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Sfid).HasColumnName("SFID");

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsUnsuccessfulPublicSiteLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Unsuccessful_Public_Site_Logins");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Unsuccessful_Public_Site_Logins_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Sfid).HasColumnName("SFID");

                entity.Property(e => e.User)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoGenReportsUnsuccessfulStorefrontCpLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoGenReports_Unsuccessful_Storefront_CP_Logins");

                entity.HasIndex(e => e.ReportId, "IX_AutoGenReports_Unsuccessful_Storefront_CP_Logins_ReportID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Sfid).HasColumnName("SFID");

                entity.Property(e => e.User)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bin>(entity =>
            {
                entity.Property(e => e.BinId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BinID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<BinProdRelationship>(entity =>
            {
                entity.HasKey(e => new { e.BinId, e.ProdId });

                entity.ToTable("Bin_Prod_Relationships");

                entity.Property(e => e.BinId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BinID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Bin)
                    .WithMany(p => p.BinProdRelationships)
                    .HasForeignKey(d => d.BinId)
                    .HasConstraintName("FK_Bin_Prod_Relationships_Bins");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.BinProdRelationships)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bin_Prod_Relationships_Prods_Products");
            });

            modelBuilder.Entity<BinsFilterTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Bins_Filter_Temp");

                entity.Property(e => e.Row)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BinsSortIndex>(entity =>
            {
                entity.HasKey(e => e.SortId);

                entity.ToTable("Bins_SortIndex");

                entity.Property(e => e.SortId).HasColumnName("SortID");

                entity.Property(e => e.Area)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CarrierRate>(entity =>
            {
                entity.ToTable("Carrier_Rate");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.Property(e => e.WeightInOz).HasColumnType("smallmoney");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CarrierRates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrier_Rate_ShipToCountries");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.CarrierRates)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrier_Rate_Carrier_Rate_Period");
            });

            modelBuilder.Entity<CarrierRatePeriod>(entity =>
            {
                entity.ToTable("Carrier_Rate_Period");

                entity.Property(e => e.CandCid).HasColumnName("CandCID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.CandC)
                    .WithMany(p => p.CarrierRatePeriods)
                    .HasForeignKey(d => d.CandCid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carrier_Rate_Period_CarriersAndClasses");
            });

            modelBuilder.Entity<CarriersAndClass>(entity =>
            {
                entity.HasKey(e => e.CandCid);

                entity.Property(e => e.CandCid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CandCID");

                entity.Property(e => e.CandCdesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CandCDesc");

                entity.Property(e => e.CarrierCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.MaxWeightInOz).HasColumnType("smallmoney");

                entity.HasMany(d => d.Countries)
                    .WithMany(p => p.CandCs)
                    .UsingEntity<Dictionary<string, object>>(
                        "CarriersAndClassesCountry",
                        l => l.HasOne<ShipToCountry>().WithMany().HasForeignKey("CountryId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CarriersAndClasses_Countries_ShipToCountries"),
                        r => r.HasOne<CarriersAndClass>().WithMany().HasForeignKey("CandCid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CarriersAndClasses_Countries_CarriersAndClasses"),
                        j =>
                        {
                            j.HasKey("CandCid", "CountryId");

                            j.ToTable("CarriersAndClasses_Countries");

                            j.IndexerProperty<byte>("CandCid").HasColumnName("CandCID");

                            j.IndexerProperty<short>("CountryId").HasColumnName("CountryID");
                        });
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .IsClustered(false);

                entity.HasIndex(e => e.AccountId, "IX_Carts_AccountID");

                entity.HasIndex(e => e.LastModified, "IX_Carts_LastModified")
                    .HasFillFactor(90);

                entity.Property(e => e.CartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CartID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.BillToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToFName");

                entity.Property(e => e.BillToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToLName");

                entity.Property(e => e.BillToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToMName");

                entity.Property(e => e.BillToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.CcnumberObsolete)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CCNumber_OBSOLETE");

                entity.Property(e => e.CctypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CCTypeCode")
                    .IsFixedLength();

                entity.Property(e => e.CouponAbsOrPerc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CouponAmount).HasColumnType("smallmoney");

                entity.Property(e => e.CouponAmountLeftToEnable).HasColumnType("smallmoney");

                entity.Property(e => e.CouponAppliedAmount).HasColumnType("smallmoney");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CouponDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CouponExpires).HasColumnType("smalldatetime");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.CouponStatusId).HasColumnName("CouponStatusID");

                entity.Property(e => e.CustomerComments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAsOnCc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NameAsOnCC");

                entity.Property(e => e.PayPalNonce)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechCustRefNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountryID");

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToFName");

                entity.Property(e => e.ShipToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToLName");

                entity.Property(e => e.ShipToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToMName");

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZoneZip)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.SubmittedPassword)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedPassword2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedUsername)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCityRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCityRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCityRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCityRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCountryRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCountyRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxDistrictRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxStateRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateRateSupplement).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<CartsGiftCertificate>(entity =>
            {
                entity.HasKey(e => new { e.CartId, e.GiftCertificateId })
                    .HasName("PK_Carts_GiftCertificates_1");

                entity.ToTable("Carts_GiftCertificates");

                entity.Property(e => e.CartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CartID");

                entity.Property(e => e.GiftCertificateId).HasColumnName("GiftCertificateID");

                entity.Property(e => e.AmountRedeemed).HasColumnType("smallmoney");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartsGiftCertificates)
                    .HasForeignKey(d => d.CartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carts_GiftCertificates_Carts");
            });

            modelBuilder.Entity<CartsLineItem>(entity =>
            {
                entity.HasKey(e => new { e.CartId, e.LineNum })
                    .IsClustered(false);

                entity.ToTable("Carts_LineItems");

                entity.HasIndex(e => e.LastModified, "IX_Carts_LineItems_LastMod")
                    .HasFillFactor(90);

                entity.Property(e => e.CartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CartID");

                entity.Property(e => e.CurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartsLineItems)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK_Carts_LineItems_Carts");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.CartsLineItems)
                    .HasForeignKey(d => d.ProdId)
                    .HasConstraintName("FK_Carts_LineItems_Prods_Products");
            });

            modelBuilder.Entity<CartsProductView>(entity =>
            {
                entity.HasKey(e => new { e.CartId, e.ProdId });

                entity.ToTable("Carts_ProductViews");

                entity.Property(e => e.CartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CartID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartsProductViews)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK_Carts_ProductViews_Carts");
            });

            modelBuilder.Entity<CartsReplenishment>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("Carts_Replenishment");

                entity.Property(e => e.CartId).HasColumnName("CartID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.BinId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BinID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<CartsStorefrontOrder>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.LineNum, e.StorefrontId });

                entity.ToTable("Carts_StorefrontOrders");

                entity.HasIndex(e => new { e.SessionId, e.ProdId, e.StorefrontId }, "IX_Carts_StorefrontOrders_SessionID_ProdID_SFID")
                    .HasFillFactor(90);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("SessionID")
                    .IsFixedLength();

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.BrandDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.PriceToConsumer).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontSku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontSKU");

                entity.Property(e => e.TaxPercent).HasColumnType("smallmoney");

                entity.Property(e => e.UnitNum).HasColumnType("smallmoney");

                entity.Property(e => e.UnitTypeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.CartsStorefrontOrders)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carts_StorefrontOrders_StorefrontInfo");
            });

            modelBuilder.Entity<CartsStorefrontOrdersGiftCertificate>(entity =>
            {
                entity.HasKey(e => new { e.SessionId, e.GiftCertificateId });

                entity.ToTable("Carts_StorefrontOrders_GiftCertificates");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("SessionID")
                    .IsFixedLength();

                entity.Property(e => e.GiftCertificateId).HasColumnName("GiftCertificateID");

                entity.Property(e => e.AmountRedeemed).HasColumnType("smallmoney");

                entity.HasOne(d => d.GiftCertificate)
                    .WithMany(p => p.CartsStorefrontOrdersGiftCertificates)
                    .HasForeignKey(d => d.GiftCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carts_StorefrontOrders_GiftCertificates_GiftCertificates");
            });

            modelBuilder.Entity<CartsViewedProduct>(entity =>
            {
                entity.HasKey(e => new { e.CartId, e.ProdId });

                entity.ToTable("Carts_ViewedProducts");

                entity.Property(e => e.CartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CartID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<CartsWholesaleOrder>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.ProdId });

                entity.ToTable("Carts_WholesaleOrders");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.EffectiveWhlsPrice).HasColumnType("smallmoney");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.CartsWholesaleOrders)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Carts_WholesaleOrders_StorefrontInfo");
            });

            modelBuilder.Entity<ChargeBridgeCommLog>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("ChargeBridgeCommLog");

                entity.Property(e => e.Uniquefier).ValueGeneratedNever();

                entity.Property(e => e.Ccexp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCExp");

                entity.Property(e => e.Ccid)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCID");

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.Ccrequest)
                    .HasColumnType("text")
                    .HasColumnName("CCRequest");

                entity.Property(e => e.Ccresponse)
                    .HasColumnType("text")
                    .HasColumnName("CCResponse");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderAmount)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.TimeSaved).HasColumnType("datetime");
            });

            modelBuilder.Entity<CopyOfHealthZoneUkMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Copy of HealthZone UK Matches");

                entity.Property(e => e.Asin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASIN");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.UkTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("UK Title");
            });

            modelBuilder.Entity<Coupon>(entity =>
            {
                entity.HasKey(e => e.CouponId)
                    .IsClustered(false);

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.AbsOrPerc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.CouponAppliedMessage).HasMaxLength(200);

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CouponDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CouponNotAppliedMessage).HasMaxLength(200);

                entity.Property(e => e.Expires).HasColumnType("smalldatetime");

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.MinEnableAmount).HasColumnType("smallmoney");

                entity.Property(e => e.Starts).HasColumnType("smalldatetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.Coupons)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupons_StorefrontInfo");
            });

            modelBuilder.Entity<CouponsProdAddToCart>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("Coupons_ProdAddToCart");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponsProdAddToCarts)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupons_ProdAddToCart_Coupons");
            });

            modelBuilder.Entity<CouponsProdGroup>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.GroupTypeId, e.GroupValue });

                entity.ToTable("Coupons_ProdGroups");

                entity.Property(e => e.CouponId).HasColumnName("CouponID");

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");

                entity.HasOne(d => d.Coupon)
                    .WithMany(p => p.CouponsProdGroups)
                    .HasForeignKey(d => d.CouponId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupons_ProdGroups_Coupons");

                entity.HasOne(d => d.GroupType)
                    .WithMany(p => p.CouponsProdGroups)
                    .HasForeignKey(d => d.GroupTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Coupons_ProdGroups_Coupons_ProdGroupsType");
            });

            modelBuilder.Entity<CouponsProdGroupsType>(entity =>
            {
                entity.HasKey(e => e.GroupTypeId);

                entity.ToTable("Coupons_ProdGroupsType");

                entity.Property(e => e.GroupTypeId).HasColumnName("GroupTypeID");

                entity.Property(e => e.GroupDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Culture>(entity =>
            {
                entity.HasKey(e => e.CultureCode)
                    .HasName("PK_LanguageCodes");

                entity.Property(e => e.CultureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.LangId).HasColumnName("LangID");
            });

            modelBuilder.Entity<CurrenciesExchangeRate>(entity =>
            {
                entity.HasKey(e => e.RateId);

                entity.ToTable("Currencies_ExchangeRates");

                entity.Property(e => e.RateId).HasColumnName("RateID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MarkupPercent).HasColumnType("smallmoney");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CurrenciesExchangeRates)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Currencies_ExchangeRates_Currencies");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.Property(e => e.CurrencyId)
                    .ValueGeneratedNever()
                    .HasColumnName("CurrencyID");

                entity.Property(e => e.IsoalphaCode)
                    .HasMaxLength(50)
                    .HasColumnName("ISOAlphaCode");

                entity.Property(e => e.IsonumericCode)
                    .HasMaxLength(50)
                    .HasColumnName("ISONumericCode");

                entity.Property(e => e.MarkupPercent).HasColumnType("smallmoney");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Symbol).HasMaxLength(50);
            });

            modelBuilder.Entity<DeptsDepartment>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .IsClustered(false);

                entity.ToTable("Depts_Departments");

                entity.HasIndex(e => e.DeptName, "IX_Depts_Departments_Constraint_Name")
                    .IsUnique();

                entity.HasIndex(e => e.LastInfoChangeTimestamp, "IX_Depts_Departments_LastInfoChangeTimestamp")
                    .HasFillFactor(90);

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastInfoChangeTimestamp).HasColumnType("datetime");

                entity.HasMany(d => d.Depts)
                    .WithMany(p => p.SubDeptOfs)
                    .UsingEntity<Dictionary<string, object>>(
                        "DeptsDeptRelationship",
                        l => l.HasOne<DeptsDepartment>().WithMany().HasForeignKey("DeptId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Depts_DeptRelationships_Depts_Departments"),
                        r => r.HasOne<DeptsDepartment>().WithMany().HasForeignKey("SubDeptOf").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Depts_DeptRelationships_Depts_Departments1"),
                        j =>
                        {
                            j.HasKey("DeptId", "SubDeptOf").IsClustered(false);

                            j.ToTable("Depts_DeptRelationships");

                            j.IndexerProperty<short>("DeptId").HasColumnName("DeptID");
                        });

                entity.HasMany(d => d.SubDeptOfs)
                    .WithMany(p => p.Depts)
                    .UsingEntity<Dictionary<string, object>>(
                        "DeptsDeptRelationship",
                        l => l.HasOne<DeptsDepartment>().WithMany().HasForeignKey("SubDeptOf").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Depts_DeptRelationships_Depts_Departments1"),
                        r => r.HasOne<DeptsDepartment>().WithMany().HasForeignKey("DeptId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Depts_DeptRelationships_Depts_Departments"),
                        j =>
                        {
                            j.HasKey("DeptId", "SubDeptOf").IsClustered(false);

                            j.ToTable("Depts_DeptRelationships");

                            j.IndexerProperty<short>("DeptId").HasColumnName("DeptID");
                        });
            });

            modelBuilder.Entity<DeptsSpellingVariation>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.StringVariation });

                entity.ToTable("Depts_SpellingVariations");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.StringVariation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.DeptsSpellingVariations)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Depts_SpellingVariations_Depts_Departments");
            });

            modelBuilder.Entity<DhlGlobalMailManifest>(entity =>
            {
                entity.HasKey(e => e.ManifestId);

                entity.ToTable("DHL_GlobalMail_Manifests");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileUploadDate).HasColumnType("datetime");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.DhlGlobalMailManifests)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_GlobalMail_Manifests_DHL_GlobalMail_Shipping_Settings");
            });

            modelBuilder.Entity<DhlGlobalMailRatesPacketPriorityDdu>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.CountryId, e.WeightInOz });

                entity.ToTable("DHL_GlobalMail_Rates_PacketPriority_DDU");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.DhlGlobalMailRatesPacketPriorityDdus)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_GlobalMail_Rates_PacketPriority_DDU_DHL_GlobalMail_Rates_PacketPriority_DDU_ShipToCountries");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.DhlGlobalMailRatesPacketPriorityDdus)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_GlobalMail_Rates_PacketPriority_DDU_DHL_GlobalMail_Rates_PacketPriority_DDU_DHL_GlobalMail_Rates_Period");
            });

            modelBuilder.Entity<DhlGlobalMailRatesParcelPriority>(entity =>
            {
                entity.HasKey(e => e.ZoneNumber);

                entity.ToTable("DHL_GlobalMail_Rates_ParcelPriority");

                entity.Property(e => e.ZoneNumber).ValueGeneratedNever();

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PerItem).HasColumnType("smallmoney");

                entity.Property(e => e.PerPound).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<DhlGlobalMailRatesParcelPriorityDdu>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.CountryId, e.WeightInOz });

                entity.ToTable("DHL_GlobalMail_Rates_ParcelPriority_DDU");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.DhlGlobalMailRatesParcelPriorityDdus)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_GlobalMail_Rates_ParcelPriority_DDU_DHL_GlobalMail_Rates_ParcelPriority_DDU_ShipToCountries");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.DhlGlobalMailRatesParcelPriorityDdus)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_GlobalMail_Rates_ParcelPriority_DDU_DHL_GlobalMail_Rates_ParcelPriority_DDU_DHL_GlobalMail_Rates_Period");
            });

            modelBuilder.Entity<DhlGlobalMailRatesParcelPriorityV2>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.WeightInOz, e.Zone })
                    .HasName("PK_DHL_GlobalMail_Rates_PriorityMail");

                entity.ToTable("DHL_GlobalMail_Rates_ParcelPriority_V2");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.DhlGlobalMailRatesParcelPriorityV2s)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_GlobalMail_Rates_ParcelPriority_V2_DHL_GlobalMail_Rates_Period");
            });

            modelBuilder.Entity<DhlGlobalMailRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("DHL_GlobalMail_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DhlGlobalMailShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentNum)
                    .HasName("PK_DHL_GlobalMail_Manifests_Shipments_1");

                entity.ToTable("DHL_GlobalMail_Shipments");

                entity.Property(e => e.ShipmentNum).ValueGeneratedNever();

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");
            });

            modelBuilder.Entity<DhlGlobalMailShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("DHL_GlobalMail_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.Ftpserver)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FTPServer");

                entity.Property(e => e.Ftpusername)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FTPUsername");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PermitNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PickupNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pocity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POCity");

                entity.Property(e => e.Postate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POState");

                entity.Property(e => e.Pozip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POZip");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DhlGlobalMailZone>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("DHL_GlobalMail_Zones");

                entity.Property(e => e.CountryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CountryID");
            });

            modelBuilder.Entity<DhlRatesParcelPlusExpedited>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("DHL_Rates_ParcelPlus_Expedited");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.DhlRatesParcelPlusExpediteds)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_Rates_ParcelPlus_Expedited_DHL_Rates_Period");
            });

            modelBuilder.Entity<DhlRatesParcelPlusGround>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("DHL_Rates_ParcelPlus_Ground");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.DhlRatesParcelPlusGrounds)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_Rates_ParcelPlus_Ground_DHL_Rates_Period");
            });

            modelBuilder.Entity<DhlRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("DHL_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<DhlRatesSmartMailExpedited>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.WeightInOunces, e.Rate });

                entity.ToTable("DHL_Rates_SmartMail_Expedited");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.DhlRatesSmartMailExpediteds)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_Rates_SmartMail_Expedited_DHL_Rates_Period");
            });

            modelBuilder.Entity<DhlRatesSmartMailGround>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.WeightInOunces, e.Rate });

                entity.ToTable("DHL_Rates_SmartMail_Ground");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.DhlRatesSmartMailGrounds)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DHL_Rates_SmartMail_Ground_DHL_Rates_Period");
            });

            modelBuilder.Entity<DhlShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("DHL_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PermitNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pocity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POCity");

                entity.Property(e => e.Postate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POState");

                entity.Property(e => e.Pozip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POZip");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EBayLmsJob>(entity =>
            {
                entity.ToTable("eBay_LMS_Job");

                entity.HasIndex(e => e.JobId, "IX_eBay_LMS_Job_JobID")
                    .HasFillFactor(90);

                entity.Property(e => e.AbortedOn).HasColumnType("datetime");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileRefId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileRefID");

                entity.Property(e => e.JobId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JobID");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PathToFile)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusErrorMessagesDownload).IsUnicode(false);

                entity.Property(e => e.StatusErrorMessagesUpload).IsUnicode(false);

                entity.Property(e => e.StatusMessagesDownload).IsUnicode(false);

                entity.Property(e => e.StatusMessagesUpload).IsUnicode(false);
            });

            modelBuilder.Entity<EBayOrder>(entity =>
            {
                entity.ToTable("eBay_Order");

                entity.HasIndex(e => e.BuyerUserId, "IX_eBay_Order_BuyerUserID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ExtendedOrderId, "IX_eBay_Order_ExtendedOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ExternalTransactionId, "IX_eBay_Order_ExternalTransactionID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.OrderId, "IX_eBay_Order_OrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.AcceptedOn).HasColumnType("datetime");

                entity.Property(e => e.AdjustmentTotal).HasColumnType("smallmoney");

                entity.Property(e => e.BuyerCheckoutMessage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerUserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BuyerUserID");

                entity.Property(e => e.CheckoutStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExtendedOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExtendedOrderID");

                entity.Property(e => e.ExternalTransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ExternalTransactionID");

                entity.Property(e => e.ExternalTransactionStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderID");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTotal).HasColumnType("smallmoney");

                entity.Property(e => e.PaymentHoldStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedOn).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFirstName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipLastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMiddleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingService)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingServiceAdditionalCost).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingServiceCost).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTotal).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.SubTotal).HasColumnType("smallmoney");

                entity.Property(e => e.TaxTotal).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<EBayOrderLine>(entity =>
            {
                entity.ToTable("eBay_Order_Line");

                entity.Property(e => e.BuyerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.EBayOrderId).HasColumnName("eBayOrderId");

                entity.Property(e => e.OrderLineItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderLineItemID");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ShippedOn).HasColumnType("datetime");

                entity.Property(e => e.Sku)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TransactionID");

                entity.HasOne(d => d.EBayOrder)
                    .WithMany(p => p.EBayOrderLines)
                    .HasForeignKey(d => d.EBayOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eBay_Order_Line_eBay_Order");
            });

            modelBuilder.Entity<EBayPayout>(entity =>
            {
                entity.ToTable("eBay_Payout");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LastAttemptedPayoutDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayoutDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayoutId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayoutStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayoutStatusDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<EBayPayoutTransaction>(entity =>
            {
                entity.ToTable("eBay_Payout_Transaction");

                entity.HasIndex(e => e.OrderId, "IX_eBay_Payout_Transaction_OrderId")
                    .HasFillFactor(90);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EBayPayoutId).HasColumnName("eBayPayoutId");

                entity.Property(e => e.FeeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentsEntity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRecordReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFeeAmount).HasColumnType("money");

                entity.Property(e => e.TotalFeeBasisAmount).HasColumnType("money");

                entity.Property(e => e.TransactionDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionMemo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EBayPayout)
                    .WithMany(p => p.EBayPayoutTransactions)
                    .HasForeignKey(d => d.EBayPayoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eBay_Payout_Order_eBay_Payout");
            });

            modelBuilder.Entity<EBayPayoutTransactionLine>(entity =>
            {
                entity.ToTable("eBay_Payout_Transaction_Line");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EBayPayoutTransactionId).HasColumnName("eBayPayoutTransactionId");

                entity.Property(e => e.FeeBasisAmount).HasColumnType("smallmoney");

                entity.Property(e => e.LineItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.EBayPayoutTransaction)
                    .WithMany(p => p.EBayPayoutTransactionLines)
                    .HasForeignKey(d => d.EBayPayoutTransactionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_eBay_Payout_Order_Line_eBay_Payout_Order");
            });

            modelBuilder.Entity<EancGroundGuide201210>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EANC_Ground_Guide_201210");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Das)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DAS");

                entity.Property(e => e.Route)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EcmsManifest>(entity =>
            {
                entity.HasKey(e => e.ManifestId)
                    .HasName("PK_ECMS_Manifests_Manifests");

                entity.ToTable("ECMS_Manifests");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EcmsShipment>(entity =>
            {
                entity.ToTable("ECMS_Shipments");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");
            });

            modelBuilder.Entity<EmailBounceLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("EmailBounceLog");

                entity.HasIndex(e => e.BouncedEmailAddress, "IX_EmailBounceLog_BouncedEmailAddress")
                    .HasFillFactor(90);

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.BounceCheckReturnValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BouncedEmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomHeaderDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomHeaderMessageId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CustomHeaderMessageID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MessageFromAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MessageFromFriendlyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MessageReplyToAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MessageReplyToFriendlyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MessageToFriendlyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MesssageSubject)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MesssageToAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailProviderAction>(entity =>
            {
                entity.ToTable("Email_Provider_Action");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailProviderId).HasColumnName("EmailProviderID");

                entity.Property(e => e.ErredOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMsg).IsUnicode(false);

                entity.Property(e => e.Parameters).IsUnicode(false);

                entity.Property(e => e.ProcessingOn).HasColumnType("datetime");

                entity.Property(e => e.SendOn).HasColumnType("datetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<EmailProviderActionType>(entity =>
            {
                entity.ToTable("Email_Provider_Action_Type");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailSendingAccount>(entity =>
            {
                entity.HasKey(e => e.EmailAccountId);

                entity.Property(e => e.EmailAccountId).HasColumnName("EmailAccountID");

                entity.Property(e => e.MailFromAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailServerAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<FedExCafeLookuptable>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("FedExCafe_lookuptable");

                entity.Property(e => e.UniqueId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UniqueID");

                entity.Property(e => e.OurShipMethodId).HasColumnName("OurShipMethodID");

                entity.Property(e => e.ServiceDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FedexFimsManifest>(entity =>
            {
                entity.HasKey(e => e.ManifestId);

                entity.ToTable("Fedex_FIMS_Manifests");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.TotalCostPrm)
                    .HasColumnType("money")
                    .HasColumnName("TotalCostPRM");

                entity.Property(e => e.TotalCostStd)
                    .HasColumnType("money")
                    .HasColumnName("TotalCostSTD");

                entity.Property(e => e.TotalPiecesPrm).HasColumnName("TotalPiecesPRM");

                entity.Property(e => e.TotalPiecesStd).HasColumnName("TotalPiecesSTD");

                entity.Property(e => e.TotalWeightInOzPrm)
                    .HasColumnType("money")
                    .HasColumnName("TotalWeightInOzPRM");

                entity.Property(e => e.TotalWeightInOzStd)
                    .HasColumnType("money")
                    .HasColumnName("TotalWeightInOzSTD");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.FedexFimsManifests)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fedex_FIMS_Manifests_Fedex_FIMS_Shipping_Settings");
            });

            modelBuilder.Entity<FedexFimsPrmFuelSurcharge>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("Fedex_FIMS_PRM_FuelSurcharge");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FedexFimsPrmRatesOverride>(entity =>
            {
                entity.HasKey(e => e.OverrideId);

                entity.ToTable("Fedex_FIMS_PRM_Rates_Overrides");

                entity.Property(e => e.OverrideId)
                    .ValueGeneratedNever()
                    .HasColumnName("OverrideID");

                entity.Property(e => e.CostPerPound).HasColumnType("smallmoney");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.FedexFimsPrmRatesOverrides)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fedex_FIMS_PRM_Rates_Overrides_ShipToCountries");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.FedexFimsPrmRatesOverrides)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fedex_FIMS_PRM_Rates_Overrides_Fedex_FIMS_PRM_Rates_Period1");
            });

            modelBuilder.Entity<FedexFimsPrmRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("Fedex_FIMS_PRM_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.DefaultCostPerPound).HasColumnType("smallmoney");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<FedexFimsShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentNum)
                    .HasName("PK_Fedex_FIMS_Manifests_Shipments_1");

                entity.ToTable("Fedex_FIMS_Shipments");

                entity.Property(e => e.ShipmentNum).ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");
            });

            modelBuilder.Entity<FedexFimsShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("Fedex_FIMS_Shipping_Settings");

                entity.Property(e => e.SettingId)
                    .ValueGeneratedNever()
                    .HasColumnName("SettingID");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FedexFimsStdFuelSurcharge>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("Fedex_FIMS_STD_FuelSurcharge");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FedexFimsStdRatesOverride>(entity =>
            {
                entity.HasKey(e => e.OverrideId);

                entity.ToTable("Fedex_FIMS_STD_Rates_Overrides");

                entity.Property(e => e.OverrideId)
                    .ValueGeneratedNever()
                    .HasColumnName("OverrideID");

                entity.Property(e => e.CostPerPound).HasColumnType("smallmoney");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.FedexFimsStdRatesOverrides)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fedex_FIMS_STD_Rates_Overrides_ShipToCountries");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.FedexFimsStdRatesOverrides)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fedex_FIMS_STD_Rates_Overrides_Fedex_FIMS_STD_Rates_Period1");
            });

            modelBuilder.Entity<FedexFimsStdRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("Fedex_FIMS_STD_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.DefaultCostPerPound).HasColumnType("smallmoney");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<FedexShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("Fedex_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSurchargePercent).HasColumnType("smallmoney");

                entity.Property(e => e.MeterNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperStateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FedexStatusCode>(entity =>
            {
                entity.HasKey(e => e.StatusCodeId);

                entity.ToTable("Fedex_Status_Codes");

                entity.HasIndex(e => e.StatusCodeId, "IX_Fedex_Status_Codes_StatusCode")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.StatusCodeId).HasColumnName("StatusCodeID");

                entity.Property(e => e.InternalDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gbk>(entity =>
            {
                entity.HasKey(e => e.Keyword)
                    .HasName("PK_Google_Banned_Keywords");

                entity.ToTable("GBKS");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GbksTemp>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.ToTable("GBKS_Temp");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gbp>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK_Google_Banned_ProdIDs");

                entity.ToTable("GBPS");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProdID");
            });

            modelBuilder.Entity<GbpsTemp>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("GBPS_Temp");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProdID");
            });

            modelBuilder.Entity<GiftCertificate>(entity =>
            {
                entity.HasIndex(e => e.CampaignId, "IX_GiftCertificates_CampaignID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.GeneratedByGiftCertificateId, "IX_GiftCertificates_GeneratedByGiftCertificateID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.GeneratedForEmail, "IX_GiftCertificates_GeneratedForEmail")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.GeneratedForMarketingPreferenceId, "IX_GiftCertificates_GeneratedForMarketingPreferenceID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.GeneratedForOrderId, "IX_GiftCertificates_GeneratedForOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.RedemptionCode, "IX_GiftCertificates_RedemptionCode")
                    .HasFillFactor(90);

                entity.Property(e => e.GiftCertificateId).HasColumnName("GiftCertificateID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.DateTimeCreated).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.GeneratedByAccountId).HasColumnName("GeneratedByAccountID");

                entity.Property(e => e.GeneratedByGiftCertificateId).HasColumnName("GeneratedByGiftCertificateID");

                entity.Property(e => e.GeneratedForEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratedForEmailName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratedForEmailNotes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.GeneratedForMarketingPreferenceId).HasColumnName("GeneratedForMarketingPreferenceID");

                entity.Property(e => e.GeneratedForOrderId).HasColumnName("GeneratedForOrderID");

                entity.Property(e => e.OriginalAmount).HasColumnType("smallmoney");

                entity.Property(e => e.RedemptionCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SentNotificationEmailOn).HasColumnType("datetime");

                entity.Property(e => e.TextToShowConsumer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.GiftCertificates)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GiftCertificates_GiftCertificates_Campaigns");
            });

            modelBuilder.Entity<GiftCertificatesCampaign>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("GiftCertificates_Campaigns");

                entity.Property(e => e.CampaignId)
                    .ValueGeneratedNever()
                    .HasColumnName("CampaignID");

                entity.Property(e => e.CampaignDesc)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignGuid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DefaultOriginalAmount).HasColumnType("smallmoney");

                entity.Property(e => e.MinEnableAmount).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<GiftCertificatesRedemption>(entity =>
            {
                entity.HasKey(e => new { e.GiftCertificateId, e.ProviderOrderId });

                entity.ToTable("GiftCertificates_Redemptions");

                entity.Property(e => e.GiftCertificateId).HasColumnName("GiftCertificateID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.AmountRedeemed).HasColumnType("smallmoney");

                entity.HasOne(d => d.GiftCertificate)
                    .WithMany(p => p.GiftCertificatesRedemptions)
                    .HasForeignKey(d => d.GiftCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GiftCertificates_Redemptions_GiftCertificates");
            });

            modelBuilder.Entity<GiftCertificatesRestriction>(entity =>
            {
                entity.HasKey(e => e.RestrictionId);

                entity.ToTable("GiftCertificates_Restrictions");

                entity.Property(e => e.RestrictionId).HasColumnName("RestrictionID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.GiftCertificateId).HasColumnName("GiftCertificateID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.GiftCertificate)
                    .WithMany(p => p.GiftCertificatesRestrictions)
                    .HasForeignKey(d => d.GiftCertificateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GiftCertificates_Restrictions_GiftCertificates");
            });

            modelBuilder.Entity<GoogleExclusions2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Google_Exclusions2");

                entity.Property(e => e.Column0)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 0");

                entity.Property(e => e.Column1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 1");

                entity.Property(e => e.Column2)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Column 2");
            });

            modelBuilder.Entity<GoogleShoppingOrder>(entity =>
            {
                entity.ToTable("Google_Shopping_Order");

                entity.HasIndex(e => e.GoogleOrderId, "IX_Google_Shopping_Order_GoogleOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.AcceptedOn).HasColumnType("datetime");

                entity.Property(e => e.BillingCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingLocality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingRecipientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingStreetAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingStreetAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingStreetAddress3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerInvoiceReceivingEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GoogleOrderID");

                entity.Property(e => e.NetPriceAmount).HasColumnType("smallmoney");

                entity.Property(e => e.NetTaxAmount).HasColumnType("smallmoney");

                entity.Property(e => e.PaymentStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlacedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectedOn).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingCostTax).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingLocality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingRecipientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingStreetAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingStreetAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingStreetAddress3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxCollector)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GoogleShoppingOrderLine>(entity =>
            {
                entity.ToTable("Google_Shopping_Order_Line");

                entity.Property(e => e.Brand)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.Condition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleOrderItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gtin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GTIN");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mpn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MPN");

                entity.Property(e => e.OfferId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ShippedOn).HasColumnType("datetime");

                entity.Property(e => e.ShippingDeliveryByDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingMethodCarrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingMethodName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingShipByDate).HasColumnType("datetime");

                entity.Property(e => e.ShippingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.GoogleShoppingOrder)
                    .WithMany(p => p.GoogleShoppingOrderLines)
                    .HasForeignKey(d => d.GoogleShoppingOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Google_Shopping_Order_Line_Google_Shopping_Order");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExclusiveToAdminId).HasColumnName("ExclusiveToAdminID");

                entity.Property(e => e.GroupDescription)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastRunDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.HasMany(d => d.Storefronts)
                    .WithMany(p => p.Groups)
                    .UsingEntity<Dictionary<string, object>>(
                        "GroupsStorefront",
                        l => l.HasOne<StorefrontInfo>().WithMany().HasForeignKey("StorefrontId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Groups_Storefronts_StorefrontInfo"),
                        r => r.HasOne<Group>().WithMany().HasForeignKey("GroupId").HasConstraintName("FK_Groups_Storefronts_Groups"),
                        j =>
                        {
                            j.HasKey("GroupId", "StorefrontId");

                            j.ToTable("Groups_Storefronts");

                            j.IndexerProperty<int>("GroupId").HasColumnName("GroupID");

                            j.IndexerProperty<short>("StorefrontId").HasColumnName("StorefrontID");
                        });
            });

            modelBuilder.Entity<GrouponOrderLine>(entity =>
            {
                entity.ToTable("Groupon_Order_Line");

                entity.HasIndex(e => e.FulfillmentLineItemId, "IX_Groupon_Order_Line_FulfillmentLineItemID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.MerchantSkuItem, "IX_Groupon_Order_Line_MerchantSkuItem")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ParentOrderId, "IX_Groupon_Order_Line_ParentOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.AcceptedOn).HasColumnType("datetime");

                entity.Property(e => e.BillingAddressCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BillingAddressStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BomSku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CountryOfOrigin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomFieldValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DealOpportunityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DealOpportunityID");

                entity.Property(e => e.FeatureEndDate).HasColumnType("datetime");

                entity.Property(e => e.FeatureStartDate).HasColumnType("datetime");

                entity.Property(e => e.FulfillmentLineItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FulfillmentLineItemID");

                entity.Property(e => e.FulfillmentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GiftMessage)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.GrouponCost).HasColumnType("smallmoney");

                entity.Property(e => e.GrouponNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrouponSku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HtsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IncoTerms)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.KittingDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantPermaLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantSkuItem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.ParentOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ParentOrderID");

                entity.Property(e => e.PermaLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductDimensionUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductHeight).HasColumnType("smallmoney");

                entity.Property(e => e.ProductLength).HasColumnType("smallmoney");

                entity.Property(e => e.ProductWeight).HasColumnType("smallmoney");

                entity.Property(e => e.ProductWeightUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductWidth).HasColumnType("smallmoney");

                entity.Property(e => e.PurchaseOrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedOn).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SalesForceDealOptionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SalesForceDealOptionID");

                entity.Property(e => e.SellPrice).HasColumnType("smallmoney");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentAddressCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentAddressCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentAddressName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentAddressPostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentAddressState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentAddressStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentAddressStreet2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentCarrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentMethodRequested)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentStrategy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentTrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.ThirdPartyLogisticsName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdPartyLogisticsWarehouseLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VendorID");
            });

            modelBuilder.Entity<GrouponOrdersFile>(entity =>
            {
                entity.ToTable("Groupon_Orders_File");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<GrouponSetting>(entity =>
            {
                entity.ToTable("Groupon_Setting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DefaultShipMethodId).HasColumnName("DefaultShipMethodID");

                entity.Property(e => e.EmailDomain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailNotificationsOrderImport)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sftphost)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPHost");

                entity.Property(e => e.Sftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPPassword");

                entity.Property(e => e.Sftpuser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPUser");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<GrouponTrackingFile>(entity =>
            {
                entity.ToTable("Groupon_Tracking_File");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UploadedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<GroupsDiscountsBrand>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("Groups_Discounts_Brands");

                entity.HasIndex(e => new { e.GroupId, e.BrandId }, "IX_Groups_Discounts_Brands_GroupID_BrandID")
                    .IsUnique();

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.PercentOffStdWhls).HasColumnType("smallmoney");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.GroupsDiscountsBrands)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_Discounts_Brands_Prods_Brands");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupsDiscountsBrands)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Groups_Discounts_Brands_Groups");
            });

            modelBuilder.Entity<GroupsDiscountsProdOverride>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("Groups_Discounts_ProdOverrides");

                entity.HasIndex(e => new { e.GroupId, e.ProdId }, "IX_Groups_Discounts_ProdOverrides_GroupID_ProdID")
                    .IsUnique();

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.PercentOffStdWhls).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupsDiscountsProdOverrides)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_Groups_Discounts_ProdOverrides_Groups");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.GroupsDiscountsProdOverrides)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Groups_Discounts_ProdOverrides_Prods_Products");
            });

            modelBuilder.Entity<GsoExtendedAreaZipCode>(entity =>
            {
                entity.HasKey(e => e.ZipCode);

                entity.ToTable("GSO_ExtendedArea_ZipCodes");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GsoRate>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("GSO_Rates");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<GsoRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("GSO_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<GsoShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("GSO_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSurchargePercent).HasColumnType("smallmoney");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperStateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GsoZipCode>(entity =>
            {
                entity.HasKey(e => e.Zip)
                    .HasName("PK_GSO_Zip");

                entity.ToTable("GSO_ZipCodes");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GsoZipCodesOriginal>(entity =>
            {
                entity.HasKey(e => e.Zip)
                    .HasName("PK_GSO_ZipCodes");

                entity.ToTable("GSO_ZipCodes_ORIGINAL");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeartbeatPrimaryAgent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Heartbeat_Primary_Agent");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HeartbeatUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Heartbeat_URLs");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LastHit).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.HasKey(e => e.HolidayDate);

                entity.ToTable("Holiday");

                entity.Property(e => e.HolidayDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ImgGen>(entity =>
            {
                entity.HasKey(e => e.ImgId);

                entity.ToTable("ImgGen");

                entity.Property(e => e.ImgId).HasColumnName("ImgID");
            });

            modelBuilder.Entity<InterProviderBillingClass>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("InterProviderBilling_Classes");

                entity.Property(e => e.ClassId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClassID");

                entity.Property(e => e.ClassDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InterProviderBillingInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("InterProviderBilling_Invoices");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.FromProviderId).HasColumnName("FromProviderID");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceDateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ToProviderId).HasColumnName("ToProviderID");

                entity.HasOne(d => d.FromProvider)
                    .WithMany(p => p.InterProviderBillingInvoiceFromProviders)
                    .HasForeignKey(d => d.FromProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_Invoices_Providers");

                entity.HasOne(d => d.ToProvider)
                    .WithMany(p => p.InterProviderBillingInvoiceToProviders)
                    .HasForeignKey(d => d.ToProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_Invoices_Providers1");
            });

            modelBuilder.Entity<InterProviderBillingPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("InterProviderBilling_Payments");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.FromProviderId).HasColumnName("FromProviderID");

                entity.Property(e => e.PaymentAmount).HasColumnType("money");

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ToProviderId).HasColumnName("ToProviderID");

                entity.HasOne(d => d.FromProvider)
                    .WithMany(p => p.InterProviderBillingPaymentFromProviders)
                    .HasForeignKey(d => d.FromProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_Payments_Providers1");

                entity.HasOne(d => d.ToProvider)
                    .WithMany(p => p.InterProviderBillingPaymentToProviders)
                    .HasForeignKey(d => d.ToProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_Payments_Providers");
            });

            modelBuilder.Entity<InterProviderBillingPaymentToInvoiceRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("InterProviderBilling_PaymentToInvoice_Relationships");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.AmountApplied).HasColumnType("money");

                entity.Property(e => e.DateApplied).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InterProviderBillingPaymentToInvoiceRelationships)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_PaymentToInvoice_Relationships_InterProviderBilling_Invoices");
            });

            modelBuilder.Entity<InterProviderBillingTransaction>(entity =>
            {
                entity.HasKey(e => e.TransNum);

                entity.ToTable("InterProviderBilling_Transactions");

                entity.Property(e => e.CalculatedCostMethodId).HasColumnName("CalculatedCostMethodID");

                entity.Property(e => e.CalculatedCostToProviderUpdatable)
                    .HasColumnType("smallmoney")
                    .HasColumnName("CalculatedCostToProvider_updatable");

                entity.Property(e => e.DateCostToProviderCalculated).HasColumnType("smalldatetime");

                entity.Property(e => e.FromProviderId).HasColumnName("FromProviderID");

                entity.Property(e => e.InvoiceIdassignedTo).HasColumnName("InvoiceIDAssignedTo");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ToProviderId).HasColumnName("ToProviderID");

                entity.Property(e => e.TransClassId).HasColumnName("TransClassID");

                entity.Property(e => e.TransDesc)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.TransTime).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("money");

                entity.HasOne(d => d.FromProvider)
                    .WithMany(p => p.InterProviderBillingTransactionFromProviders)
                    .HasForeignKey(d => d.FromProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_Transactions_Providers");

                entity.HasOne(d => d.ToProvider)
                    .WithMany(p => p.InterProviderBillingTransactionToProviders)
                    .HasForeignKey(d => d.ToProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_Transactions_Providers1");

                entity.HasOne(d => d.TransClass)
                    .WithMany(p => p.InterProviderBillingTransactions)
                    .HasForeignKey(d => d.TransClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InterProviderBilling_Transactions_InterProviderBilling_Classes");
            });

            modelBuilder.Entity<InventoryAdjustment>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK_InventoryRetirement");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InventoryAdjustments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InventoryRetirement_Admins_Provider");
            });

            modelBuilder.Entity<InventoryLog>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("Inventory_Log");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Cainv).HasColumnName("CAInv");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Ncinv).HasColumnName("NCInv");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<IterableActionObsolete>(entity =>
            {
                entity.ToTable("Iterable_Action_OBSOLETE");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErredOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMsg)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Parameters).IsUnicode(false);

                entity.Property(e => e.ProcessingOn).HasColumnType("datetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<IterableActionTypeObsolete>(entity =>
            {
                entity.ToTable("Iterable_Action_Type_OBSOLETE");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IterableSetting>(entity =>
            {
                entity.ToTable("Iterable_Setting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JetFileUpload>(entity =>
            {
                entity.ToTable("Jet_FileUpload");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorExcerpt)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorUrl)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ErrorURL");

                entity.Property(e => e.FileId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FileID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeTriggerOnCompletion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingEndedOn).HasColumnType("datetime");

                entity.Property(e => e.ProcessingStartedOn).HasColumnType("datetime");

                entity.Property(e => e.ReceivedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<JetMerchantSkusAvailable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jet_MerchantSKUs_Available");

                entity.Property(e => e.Inventory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Substatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JetOrder>(entity =>
            {
                entity.ToTable("Jet_Order");

                entity.HasIndex(e => e.MerchantOrderId, "IX_Jet_Order_MerchantOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ReferenceOrderId, "IX_Jet_Order_ReferenceOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.AcceptedOn).HasColumnType("datetime");

                entity.Property(e => e.BuyerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BuyerPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FulfillmentNode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HashEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantOrderID");

                entity.Property(e => e.OrderPlacedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderTransmissionDate).HasColumnType("datetime");

                entity.Property(e => e.RawJson)
                    .IsUnicode(false)
                    .HasColumnName("RawJSON");

                entity.Property(e => e.ReferenceOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceOrderID");

                entity.Property(e => e.RejectedOn).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDeliveryBy).HasColumnType("datetime");

                entity.Property(e => e.RequestServiceLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestShipBy).HasColumnType("datetime");

                entity.Property(e => e.RequestShippingCarrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRecipientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipRecipientPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<JetOrderLine>(entity =>
            {
                entity.ToTable("Jet_Order_Line");

                entity.Property(e => e.BasePrice).HasColumnType("smallmoney");

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ItemShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.ItemShippingTax).HasColumnType("smallmoney");

                entity.Property(e => e.ItemTax).HasColumnType("smallmoney");

                entity.Property(e => e.ItemTaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantSku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantSKU");

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProductTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedOn).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.JetOrder)
                    .WithMany(p => p.JetOrderLines)
                    .HasForeignKey(d => d.JetOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jet_Orders_Jet_Orders_Lines");
            });

            modelBuilder.Entity<JetOrderLineFeeAdjustment>(entity =>
            {
                entity.ToTable("Jet_Order_Line_FeeAdjustment");

                entity.Property(e => e.AdjustmentName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CommissionID");

                entity.Property(e => e.Value).HasColumnType("smallmoney");

                entity.HasOne(d => d.JetOrderLine)
                    .WithMany(p => p.JetOrderLineFeeAdjustments)
                    .HasForeignKey(d => d.JetOrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jet_Order_Line_FeeAdjustment_Jet_Order_Line");
            });

            modelBuilder.Entity<JetProductMissingDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jet_Product_MissingData");

                entity.Property(e => e.Inventory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku).HasColumnName("SKU");

                entity.Property(e => e.Status)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Substatus)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JetReturn>(entity =>
            {
                entity.ToTable("Jet_Return");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MerchantOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantOrderID");

                entity.Property(e => e.MerchantReturnAuthorizationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantReturnAuthorizationID");

                entity.Property(e => e.MerchantReturnCharge).HasColumnType("smallmoney");

                entity.Property(e => e.RawJson)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("RawJSON");

                entity.Property(e => e.ReferenceOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceOrderID");

                entity.Property(e => e.ReferenceReturnAuthorizationId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceReturnAuthorizationID");

                entity.Property(e => e.ReturnChargeFeedback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");

                entity.Property(e => e.ReturnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReturnID");

                entity.Property(e => e.ReturnStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCarrier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<JetReturnLine>(entity =>
            {
                entity.ToTable("Jet_Return_Line");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MerchantSku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantSKU");

                entity.Property(e => e.MerchantSkutitle)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("MerchantSKUTitle");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID");

                entity.Property(e => e.Principal).HasColumnType("smallmoney");

                entity.Property(e => e.Reason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RefundFeedback)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefundPrincipal).HasColumnType("smallmoney");

                entity.Property(e => e.RefundShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.RefundShippingTax).HasColumnType("smallmoney");

                entity.Property(e => e.RefundTax).HasColumnType("smallmoney");

                entity.Property(e => e.RefundedOn).HasColumnType("datetime");

                entity.Property(e => e.ShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTax).HasColumnType("smallmoney");

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.HasOne(d => d.JetReturn)
                    .WithMany(p => p.JetReturnLines)
                    .HasForeignKey(d => d.JetReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jet_Return_Line_Jet_Return");
            });

            modelBuilder.Entity<JetSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId)
                    .HasName("PK_Jet_Settings");

                entity.ToTable("Jet_Setting");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.ApiSecret)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApiUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaFulfillmentNodeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CaFulfillmentNodeID");

                entity.Property(e => e.ExpeditedShipMethodId).HasColumnName("ExpeditedShipMethodID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NcFulfillmentNodeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NcFulfillmentNodeID");

                entity.Property(e => e.StandardShipMethodId).HasColumnName("StandardShipMethodID");
            });

            modelBuilder.Entity<JetSettlement>(entity =>
            {
                entity.ToTable("Jet_Settlement");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JetAdjustment).HasColumnType("money");

                entity.Property(e => e.OrderBalance).HasColumnType("money");

                entity.Property(e => e.OrderBaseCommission).HasColumnType("money");

                entity.Property(e => e.OrderFulfillmentFee).HasColumnType("money");

                entity.Property(e => e.OrderMerchantPrice).HasColumnType("money");

                entity.Property(e => e.OrderShippingCharge).HasColumnType("money");

                entity.Property(e => e.OrderShippingRevenue).HasColumnType("money");

                entity.Property(e => e.OrderShippingTax).HasColumnType("money");

                entity.Property(e => e.OrderTax).HasColumnType("money");

                entity.Property(e => e.OrderVariableCommission).HasColumnType("money");

                entity.Property(e => e.PeriodEnd).HasColumnType("datetime");

                entity.Property(e => e.PeriodStart).HasColumnType("datetime");

                entity.Property(e => e.ReportId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportID");

                entity.Property(e => e.ReportId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("report_id");

                entity.Property(e => e.ReturnBalance).HasColumnType("money");

                entity.Property(e => e.ReturnBaseCommission).HasColumnType("money");

                entity.Property(e => e.ReturnMerchantPrice).HasColumnType("money");

                entity.Property(e => e.ReturnMerchantReturnCharge).HasColumnType("money");

                entity.Property(e => e.ReturnProcessingFee).HasColumnType("money");

                entity.Property(e => e.ReturnShippingRevenue).HasColumnType("money");

                entity.Property(e => e.ReturnShippingTax).HasColumnType("money");

                entity.Property(e => e.ReturnTax).HasColumnType("money");

                entity.Property(e => e.ReturnVariableCommission).HasColumnType("money");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.UnavailableBalance).HasColumnType("money");

                entity.Property(e => e.Value).HasColumnType("money");
            });

            modelBuilder.Entity<JetSettlementOrder>(entity =>
            {
                entity.ToTable("Jet_Settlement_Order");

                entity.Property(e => e.BaseCommission).HasColumnType("smallmoney");

                entity.Property(e => e.MerchantOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantOrderID");

                entity.Property(e => e.MerchantPrice).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTax).HasColumnType("smallmoney");

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.Property(e => e.TotalOrderBalance).HasColumnType("smallmoney");

                entity.Property(e => e.VariableCommission).HasColumnType("smallmoney");

                entity.HasOne(d => d.JetSettlement)
                    .WithMany(p => p.JetSettlementOrders)
                    .HasForeignKey(d => d.JetSettlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jet_Settlement_Order_Jet_Settlement");
            });

            modelBuilder.Entity<JetSettlementOrderItem>(entity =>
            {
                entity.ToTable("Jet_Settlement_Order_Item");

                entity.Property(e => e.BaseCommission).HasColumnType("smallmoney");

                entity.Property(e => e.FulfillmentMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantPrice).HasColumnType("smallmoney");

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID");

                entity.Property(e => e.ShippingRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTax).HasColumnType("smallmoney");

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.Property(e => e.TotalOrderItemBalance).HasColumnType("smallmoney");

                entity.Property(e => e.VariableCommission).HasColumnType("smallmoney");

                entity.HasOne(d => d.JetSettlementOrder)
                    .WithMany(p => p.JetSettlementOrderItems)
                    .HasForeignKey(d => d.JetSettlementOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jet_Settlement_Order_Item_Jet_Settlement_Order");
            });

            modelBuilder.Entity<JetSettlementReturn>(entity =>
            {
                entity.ToTable("Jet_Settlement_Return");

                entity.Property(e => e.BaseCommission).HasColumnType("smallmoney");

                entity.Property(e => e.MerchantOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantOrderID");

                entity.Property(e => e.MerchantPrice).HasColumnType("smallmoney");

                entity.Property(e => e.MerchantReturnCharge).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTax).HasColumnType("smallmoney");

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.Property(e => e.TotalReturnBalance).HasColumnType("smallmoney");

                entity.Property(e => e.VariableCommission).HasColumnType("smallmoney");

                entity.HasOne(d => d.JetSettlement)
                    .WithMany(p => p.JetSettlementReturns)
                    .HasForeignKey(d => d.JetSettlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jet_Settlement_Return_Jet_Settlement");
            });

            modelBuilder.Entity<JetSettlementReturnItem>(entity =>
            {
                entity.ToTable("Jet_Settlement_Return_Item");

                entity.Property(e => e.BaseCommission).HasColumnType("smallmoney");

                entity.Property(e => e.MerchantPrice).HasColumnType("smallmoney");

                entity.Property(e => e.MerchantReturnCharge).HasColumnType("smallmoney");

                entity.Property(e => e.OrderItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OrderItemID");

                entity.Property(e => e.ReturnId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReturnID");

                entity.Property(e => e.ReturnLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTax).HasColumnType("smallmoney");

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.Property(e => e.TotalReturnItemBalance).HasColumnType("smallmoney");

                entity.Property(e => e.VariableCommission).HasColumnType("smallmoney");

                entity.HasOne(d => d.JetSettlementReturn)
                    .WithMany(p => p.JetSettlementReturnItems)
                    .HasForeignKey(d => d.JetSettlementReturnId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Jet_Settlement_Return_Item_Jet_Settlement_Return");
            });

            modelBuilder.Entity<KeywordsSpellingVariation>(entity =>
            {
                entity.HasKey(e => new { e.KeywordId, e.StringVariation })
                    .IsClustered(false);

                entity.ToTable("Keywords_SpellingVariations");

                entity.HasIndex(e => e.KeywordId, "IX_Keywords_SpellingVariations_KeywordID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StringVariation, "IX_temp_to_solve_optimizer_not_using_other_indexes3")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StringVariation, "IX_temp_to_solve_optimizer_not_using_other_indexes4")
                    .HasFillFactor(90);

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.StringVariation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.KeywordsSpellingVariations)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Keywords_SpellingVariations_Keywords_Standard");
            });

            modelBuilder.Entity<KeywordsStandard>(entity =>
            {
                entity.HasKey(e => e.KeywordId)
                    .IsClustered(false);

                entity.ToTable("Keywords_Standard");

                entity.HasIndex(e => e.LastInfoChangeTimestamp, "IX_Keywords_Standard_LastInfoChangeTimestamp")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StandardString, "IX_Keywords_Standard_StdString_Const")
                    .IsUnique();

                entity.HasIndex(e => e.StandardString, "IX_Keywords_Standard_StdString_Constraint")
                    .IsUnique();

                entity.HasIndex(e => e.KeywordId, "IX_temp_to_solve_optimizer_not_using_other_indexes")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StandardString, "IX_temp_to_solve_optimizer_not_using_other_indexes2")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StandardString, "IX_temp_to_solve_optimizer_not_using_other_indexes3")
                    .HasFillFactor(90);

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.LastInfoChangeTimestamp).HasColumnType("datetime");

                entity.Property(e => e.StandardString)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LandmarkGlobalManifest>(entity =>
            {
                entity.HasKey(e => e.ManifestId);

                entity.ToTable("Landmark_Global_Manifests");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileUploadDate).HasColumnType("datetime");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.LandmarkGlobalManifests)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Landmark_Global_Manifests_Landmark_Global_Shipping_Settings");
            });

            modelBuilder.Entity<LandmarkGlobalShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentNum)
                    .HasName("PK_Landmark_Global_Shipments_");

                entity.ToTable("Landmark_Global_Shipments");

                entity.Property(e => e.ShipmentNum).ValueGeneratedNever();

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");
            });

            modelBuilder.Entity<LandmarkGlobalShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("Landmark_Global_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.Ftpserver)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FTPServer");

                entity.Property(e => e.Ftpusername)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FTPUsername");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PermitNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pocity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POCity");

                entity.Property(e => e.Postate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POState");

                entity.Property(e => e.Pozip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POZip");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LangId);

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.LanguageLocalizedName).HasMaxLength(25);

                entity.Property(e => e.LanguageName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaserShipRate>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("LaserShip_Rates");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<LaserShipRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("LaserShip_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<LaserShipShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("LaserShip_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apiid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APIID");

                entity.Property(e => e.Apikey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("APIKey");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperStateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LaserShipZipCode>(entity =>
            {
                entity.HasKey(e => e.Zip);

                entity.ToTable("LaserShip_ZipCodes");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LegitScriptResultProductMatch>(entity =>
            {
                entity.ToTable("LegitScript_Result_Product_Match");

                entity.HasIndex(e => e.Manufacturer, "IX_LegitScript_Result_Product_Match_Manfacturer")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_LegitScript_Result_Product_Match_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ResultTerm, "IX_LegitScript_Result_Product_Match_ResultTerm")
                    .HasFillFactor(90);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ResultTerm)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LinkShareTransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("LinkShare_Transactions");

                entity.Property(e => e.TransactionId).HasColumnName("TransactionID");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.Currency)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("SiteID");

                entity.Property(e => e.SkuNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TimeCompleted).HasColumnType("datetime");

                entity.Property(e => e.TimeEntered).HasColumnType("datetime");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.LinkShareTransactions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LinkShare_Transactions_LinkShare_Transactions_Status");
            });

            modelBuilder.Entity<LinkShareTransactionsStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("LinkShare_Transactions_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailExpressClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK_MailExpress_SortCode_Class");

                entity.ToTable("MailExpress_Class");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryConfirmationFee).HasColumnType("smallmoney");

                entity.Property(e => e.LowerBoundWeightInOunces).HasColumnType("smallmoney");

                entity.Property(e => e.ServiceTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpperBoundWeightInOunces).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<MailExpressRatesParcelSelect>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("MailExpress_Rates_ParcelSelect");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.MailExpressRatesParcelSelects)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailExpress_Rates_ParcelSelect_MailExpress_Rates_Period");
            });

            modelBuilder.Entity<MailExpressRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("MailExpress_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MailExpressRatesPresortedStd>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.WeightInOunces, e.Rate });

                entity.ToTable("MailExpress_Rates_PresortedStd");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.MailExpressRatesPresortedStds)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailExpress_Rates_PresortedStd_MailExpress_Rates_Period");
            });

            modelBuilder.Entity<MailExpressShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("MailExpress_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PermitNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pocity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POCity");

                entity.Property(e => e.Postate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POState");

                entity.Property(e => e.Pozip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POZip");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailExpressSortCode>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.ClassId, e.SortZip });

                entity.ToTable("MailExpress_SortCode");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.SortZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.MailExpressSortCodes)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailExpress_SortCode_MailExpress_SortCode_Period");
            });

            modelBuilder.Entity<MailExpressSortCodePeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("MailExpress_SortCode_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MailExpressTrackingEvent>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("MailExpress_Tracking_Events");

                entity.HasIndex(e => e.PackageId2, "IX_MailExpress_Tracking_Events_PackageID2")
                    .HasFillFactor(90);

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.CosigneeAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CosigneeAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CosigneeCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CosigneeCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CosigneeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CosigneeState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CosigneeZip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EventCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EventSource)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EventState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventZip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.PackageId1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PackageID1");

                entity.Property(e => e.PackageId2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PackageID2");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.HasOne(d => d.EventCodeNavigation)
                    .WithMany(p => p.MailExpressTrackingEvents)
                    .HasForeignKey(d => d.EventCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailExpress_Tracking_Events_MailExpress_Tracking_EventCode");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.MailExpressTrackingEvents)
                    .HasForeignKey(d => d.ImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MailExpress_Tracking_Events_MailExpress_Tracking_Import");
            });

            modelBuilder.Entity<MailExpressTrackingEventCode>(entity =>
            {
                entity.HasKey(e => e.EventCode)
                    .HasName("PK_MailExpress_Tracking_EventCode_1");

                entity.ToTable("MailExpress_Tracking_EventCode");

                entity.Property(e => e.EventCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EventCodeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailExpressTrackingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("MailExpress_Tracking_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingDealOfTheDay>(entity =>
            {
                entity.HasKey(e => e.DealId);

                entity.ToTable("Marketing_DealOfTheDay");

                entity.Property(e => e.DealId).HasColumnName("DealID");

                entity.Property(e => e.ActualEndDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ActualStartDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedOnDateTime).HasColumnType("datetime");

                entity.Property(e => e.DealDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.DealName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.MarketingDealOfTheDays)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Marketing_DealOfTheDay_StorefrontInfo");
            });

            modelBuilder.Entity<MarketingDealOfTheDayProd>(entity =>
            {
                entity.HasKey(e => e.DealProdId);

                entity.ToTable("Marketing_DealOfTheDay_Prods");

                entity.Property(e => e.DealProdId).HasColumnName("DealProdID");

                entity.Property(e => e.CreatedOnDateTime).HasColumnType("datetime");

                entity.Property(e => e.DealCurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.DealId).HasColumnName("DealID");

                entity.Property(e => e.OldCurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Deal)
                    .WithMany(p => p.MarketingDealOfTheDayProds)
                    .HasForeignKey(d => d.DealId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Marketing_DealOfTheDay_Prods_Marketing_DealOfTheDay");
            });

            modelBuilder.Entity<MarketingEmailCampaign>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("Marketing_Email_Campaign");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.FromEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Htmlsource)
                    .HasColumnType("text")
                    .HasColumnName("HTMLSource");

                entity.Property(e => e.Notes)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TextSource).HasColumnType("text");
            });

            modelBuilder.Entity<MarketingEmailLink>(entity =>
            {
                entity.HasKey(e => new { e.LinkId, e.CampaignId });

                entity.ToTable("Marketing_Email_Links");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.LinkDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Campaign)
                    .WithMany(p => p.MarketingEmailLinks)
                    .HasForeignKey(d => d.CampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Marketing_Email_Links_Marketing_Email_Campaign");
            });

            modelBuilder.Entity<MarketingEmailsIterableStaging>(entity =>
            {
                entity.HasKey(e => e.ProspectId);

                entity.ToTable("Marketing_Emails_ITERABLE_STAGING");

                entity.Property(e => e.ProspectId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProspectID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.LastMailedOn).HasColumnType("datetime");

                entity.Property(e => e.LastOrderedOn).HasColumnType("datetime");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.ProcessingOn).HasColumnType("datetime");

                entity.Property(e => e.ProspectIdstring)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProspectIDstring");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<MarketingEmailsMetadatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Marketing_Emails_Metadata");

                entity.Property(e => e.LastSerialNumSent)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingEmailsSerial>(entity =>
            {
                entity.HasKey(e => e.SerialNum);

                entity.ToTable("Marketing_Emails_Serials");

                entity.HasIndex(e => new { e.CampaignId, e.LinkId }, "IX_Marketing_Emails_Serials_campaignid_linkid")
                    .HasFillFactor(90);

                entity.Property(e => e.SerialNum)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.DateTimeSent).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.ProspectId).HasColumnName("ProspectID");

                entity.HasOne(d => d.Prospect)
                    .WithMany(p => p.MarketingEmailsSerials)
                    .HasForeignKey(d => d.ProspectId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Marketing_Emails_Serials_MarketingPreferences");
            });

            modelBuilder.Entity<MarketingEmailsTemplateDatum>(entity =>
            {
                entity.ToTable("Marketing_Emails_Template_Data");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Template)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MarketingPreference>(entity =>
            {
                entity.HasKey(e => e.ProspectId);

                entity.HasIndex(e => e.AccountId, "IX_MarketingPreferences_AccountID")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Email, e.StorefrontId }, "IX_MarketingPreferences_Email")
                    .IsUnique();

                entity.Property(e => e.ProspectId).HasColumnName("ProspectID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateTimeCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FName");

                entity.Property(e => e.LastBounceTimeStamp).HasColumnType("smalldatetime");

                entity.Property(e => e.Lname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LName");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefillRemindersLastmailing)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("RefillReminders_lastmailing");

                entity.Property(e => e.RefillRemindersWeeksbeforeempty).HasColumnName("RefillReminders_weeksbeforeempty");

                entity.Property(e => e.SalesMailingsLastmailing)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SalesMailings_lastmailing");

                entity.Property(e => e.SalesMailingsMonthlyfrequency).HasColumnName("SalesMailings_monthlyfrequency");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Zip)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.MarketingPreferences)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_MarketingPreferences_UserAccounts");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.MarketingPreferences)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MarketingPreferences_StorefrontInfo");
            });

            modelBuilder.Entity<MetatagsBrand>(entity =>
            {
                entity.HasKey(e => new { e.BrandId, e.StorefrontId });

                entity.ToTable("Metatags_Brands");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.Header)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InternalNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Description");

                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Keywords");

                entity.Property(e => e.MetaTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Title");

                entity.Property(e => e.Urlid).HasColumnName("URLID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.MetatagsBrands)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Metatags_Brands_Prods_Brands");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.MetatagsBrands)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Metatags_Brands_StorefrontInfo");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.MetatagsBrands)
                    .HasForeignKey(d => d.Urlid)
                    .HasConstraintName("FK_Metatags_Brands_StandardURLs");
            });

            modelBuilder.Entity<MetatagsDept>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.StorefrontId });

                entity.ToTable("Metatags_Depts");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.Header)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InternalNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Description");

                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Keywords");

                entity.Property(e => e.MetaTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Title");

                entity.Property(e => e.TempFscontentbackup)
                    .HasColumnType("text")
                    .HasColumnName("TempFScontentbackup");

                entity.Property(e => e.Urlid).HasColumnName("URLID");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.MetatagsDepts)
                    .HasForeignKey(d => d.DeptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Metatags_Depts_Depts_Departments");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.MetatagsDepts)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Metatags_Depts_StorefrontInfo");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.MetatagsDepts)
                    .HasForeignKey(d => d.Urlid)
                    .HasConstraintName("FK_Metatags_Depts_StandardURLs");
            });

            modelBuilder.Entity<MetatagsFam>(entity =>
            {
                entity.HasKey(e => new { e.FamId, e.StorefrontId });

                entity.ToTable("Metatags_Fams");

                entity.HasIndex(e => new { e.StorefrontId, e.FamUrlforSeo }, "IX_Metatags_Fams_StorefrontID_FamURLForSEO")
                    .IsUnique();

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.FamUrlforSeo)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FamURLForSEO");

                entity.Property(e => e.Header)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.InternalNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Description");

                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Keywords");

                entity.Property(e => e.MetaTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Title");

                entity.Property(e => e.Urlid).HasColumnName("URLID");

                entity.HasOne(d => d.Fam)
                    .WithMany(p => p.MetatagsFams)
                    .HasForeignKey(d => d.FamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Metatags_Fams_Prods_Families");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.MetatagsFams)
                    .HasForeignKey(d => d.Urlid)
                    .HasConstraintName("FK_Metatags_Fams_StandardURLs");
            });

            modelBuilder.Entity<MetatagsFamsOverride>(entity =>
            {
                entity.HasKey(e => new { e.FamId, e.StorefrontId });

                entity.ToTable("Metatags_Fams_Overrides");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Content).HasColumnType("ntext");
            });

            modelBuilder.Entity<MetatagsKeyword>(entity =>
            {
                entity.HasKey(e => new { e.KeywordId, e.StorefrontId })
                    .HasName("PK_Keywords_Metatags");

                entity.ToTable("Metatags_Keywords");

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.DivertToUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DivertToURL");

                entity.Property(e => e.Header)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InternalNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MetaDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Description");

                entity.Property(e => e.MetaKeywords)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Keywords");

                entity.Property(e => e.MetaTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("Meta_Title");

                entity.Property(e => e.Urlid).HasColumnName("URLID");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.MetatagsKeywords)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Keywords_Metatags_Keywords_Standard");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.MetatagsKeywords)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Keywords_Metatags_StorefrontInfo");

                entity.HasOne(d => d.Url)
                    .WithMany(p => p.MetatagsKeywords)
                    .HasForeignKey(d => d.Urlid)
                    .HasConstraintName("FK_Metatags_Keywords_StandardURLs");
            });

            modelBuilder.Entity<NackOrder>(entity =>
            {
                entity.HasKey(e => new { e.ProviderOrderId, e.ProdId })
                    .IsClustered(false);

                entity.ToTable("Nack_Orders");

                entity.HasIndex(e => e.DateTimeRecorded, "IX_Nack_Orders_DateTimeRecorded")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.DateTimeRecorded).HasColumnType("smalldatetime");

                entity.Property(e => e.NackPrice).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontPrice).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<NackPriceControl>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.ProdId });

                entity.ToTable("Nack_PriceControl");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.HideFromSf).HasColumnName("HideFromSF");

                entity.Property(e => e.MarkupPercent).HasColumnType("smallmoney");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.NackPriceControls)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nack_PriceControl_StorefrontInfo");
            });

            modelBuilder.Entity<NackStorefront>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Nack_Storefronts");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.DefaultMarkupPercent).HasColumnType("smallmoney");

                entity.HasOne(d => d.Storefront)
                    .WithOne(p => p.NackStorefront)
                    .HasForeignKey<NackStorefront>(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Nack_Storefronts_StorefrontInfo");
            });

            modelBuilder.Entity<NgsFee>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.CarrierId, e.FeeCode });

                entity.ToTable("NGS_Fees");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.CarrierId)
                    .HasMaxLength(10)
                    .HasColumnName("CarrierID")
                    .IsFixedLength();

                entity.Property(e => e.FeeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<NgsManifest>(entity =>
            {
                entity.HasKey(e => e.ManifestId);

                entity.ToTable("NGS_Manifests");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileUploadDate).HasColumnType("datetime");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.NgsManifests)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NGS_Manifests_NGS_Shipping_Settings");
            });

            modelBuilder.Entity<NgsRatesParcelSelectObsolete>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone })
                    .HasName("PK_NGS_Rates_ParcelSelect");

                entity.ToTable("NGS_Rates_ParcelSelect_OBSOLETE");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<NgsRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("NGS_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<NgsRatesStandardMailParcel>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.WeightInOunces, e.Rate });

                entity.ToTable("NGS_Rates_StandardMailParcels");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<NgsShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentNum);

                entity.ToTable("NGS_Shipments");

                entity.Property(e => e.ShipmentNum).ValueGeneratedNever();

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");
            });

            modelBuilder.Entity<NgsShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("NGS_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.FacilityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FacilityID");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.Ftpserver)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPServer");

                entity.Property(e => e.Ftpusername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPUsername");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.InductionSiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InductionSiteID");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MerchantID");

                entity.Property(e => e.Pocity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POCity");

                entity.Property(e => e.Postate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POState");

                entity.Property(e => e.Pozip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POZip");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NgsTransitTime>(entity =>
            {
                entity.HasKey(e => new { e.FromWrhsId, e.ToZip })
                    .HasName("PK_NGS_Transit_Time_170105");

                entity.ToTable("NGS_Transit_Time");

                entity.HasIndex(e => e.ToZip, "IX_NGS_Transit_Time_170105_ToZip")
                    .HasFillFactor(90);

                entity.Property(e => e.FromWrhsId).HasColumnName("FromWrhsID");

                entity.Property(e => e.ToZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AvgDaysInTransit).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<NorcoShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("Norco_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseRate).HasColumnType("smallmoney");

                entity.Property(e => e.BaseRateWeightInLbs).HasColumnType("smallmoney");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaxWeightInLbs).HasColumnType("smallmoney");

                entity.Property(e => e.PerPoundRateOverBaseRate).HasColumnType("smallmoney");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NorcoZipCode>(entity =>
            {
                entity.HasKey(e => e.Zip);

                entity.ToTable("Norco_ZipCodes");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NorcoZipCodes20150113>(entity =>
            {
                entity.HasKey(e => e.Zip);

                entity.ToTable("Norco_ZipCodes_20150113");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObsoleteContent>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Obsolete_Content");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<OnTracShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("OnTrac_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BaseUri)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BaseURI");

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperStateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnTracZipCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OnTrac_ZipCodes");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeavyweightService)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PickupService)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdayDelivery)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdaySunriseDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdaySunriseGoldDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SunriseDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SunriseGoldDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnTracZipCodesInfo>(entity =>
            {
                entity.HasKey(e => new { e.ZipCode, e.WrhsId });

                entity.ToTable("OnTrac_ZipCodes_Info");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.DisabledOn).HasColumnType("datetime");

                entity.Property(e => e.ServiceArea)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Surcharge)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnTracZipCodesNew>(entity =>
            {
                entity.HasKey(e => e.ZipCode);

                entity.ToTable("OnTrac_ZipCodes_NEW");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Das)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DAS");

                entity.Property(e => e.Eas)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EAS");

                entity.Property(e => e.SortCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnTracZipCodesOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OnTrac_ZipCodes_OLD");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HeavyweightService)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PickupService)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdayDelivery)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdaySunriseDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SaturdaySunriseGoldDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SunriseDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SunriseGoldDeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId)
                    .HasName("PK_OrdersSent2")
                    .IsClustered(false);

                entity.HasIndex(e => new { e.StorefrontId, e.StorefrontOrderId }, "CK_Orders_Unique_StorefrontOrderID")
                    .IsUnique();

                entity.HasIndex(e => e.BillToEmail, "IX_Orders_BillToEmail")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.BillToLname, e.BillToFname }, "IX_Orders_BillToLNameFName")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ConsumerAccountId, "IX_Orders_ConsumerAccountID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DateTimeOrderPlaced, "IX_Orders_Date")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ReadyForPickup, "IX_Orders_ReadyForPickup")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipToState, "IX_Orders_ShipToState")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipToZip, "IX_Orders_ShipToZip")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Orders_StorefrontID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TempTestMirrorOrderId, "IX_Orders_TempTestMirrorOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Void, "IX_Orders_Void")
                    .HasFillFactor(90);

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.BillToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToFName");

                entity.Property(e => e.BillToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToLName");

                entity.Property(e => e.BillToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToMName");

                entity.Property(e => e.BillToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.CctypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CCTypeCode")
                    .IsFixedLength();

                entity.Property(e => e.CheckAccountNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRoutingNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIpaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ClientIPAddress");

                entity.Property(e => e.CommentsFromConsumer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerAccountId).HasColumnName("ConsumerAccountID");

                entity.Property(e => e.CouponAppliedAmount).HasColumnType("smallmoney");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CouponDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateFollowUp).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeImported).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeOrderPlaced).HasColumnType("smalldatetime");

                entity.Property(e => e.InProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.InProcessInvalidShipAddress)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_InvalidShipAddress");

                entity.Property(e => e.InProcessProdNotAvail)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_ProdNotAvail");

                entity.Property(e => e.InProcessProdRemovalRequired)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_ProdRemovalRequired");

                entity.Property(e => e.InsAmount).HasColumnType("smallmoney");

                entity.Property(e => e.InsDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsTypeIddesired).HasColumnName("InsTypeIDDesired");

                entity.Property(e => e.NameAsOnCc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NameAsOnCC");

                entity.Property(e => e.OrderGrandTotal).HasColumnType("smallmoney");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PubPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.ReadyForPickup).HasColumnType("smalldatetime");

                entity.Property(e => e.ReadyForReview).HasColumnType("smalldatetime");

                entity.Property(e => e.ReadyToProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.RetailPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.SalesTaxAmount).HasColumnType("smallmoney");

                entity.Property(e => e.SalesTaxDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("smallmoney");

                entity.Property(e => e.ShipAmount).HasColumnType("smallmoney");

                entity.Property(e => e.ShipMethodDescDesired)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodIddesired).HasColumnName("ShipMethodIDDesired");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountryID");

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToFName");

                entity.Property(e => e.ShipToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToLName");

                entity.Property(e => e.ShipToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToMName");

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFooter)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMemo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontAdminId).HasColumnName("StorefrontAdminID");

                entity.Property(e => e.StorefrontCartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontCartID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.StorefrontOrderId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontOrderID");

                entity.Property(e => e.StorefrontPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontSessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontSessionID");

                entity.Property(e => e.SuggestedCarrierId).HasColumnName("SuggestedCarrierID");

                entity.Property(e => e.TempTestBa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBA");

                entity.Property(e => e.TempTestBa2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBA2");

                entity.Property(e => e.TempTestBc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBC");

                entity.Property(e => e.TempTestBe)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBE");

                entity.Property(e => e.TempTestBf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBF");

                entity.Property(e => e.TempTestBl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBL");

                entity.Property(e => e.TempTestBm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBM");

                entity.Property(e => e.TempTestBp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBP");

                entity.Property(e => e.TempTestBs)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBS");

                entity.Property(e => e.TempTestBz)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TempTestBZ");

                entity.Property(e => e.TempTestMirrorOrderId).HasColumnName("TempTestMirrorOrderID");

                entity.Property(e => e.TempTestOgt)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TempTestOGT");

                entity.Property(e => e.TempTestPpt)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TempTestPPT");

                entity.Property(e => e.TempTestSa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSA");

                entity.Property(e => e.TempTestSa2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSA2");

                entity.Property(e => e.TempTestSc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSC");

                entity.Property(e => e.TempTestSe)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSE");

                entity.Property(e => e.TempTestSf)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSF");

                entity.Property(e => e.TempTestSl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSL");

                entity.Property(e => e.TempTestSm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSM");

                entity.Property(e => e.TempTestSp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSP");

                entity.Property(e => e.TempTestSs)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSS");

                entity.Property(e => e.TempTestSta)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TempTestSTA");

                entity.Property(e => e.TempTestStd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSTD");

                entity.Property(e => e.TempTestStp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TempTestSTP");

                entity.Property(e => e.TempTestSz)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TempTestSZ");

                entity.Property(e => e.Void).HasColumnType("smalldatetime");

                entity.HasOne(d => d.ConsumerAccount)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ConsumerAccountId)
                    .HasConstraintName("FK_Orders_UserAccounts");

                entity.HasOne(d => d.ShipMethodIddesiredNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ShipMethodIddesired)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_ShippingMethods");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_Orders_Orders_Source");
            });

            modelBuilder.Entity<OrdersAction>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("Orders_Actions");

                entity.Property(e => e.ActionId)
                    .ValueGeneratedNever()
                    .HasColumnName("ActionID");

                entity.Property(e => e.ActionDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersActionsLog>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Orders_Actions_Log");

                entity.HasIndex(e => e.ActionId, "IX_Orders_Actions_Log_ActionID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Actions_Log_ProviderOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");
            });

            modelBuilder.Entity<OrdersAmazonFulfillment>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId);

                entity.ToTable("Orders_Amazon_Fulfillment");

                entity.HasIndex(e => e.Fulfilled, "IX_Orders_Amazon_Fulfillment_Fulfilled")
                    .HasFillFactor(90);

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersAutoCaptureCondition>(entity =>
            {
                entity.HasKey(e => e.CondId);

                entity.ToTable("Orders_AutoCapture_Conditions");

                entity.Property(e => e.CondId).HasColumnName("CondID");

                entity.Property(e => e.CheckFpoapo).HasColumnName("CheckFPOAPO");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MaxOrderAmount).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.ValidAvscodes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ValidAVSCodes");

                entity.Property(e => e.ValidCvvcodes)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ValidCVVCodes");

                entity.Property(e => e.ValidShipMethodIds)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ValidShipMethodIDs");
            });

            modelBuilder.Entity<OrdersAutoCaptureUserAccount>(entity =>
            {
                entity.ToTable("Orders_AutoCapture_UserAccounts");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaskedCcnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MaskedCCNumber");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<OrdersBatchesPrinting>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("Orders_Batches_Printing");

                entity.HasIndex(e => e.AdminId, "IX_Orders_Batches_Printing_AdminID")
                    .HasFillFactor(90);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.BatchStatusObsolete).HasColumnName("BatchStatus_OBSOLETE");

                entity.Property(e => e.Carrier)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasMany(d => d.LineItemRows)
                    .WithMany(p => p.Batches)
                    .UsingEntity<Dictionary<string, object>>(
                        "OrdersProviderLineItemsBatch",
                        l => l.HasOne<OrdersProviderLineItem>().WithMany().HasForeignKey("LineItemRowId").HasConstraintName("FK_Orders_Provider_LineItems_Batches_Orders_Provider_LineItems"),
                        r => r.HasOne<OrdersBatchesPrinting>().WithMany().HasForeignKey("BatchId").HasConstraintName("FK_Orders_Provider_LineItems_Batches_Orders_Batches_Printing"),
                        j =>
                        {
                            j.HasKey("BatchId", "LineItemRowId");

                            j.ToTable("Orders_Provider_LineItems_Batches");

                            j.HasIndex(new[] { "LineItemRowId" }, "IX_Orders_Provider_LineItems_Batches_LIRowID").HasFillFactor(90);

                            j.IndexerProperty<int>("BatchId").HasColumnName("BatchID");

                            j.IndexerProperty<int>("LineItemRowId").HasColumnName("LineItemRowID");
                        });
            });

            modelBuilder.Entity<OrdersBlacklist>(entity =>
            {
                entity.HasKey(e => e.BlacklistId);

                entity.ToTable("Orders_Blacklist");

                entity.Property(e => e.BlacklistId).HasColumnName("BlacklistID");

                entity.Property(e => e.BillToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToFName");

                entity.Property(e => e.BillToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToLName");

                entity.Property(e => e.BillToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("CartID");

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountryID");

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToFName");

                entity.Property(e => e.ShipToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToLName");

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<OrdersLineItem>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK_OrdersSent_LineItems2")
                    .IsClustered(false);

                entity.ToTable("Orders_LineItems");

                entity.HasIndex(e => new { e.ProviderOrderId, e.LineNum }, "IX_Orders_LineItems_OrdID_LineNum_Const")
                    .IsUnique()
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_LineItems_OrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_Orders_LineItems_ProdID")
                    .HasFillFactor(90);

                entity.Property(e => e.RowId)
                    .ValueGeneratedNever()
                    .HasColumnName("RowID");

                entity.Property(e => e.Backordered).HasColumnType("smalldatetime");

                entity.Property(e => e.BrandDesc).HasMaxLength(50);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.LineItemInProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.LineItemShipped).HasColumnType("smalldatetime");

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.PriceToConsumer).HasColumnType("smallmoney");

                entity.Property(e => e.PriceToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdName).HasMaxLength(100);

                entity.Property(e => e.ProviderAdminId).HasColumnName("ProviderAdminID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.SfadminId).HasColumnName("SFAdminID");

                entity.Property(e => e.TempTestPtc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TempTestPTC");

                entity.Property(e => e.UnitNum).HasColumnType("smallmoney");

                entity.Property(e => e.UnitTypeDesc).HasMaxLength(50);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.WrhsIdassignedTo).HasColumnName("WrhsIDAssignedTo");

                entity.HasOne(d => d.ProviderOrder)
                    .WithMany(p => p.OrdersLineItems)
                    .HasForeignKey(d => d.ProviderOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_LineItems_Orders");
            });

            modelBuilder.Entity<OrdersMass119Info>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId);

                entity.ToTable("Orders_Mass119_Info");

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarCodeSmall)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.City1).HasMaxLength(50);

                entity.Property(e => e.City2)
                    .HasMaxLength(50)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CosigneeAddress)
                    .HasMaxLength(200)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.CosigneeCellphone).HasMaxLength(50);

                entity.Property(e => e.CosigneeName).HasMaxLength(100);

                entity.Property(e => e.CosigneePhone).HasMaxLength(50);

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.Freight).HasMaxLength(25);

                entity.Property(e => e.FreightType).HasMaxLength(25);

                entity.Property(e => e.FullDescription).HasMaxLength(500);

                entity.Property(e => e.Item)
                    .HasMaxLength(100)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.NewVar1).HasMaxLength(50);

                entity.Property(e => e.NewVar2).HasMaxLength(50);

                entity.Property(e => e.Origin)
                    .HasMaxLength(50)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.ShipToAddress).HasMaxLength(100);

                entity.Property(e => e.ShipToAddress2).HasMaxLength(100);

                entity.Property(e => e.ShipperAddress)
                    .HasMaxLength(200)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.ShipperName).HasMaxLength(100);

                entity.Property(e => e.ShipperName2)
                    .HasMaxLength(100)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.ShipperPhone)
                    .HasMaxLength(50)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.Trname)
                    .HasMaxLength(50)
                    .HasColumnName("TRName");

                entity.Property(e => e.Type).HasMaxLength(25);

                entity.Property(e => e.ValueDeclared)
                    .HasColumnType("smallmoney")
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.Var1).HasComment("_OBSOLETE");

                entity.Property(e => e.Var2)
                    .HasMaxLength(50)
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.Weight)
                    .HasColumnType("smallmoney")
                    .HasComment("_OBSOLETE");

                entity.Property(e => e.WeightAndValue).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(25);
            });

            modelBuilder.Entity<OrdersMass119InfoStaging>(entity =>
            {
                entity.HasKey(e => e.StorefrontOrderId);

                entity.ToTable("Orders_Mass119_Info_STAGING");

                entity.Property(e => e.StorefrontOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontOrderID");

                entity.Property(e => e.BarCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarCodeSmall)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City1).HasMaxLength(50);

                entity.Property(e => e.City2).HasMaxLength(50);

                entity.Property(e => e.CosigneeAddress).HasMaxLength(200);

                entity.Property(e => e.CosigneeCellphone).HasMaxLength(50);

                entity.Property(e => e.CosigneeName).HasMaxLength(100);

                entity.Property(e => e.CosigneePhone).HasMaxLength(50);

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.FullDescription).HasMaxLength(500);

                entity.Property(e => e.Item).HasMaxLength(100);

                entity.Property(e => e.Origin).HasMaxLength(50);

                entity.Property(e => e.ShipperAddress).HasMaxLength(200);

                entity.Property(e => e.ShipperName).HasMaxLength(100);

                entity.Property(e => e.ShipperName2).HasMaxLength(100);

                entity.Property(e => e.ShipperPhone).HasMaxLength(50);

                entity.Property(e => e.ValueDeclared).HasColumnType("smallmoney");

                entity.Property(e => e.Var2).HasMaxLength(50);

                entity.Property(e => e.Weight).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<OrdersNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("Orders_Notes");

                entity.HasIndex(e => e.ProviderOrderId, "IX_Order_Notes_ProviderOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.Body).HasMaxLength(2000);

                entity.Property(e => e.NoteTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.NoteTypeId).HasColumnName("NoteTypeID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.NoteType)
                    .WithMany(p => p.OrdersNotes)
                    .HasForeignKey(d => d.NoteTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Notes_Orders_Notes_Type");
            });

            modelBuilder.Entity<OrdersNotesType>(entity =>
            {
                entity.HasKey(e => e.NoteTypeId);

                entity.ToTable("Orders_Notes_Type");

                entity.Property(e => e.NoteTypeId).HasColumnName("NoteTypeID");

                entity.Property(e => e.NoteTypeDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersPlacedTask>(entity =>
            {
                entity.ToTable("Orders_Placed_Task");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ErredOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMsg)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Parameters)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingOn).HasColumnType("datetime");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ScheduledOn).HasColumnType("datetime");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.ProviderOrder)
                    .WithMany(p => p.OrdersPlacedTasks)
                    .HasForeignKey(d => d.ProviderOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Placed_Task_Orders_Provider");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.OrdersPlacedTasks)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Placed_Task_Orders_Placed_Task_Type");
            });

            modelBuilder.Entity<OrdersPlacedTaskType>(entity =>
            {
                entity.ToTable("Orders_Placed_Task_Type");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Type)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersPreliminaryShippingDataUp>(entity =>
            {
                entity.HasKey(e => new { e.ProviderOrderId, e.WrhsName });

                entity.ToTable("Orders_Preliminary_ShippingData_UPS");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.WrhsName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("smallmoney");

                entity.Property(e => e.ProviderCostSubtotal).HasColumnType("smallmoney");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<OrdersProvider>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId)
                    .HasName("PK_OrdersSent")
                    .IsClustered(false);

                entity.ToTable("Orders_Provider");

                entity.HasIndex(e => new { e.StorefrontId, e.StorefrontOrderId }, "CK_Orders_Provider_Unique_StorefrontOrderID")
                    .IsUnique();

                entity.HasIndex(e => e.BillToAddress, "IX_Orders_Provider_BillToAddress");

                entity.HasIndex(e => e.BillToEmail, "IX_Orders_Provider_BillToEmail")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.BillToFname, "IX_Orders_Provider_BillToFName")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.BillToLname, e.BillToFname }, "IX_Orders_Provider_BillToLNameFName")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.BillToPhone, "IX_Orders_Provider_BillToPhone");

                entity.HasIndex(e => e.BillToTitle, "IX_Orders_Provider_BillToTitle")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ConsumerAccountId, "IX_Orders_Provider_ConsumerAccountID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DateTimeOrderPlaced, "IX_Orders_Provider_Date")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.InProcess, "IX_Orders_Provider_InProcess")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Ponumber, "IX_Orders_Provider_PONumber");

                entity.HasIndex(e => e.ReadyForPickup, "IX_Orders_Provider_ReadyForPickup")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ReadyToProcess, "IX_Orders_Provider_ReadyToProcess")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontSessionId, "IX_Orders_Provider_SessionID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipToAddress, "IX_Orders_Provider_ShipToAddress");

                entity.HasIndex(e => e.ShipToEmail, "IX_Orders_Provider_ShipToEmail")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipToFname, "IX_Orders_Provider_ShipToFName")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipToPhone, "IX_Orders_Provider_ShipToPhone");

                entity.HasIndex(e => e.ShipToTitle, "IX_Orders_Provider_ShipToTitle")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipToZip, "IX_Orders_Provider_ShipToZip")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_Storefront")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontOrderId, "IX_Orders_Provider_StorefrontOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SuggestedCarrierId, "IX_Orders_Provider_SuggestedCarrierID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Void, "IX_Orders_Provider_Void")
                    .HasFillFactor(90);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.BillToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToFName");

                entity.Property(e => e.BillToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToLName");

                entity.Property(e => e.BillToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToMName");

                entity.Property(e => e.BillToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BphoneFiltered)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BPhoneFiltered");

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.CcnumberObsolete)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CCNumber_OBSOLETE");

                entity.Property(e => e.CctypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CCTypeCode")
                    .IsFixedLength();

                entity.Property(e => e.CcverificationNum)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCVerificationNum");

                entity.Property(e => e.CheckAccountNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRoutingNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIpaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ClientIPAddress");

                entity.Property(e => e.CommentsFromConsumer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerAccountId).HasColumnName("ConsumerAccountID");

                entity.Property(e => e.CouponAppliedAmount).HasColumnType("smallmoney");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CouponDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateFollowUp).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeImported).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeOrderPlaced).HasColumnType("smalldatetime");

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExtAreaSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.FxrateIdcharged).HasColumnName("FXRateIDCharged");

                entity.Property(e => e.FxrateIdsettled).HasColumnName("FXRateIDSettled");

                entity.Property(e => e.InProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.InProcessInvalidShipAddress)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_InvalidShipAddress");

                entity.Property(e => e.InProcessProdNotAvail)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_ProdNotAvail");

                entity.Property(e => e.InProcessProdRemovalRequired)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_ProdRemovalRequired");

                entity.Property(e => e.InsAmount).HasColumnType("smallmoney");

                entity.Property(e => e.InsDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsTypeIddesired).HasColumnName("InsTypeIDDesired");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NameAsOnCc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NameAsOnCC");

                entity.Property(e => e.OrderGrandTotal).HasColumnType("smallmoney");

                entity.Property(e => e.PayPalNonce)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayPalVaultToken)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechCustRefNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.PubPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.RateShopCarrierIdlist)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RateShopCarrierIDList");

                entity.Property(e => e.ReadyForPickup).HasColumnType("smalldatetime");

                entity.Property(e => e.ReadyForReview).HasColumnType("smalldatetime");

                entity.Property(e => e.ReadyToProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.RetailPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.SalesRepAdminId).HasColumnName("SalesRepAdminID");

                entity.Property(e => e.SalesTaxAmount).HasColumnType("smallmoney");

                entity.Property(e => e.SalesTaxDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("smallmoney");

                entity.Property(e => e.ShipAmount).HasColumnType("smallmoney");

                entity.Property(e => e.ShipMethodDescDesired)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodIddesired).HasColumnName("ShipMethodIDDesired");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountryID");

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToFName");

                entity.Property(e => e.ShipToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToLName");

                entity.Property(e => e.ShipToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToMName");

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingProcessTypeId).HasColumnName("ShippingProcessTypeID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SphoneFiltered)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SPhoneFiltered");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFooter)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMemo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontAdminId).HasColumnName("StorefrontAdminID");

                entity.Property(e => e.StorefrontCartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontCartID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.StorefrontOrderId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontOrderID");

                entity.Property(e => e.StorefrontPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontSessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontSessionID");

                entity.Property(e => e.SuggestedCarrierId).HasColumnName("SuggestedCarrierID");

                entity.Property(e => e.TermsType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Void).HasColumnType("smalldatetime");

                entity.Property(e => e.WillShip).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdersProviderConsumerPaymentsAndCredit>(entity =>
            {
                entity.HasKey(e => e.TransNum);

                entity.ToTable("Orders_Provider_ConsumerPaymentsAndCredits");

                entity.HasIndex(e => new { e.ProviderOrderId, e.TransType, e.TransAmount }, "Orders_Provider_ConsumerPaymentsAndCredits3")
                    .HasFillFactor(90);

                entity.Property(e => e.ApprovalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttemptedTransType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthNetAuthorizationCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetAvscode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AuthNetAVSCode")
                    .IsFixedLength();

                entity.Property(e => e.AuthNetResponseCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthNetResponseReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetResponseReasonText)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetTransactionId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AuthNetTransactionID");

                entity.Property(e => e.AvsCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CbapprovalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CBApprovalCode");

                entity.Property(e => e.CbavsresultCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CBAVSResultCode")
                    .IsFixedLength();

                entity.Property(e => e.CberrorMsg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CBErrorMsg");

                entity.Property(e => e.CbresponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CBResponseCode");

                entity.Property(e => e.CbresponseText)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CBResponseText");

                entity.Property(e => e.CbstatusId).HasColumnName("CBStatusID");

                entity.Property(e => e.CbtransactionId).HasColumnName("CBTransactionID");

                entity.Property(e => e.Cccvv2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CCCVV2")
                    .IsFixedLength();

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.CcholderName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CCholderName");

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.CcnumberObsolete)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CCNumber_OBSOLETE");

                entity.Property(e => e.ChargebackCaseNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckAccountNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckNum)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRoutingNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustRefNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CvvCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GatewayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.MiscResponse1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiscResponse2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MiscResponse3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoneyOrderNotes)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechAuthorizationCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechAvsrespCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PayTechAVSRespCode");

                entity.Property(e => e.PayTechCustRefNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechCvvrespCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PayTechCVVRespCode");

                entity.Property(e => e.PayTechRespCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechRespCodeMsg)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechRespDateTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechResponseText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechTransRefId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PayTechTransRefID");

                entity.Property(e => e.PayTechTransRefNum)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ResponseCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseText)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TransAmount).HasColumnType("smallmoney");

                entity.Property(e => e.TransRefNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransTime).HasColumnType("datetime");

                entity.Property(e => e.TransType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransactionNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderDropshippingIgnoreBilling>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId);

                entity.ToTable("Orders_Provider_Dropshipping_IgnoreBilling");

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderDropshippingInvoice>(entity =>
            {
                entity.HasKey(e => e.InvoiceId);

                entity.ToTable("Orders_Provider_Dropshipping_Invoices");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.DateDue).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceDateTime).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.OrdersProviderDropshippingInvoices)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Invoices_StorefrontInfo");
            });

            modelBuilder.Entity<OrdersProviderDropshippingPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId);

                entity.ToTable("Orders_Provider_Dropshipping_Payments");

                entity.HasIndex(e => e.StorefrontId, "IX_Orders_Provider_Dropshipping_Payments_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentAmount).HasColumnType("money");

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.Property(e => e.PaymentNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.OrdersProviderDropshippingPayments)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Payments_StorefrontInfo");
            });

            modelBuilder.Entity<OrdersProviderDropshippingPaymentToInvoiceRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("Orders_Provider_Dropshipping_PaymentToInvoice_Relationships");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.AmountApplied).HasColumnType("money");

                entity.Property(e => e.DateApplied).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.OrdersProviderDropshippingPaymentToInvoiceRelationships)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_PaymentToInvoice_Relationships_Orders_Provider_Dropshipping_Invoices");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.OrdersProviderDropshippingPaymentToInvoiceRelationships)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_PaymentToInvoice_Relationships_Orders_Provider_Dropshipping_Payments");
            });

            modelBuilder.Entity<OrdersProviderDropshippingTransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_Provider_Dropshipping_Transactions");

                entity.HasIndex(e => e.InvoiceIdassignedTo, "IX_Orders_Provideer_Dropshipping_Transactions_InvoiceIDAssignedTo");

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_Dropshipping_Transactions_ProviderOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Reference1, "IX_Orders_Provider_Dropshipping_Transactions_Reference1")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Orders_Provider_Dropshipping_Transactions_StorefrontID");

                entity.HasIndex(e => e.TransTime, "IX_Orders_Provider_Dropshipping_Transactions_TransTime")
                    .IsClustered();

                entity.Property(e => e.InvoiceIdassignedTo).HasColumnName("InvoiceIDAssignedTo");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.Reference1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TransClassId).HasColumnName("TransClassID");

                entity.Property(e => e.TransDesc)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.TransNum).ValueGeneratedOnAdd();

                entity.Property(e => e.TransTime).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("smallmoney");

                entity.HasOne(d => d.InvoiceIdassignedToNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.InvoiceIdassignedTo)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Transactions_Orders_Provider_Dropshipping_Invoices");

                entity.HasOne(d => d.Storefront)
                    .WithMany()
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Transactions_StorefrontInfo");

                entity.HasOne(d => d.TransClass)
                    .WithMany()
                    .HasForeignKey(d => d.TransClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Transactions_Orders_Provider_Dropshipping_Transactions_Classes");
            });

            modelBuilder.Entity<OrdersProviderDropshippingTransactionsArchive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_Provider_Dropshipping_Transactions_ARCHIVE");

                entity.HasIndex(e => e.TransTime, "IX_Orders_Provider_Dropshipping_Transactions_ARCHIVE_TransTIme")
                    .IsClustered();

                entity.Property(e => e.InvoiceIdassignedTo).HasColumnName("InvoiceIDAssignedTo");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.Reference1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TransClassId).HasColumnName("TransClassID");

                entity.Property(e => e.TransDesc)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.TransNum).ValueGeneratedOnAdd();

                entity.Property(e => e.TransTime).HasColumnType("datetime");

                entity.Property(e => e.UnitCost).HasColumnType("smallmoney");

                entity.HasOne(d => d.InvoiceIdassignedToNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.InvoiceIdassignedTo)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Transactions_ARCHIVE_Orders_Provider_Dropshipping_Invoices");

                entity.HasOne(d => d.Storefront)
                    .WithMany()
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Transactions_ARCHIVE_StorefrontInfo");

                entity.HasOne(d => d.TransClass)
                    .WithMany()
                    .HasForeignKey(d => d.TransClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Dropshipping_Transactions_ARCHIVE_Orders_Provider_Dropshipping_Transactions_Classes");
            });

            modelBuilder.Entity<OrdersProviderDropshippingTransactionsClass>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("Orders_Provider_Dropshipping_Transactions_Classes");

                entity.Property(e => e.ClassId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ClassID");

                entity.Property(e => e.ClassDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderExtension>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId)
                    .HasName("PK_Orders_Provider");

                entity.ToTable("Orders_Provider_Extension");

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Extra1).HasMaxLength(50);

                entity.Property(e => e.ShipToAddress).HasMaxLength(100);

                entity.Property(e => e.ShipToAddress2).HasMaxLength(100);

                entity.Property(e => e.ShipToCity).HasMaxLength(50);

                entity.Property(e => e.ShipToFname)
                    .HasMaxLength(50)
                    .HasColumnName("ShipToFName");

                entity.Property(e => e.ShipToLname)
                    .HasMaxLength(50)
                    .HasColumnName("ShipToLName");

                entity.Property(e => e.ShipToMname)
                    .HasMaxLength(50)
                    .HasColumnName("ShipToMName");

                entity.Property(e => e.ShipToPhone).HasMaxLength(25);

                entity.Property(e => e.ShipToState).HasMaxLength(50);

                entity.Property(e => e.ShipToZip).HasMaxLength(25);
            });

            modelBuilder.Entity<OrdersProviderKountRisresult>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Orders_Provider_KountRISResults");

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_KountRISResults_ProviderOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Auto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Browser)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Cookies)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DateDeviceFirstSeen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateTimeInserted).HasColumnType("datetime");

                entity.Property(e => e.DeviceScreenResolution)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Devicelayers)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Fingerprint)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Flash)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Geox)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.HttpCountry)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Ipcity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("IPCity");

                entity.Property(e => e.Ipcountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("IPCountry");

                entity.Property(e => e.Iplatitude)
                    .HasColumnType("smallmoney")
                    .HasColumnName("IPLatitude");

                entity.Property(e => e.Iplongitude)
                    .HasColumnType("smallmoney")
                    .HasColumnName("IPLongitude");

                entity.Property(e => e.Iporganization)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("IPOrganization");

                entity.Property(e => e.Ipregion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IPRegion");

                entity.Property(e => e.Javascript)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Kaptcha)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.KnowYourCustomer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LocalTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MasterCardFraudScore)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantId).HasColumnName("MerchantID");

                entity.Property(e => e.MobileDevice)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MobileForwarder)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MobileType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Mode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Network)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Os)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("OS");

                entity.Property(e => e.Pcremote)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PCRemote");

                entity.Property(e => e.Pipaddress)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("PIPAddress");

                entity.Property(e => e.Pipcity)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PIPCity");

                entity.Property(e => e.Pipcountry)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PIPCountry");

                entity.Property(e => e.Piplatitude)
                    .HasColumnType("smallmoney")
                    .HasColumnName("PIPLatitude");

                entity.Property(e => e.Piplongitude)
                    .HasColumnType("smallmoney")
                    .HasColumnName("PIPLongitude");

                entity.Property(e => e.Piporganization)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("PIPOrganization");

                entity.Property(e => e.Pipregion)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PIPRegion");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.Proxy)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("SessionID");

                entity.Property(e => e.Site)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Timezone)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.UserAgentString)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceDevice)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProviderOrder)
                    .WithMany(p => p.OrdersProviderKountRisresults)
                    .HasForeignKey(d => d.ProviderOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_KountRISResults_Orders_Provider");
            });

            modelBuilder.Entity<OrdersProviderLineItem>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .HasName("PK_OrdersSent_LineItems")
                    .IsClustered(false);

                entity.ToTable("Orders_Provider_LineItems");

                entity.HasIndex(e => e.LineItemShipped, "IX_Orders_Provider_LineItems_LineItemShipped")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.ProviderOrderId, e.LineNum }, "IX_Orders_Provider_LineItems_OrdID_LineNum_Const")
                    .IsUnique()
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_LineItems_OrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_Orders_Provider_LineItems_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.WrhsIdassignedTo, "IX_Orders_Provider_LineItems_WrhsIDAssignedTo")
                    .HasFillFactor(90);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Backordered).HasColumnType("smalldatetime");

                entity.Property(e => e.BrandDesc).HasMaxLength(50);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.CalculatedCostMethodId).HasColumnName("CalculatedCostMethodID");

                entity.Property(e => e.CalculatedCostToProviderUpdatable)
                    .HasColumnType("smallmoney")
                    .HasColumnName("CalculatedCostToProvider_updatable");

                entity.Property(e => e.DateCostToProviderCalculated).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.LineItemInProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.LineItemShipped).HasColumnType("smalldatetime");

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.PriceToConsumer).HasColumnType("smallmoney");

                entity.Property(e => e.PriceToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdName).HasMaxLength(100);

                entity.Property(e => e.ProviderAdminId).HasColumnName("ProviderAdminID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.SfadminId).HasColumnName("SFAdminID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.TaxPercent).HasColumnType("smallmoney");

                entity.Property(e => e.UnitNum).HasColumnType("smallmoney");

                entity.Property(e => e.UnitTypeDesc).HasMaxLength(50);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.WrhsIdassignedTo).HasColumnName("WrhsIDAssignedTo");

                entity.HasOne(d => d.ProviderOrder)
                    .WithMany(p => p.OrdersProviderLineItems)
                    .HasForeignKey(d => d.ProviderOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_LineItems_Orders_Provider");
            });

            modelBuilder.Entity<OrdersProviderLineItemsAmazon>(entity =>
            {
                entity.HasKey(e => new { e.ProviderOrderId, e.Sku })
                    .HasName("PK_Orders_Amazon_LineItems");

                entity.ToTable("Orders_Provider_LineItems_Amazon");

                entity.HasIndex(e => e.ProdId, "IX_Orders_Amazon_LineItems")
                    .HasFillFactor(90);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<OrdersProviderLineItemsCalculatedCostMethodsLegend>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_Provider_LineItems_CalculatedCostMethodsLegend");

                entity.Property(e => e.CalculatedCostMethodDesc)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CalculatedCostMethodId).HasColumnName("CalculatedCostMethodID");
            });

            modelBuilder.Entity<OrdersProviderLineItemsInventoryAllocation>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("Orders_Provider_LineItems_InventoryAllocation");

                entity.HasIndex(e => e.PoLiUniquefier, "IX_Orders_Provider_LineItems_InventoryAllocation_POLIUniquefier")
                    .HasFillFactor(90);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.PoLiUniquefier).HasColumnName("PO_LI_Uniquefier");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.HasOne(d => d.PoLiUniquefierNavigation)
                    .WithMany(p => p.OrdersProviderLineItemsInventoryAllocations)
                    .HasForeignKey(d => d.PoLiUniquefier)
                    .HasConstraintName("FK_Orders_Provider_LineItems_InventoryAllocation_Orders_Provider_LineItems_InventoryAllocation_PO_LI_Uniqfier");
            });

            modelBuilder.Entity<OrdersProviderLineItemsOutOfStock>(entity =>
            {
                entity.HasKey(e => new { e.ProviderOrderId, e.ProdId });

                entity.ToTable("Orders_Provider_LineItems_OutOfStock");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.DateMissing).HasColumnType("smalldatetime");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.OrdersProviderLineItemsOutOfStocks)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_LineItems_OutOfStock_Prods_Products");
            });

            modelBuilder.Entity<OrdersProviderLineItemsShipment>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("Orders_Provider_LineItems_Shipments");

                entity.HasIndex(e => e.LineItemRowId, "IX_Orders_Provider_LineItems_Shipments_LineItemRowID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_LineItems_Shipments_ShipmentNum")
                    .HasFillFactor(90);

                entity.Property(e => e.LineItemRowId).HasColumnName("LineItemRowID");

                entity.HasOne(d => d.LineItemRow)
                    .WithMany(p => p.OrdersProviderLineItemsShipments)
                    .HasForeignKey(d => d.LineItemRowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_LineItems_Shipments_Orders_Provider_LineItems");

                entity.HasOne(d => d.ShipmentNumNavigation)
                    .WithMany(p => p.OrdersProviderLineItemsShipments)
                    .HasForeignKey(d => d.ShipmentNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_LineItems_Shipments_Orders_Provider_Shipping");
            });

            modelBuilder.Entity<OrdersProviderLineItemsTax>(entity =>
            {
                entity.HasKey(e => new { e.RowId, e.TaxId })
                    .HasName("PK_Orders_Provider_LineItems_Tax_1");

                entity.ToTable("Orders_Provider_LineItems_Tax");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.TaxPercent).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<OrdersProviderLineItemsTaxShipping>(entity =>
            {
                entity.HasKey(e => new { e.ProviderOrderId, e.TaxId });

                entity.ToTable("Orders_Provider_LineItems_Tax_Shipping");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.TaxId).HasColumnName("TaxID");

                entity.Property(e => e.TaxPercent).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<OrdersProviderLineItemsTempVelocity>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("Orders_Provider_LineItems_TEMP_VELOCITY");

                entity.HasIndex(e => e.ProcessingType, "IX_Orders_Provider_LineItems_TEMP_VELOCITY_ProcessingType")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_Orders_Provider_LineItems_TEMP_VELOCITY_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipToZip, "IX_Orders_Provider_LineItems_TEMP_VELOCITY_ShipToZip")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Orders_Provider_LineItems_TEMP_VELOCITY_StorefrontID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.WrhsIdassignedTo, "IX_Orders_Provider_LineItems_TEMP_VELOCITY_WrhsIDAssignedTo")
                    .HasFillFactor(90);

                entity.Property(e => e.RowId)
                    .ValueGeneratedNever()
                    .HasColumnName("RowID");

                entity.Property(e => e.DateTimeOrderPlaced).HasColumnType("smalldatetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountryID");

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.WrhsIdassignedTo).HasColumnName("WrhsIDAssignedTo");
            });

            modelBuilder.Entity<OrdersProviderMaxMindFraudResult>(entity =>
            {
                entity.ToTable("Orders_Provider_MaxMindFraudResults");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AnonymousProxy)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BinCountry)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinMatch)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BinName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinNameMatch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BinPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BinPhoneMatch)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CityPostalMatch)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryMatch)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustPhoneInBillingLoc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.Explanation).IsUnicode(false);

                entity.Property(e => e.FreeMail)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HighRiskCountry)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_City");

                entity.Property(e => e.IpIsp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ISP");

                entity.Property(e => e.IpLatitude)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP_Latitude");

                entity.Property(e => e.IpLongitude)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IP_Longitude");

                entity.Property(e => e.IpOrg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IP_ORG");

                entity.Property(e => e.IpRegion)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IP_Region");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ProxyScore).HasColumnType("smallmoney");

                entity.Property(e => e.RiskScore).HasColumnType("smallmoney");

                entity.Property(e => e.Score).HasColumnType("smallmoney");

                entity.Property(e => e.ShipCityPostalMatch)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderPrintedOutputType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("Orders_Provider_PrintedOutputType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderProcessingType>(entity =>
            {
                entity.HasKey(e => e.TypeId);

                entity.ToTable("Orders_Provider_ProcessingType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderSampleLineItem>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("Orders_Provider_SampleLineItems");

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_SampleLineItems_ProviderOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SampleId, "IX_Orders_Provider_SampleLineItems_SampleID")
                    .HasFillFactor(90);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.SampleId).HasColumnName("SampleID");
            });

            modelBuilder.Entity<OrdersProviderShipping>(entity =>
            {
                entity.HasKey(e => e.ShipmentNum)
                    .HasName("PK_OrdersSent_ShippingConfirmation")
                    .IsClustered(false);

                entity.ToTable("Orders_Provider_Shipping");

                entity.HasIndex(e => e.CarrierAndClassId, "IX_Orders_Provider_Shipping_CandCID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CarrierScheduledDeliveryDate, "IX_Orders_Provider_Shipping_CarrierScheduledDeliveryDate")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ManifestId, "IX_Orders_Provider_Shipping_ManifestID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.MasterShipmentNum, "IX_Orders_Provider_Shipping_MasterShipmentNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PackageWeight, "IX_Orders_Provider_Shipping_PackageWeight")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ParentTrackingNum, "IX_Orders_Provider_Shipping_ParentTrackingNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_Shipping_ProviderOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TrackingNum, "IX_Orders_Provider_Shipping_TrackingNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.UspsAccountSettingId, "IX_Orders_Provider_Shipping_USPS_Account_SettingID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.UserId, "IX_Orders_Provider_Shipping_UserID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.WrhsId, "IX_Orders_Provider_Shipping_WrhsID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipDate, "IX_Orders_Provider_Shipping_shipdate_CLUST")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.CarrierAndClassDesc)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CarrierAndClassId).HasColumnName("CarrierAndClassID");

                entity.Property(e => e.CarrierReportedDeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CarrierScheduledDeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ConfirmationEmailSentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FedExAccountSettingId).HasColumnName("FedEx_Account_SettingID");

                entity.Property(e => e.InsuranceAmount).HasColumnType("smallmoney");

                entity.Property(e => e.InsuranceFee).HasColumnType("smallmoney");

                entity.Property(e => e.InternalShipNotes)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.PackageWeight).HasColumnType("smallmoney");

                entity.Property(e => e.ParentTrackingNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostageRate).HasColumnType("smallmoney");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ShipCostToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.ShipDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsAccountSettingId).HasColumnName("UPS_Account_SettingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UspsAccountSettingId).HasColumnName("USPS_Account_SettingID");

                entity.Property(e => e.Uspspicnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USPSPICNumber");

                entity.Property(e => e.Uspszip9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USPSZip9");

                entity.Property(e => e.Void).HasColumnType("smalldatetime");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.CarrierAndClass)
                    .WithMany(p => p.OrdersProviderShippings)
                    .HasForeignKey(d => d.CarrierAndClassId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_CarriersAndClasses");
            });

            modelBuilder.Entity<OrdersProviderShippingBoxSuggestionsGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.ProdId });

                entity.ToTable("Orders_Provider_Shipping_BoxSuggestions_Groups");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<OrdersProviderShippingBoxSuggestionsSuggestGroup>(entity =>
            {
                entity.HasKey(e => e.LineNum);

                entity.ToTable("Orders_Provider_Shipping_BoxSuggestions_Suggest_Groups");

                entity.HasIndex(e => e.ProdId, "IX_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Qty, "IX_Qty")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SuggestId, "IX_SuggestID")
                    .HasFillFactor(90);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SuggestId).HasColumnName("SuggestID");
            });

            modelBuilder.Entity<OrdersProviderShippingBoxSuggestionsV3>(entity =>
            {
                entity.HasKey(e => e.SuggestId);

                entity.ToTable("Orders_Provider_Shipping_BoxSuggestions_v3");

                entity.HasIndex(e => e.BoxDescription, "IX_Orders_Provider_Shipping_BoxSuggestions_v3_boxdesc")
                    .HasFillFactor(90);

                entity.Property(e => e.SuggestId).HasColumnName("SuggestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.BoxDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingClaim>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.ToTable("Orders_Provider_Shipping_Claims");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.AmountClaimed).HasColumnType("smallmoney");

                entity.Property(e => e.AmountLost).HasColumnType("smallmoney");

                entity.Property(e => e.AmountPaid).HasColumnType("smallmoney");

                entity.Property(e => e.ClaimReasonId).HasColumnName("ClaimReasonID");

                entity.Property(e => e.ClaimReferenceNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimStatusId).HasColumnName("ClaimStatusID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FollowUpOn).HasColumnType("datetime");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.RefundToDropshipper).HasColumnType("smallmoney");

                entity.Property(e => e.SfadminId).HasColumnName("SFAdminID");

                entity.HasOne(d => d.ClaimReason)
                    .WithMany(p => p.OrdersProviderShippingClaims)
                    .HasForeignKey(d => d.ClaimReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Claims_Orders_Provider_Shipping_Claims_Reason");

                entity.HasOne(d => d.ClaimStatus)
                    .WithMany(p => p.OrdersProviderShippingClaims)
                    .HasForeignKey(d => d.ClaimStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Claims_Orders_Provider_Shipping_Claims_Status");

                entity.HasOne(d => d.ShipmentNumNavigation)
                    .WithMany(p => p.OrdersProviderShippingClaims)
                    .HasForeignKey(d => d.ShipmentNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Claims_Orders_Provider_Shipping");
            });

            modelBuilder.Entity<OrdersProviderShippingClaimsNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("Orders_Provider_Shipping_Claims_Notes");

                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SfadminId).HasColumnName("SFAdminID");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.OrdersProviderShippingClaimsNotes)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Claims_Notes_Orders_Provider_Shipping_Claims");
            });

            modelBuilder.Entity<OrdersProviderShippingClaimsReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("Orders_Provider_Shipping_Claims_Reason");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingClaimsStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Orders_Provider_Shipping_Claims_Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingDhlexpressBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_DHLExpress_Billing");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AirwayBillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Charges).HasColumnType("smallmoney");

                entity.Property(e => e.Currency)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DateImported).HasColumnType("smalldatetime");

                entity.Property(e => e.DestinationCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationCountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Receiver)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippersReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubAmount).HasColumnType("smallmoney");

                entity.Property(e => e.TaxVat)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TaxVAT");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingDhlexpressBillings)
                    .HasForeignKey(d => d.ImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_DHLExpress_Billing_DHLExpress_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingDhlexpressBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("Orders_Provider_Shipping_DHLExpress_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingDhlglobalMailBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_DHLGlobalMail_Billing");

                entity.HasIndex(e => e.CustomerConfirmation, "IX_Orders_Provider_Shipping_DHLGlobalMail_Billing_CustomerConfirmation")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_Shipping_DHLGlobalMail_Billing_ShipmentNum")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.ActWeight).HasColumnType("smallmoney");

                entity.Property(e => e.ActWeightUom)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ActWeightUOM");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BillRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillRef2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillWeight).HasColumnType("smallmoney");

                entity.Property(e => e.BillWeightUom)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BillWeightUOM");

                entity.Property(e => e.Bol)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BOL");

                entity.Property(e => e.Charge).HasColumnType("smallmoney");

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerConfirmation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryConfirmation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.InternalTrackingNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialOrVasDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialOrVasNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinPickupCharge).HasColumnType("smallmoney");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PickupFrom)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PricingZone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pudate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PUDate");

                entity.Property(e => e.Putime)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PUTime");

                entity.Property(e => e.QuantityUom)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("QuantityUOM");

                entity.Property(e => e.ScreeningFee).HasColumnType("smallmoney");

                entity.Property(e => e.ShipPoint)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SoldTo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Zfuel)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ZFuel");

                entity.Property(e => e.Zip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingDhlglobalMailBillings)
                    .HasForeignKey(d => d.ImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_DHLGlobalMail_Billing_Orders_Provider_Shipping_DHLGlobalMail_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingDhlglobalMailBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("Orders_Provider_Shipping_DHLGlobalMail_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingEcmsBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_ECMS_Billing");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.AcctPeriod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AmountDueUsd)
                    .HasColumnType("money")
                    .HasColumnName("AmountDueUSD");

                entity.Property(e => e.ChargeableWeightLb)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ChargeableWeightLB");

                entity.Property(e => e.Customer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FromPort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossWeightLb)
                    .HasColumnType("smallmoney")
                    .HasColumnName("GrossWeightLB");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mawbno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAWBNo");

                entity.Property(e => e.ReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ToPort)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VolumeWeightLb)
                    .HasColumnType("smallmoney")
                    .HasColumnName("VolumeWeightLB");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingEcmsBillings)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_ECMS_Billing_ECMS_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingEcmsBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("Orders_Provider_Shipping_ECMS_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingFedexActivity>(entity =>
            {
                entity.HasKey(e => new { e.ShipmentNum, e.IndexNum })
                    .IsClustered(false);

                entity.ToTable("Orders_Provider_Shipping_Fedex_Activity");

                entity.HasIndex(e => e.DateAndTime, "IX_Orders_Provider_Shipping_Fedex_Activity_DateAndTime")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StatusCodeId, "IX_Orders_Provider_Shipping_Fedex_Activity_StatusCodeID")
                    .HasFillFactor(90);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCodeId).HasColumnName("StatusCodeID");

                entity.Property(e => e.StatusTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusTypeDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.StatusCode)
                    .WithMany(p => p.OrdersProviderShippingFedexActivities)
                    .HasForeignKey(d => d.StatusCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Fedex_Activity_Fedex_Status_Codes");
            });

            modelBuilder.Entity<OrdersProviderShippingFedexBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_Fedex_Billing");

                entity.HasIndex(e => e.DateImported, "IX_Orders_Provider_Shipping_Fedex_Billing_DateImported")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.InvoiceNumber, "IX_Orders_Provider_Shipping_Fedex_Billing_InvoiceNumber")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_Shipping_Fedex_Billing_ShipmentNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.NetChargeAmount, "IX_Orders_Provider_Shipping_Fedex_billing_NetChargeAmount")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.ActualWeightAmount).HasColumnType("smallmoney");

                entity.Property(e => e.ActualWeightUnits)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAccountNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityCountryCode1)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityCountryCode2)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityCountryCode3)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityCountryCode4)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityDescription1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityDescription2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityDescription3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CommodityDescription4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyConversionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CurrentyConversionRate).HasColumnType("smallmoney");

                entity.Property(e => e.CustomsValue).HasColumnType("smallmoney");

                entity.Property(e => e.CustomsValueCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateImported).HasColumnType("smalldatetime");

                entity.Property(e => e.DeclaredValue).HasColumnType("smallmoney");

                entity.Property(e => e.DeclaredValueCurrencyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.GroundService)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroundTrkIdaddrCorrDiscAmount)
                    .HasColumnType("smallmoney")
                    .HasColumnName("GroundTrkIDAddrCorrDiscAmount");

                entity.Property(e => e.GroundTrkIdaddrCorrGrossAmount)
                    .HasColumnType("smallmoney")
                    .HasColumnName("GroundTrkIDAddrCorrGrossAmount");

                entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MultiweightShipmentChargeTotal).HasColumnType("money");

                entity.Property(e => e.MultiweightShipmentWeightTotal).HasColumnType("money");

                entity.Property(e => e.MultiweightWeightTotal).HasColumnType("money");

                entity.Property(e => e.NetChargeAmount).HasColumnType("smallmoney");

                entity.Property(e => e.OriginalCustomerRef)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalDeptRefDesc)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRecipientAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRecipientAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRecipientCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRecipientCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRecipientState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRecipientZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRef2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalRef3)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PoddeliveryDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("PODDeliveryDate");

                entity.Property(e => e.PodserviceAreaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PODServiceAreaCode");

                entity.Property(e => e.PodsignatureDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PODSignatureDescription");

                entity.Property(e => e.RatedWeightAmount).HasColumnType("smallmoney");

                entity.Property(e => e.RatedWeightUnits)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Rmanumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RMANumber");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ShipmentNum)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShipperAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TrackingID");

                entity.Property(e => e.TransportationChargeAmount).HasColumnType("smallmoney");

                entity.Property(e => e.UpdatedCustomerRef)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDeptRefDesc)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedRef2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedRef3)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingFedexBillingCharge>(entity =>
            {
                entity.HasKey(e => e.ChargeId);

                entity.ToTable("Orders_Provider_Shipping_Fedex_Billing_Charges");

                entity.HasIndex(e => e.DetailId, "IX_Orders_Provider_Shipping_Fedex_Billing_Charges_DetailID")
                    .HasFillFactor(90);

                entity.Property(e => e.ChargeId).HasColumnName("ChargeID");

                entity.Property(e => e.ChargeAmount).HasColumnType("smallmoney");

                entity.Property(e => e.ChargeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.OrdersProviderShippingFedexBillingCharges)
                    .HasForeignKey(d => d.DetailId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Fedex_Billing_Charges_Orders_Provider_Shipping_Fedex_Billing");
            });

            modelBuilder.Entity<OrdersProviderShippingGsoBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_GSO_Billing");

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_Shipping_GSO_Billing_ShipmentNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TrackingNumber, "IX_Orders_Provider_Shipping_GSO_Billing_TrackingNumber")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.BillingComments)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Codcharge)
                    .HasColumnType("smallmoney")
                    .HasColumnName("CODCharge");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeliveryState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryTime)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryZip)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryZone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.InsuranceCharge).HasColumnType("smallmoney");

                entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.OtherCharge).HasColumnType("smallmoney");

                entity.Property(e => e.PickupAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PickupCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PickupState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PickupZip)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RecordType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SignedBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TotalShippingCharge).HasColumnType("smallmoney");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransportationCharge).HasColumnType("smallmoney");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingGsoBillings)
                    .HasForeignKey(d => d.ImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_GSO_Billing_GSO_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingGsoBillingAdjustment>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_GSO_Billing_Adjustments");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.Reference)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingGsoBillingAdjustments)
                    .HasForeignKey(d => d.ImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_GSO_Billing_Adjustments_GSO_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingGsoBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("Orders_Provider_Shipping_GSO_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdersProviderShippingLaserShipBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_LaserShip_Billing");

                entity.HasIndex(e => e.LstrackingNumber, "IX_Orders_Provider_Shipping_LaserShip_Billing_LSTrackingNumber")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_Shipping_LaserShip_Billing_ShipmentNum");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Caller)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.En)
                    .HasColumnType("smallmoney")
                    .HasColumnName("EN");

                entity.Property(e => e.Extra1Amount).HasColumnType("smallmoney");

                entity.Property(e => e.Extra2Amount).HasColumnType("smallmoney");

                entity.Property(e => e.Extra3Amount).HasColumnType("smallmoney");

                entity.Property(e => e.Extra4Amount).HasColumnType("smallmoney");

                entity.Property(e => e.ExtraCode1)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraCode2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraCode3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraCode4)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromRoom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LstrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LSTrackingNumber");

                entity.Property(e => e.Pod)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POD");

                entity.Property(e => e.Poddate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PODDate");

                entity.Property(e => e.Podtime)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PODTime");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceAmount).HasColumnType("smallmoney");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.Property(e => e.Tdate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TDate");

                entity.Property(e => e.ToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToRoom)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("smallmoney");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingLaserShipBillings)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_LaserShip_Billing_LaserShip_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingLaserShipBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId)
                    .HasName("PK_LaserShip_Billing_Import");

                entity.ToTable("Orders_Provider_Shipping_LaserShip_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingMailExpressBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_MailExpress_Billing");

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_Shipping_MailExpress_Billing_ShipmentNum")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("smallmoney");

                entity.Property(e => e.DeliveryConfirmation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PackageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PackageID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TotalChargesToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingMailExpressBillings)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_MailExpress_Billing_MailExpress_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingMailExpressBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId)
                    .HasName("PK_MailExpress_Billing_Import");

                entity.ToTable("Orders_Provider_Shipping_MailExpress_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingMiscCarriersBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_MiscCarriers_Billing");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Amount).HasColumnType("smallmoney");

                entity.Property(e => e.Bolnumber)
                    .HasMaxLength(50)
                    .HasColumnName("BOLNumber");

                entity.Property(e => e.DateImported).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ProcessingFee).HasColumnType("smallmoney");

                entity.HasOne(d => d.ShipmentNumNavigation)
                    .WithMany(p => p.OrdersProviderShippingMiscCarriersBillings)
                    .HasForeignKey(d => d.ShipmentNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_MiscCarriers_Billing_Orders_Provider_Shipping");
            });

            modelBuilder.Entity<OrdersProviderShippingNewgisticsActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK_Orders_Provider_Shipping_USPS_Newgistics");

                entity.ToTable("Orders_Provider_Shipping_Newgistics_Activity");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.DateAndTimeImported).HasColumnType("smalldatetime");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDetail)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ShipmentNumNavigation)
                    .WithMany(p => p.OrdersProviderShippingNewgisticsActivities)
                    .HasForeignKey(d => d.ShipmentNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Newgistics_Activity_Orders_Provider_Shipping");
            });

            modelBuilder.Entity<OrdersProviderShippingNewgisticsBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_Newgistics_Billing");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryConfirmationFee).HasColumnType("smallmoney");

                entity.Property(e => e.EntryFacility)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FuelSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.ManifestDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PostageTotal).HasColumnType("smallmoney");

                entity.Property(e => e.RatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCharges).HasColumnType("smallmoney");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("smallmoney");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrailerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingNewgisticsBillings)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Newgistics_Billing_Newgistics_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingNewgisticsBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("Orders_Provider_Shipping_Newgistics_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingNorcoBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_Norco_Billing");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.AmountCharged).HasColumnType("smallmoney");

                entity.Property(e => e.Auth)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DestState)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DestZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate).HasColumnType("datetime");

                entity.Property(e => e.OriginAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OriginState)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OriginZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OtherFees).HasColumnType("smallmoney");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.PodDateTime).HasColumnType("datetime");

                entity.Property(e => e.Service).HasColumnType("smallmoney");

                entity.Property(e => e.ServiceDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingNorcoBillings)
                    .HasForeignKey(d => d.ImportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Norco_Billing_Norco_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingNorcoBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("Orders_Provider_Shipping_Norco_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.Results)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingOnTracBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_OnTrac_Billing");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.FromCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromState)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemitToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Service)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShipDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToCountry)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToState)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCharge).HasColumnType("money");

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.TrackingNum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("smallmoney");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingOnTracBillings)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_OnTrac_Billing_OnTrac_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingOnTracBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId)
                    .HasName("PK_OnTrac_Billing_Import");

                entity.ToTable("Orders_Provider_Shipping_OnTrac_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingProcessType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders_Provider_ShippingProcessType");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingSagawaBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_Sagawa_Billing");

                entity.HasIndex(e => e.ReferenceNum, "IX_Orders_Provider_Shipping_Sagawa_Billing_ReferenceNum");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.ConsigneeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.Product)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.Property(e => e.ReferenceNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueJpy)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ValueJPY");

                entity.Property(e => e.WeightInKgs).HasColumnType("smallmoney");

                entity.HasOne(d => d.Import)
                    .WithMany(p => p.OrdersProviderShippingSagawaBillings)
                    .HasForeignKey(d => d.ImportId)
                    .HasConstraintName("FK_Orders_Provider_Shipping_Sagawa_Billing_Sagawa_Billing_Import");
            });

            modelBuilder.Entity<OrdersProviderShippingSagawaBillingImport>(entity =>
            {
                entity.HasKey(e => e.ImportId);

                entity.ToTable("Orders_Provider_Shipping_Sagawa_Billing_Import");

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.DateOfImport).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderShippingUpsActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK_Orders_Provider_Shipping_UPS_Activity_STAGING");

                entity.ToTable("Orders_Provider_Shipping_UPS_Activity");

                entity.HasIndex(e => e.DateAndTime, "IX_Orders_Provider_Shipping_UPS_Activity_DateAndTime")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_Shipping_UPS_Activity_ShipmentNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StatusCodeId, "IX_Orders_Provider_Shipping_UPS_Activity_StatusCodeID")
                    .HasFillFactor(90);

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.ActivityLocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityLocationDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.DateAndTimeImported).HasColumnType("smalldatetime");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCodeId).HasColumnName("StatusCodeID");

                entity.Property(e => e.StatusTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatusTypeDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ShipmentNumNavigation)
                    .WithMany(p => p.OrdersProviderShippingUpsActivities)
                    .HasForeignKey(d => d.ShipmentNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_UPS_Activity_STAGING_Orders_Provider_Shipping");

                entity.HasOne(d => d.StatusCode)
                    .WithMany(p => p.OrdersProviderShippingUpsActivities)
                    .HasForeignKey(d => d.StatusCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_UPS_Activity_STAGING_UPS_Status_Codes");
            });

            modelBuilder.Entity<OrdersProviderShippingUpsBilling>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Orders_Provider_Shipping_UPS_Billing");

                entity.HasIndex(e => e.BillDate, "IX_Orders_Provider_Shipping_UPS_Billing_BillDate")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ChargeCategoryCode, "IX_Orders_Provider_Shipping_UPS_Billing_ChargeCategoryCode")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ChargeClassificationCode, "IX_Orders_Provider_Shipping_UPS_Billing_ChargeClassificationCode")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DateImported, "IX_Orders_Provider_Shipping_UPS_Billing_DateImported")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_Shipping_UPS_Billing_ProviderOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipmentNum, "IX_Orders_Provider_Shipping_UPS_Billing_ShipmentNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TrackingNumber, "IX_Orders_Provider_Shipping_UPS_Billing_TrackingNumber")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TransactionCode, "IX_Orders_Provider_Shipping_UPS_Billing_TransactionCode")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.ActualWeight).HasColumnType("smallmoney");

                entity.Property(e => e.AddtHandlingIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BillDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BilledWeight).HasColumnType("smallmoney");

                entity.Property(e => e.BillingOptionIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChargeCategoryCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeCategoryDetailCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeClassificationCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeDescriptionCode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ChargebackSurchargeIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Codindicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODIndicator")
                    .IsFixedLength();

                entity.Property(e => e.ConsolidatedClearanceIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurrencySurchargeIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateImported).HasColumnType("smalldatetime");

                entity.Property(e => e.DeclaredValueIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryAreaSurchargeIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryConfIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DimensionalWeightIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EarlyAmsurchargeIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("EarlyAMSurchargeIndicator")
                    .IsFixedLength();

                entity.Property(e => e.ExportLicVerificationIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExtDestSurchargeIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Incentive).HasColumnType("smallmoney");

                entity.Property(e => e.InvalidAcctChargeIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InvoiceAmount).HasColumnType("money");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Misc1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Misc2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Misc3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Misc4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Misc5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetCharges).HasColumnType("smallmoney");

                entity.Property(e => e.Oversize1Indicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oversize2Indicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PickupDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PickupFeeIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PickupRecordNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ReceiverCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderStreet)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SplitDuty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCharges).HasColumnType("smallmoney");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WeightIndicator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdersProviderShippingUspsActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId)
                    .HasName("PK_Orders_Provider_Shipping_USPS_Activity_1");

                entity.ToTable("Orders_Provider_Shipping_USPS_Activity");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.DateAndTimeImported).HasColumnType("smalldatetime");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackDetail)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.ShipmentNumNavigation)
                    .WithMany(p => p.OrdersProviderShippingUspsActivities)
                    .HasForeignKey(d => d.ShipmentNum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_Shipping_USPS_Activity_Orders_Provider_Shipping");
            });

            modelBuilder.Entity<OrdersProviderThirdPartyBillingUp>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId);

                entity.ToTable("Orders_Provider_ThirdPartyBilling_UPS");

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.UpsaccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("UPSAccountNumber");

                entity.Property(e => e.Upsattention)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSAttention");

                entity.Property(e => e.Upscity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSCity");

                entity.Property(e => e.UpscompanyOrName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSCompanyOrName");

                entity.Property(e => e.Upscountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSCountry");

                entity.Property(e => e.UpsdepartmentAddress3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSDepartmentAddress3");

                entity.Property(e => e.Upsfax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSFax");

                entity.Property(e => e.Upsref1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSRef1");

                entity.Property(e => e.Upsref2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSRef2");

                entity.Property(e => e.UpsroomFloorAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSRoomFloorAddress2");

                entity.Property(e => e.UpsstateProv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSStateProv");

                entity.Property(e => e.Upsstreet)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSStreet");

                entity.Property(e => e.Upstelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSTelephone");

                entity.Property(e => e.UpszipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSZipCode");
            });

            modelBuilder.Entity<OrdersProviderWholesalePayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_Orders_Provider_WholesalePayments_1");

                entity.ToTable("Orders_Provider_WholesalePayments");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.AppliedToPaymentId).HasColumnName("AppliedToPaymentID");

                entity.Property(e => e.AppliedToTransLegacy).HasColumnName("AppliedToTrans_LEGACY");

                entity.Property(e => e.AttemptedTransType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthNetAuthorizationCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetAvscode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AuthNetAVSCode")
                    .IsFixedLength();

                entity.Property(e => e.AuthNetResponseCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthNetResponseReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetResponseReasonText)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetTransactionId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AuthNetTransactionID");

                entity.Property(e => e.CbapprovalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CBApprovalCode");

                entity.Property(e => e.CbavsresultCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CBAVSResultCode")
                    .IsFixedLength();

                entity.Property(e => e.CberrorMsg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CBErrorMsg");

                entity.Property(e => e.CbresponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CBResponseCode");

                entity.Property(e => e.CbresponseText)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CBResponseText");

                entity.Property(e => e.CbstatusId).HasColumnName("CBStatusID");

                entity.Property(e => e.CbtransactionId).HasColumnName("CBTransactionID");

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.CcholderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCHolderName");

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.ChargebackCaseNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckAccountNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CheckNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRoutingNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreditMemoNotesToPrint)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastUpdateDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PayTechAuthorizationCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechAvsrespCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PayTechAVSRespCode");

                entity.Property(e => e.PayTechCvvrespCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PayTechCVVRespCode");

                entity.Property(e => e.PayTechRespCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechRespCodeMsg)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechRespDateTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechResponseText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechTransRefId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PayTechTransRefID");

                entity.Property(e => e.PayTechTransRefNum)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProviderOrderIdLegacy).HasColumnName("ProviderOrderID_LEGACY");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TransAmount).HasColumnType("money");

                entity.Property(e => e.TransNumLegacy).HasColumnName("TransNum_LEGACY");

                entity.Property(e => e.TransType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransactionNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersProviderWholesalePaymentsCreditMemoLineItem>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("Orders_Provider_WholesalePayments_CreditMemo_LineItems");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.UnitAmount).HasColumnType("money");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.OrdersProviderWholesalePaymentsCreditMemoLineItems)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_WholesalePayments_CreditMemo_LineItems_Orders_Provider_WholesalePayments");
            });

            modelBuilder.Entity<OrdersProviderWholesalePaymentsPaymentToOrderRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("Orders_Provider_WholesalePayments_PaymentToOrder_Relationship");

                entity.HasIndex(e => e.PaymentId, "IX_Orders_Provider_WholesalePayments_PaymentToOrder_Relationship_PaymentID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Provider_WholesalePayments_PaymentToOrder_Relationship_ProviderOrderID_covrd")
                    .HasFillFactor(90);

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.AmountApplied).HasColumnType("money");

                entity.Property(e => e.DateApplied).HasColumnType("smalldatetime");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.OrdersProviderWholesalePaymentsPaymentToOrderRelationships)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Provider_WholesalePayments_PaymentToOrder_Relationship_Orders_Provider_WholesalePayments");
            });

            modelBuilder.Entity<OrdersProviderWholesalePaymentsTest>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK_Orders_Provider_WholesalePayments_2");

                entity.ToTable("Orders_Provider_WholesalePayments_TEST");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.AppliedToPaymentId).HasColumnName("AppliedToPaymentID");

                entity.Property(e => e.AppliedToTransLegacy).HasColumnName("AppliedToTrans_LEGACY");

                entity.Property(e => e.AttemptedTransType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthNetAuthorizationCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetAvscode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("AuthNetAVSCode")
                    .IsFixedLength();

                entity.Property(e => e.AuthNetResponseCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthNetResponseReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetResponseReasonText)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AuthNetTransactionId)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AuthNetTransactionID");

                entity.Property(e => e.CbapprovalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("CBApprovalCode");

                entity.Property(e => e.CbavsresultCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CBAVSResultCode")
                    .IsFixedLength();

                entity.Property(e => e.CberrorMsg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CBErrorMsg");

                entity.Property(e => e.CbresponseCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CBResponseCode");

                entity.Property(e => e.CbresponseText)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CBResponseText");

                entity.Property(e => e.CbstatusId).HasColumnName("CBStatusID");

                entity.Property(e => e.CbtransactionId).HasColumnName("CBTransactionID");

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.CcholderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CCHolderName");

                entity.Property(e => e.Ccnumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CCNumber");

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.ChargebackCaseNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckAccountNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CheckNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRoutingNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreditMemoNotesToPrint)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechAuthorizationCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechAvsrespCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("PayTechAVSRespCode");

                entity.Property(e => e.PayTechCvvrespCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PayTechCVVRespCode");

                entity.Property(e => e.PayTechRespCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechRespCodeMsg)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechRespDateTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechResponseText)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PayTechTransRefId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("PayTechTransRefID");

                entity.Property(e => e.PayTechTransRefNum)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDateTime).HasColumnType("datetime");

                entity.Property(e => e.ProviderOrderIdLegacy).HasColumnName("ProviderOrderID_LEGACY");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TransAmount).HasColumnType("money");

                entity.Property(e => e.TransNumLegacy).HasColumnName("TransNum_LEGACY");

                entity.Property(e => e.TransType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TransactionNotes)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersRefillRemindersStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.ToTable("Orders_Refill_Reminders_Status");

                entity.Property(e => e.StatusDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersRefillRemindersV2>(entity =>
            {
                entity.HasKey(e => e.RefillId);

                entity.ToTable("Orders_Refill_Reminders_v2");

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Refill_Reminders_v2_ProviderOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StatusCode, "IX_Orders_Refill_Reminders_v2_StatusCode")
                    .HasFillFactor(90);

                entity.Property(e => e.RefillId).HasColumnName("RefillID");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.SendDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SentDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.StatusCodeNavigation)
                    .WithMany(p => p.OrdersRefillRemindersV2s)
                    .HasForeignKey(d => d.StatusCode)
                    .HasConstraintName("FK_Orders_Refill_Reminders_v2_Orders_Refill_Reminders_Status");
            });

            modelBuilder.Entity<OrdersReturnBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId);

                entity.ToTable("Orders_Return_Batches");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.ClosedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<OrdersReturnBatchesLineItem>(entity =>
            {
                entity.HasKey(e => e.LineId)
                    .HasName("PK_Orders_Return_Batches_Relationship");

                entity.ToTable("Orders_Return_Batches_LineItems");

                entity.HasIndex(e => e.LineId, "IX_Orders_Return_Batches_LineItems_ProviderOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.LineId).HasColumnName("LineID");

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.DateAndTimeSubmitted).HasColumnType("datetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ReturnTo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<OrdersReturnRequest>(entity =>
            {
                entity.ToTable("Orders_Return_Request");

                entity.HasIndex(e => e.ProviderOrderId, "IX_Orders_Return_Request_ProviderOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.ApprovedOn).HasColumnType("datetime");

                entity.Property(e => e.CarrierId).HasColumnName("CarrierID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.ContactEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerNotes).HasMaxLength(500);

                entity.Property(e => e.DeniedOn).HasColumnType("datetime");

                entity.Property(e => e.Label).IsUnicode(false);

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.RefundType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.OrdersReturnRequests)
                    .HasForeignKey(d => d.ReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Return_Request_Orders_Return_Request_Reason");
            });

            modelBuilder.Entity<OrdersReturnRequestLine>(entity =>
            {
                entity.ToTable("Orders_Return_Request_Line");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.OrdersReturnRequestLines)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Return_Request_Line_Orders_Return_Request");
            });

            modelBuilder.Entity<OrdersReturnRequestReason>(entity =>
            {
                entity.ToTable("Orders_Return_Request_Reason");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Reason)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdersShopDotComFulfillment>(entity =>
            {
                entity.HasKey(e => new { e.ProviderOrderId, e.ProdId });

                entity.ToTable("Orders_ShopDotCom_Fulfillment");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.InvoiceNum)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.PurchaseId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PurchaseID");
            });

            modelBuilder.Entity<OrdersSource>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("Orders_Source");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.SourceDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PayPalSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId)
                    .HasName("PK_PayPa_Settings");

                entity.ToTable("PayPal_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.AccessToken)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MerchantName)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.ReportsSftphostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportsSFTPHostName");

                entity.Property(e => e.ReportsSftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportsSFTPPassword");

                entity.Property(e => e.ReportsSftpuser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReportsSFTPUser");
            });

            modelBuilder.Entity<PayPalSettlement>(entity =>
            {
                entity.ToTable("PayPal_Settlement");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceID");
            });

            modelBuilder.Entity<PayPalSettlementTransaction>(entity =>
            {
                entity.ToTable("PayPal_Settlement_Transaction");

                entity.HasIndex(e => e.CustomField, "IX_PayPal_Settlement_Transaction_CustomField")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.InvoiceId, "IX_PayPal_Settlement_Transaction_InvoiceID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProviderOrderId, "IX_PayPal_Settlement_Transaction_ProviderOrderID")
                    .HasFillFactor(90);

                entity.Property(e => e.ConsumerId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ConsumerID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomField)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount).HasColumnType("smallmoney");

                entity.Property(e => e.FeeCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FeeDebitOrCredit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GrossTransactionAmount).HasColumnType("smallmoney");

                entity.Property(e => e.GrossTransactionCurrency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("InvoiceID");

                entity.Property(e => e.PayPalReferenceId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PayPalReferenceID");

                entity.Property(e => e.PayPalReferenceIdtype)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PayPalReferenceIDType");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.TransactionCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.TransactionDebitOrCredit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionEventCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TransactionID");

                entity.Property(e => e.TransactionInitiationDate).HasColumnType("datetime");

                entity.HasOne(d => d.PayPalSettlement)
                    .WithMany(p => p.PayPalSettlementTransactions)
                    .HasForeignKey(d => d.PayPalSettlementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PayPal_Settlement_Transactions_PayPal_Settlement");
            });

            modelBuilder.Entity<PaymentechSubmission>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("Paymentech_Submissions");

                entity.HasIndex(e => e.ProviderOrderId, "IX_Paymentech_Submissions_ProviderOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SubmissionDate, "IX_Paymentech_Submissions_SubmissionDate")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SubmissionNumber, "IX_Paymentech_Submissions_SubmissionNumber")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ActionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AuthDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DepositAmount).HasColumnType("money");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.SubmissionDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SubmissionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PickupGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("Pickup_Groups");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("GroupID");

                entity.Property(e => e.GroupDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PickupGroupsMapping>(entity =>
            {
                entity.HasKey(e => new { e.PickupGroupId, e.CarrierAndClassId })
                    .HasName("PK_Pickup_Groups_Mappings_1");

                entity.ToTable("Pickup_Groups_Mappings");

                entity.Property(e => e.PickupGroupId).HasColumnName("PickupGroupID");

                entity.Property(e => e.CarrierAndClassId).HasColumnName("CarrierAndClassID");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.HasOne(d => d.CarrierAndClass)
                    .WithMany(p => p.PickupGroupsMappings)
                    .HasForeignKey(d => d.CarrierAndClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pickup_Groups_Mappings_CarriersAndClasses");

                entity.HasOne(d => d.PickupGroup)
                    .WithMany(p => p.PickupGroupsMappings)
                    .HasForeignKey(d => d.PickupGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pickup_Groups_Mappings_Pickup_Groups");

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.PickupGroupsMappings)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pickup_Groups_Mappings_ShippingMethods");
            });

            modelBuilder.Entity<ProdsBatch>(entity =>
            {
                entity.ToTable("Prods_Batch");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.OrdersBatchesPrintingId).HasColumnName("OrdersBatchesPrintingID");

                entity.Property(e => e.TotalWeightInLbs).HasColumnType("smallmoney");

                entity.HasOne(d => d.ProdsBatchType)
                    .WithMany(p => p.ProdsBatches)
                    .HasForeignKey(d => d.ProdsBatchTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Batch_Prods_Batch_Type");
            });

            modelBuilder.Entity<ProdsBatchLog>(entity =>
            {
                entity.ToTable("Prods_Batch_Log");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.StartedOn).HasColumnType("datetime");

                entity.HasOne(d => d.ProdsBatch)
                    .WithMany(p => p.ProdsBatchLogs)
                    .HasForeignKey(d => d.ProdsBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Batch_Log_Prods_Batch");
            });

            modelBuilder.Entity<ProdsBatchType>(entity =>
            {
                entity.ToTable("Prods_Batch_Type");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdsBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .IsClustered(false);

                entity.ToTable("Prods_Brands");

                entity.HasIndex(e => e.BrandId2, "CK_Prods_Brands_BrandID2")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.LastInfoChangeTimestamp, "IX_Prods_Brands_LastInfoChangeTimestamp")
                    .HasFillFactor(90);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandAbbrev)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId2).HasColumnName("BrandID2");

                entity.Property(e => e.BrandLogoUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BrandLogoURL");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastInfoChangeTimestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdsBrandsSpellingVariation>(entity =>
            {
                entity.HasKey(e => new { e.BrandId, e.StringVariation });

                entity.ToTable("Prods_Brands_SpellingVariations");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.StringVariation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ProdsBrandsSpellingVariations)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Brands_SpellingVariations_Prods_Brands");
            });

            modelBuilder.Entity<ProdsBundlesMapping>(entity =>
            {
                entity.HasKey(e => new { e.MasterProdId, e.ChildProdId });

                entity.ToTable("Prods_Bundles_Mappings");

                entity.Property(e => e.MasterProdId).HasColumnName("MasterProdID");

                entity.Property(e => e.ChildProdId).HasColumnName("ChildProdID");
            });

            modelBuilder.Entity<ProdsCountryExclusion>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.CountryId, e.AllowDisallow, e.StateCode });

                entity.ToTable("Prods_Country_Exclusions");

                entity.HasIndex(e => e.CountryId, "IX_Prods_Country_Exclusions_CountryID");

                entity.HasIndex(e => e.ProdId, "IX_Prods_Country_Exclusions_ProdID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.AllowDisallow)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StateCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdsCountryIngredientsExclusion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prods_Country_Ingredients_Exclusions");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Ingredient)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdsCountryIngredientsExclusionsNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Prods_Country_Ingredients_Exclusions_Notes");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Notes).IsUnicode(false);
            });

            modelBuilder.Entity<ProdsDamagedShelf>(entity =>
            {
                entity.ToTable("Prods_Damaged_Shelf");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Defect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(248);

                entity.Property(e => e.ExpDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<ProdsDictionary>(entity =>
            {
                entity.ToTable("Prods_Dictionary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Word)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdsFamiliesReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .IsClustered(false);

                entity.ToTable("Prods_Families_Reviews");

                entity.HasIndex(e => e.ReviewId, "IX_Prods_Families_Reviews_DateAndTime")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.FamId, "IX_Prods_Families_Reviews_FamID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.LastModified, "IX_Prods_Families_Reviews_LastModified")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ReviewerAccountId, "IX_Prods_Families_Reviews_ReviewerAccountID");

                entity.Property(e => e.ReviewId).HasColumnName("ReviewID");

                entity.Property(e => e.ApprovedBySfadminId).HasColumnName("ApprovedBySFAdminID");

                entity.Property(e => e.DateAndTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Details).HasMaxLength(4000);

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.ModeratorComments).HasMaxLength(2000);

                entity.Property(e => e.RejectedBySfadminId).HasColumnName("RejectedBySFAdminID");

                entity.Property(e => e.ReviewerAccountId).HasColumnName("ReviewerAccountID");

                entity.Property(e => e.Summary).HasMaxLength(150);
            });

            modelBuilder.Entity<ProdsFamiliesTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.FamId });

                entity.ToTable("Prods_Families_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.DetailedDesc).HasMaxLength(2000);

                entity.Property(e => e.FamName).HasMaxLength(100);

                entity.Property(e => e.FamName2).HasMaxLength(100);

                entity.Property(e => e.ShortDesc).HasMaxLength(250);

                entity.HasOne(d => d.Lang)
                    .WithMany(p => p.ProdsFamiliesTranslations)
                    .HasForeignKey(d => d.LangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Families_Translations_Languages");
            });

            modelBuilder.Entity<ProdsFamily>(entity =>
            {
                entity.HasKey(e => e.FamId)
                    .IsClustered(false);

                entity.ToTable("Prods_Families");

                entity.HasIndex(e => e.BrandId, "IX_Prods_Families_BrandID");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.OwnedByStorefrontId).HasColumnName("OwnedByStorefrontID");

                entity.Property(e => e.PicFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxableCa).HasColumnName("taxable_CA");

                entity.Property(e => e.TaxableNc).HasColumnName("taxable_NC");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ProdsFamilies)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Families_Prods_Brands");

                entity.HasOne(d => d.OwnedByStorefront)
                    .WithMany(p => p.ProdsFamilies)
                    .HasForeignKey(d => d.OwnedByStorefrontId)
                    .HasConstraintName("FK_Prods_Families_StorefrontInfo");

                entity.HasMany(d => d.Depts)
                    .WithMany(p => p.Fams)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProdsDeptsRelationship",
                        l => l.HasOne<DeptsDepartment>().WithMany().HasForeignKey("DeptId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Prods_Depts_Relationships_Depts_Departments"),
                        r => r.HasOne<ProdsFamily>().WithMany().HasForeignKey("FamId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Prods_Depts_Relationships_Prods_Families"),
                        j =>
                        {
                            j.HasKey("FamId", "DeptId").IsClustered(false);

                            j.ToTable("Prods_Depts_Relationships");

                            j.HasIndex(new[] { "DeptId" }, "IX_Prods_Depts_Relationships_DeptID");

                            j.IndexerProperty<int>("FamId").HasColumnName("FamID");

                            j.IndexerProperty<short>("DeptId").HasColumnName("DeptID");
                        });

                entity.HasMany(d => d.Keywords)
                    .WithMany(p => p.Fams)
                    .UsingEntity<Dictionary<string, object>>(
                        "ProdsKeywordsRelationship",
                        l => l.HasOne<KeywordsStandard>().WithMany().HasForeignKey("KeywordId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Prods_Keywords_Relationships_Keywords_Standard"),
                        r => r.HasOne<ProdsFamily>().WithMany().HasForeignKey("FamId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Prods_Keywords_Relationships_Prods_Families"),
                        j =>
                        {
                            j.HasKey("FamId", "KeywordId").IsClustered(false);

                            j.ToTable("Prods_Keywords_Relationships");

                            j.IndexerProperty<int>("FamId").HasColumnName("FamID");

                            j.IndexerProperty<int>("KeywordId").HasColumnName("KeywordID");
                        });
            });

            modelBuilder.Entity<ProdsLeadTime>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.WrhsId });

                entity.ToTable("Prods_LeadTime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<ProdsPrimaryVendor>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.ProviderId, e.VendorId });

                entity.ToTable("Prods_PrimaryVendor");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProdsPrimaryVendors)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_PrimaryVendor_Providers");

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.ProdsPrimaryVendors)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_PrimaryVendor_Vendors");
            });

            modelBuilder.Entity<ProdsProdManager>(entity =>
            {
                entity.HasKey(e => new { e.ProviderAdminId, e.ProdId });

                entity.ToTable("Prods_ProdManager");

                entity.Property(e => e.ProviderAdminId).HasColumnName("ProviderAdminID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<ProdsProduct>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .IsClustered(false);

                entity.ToTable("Prods_Products");

                entity.HasIndex(e => e.Discontinued, "IX_Prods_Products_Discontinued")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.DisplayToStorefronts, "IX_Prods_Products_DisplayToStorefronts")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.FamId, "IX_Prods_Products_FamID");

                entity.HasIndex(e => e.ProdId2, "IX_Prods_Products_ProdID2")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Upc, "IX_Prods_Products_UPC_const")
                    .IsUnique();

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.AccountingSalesClassId).HasColumnName("AccountingSalesClassID");

                entity.Property(e => e.ActualShippingWeightOz).HasColumnType("smallmoney");

                entity.Property(e => e.CountryOfOriginId).HasColumnName("CountryOfOriginID");

                entity.Property(e => e.DateProdCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DescLastUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.DiscontinuedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EconomyShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.EstimatedShippingWeightOz).HasColumnType("smallmoney");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.GrossWeight).HasColumnType("smallmoney");

                entity.Property(e => e.Height).HasColumnType("smallmoney");

                entity.Property(e => e.Length).HasColumnType("smallmoney");

                entity.Property(e => e.ManagementNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.NormalVelocity30DaysCa).HasColumnName("NormalVelocity30DaysCA");

                entity.Property(e => e.NormalVelocity30DaysNc).HasColumnName("NormalVelocity30DaysNC");

                entity.Property(e => e.PicFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PictureVerified).HasColumnType("smalldatetime");

                entity.Property(e => e.ProdId2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ProdID2");

                entity.Property(e => e.RestockLessThanDaysCa).HasColumnName("RestockLessThanDaysCA");

                entity.Property(e => e.RestockLessThanDaysNc).HasColumnName("RestockLessThanDaysNC");

                entity.Property(e => e.RestockToDaysCa).HasColumnName("RestockToDaysCA");

                entity.Property(e => e.RestockToDaysNc).HasColumnName("RestockToDaysNC");

                entity.Property(e => e.ServingSize).HasColumnType("smallmoney");

                entity.Property(e => e.ServingsPerContainer).HasColumnType("smallmoney");

                entity.Property(e => e.SpellingVerified)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StandardShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.StdCostToProvider).HasColumnType("smallmoney");

                entity.Property(e => e.UnitNumber).HasColumnType("smallmoney");

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.UnusualVelocityReason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnusualVelocityRemovalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.Width).HasColumnType("smallmoney");

                entity.HasOne(d => d.CountryOfOrigin)
                    .WithMany(p => p.ProdsProducts)
                    .HasForeignKey(d => d.CountryOfOriginId)
                    .HasConstraintName("FK_Prods_Products_Countries");

                entity.HasOne(d => d.Fam)
                    .WithMany(p => p.ProdsProducts)
                    .HasForeignKey(d => d.FamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Products_Prods_Families");
            });

            modelBuilder.Entity<ProdsProductsAvailability>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.WrhsId });

                entity.ToTable("Prods_Products_Availability");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.DebugSource)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.LastChangeTimestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProdsProductsAvailabilities)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Products_Availability_Prods_Products");

                entity.HasOne(d => d.Wrhs)
                    .WithMany(p => p.ProdsProductsAvailabilities)
                    .HasForeignKey(d => d.WrhsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Products_Availability_Warehouses");
            });

            modelBuilder.Entity<ProdsProductsDiscoAlternate>(entity =>
            {
                entity.ToTable("Prods_Products_DiscoAlternates");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlternateProdId).HasColumnName("AlternateProdID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<ProdsProductsExt1Translation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.ProdId });

                entity.ToTable("Prods_Products_Ext1_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.MfgDesc).HasMaxLength(2000);

                entity.Property(e => e.MfgDirections).HasMaxLength(1250);
            });

            modelBuilder.Entity<ProdsProductsExt2Translation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.ProdId });

                entity.ToTable("Prods_Products_Ext2_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.MfgDisclaimer).HasMaxLength(1500);

                entity.Property(e => e.MfgFactNotes).HasMaxLength(1000);

                entity.Property(e => e.MfgIngredients).HasMaxLength(1450);
            });

            modelBuilder.Entity<ProdsProductsExt3Translation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.ProdId });

                entity.ToTable("Prods_Products_Ext3_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.DescMarkerInfo).HasMaxLength(1000);
            });

            modelBuilder.Entity<ProdsProductsFeaturedMapping>(entity =>
            {
                entity.HasKey(e => new { e.FeaturedProdId, e.ProdId, e.StorefrontId });

                entity.ToTable("Prods_Products_Featured_Mappings");

                entity.HasIndex(e => e.FeaturedProdId, "IX_Prods_Products_Featured_Mappings_FeaturedProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_Prods_Products_Featured_Mappings_ProdID")
                    .HasFillFactor(90);

                entity.Property(e => e.FeaturedProdId).HasColumnName("FeaturedProdID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<ProdsProductsInStockNotification>(entity =>
            {
                entity.ToTable("Prods_Products_InStockNotification");

                entity.HasIndex(e => e.CartId, "IX_Prods_Products_InStockNotification_CartID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CreatedOn, "IX_Prods_Products_InStockNotification_CreatedOn")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.EmailAddress, "IX_Prods_Products_InStockNotification_EmailAddress")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Ipaddress, "IX_Prods_Products_InStockNotification_IPAddress")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_Prods_Products_InStockNotification_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ScheduledOn, "IX_Prods_Products_InStockNotification_ScheduledOn")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SentOn, "IX_Prods_Products_InStockNotification_SentOn")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Prods_Products_InStockNotification_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.CartId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CartID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ScheduledOn).HasColumnType("datetime");

                entity.Property(e => e.SentOn).HasColumnType("datetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProdsProductsInStockNotifications)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Products_InStockNotification_Prods_Products");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.ProdsProductsInStockNotifications)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Products_InStockNotification_StorefrontInfo");
            });

            modelBuilder.Entity<ProdsProductsPriceChangeLog>(entity =>
            {
                entity.ToTable("Prods_Products_Price_Change_Log");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Field)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue).HasColumnType("smallmoney");

                entity.Property(e => e.OldValue).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<ProdsProductsPriceChangeReasonLog>(entity =>
            {
                entity.ToTable("Prods_Products_Price_Change_Reason_Log");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PriceRolledBackOn).HasColumnType("datetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Reason)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.UnusualVelocityClearedOn).HasColumnType("datetime");

                entity.Property(e => e.Velocity30DaysCa).HasColumnName("Velocity30DaysCA");

                entity.Property(e => e.Velocity30DaysNc).HasColumnName("Velocity30DaysNC");
            });

            modelBuilder.Entity<ProdsProductsProp65Log>(entity =>
            {
                entity.ToTable("Prods_Products_Prop65_Log");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.HasOne(d => d.LogStatus)
                    .WithMany(p => p.ProdsProductsProp65Logs)
                    .HasForeignKey(d => d.LogStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Products_Prop65_Log_Prods_Products_Prop65_Log_Status");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProdsProductsProp65Logs)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Products_Prop65_Log_Prods_Products");
            });

            modelBuilder.Entity<ProdsProductsProp65LogStatus>(entity =>
            {
                entity.ToTable("Prods_Products_Prop65_Log_Status");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdsProductsRecount>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .IsClustered(false);

                entity.ToTable("Prods_Products_Recounts");

                entity.HasIndex(e => e.ProdId, "IX_Prods_Products_Recounts_prodid_clust")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Wrhsid).HasColumnName("WRHSID");
            });

            modelBuilder.Entity<ProdsProductsSpecialNotice>(entity =>
            {
                entity.ToTable("Prods_Products_SpecialNotices");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NoticeId).HasColumnName("NoticeID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<ProdsProductsSpecialNoticesLegend>(entity =>
            {
                entity.HasKey(e => e.NoticeId);

                entity.ToTable("Prods_Products_SpecialNotices_Legend");

                entity.Property(e => e.NoticeId).HasColumnName("NoticeID");

                entity.Property(e => e.NoticeDesc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NoticeMessage)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProdsProductsTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.ProdId });

                entity.ToTable("Prods_Products_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.DetailedDesc).HasMaxLength(2000);

                entity.Property(e => e.FamNameSuffix).HasMaxLength(200);

                entity.Property(e => e.FamNameSuffix2).HasMaxLength(200);

                entity.Property(e => e.PopupNoteToConsumer).HasMaxLength(400);

                entity.Property(e => e.Prop65).HasMaxLength(500);

                entity.Property(e => e.Prop65ImportedOn).HasColumnType("datetime");

                entity.Property(e => e.ServingUnit).HasMaxLength(20);

                entity.Property(e => e.ShortDesc).HasMaxLength(1000);
            });

            modelBuilder.Entity<ProdsProductsTranslationsOverride>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.ProdId });

                entity.ToTable("Prods_Products_Translations_Overrides");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.MfgDesc).HasMaxLength(2000);

                entity.Property(e => e.MfgDirections).HasMaxLength(1000);

                entity.Property(e => e.MfgDisclaimer).HasMaxLength(1500);

                entity.Property(e => e.MfgFactNotes).HasMaxLength(1250);

                entity.Property(e => e.MfgIngredients).HasMaxLength(1450);
            });

            modelBuilder.Entity<ProdsSample>(entity =>
            {
                entity.HasKey(e => e.SampleId);

                entity.ToTable("Prods_Samples");

                entity.Property(e => e.SampleId).HasColumnName("SampleID");

                entity.Property(e => e.InsertFeeToStorefrontObsolete)
                    .HasColumnType("smallmoney")
                    .HasColumnName("InsertFeeToStorefront_OBSOLETE");

                entity.Property(e => e.SampleName).HasMaxLength(50);

                entity.Property(e => e.SampleNotes).HasMaxLength(4000);

                entity.Property(e => e.SampleUpc)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("SampleUPC");
            });

            modelBuilder.Entity<ProdsSamplesInbound>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("Prods_Samples_Inbound");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.DateExpected).HasColumnType("smalldatetime");

                entity.Property(e => e.DateReceived).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.SampleId).HasColumnName("SampleID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.Sample)
                    .WithMany(p => p.ProdsSamplesInbounds)
                    .HasForeignKey(d => d.SampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Samples_Inbound_Prods_Samples");

                entity.HasOne(d => d.Wrhs)
                    .WithMany(p => p.ProdsSamplesInbounds)
                    .HasForeignKey(d => d.WrhsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Samples_Inbound_Warehouses");
            });

            modelBuilder.Entity<ProdsSamplesInventory>(entity =>
            {
                entity.HasKey(e => new { e.SampleId, e.WrhsId });

                entity.ToTable("Prods_Samples_Inventory");

                entity.Property(e => e.SampleId).HasColumnName("SampleID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.Sample)
                    .WithMany(p => p.ProdsSamplesInventories)
                    .HasForeignKey(d => d.SampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Samples_Inventory_Prods_Samples");

                entity.HasOne(d => d.Wrhs)
                    .WithMany(p => p.ProdsSamplesInventories)
                    .HasForeignKey(d => d.WrhsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Samples_Inventory_Warehouses");
            });

            modelBuilder.Entity<ProdsSamplesProdsRelationship>(entity =>
            {
                entity.HasKey(e => new { e.SampleId, e.ProdId, e.StorefrontId });

                entity.ToTable("Prods_SamplesProds_Relationship");

                entity.Property(e => e.SampleId).HasColumnName("SampleID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ProdsSamplesProdsRelationships)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_SamplesProds_Relationship_Prods_Products");

                entity.HasOne(d => d.Sample)
                    .WithMany(p => p.ProdsSamplesProdsRelationships)
                    .HasForeignKey(d => d.SampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_SamplesProds_Relationship_Prods_Samples");
            });

            modelBuilder.Entity<ProdsSamplesProdsRelationshipExclude>(entity =>
            {
                entity.HasKey(e => new { e.SampleId, e.ProdId, e.StorefrontId });

                entity.ToTable("Prods_SamplesProds_Relationship_Exclude");

                entity.Property(e => e.SampleId).HasColumnName("SampleID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Sample)
                    .WithMany(p => p.ProdsSamplesProdsRelationshipExcludes)
                    .HasForeignKey(d => d.SampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_SamplesProds_Relationship_Exclude_Prods_Samples");
            });

            modelBuilder.Entity<ProdsSamplesStorefront>(entity =>
            {
                entity.HasKey(e => new { e.SampleId, e.StorefrontId });

                entity.ToTable("Prods_Samples_Storefronts");

                entity.Property(e => e.SampleId).HasColumnName("SampleID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.InsertFeeToStorefront).HasColumnType("smallmoney");

                entity.HasOne(d => d.Sample)
                    .WithMany(p => p.ProdsSamplesStorefronts)
                    .HasForeignKey(d => d.SampleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Samples_Storefronts_Prods_Samples");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.ProdsSamplesStorefronts)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prods_Samples_Storefronts_StorefrontInfo");
            });

            modelBuilder.Entity<ProdsServingsTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.ProdId, e.TableIndex });

                entity.ToTable("Prods_Servings_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Header).HasMaxLength(50);

                entity.Property(e => e.ServingSize).HasColumnType("smallmoney");

                entity.Property(e => e.ServingUnit).HasMaxLength(10);

                entity.Property(e => e.ServingsPerContainer).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<ProdsSupplementFactsTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.ProdId, e.RowNum, e.TableIndex });

                entity.ToTable("Prods_SupplementFacts_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.AmtPerServ).HasMaxLength(15);

                entity.Property(e => e.Ingredient).HasMaxLength(100);

                entity.Property(e => e.PercentDv)
                    .HasMaxLength(15)
                    .HasColumnName("PercentDV");
            });

            modelBuilder.Entity<ProdsUnassignedToGroup>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("Prods_UnassignedToGroup");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProdID");

                entity.Property(e => e.DateStamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProdsUnitTypesTranslation>(entity =>
            {
                entity.HasKey(e => new { e.LangId, e.UnitTypeId });

                entity.ToTable("Prods_UnitTypes_Translations");

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.UnitTypeId).HasColumnName("UnitTypeID");

                entity.Property(e => e.UnitTypeName).HasMaxLength(5);

                entity.Property(e => e.UnitTypeName2).HasMaxLength(10);

                entity.Property(e => e.VariationTheme)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Abbreviation)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.BounceBackEmailForCustomerComm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.Country).HasMaxLength(30);

                entity.Property(e => e.DefaultPricingGroupId).HasColumnName("DefaultPricingGroupID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FromEmailForCustomerComm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailServerForCustomerComm)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OverheadDeductionPercentForCommissions).HasColumnType("smallmoney");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SfaccountDefaultAllowBackorders).HasColumnName("SFAccountDefault_AllowBackorders");

                entity.Property(e => e.SfaccountDefaultDefaultWarehouseAssignment).HasColumnName("SFAccountDefault_DefaultWarehouseAssignment");

                entity.Property(e => e.SfaccountDefaultDisplayInventoryCap).HasColumnName("SFAccountDefault_DisplayInventoryCap");

                entity.Property(e => e.SfaccountDefaultInventoryDisplayTypeId).HasColumnName("SFAccountDefault_InventoryDisplayTypeID");

                entity.Property(e => e.SfaccountDefaultManualApprovalRequired).HasColumnName("SFAccountDefault_ManualApprovalRequired");

                entity.Property(e => e.SfaccountDefaultPaymentMethodsCod).HasColumnName("SFAccountDefault_PaymentMethods_COD");

                entity.Property(e => e.SfaccountDefaultPaymentMethodsCodGtd).HasColumnName("SFAccountDefault_PaymentMethods_COD_GTD");

                entity.Property(e => e.SfaccountDefaultPaymentMethodsCreditCard).HasColumnName("SFAccountDefault_PaymentMethods_CreditCard");

                entity.Property(e => e.SfaccountDefaultPaymentMethodsPrepay).HasColumnName("SFAccountDefault_PaymentMethods_Prepay");

                entity.Property(e => e.SfaccountDefaultPaymentMethodsTerms).HasColumnName("SFAccountDefault_PaymentMethods_Terms");

                entity.Property(e => e.SfaccountDefaultPaymentMethodsTermsNet).HasColumnName("SFAccountDefault_PaymentMethods_Terms_NET");

                entity.Property(e => e.SfaccountDefaultShippingProcessTypeId).HasColumnName("SFAccountDefault_ShippingProcessTypeID");

                entity.Property(e => e.SfaccountDefaultTermsType)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SFAccountDefault_TermsType");

                entity.Property(e => e.SfaccountDefaultWhlsSalesTaxPercentCa)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SFAccountDefault_WhlsSalesTaxPercent_CA");

                entity.Property(e => e.SfaccountDefaultWhlsSalesTaxPercentNc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SFAccountDefault_WhlsSalesTaxPercent_NC");

                entity.Property(e => e.SfaccountDefaultWholesaleCreditLimit)
                    .HasColumnType("money")
                    .HasColumnName("SFAccountDefault_WholesaleCreditLimit");

                entity.Property(e => e.State).HasMaxLength(25);

                entity.Property(e => e.WhlsAccountApprovalRequestAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip).HasMaxLength(25);
            });

            modelBuilder.Entity<PurchaseAutomationExclusion>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("PurchaseAutomationExclusion");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProdID");
            });

            modelBuilder.Entity<PurchaseList>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.ProviderId });

                entity.ToTable("PurchaseList");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseOrder>(entity =>
            {
                entity.HasKey(e => e.Ponum);

                entity.HasIndex(e => e.TransferId, "IX_PurchaseOrders_TransferID")
                    .HasFillFactor(90);

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.AccountingSignoffTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Confirmed).HasColumnType("smalldatetime");

                entity.Property(e => e.DateExpected).HasColumnType("smalldatetime");

                entity.Property(e => e.DatePlaced).HasColumnType("smalldatetime");

                entity.Property(e => e.IsSpecialCasePo).HasColumnName("IsSpecialCasePO");

                entity.Property(e => e.IsTransferPendingPo).HasColumnName("IsTransferPendingPO");

                entity.Property(e => e.IsTransferPo).HasColumnName("IsTransferPO");

                entity.Property(e => e.IsTransferStagingPo).HasColumnName("IsTransferStagingPO");

                entity.Property(e => e.Notes)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.PurchaserInfo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivingSignoffTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ShipToInfo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ShowPriceOnPo).HasColumnName("ShowPriceOnPO");

                entity.Property(e => e.ShowVendorCodeOnPo).HasColumnName("ShowVendorCodeOnPO");

                entity.Property(e => e.StockConfirmed).HasColumnType("smalldatetime");

                entity.Property(e => e.TransferId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TransferID");

                entity.Property(e => e.TransferOrderId).HasColumnName("TransferOrderID");

                entity.Property(e => e.Vendor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.VendorNotes)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNotesObsolete)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("VendorNotes_OBSOLETE");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.VendorNavigation)
                    .WithMany(p => p.PurchaseOrders)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_PurchaseOrders_Vendors");
            });

            modelBuilder.Entity<PurchaseOrderAction>(entity =>
            {
                entity.ToTable("PurchaseOrder_Actions");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchaseOrderActionsLog>(entity =>
            {
                entity.ToTable("PurchaseOrder_Actions_Log");

                entity.HasIndex(e => e.Ponum, "IX_PurchaseOrder_Actions_Log_PONum")
                    .HasFillFactor(90);

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ponum).HasColumnName("PONum");
            });

            modelBuilder.Entity<PurchaseOrdersLineItem>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("PurchaseOrders_LineItems");

                entity.HasIndex(e => e.Ponum, "IX_PurchaseOrders_LineItems_PONum")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.ProdId, e.WrhsId }, "IX_PurchaseOrders_LineItems_ProdID_WrhsID_wQtyOrdered");

                entity.HasIndex(e => e.QtyInInventory, "IX_PurchaseOrders_LineItems_QtyInInventory")
                    .HasFillFactor(90);

                entity.Property(e => e.NotesForDebugTracking)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.RebatePercent).HasColumnType("smallmoney");

                entity.Property(e => e.UnitCost).HasColumnType("smallmoney");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.PonumNavigation)
                    .WithMany(p => p.PurchaseOrdersLineItems)
                    .HasForeignKey(d => d.Ponum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrders_LineItemsPlaced_PurchaseOrders");
            });

            modelBuilder.Entity<PurchaseOrdersLineItemsExpectedDate>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("PurchaseOrders_LineItems_ExpectedDate");

                entity.HasIndex(e => e.Ponum, "IX_PurchaseOrders_LineItems_ExpectedDate_PONum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_PurchaseOrders_LineItems_ExpectedDate_ProdID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateExpected).HasColumnType("smalldatetime");

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<PurchaseOrdersLineItemsExpirationDate>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("PurchaseOrders_LineItems_ExpirationDate");

                entity.HasIndex(e => e.Ponum, "IX_PurchaseOrders_LineItems_ExpirationDate_PONum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_PurchaseOrders_LineItems_ExpirationDate_ProdID")
                    .HasFillFactor(90);

                entity.Property(e => e.ExpirationDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<PurchaseOrdersLineItemsPallet>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("PurchaseOrders_LineItems_Pallets");

                entity.HasIndex(e => e.Ponum, "IX_PurchaseOrders_LineItems_Pallets_PONum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_PurchaseOrders_LineItems_Pallets_ProdID")
                    .HasFillFactor(90);

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<PurchaseOrdersLineItemsRackingGroup>(entity =>
            {
                entity.ToTable("PurchaseOrders_LineItems_RackingGroups");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.ClosedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<PurchaseOrdersLineItemsRackingGroupsPallet>(entity =>
            {
                entity.ToTable("PurchaseOrders_LineItems_RackingGroups_Pallets");

                entity.HasIndex(e => e.PalletUniquefier, "IX_PurchaseOrders_LineItems_RackingGroups_Pallets_PalletUniqufier")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.RackingGroupId, "IX_PurchaseOrders_LineItems_RackingGroups_Pallets_RackingGroupId")
                    .HasFillFactor(90);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.HasOne(d => d.PalletUniquefierNavigation)
                    .WithMany(p => p.PurchaseOrdersLineItemsRackingGroupsPallets)
                    .HasForeignKey(d => d.PalletUniquefier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrders_LineItems_RackingGroups_Pallets_PalletUniquefier");

                entity.HasOne(d => d.RackingGroup)
                    .WithMany(p => p.PurchaseOrdersLineItemsRackingGroupsPallets)
                    .HasForeignKey(d => d.RackingGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseOrders_LineItems_RackingGroups_Pallets_RackingGroupId");
            });

            modelBuilder.Entity<PurchaseOrdersLineItemsReceivedDate>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("PurchaseOrders_LineItems_ReceivedDate");

                entity.HasIndex(e => e.Ponum, "IX_PurchaseOrders_LineItems_ReceivedDate_PONum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_PurchaseOrders_LineItems_ReceivedDate_ProdID")
                    .HasFillFactor(90);

                entity.Property(e => e.DateReceived).HasColumnType("smalldatetime");

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<PurchaseOrdersUnrecognizedProd>(entity =>
            {
                entity.HasKey(e => new { e.Ponum, e.Upc });

                entity.ToTable("PurchaseOrders_UnrecognizedProds");

                entity.Property(e => e.Ponum).HasColumnName("PONum");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PurchasePricing>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.VendorId, e.ProviderId })
                    .HasName("PK_PurchasePricing_Backup");

                entity.ToTable("PurchasePricing");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.EverydayLowPrice).HasColumnType("smallmoney");

                entity.Property(e => e.EverydayRebatePercent).HasColumnType("smallmoney");

                entity.Property(e => e.InStockDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialPrice).HasColumnType("smallmoney");

                entity.Property(e => e.SpecialPriceBeg).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialPriceExp).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorSku)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VendorSKU");
            });

            modelBuilder.Entity<PurchasePricingBrandNote>(entity =>
            {
                entity.HasKey(e => e.NoteId);

                entity.ToTable("PurchasePricing_BrandNotes");

                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.PurchasePricingBrandNotes)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchasePricing_BrandNotes_Prods_Brands");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PurchasePricingBrandNotes)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchasePricing_BrandNotes_Providers");
            });

            modelBuilder.Entity<PurchasePricingCorrupted>(entity =>
            {
                entity.HasKey(e => new { e.ProdId, e.VendorId, e.ProviderId })
                    .HasName("PK_PurchasePricing");

                entity.ToTable("PurchasePricing_CORRUPTED");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.EverydayLowPrice).HasColumnType("smallmoney");

                entity.Property(e => e.EverydayRebatePercent).HasColumnType("smallmoney");

                entity.Property(e => e.SpecialPrice).HasColumnType("smallmoney");

                entity.Property(e => e.SpecialPriceBeg).HasColumnType("smalldatetime");

                entity.Property(e => e.SpecialPriceExp).HasColumnType("smalldatetime");

                entity.Property(e => e.VendorSku)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("VendorSKU");
            });

            modelBuilder.Entity<Redirect>(entity =>
            {
                entity.HasIndex(e => e.FromUrl, "IX_Redirects_FromURL_incToURL")
                    .HasFillFactor(90);

                entity.Property(e => e.RedirectId).HasColumnName("RedirectID");

                entity.Property(e => e.FromUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FromURL");

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.ToUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("ToURL");
            });

            modelBuilder.Entity<RemoteAreaSurchargeCarrier>(entity =>
            {
                entity.HasKey(e => e.CarrierId)
                    .HasName("PK_RemoteAreaSurchargeCarrier");

                entity.Property(e => e.CarrierId).HasColumnName("CarrierID");

                entity.Property(e => e.CarrierDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RemoteAreaSurchargeZipCode>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_RemoteAreaSurchargeZipCodes_2016");

                entity.HasIndex(e => e.City, "IX_RemoteAreaSurchargeZipCodes_City_2016")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CountryCode, "IX_RemoteAreaSurchargeZipCodes_CountryCode_2016")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeHigh, "IX_RemoteAreaSurchargeZipCodes_PostalCodeHigh_2016")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeLow, "IX_RemoteAreaSurchargeZipCodes_PostalCodeLow_2016")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CarrierId).HasColumnName("CarrierID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeHigh)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeLow)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.RemoteAreaSurchargeZipCodes)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RemoteAreaSurchargeZipCodes_RemoteAreaSurchargeCarrier_2016");
            });

            modelBuilder.Entity<RemoteAreaSurchargeZipCodes2015>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_RemoteAreaSurchargeZipCodes");

                entity.ToTable("RemoteAreaSurchargeZipCodes_2015");

                entity.HasIndex(e => e.City, "IX_RemoteAreaSurchargeZipCodes_City")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CountryCode, "IX_RemoteAreaSurchargeZipCodes_CountryCode")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeHigh, "IX_RemoteAreaSurchargeZipCodes_PostalCodeHigh")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeLow, "IX_RemoteAreaSurchargeZipCodes_PostalCodeLow")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CarrierId).HasColumnName("CarrierID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeHigh)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeLow)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.RemoteAreaSurchargeZipCodes2015s)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RemoteAreaSurchargeZipCodes_RemoteAreaSurchargeCarrier");
            });

            modelBuilder.Entity<ReturnOrder>(entity =>
            {
                entity.HasKey(e => e.Ronum);

                entity.Property(e => e.Ronum).HasColumnName("RONum");

                entity.Property(e => e.CreditToInfo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DateFollowUp).HasColumnType("smalldatetime");

                entity.Property(e => e.DatePlaced).HasColumnType("smalldatetime");

                entity.Property(e => e.DateSent).HasColumnType("smalldatetime");

                entity.Property(e => e.HeaderInfo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Ronotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("RONotes");

                entity.Property(e => e.SignOffByAccounting).HasColumnType("smalldatetime");

                entity.Property(e => e.SignOffByAccountingAdminId).HasColumnName("SignOffByAccountingAdminID");

                entity.Property(e => e.SignOffByPurchasing).HasColumnType("smalldatetime");

                entity.Property(e => e.SignOffByPurchasingAdminId).HasColumnName("SignOffByPurchasingAdminID");

                entity.Property(e => e.VendorId).HasColumnName("VendorID");
            });

            modelBuilder.Entity<ReturnOrderAction>(entity =>
            {
                entity.ToTable("ReturnOrder_Actions");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReturnOrderActionsLog>(entity =>
            {
                entity.ToTable("ReturnOrder_Actions_Log");

                entity.HasIndex(e => e.Ronum, "IX_ReturnOrder_Actions_Log_RONum")
                    .HasFillFactor(90);

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ronum).HasColumnName("RONum");
            });

            modelBuilder.Entity<ReturnOrdersLineItem>(entity =>
            {
                entity.HasKey(e => new { e.Ronum, e.ProdId });

                entity.ToTable("ReturnOrders_LineItems");

                entity.Property(e => e.Ronum).HasColumnName("RONum");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Cost).HasColumnType("smallmoney");

                entity.HasOne(d => d.RonumNavigation)
                    .WithMany(p => p.ReturnOrdersLineItems)
                    .HasForeignKey(d => d.Ronum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnOrders_LineItems_ReturnOrders");
            });

            modelBuilder.Entity<ReturnsShelf>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("ReturnsShelf");

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Classification)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.ReturnsShelves)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReturnsShelf_Prods_Products");
            });

            modelBuilder.Entity<SagawaManifest>(entity =>
            {
                entity.HasKey(e => e.ManifestId);

                entity.ToTable("Sagawa_Manifests");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileUploadDate).HasColumnType("datetime");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.SagawaManifests)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sagawa_Manifests_Sagawa_Shipping_Settings");
            });

            modelBuilder.Entity<SagawaRate>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.WeightInLbs });

                entity.ToTable("Sagawa_Rates");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.WeightInLbs).HasColumnType("smallmoney");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.SagawaRates)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sagawa_Rates_Sagawa_Rates_Period");
            });

            modelBuilder.Entity<SagawaRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("Sagawa_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SagawaShipment>(entity =>
            {
                entity.HasKey(e => e.ShipmentNum)
                    .HasName("PK_Sagawa_Shipments_");

                entity.ToTable("Sagawa_Shipments");

                entity.Property(e => e.ShipmentNum).ValueGeneratedNever();

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");
            });

            modelBuilder.Entity<SagawaShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("Sagawa_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.Ftpserver)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FTPServer");

                entity.Property(e => e.Ftpusername)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("FTPUsername");

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.ManifestEmailAddresses)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesRepCommissionsLineItem>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .IsClustered(false);

                entity.ToTable("SalesRepCommissions_LineItems");

                entity.HasIndex(e => e.AdminId, "IX_SalesRepCommissions_LineItems_AdminID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.LineItemRowId, "IX_SalesRepCommissions_LineItems_LineItemRowID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.MiscBillingDetailId, "IX_SalesRepCommissions_LineItems_MiscBillingDetailID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.OrderDateTime, "IX_SalesRepCommissions_LineItems_OrderDateTime")
                    .IsClustered()
                    .HasFillFactor(90);

                entity.HasIndex(e => e.UpsbillingDetailId, "IX_SalesRepCommissions_LineItems_UPSBillingDetailID")
                    .HasFillFactor(90);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.CommissionAmount).HasColumnType("money");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.DateAssignedToStatement).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FinalPodrawnFrom).HasColumnName("FinalPODrawnFrom");

                entity.Property(e => e.FinalProdCost).HasColumnType("money");

                entity.Property(e => e.FinalProdSalePrice).HasColumnType("money");

                entity.Property(e => e.GsobillingDetailId).HasColumnName("GSOBillingDetailID");

                entity.Property(e => e.LineItemRowId).HasColumnName("LineItemRowID");

                entity.Property(e => e.MiscBillingDetailId).HasColumnName("MiscBillingDetailID");

                entity.Property(e => e.OrderDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.SalesCommissionLineItemClassId).HasColumnName("SalesCommissionLineItemClassID");

                entity.Property(e => e.ShipDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StatementIdassignedTo).HasColumnName("StatementIDAssignedTo");

                entity.Property(e => e.UpsbillingDetailId).HasColumnName("UPSBillingDetailID");
            });

            modelBuilder.Entity<SalesRepCommissionsStatement>(entity =>
            {
                entity.HasKey(e => e.StatementId);

                entity.ToTable("SalesRepCommissions_Statements");

                entity.Property(e => e.StatementId).HasColumnName("StatementID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.StatementAmount).HasColumnType("smallmoney");

                entity.Property(e => e.StatementDate).HasColumnType("datetime");

                entity.Property(e => e.StatementNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesTaxFamSetting>(entity =>
            {
                entity.ToTable("SalesTaxFamSetting");

                entity.HasIndex(e => e.FamId, "IX_SalesTaxFamSetting_FamID")
                    .HasFillFactor(90);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxJarCategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesTaxSetting>(entity =>
            {
                entity.ToTable("SalesTaxSetting");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RateFood).HasColumnType("smallmoney");

                entity.Property(e => e.RateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.RateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.StateCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<ShipToCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .IsClustered(false);

                entity.HasIndex(e => e.CountryCode, "IX_ShipToCountries_CodeConstraint")
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsIntl>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_ShippingExtAreaSurchargeZipsINTL_2016");

                entity.ToTable("ShippingExtAreaSurchargeZipsINTL");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeHigh)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeLow)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsIntl20090401Obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ShippingExtAreaSurchargeZipsINTL_20090401_obsoletedata");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeHigh)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeLow)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsIntl2010obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ShippingExtAreaSurchargeZipsINTL_2010obsoletedata");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeHigh)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeLow)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsIntl20150403Obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ShippingExtAreaSurchargeZipsINTL_20150403_obsoletedata");

                entity.HasIndex(e => e.City, "IX_ShippingExtAreaSurchargeZipsINTL_City")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CountryCode, "IX_ShippingExtAreaSurchargeZipsINTL_CountryCode")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeHigh, "IX_ShippingExtAreaSurchargeZipsINTL_PostalCodeHigh")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeLow, "IX_ShippingExtAreaSurchargeZipsINTL_PostalCodeLow")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeHigh)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeLow)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsIntl2015obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK_ShippingExtAreaSurchargeZipsINTL_NEW");

                entity.ToTable("ShippingExtAreaSurchargeZipsINTL_2015obsoletedata");

                entity.HasIndex(e => e.City, "IX_ShippingExtAreaSurchargeZipsINTL_City")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CountryCode, "IX_ShippingExtAreaSurchargeZipsINTL_CountryCode")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeHigh, "IX_ShippingExtAreaSurchargeZipsINTL_PostalCodeHigh")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PostalCodeLow, "IX_ShippingExtAreaSurchargeZipsINTL_PostalCodeLow")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.City)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeHigh)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCodeLow)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsUp>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("PK_ShippingExtAreaSurchargeZips_UPS_2016");

                entity.ToTable("ShippingExtAreaSurchargeZips_UPS");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsUps2007obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("PK_ShippingExtAreaSurchargeZips");

                entity.ToTable("ShippingExtAreaSurchargeZips_UPS_2007obsoletedata");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsUps20090216Obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.ZipCode);

                entity.ToTable("ShippingExtAreaSurchargeZips_UPS_20090216_obsoletedata");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsUps2010obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.ZipCode);

                entity.ToTable("ShippingExtAreaSurchargeZips_UPS_2010obsoletedata");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingExtAreaSurchargeZipsUps2015obsoletedatum>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("PK_ShippingExtAreaSurchargeZips_TEMP");

                entity.ToTable("ShippingExtAreaSurchargeZips_UPS_2015obsoletedata");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.HasKey(e => e.ShipMethodId)
                    .IsClustered(false);

                entity.HasIndex(e => e.ShipMethodCode, "IX_ShippingMethods_CodeConstraint")
                    .IsUnique();

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.DomOrInt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlatOrZipDependent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShipMethodDescToPublic)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodDescToStorefront)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShippingTransitTime>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.ToZip });

                entity.ToTable("Shipping_TransitTimes");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.ToZip)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BasicBrownobserved).HasColumnType("smallmoney");

                entity.Property(e => e.BasicUspsobserved)
                    .HasColumnType("smallmoney")
                    .HasColumnName("BasicUSPSobserved");

                entity.Property(e => e.Fcobserved)
                    .HasColumnType("smallmoney")
                    .HasColumnName("FCobserved");

                entity.Property(e => e.Mxobserved)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MXobserved");

                entity.Property(e => e.Ngsobserved)
                    .HasColumnType("smallmoney")
                    .HasColumnName("NGSobserved");

                entity.Property(e => e.Ngsstated)
                    .HasColumnType("smallmoney")
                    .HasColumnName("NGSstated");

                entity.Property(e => e.Pmobserved)
                    .HasColumnType("smallmoney")
                    .HasColumnName("PMobserved");

                entity.Property(e => e.Upsgroundobserved)
                    .HasColumnType("smallmoney")
                    .HasColumnName("UPSGroundobserved");
            });

            modelBuilder.Entity<ShippingUpsbasicZipDeliveredBy>(entity =>
            {
                entity.HasKey(e => e.Zip);

                entity.ToTable("Shipping_UPSBasic_ZipDeliveredBy");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.Upsdeliveries).HasColumnName("UPSDeliveries");

                entity.Property(e => e.Uspsdeliveries).HasColumnName("USPSDeliveries");
            });

            modelBuilder.Entity<ShippingZone>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.BegZip })
                    .HasName("PK_ShippingZones_NEW");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.BegZip)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndZip)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            });

            modelBuilder.Entity<ShippingZonesOld>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.BegZip })
                    .HasName("PK_ShippingZones");

                entity.ToTable("ShippingZones_OLD");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.BegZip)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndZip)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");
            });

            modelBuilder.Entity<SpamComplaintAddress>(entity =>
            {
                entity.HasKey(e => new { e.Email, e.Date });

                entity.HasIndex(e => e.Email, "IX_SpamComplaintAddresses_Email")
                    .HasFillFactor(90);

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EmailCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StandardUrl>(entity =>
            {
                entity.HasKey(e => e.Urlid);

                entity.ToTable("StandardURLs");

                entity.HasIndex(e => e.StdUrl, "IX_StdURL")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.Urlid).HasColumnName("URLID");

                entity.Property(e => e.StdUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("StdURL");
            });

            modelBuilder.Entity<StorefrontBrandInfo>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.BrandId });

                entity.ToTable("StorefrontBrandInfo");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.DisableMapstrikeThrough).HasColumnName("DisableMAPStrikeThrough");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.StorefrontBrandInfos)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontBrandInfo_StorefrontInfo");
            });

            modelBuilder.Entity<StorefrontCcinfo>(entity =>
            {
                entity.HasKey(e => e.CardId);

                entity.ToTable("StorefrontCCInfo");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CardExpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CardExpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CardLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.NameOnCard)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.StorefrontCcinfos)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontCCInfo_StorefrontInfo");
            });

            modelBuilder.Entity<StorefrontControlPanelLink>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Text)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<StorefrontCustomerMessage>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.Property(e => e.MessageLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageText).HasColumnType("ntext");

                entity.Property(e => e.ShowOnSfcommPage).HasColumnName("ShowOnSFcommPage");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<StorefrontInfo>(entity =>
            {
                entity.HasKey(e => e.StorefrontId)
                    .IsClustered(false);

                entity.ToTable("StorefrontInfo");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.AccessPwd)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNotes)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeNetEmailMerchantSetting)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthorizeNetLogin)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeNetPassword)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AuthorizeNetUrltoPost)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("AuthorizeNetURLToPost");

                entity.Property(e => e.BillToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillToFax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cancelorderinprocessfee).HasColumnType("smallmoney");

                entity.Property(e => e.CcorderConfirmationEmailsTo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CCOrderConfirmationEmailsTo");

                entity.Property(e => e.CcrefillReminderEmailsTo)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CCRefillReminderEmailsTo");

                entity.Property(e => e.ChargeBridgeId).HasColumnName("ChargeBridgeID");

                entity.Property(e => e.ChargeBridgePassword)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeBridgeUsername)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CustomStorefrontMenuIds)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CustomStorefrontMenuIDs");

                entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DropShipCreditLimit).HasColumnType("money");

                entity.Property(e => e.EmailReturnsNotificationTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailShipmentNotificationTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTextFileDropshipNotificationTo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnabledInternalSfcpfeatures).HasColumnName("EnabledInternalSFCPfeatures");

                entity.Property(e => e.FooterOnSlip)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDisplayTypeId).HasColumnName("InventoryDisplayTypeID");

                entity.Property(e => e.LegalName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LinkSecureUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LinkSecureURL");

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LinkURL");

                entity.Property(e => e.MailReturnAddressPublicWebsite)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailServerAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MemoOnSlip)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OwnedByProviderId).HasColumnName("OwnedByProviderID");

                entity.Property(e => e.PaymentMethodsCod).HasColumnName("PaymentMethods_COD");

                entity.Property(e => e.PaymentMethodsCodGtd).HasColumnName("PaymentMethods_COD_GTD");

                entity.Property(e => e.PaymentMethodsCreditCard).HasColumnName("PaymentMethods_CreditCard");

                entity.Property(e => e.PaymentMethodsECheck).HasColumnName("PaymentMethods_eCheck");

                entity.Property(e => e.PaymentMethodsPrepay).HasColumnName("PaymentMethods_Prepay");

                entity.Property(e => e.PaymentMethodsTerms).HasColumnName("PaymentMethods_Terms");

                entity.Property(e => e.PaymentMethodsTermsNet).HasColumnName("PaymentMethods_Terms_NET");

                entity.Property(e => e.PaymentechCcenabled).HasColumnName("PaymentechCCEnabled");

                entity.Property(e => e.PaymentechEcheckEnabled).HasColumnName("PaymentechECheckEnabled");

                entity.Property(e => e.PaymentechMerchantId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("PaymentechMerchantID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.ResaleCertNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesRepAdminId).HasColumnName("SalesRepAdminID");

                entity.Property(e => e.SalesTaxPercentCa)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SalesTaxPercent_CA");

                entity.Property(e => e.SalesTaxPercentNc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SalesTaxPercent_NC");

                entity.Property(e => e.ServiceFeeFulfillmentPerItem)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ServiceFee_Fulfillment_PerItem");

                entity.Property(e => e.ServiceFeeFulfillmentPerOrder)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ServiceFee_Fulfillment_PerOrder");

                entity.Property(e => e.ServiceFeeReturnsPerOrder)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ServiceFee_Returns_PerOrder");

                entity.Property(e => e.ServiceFeeReturnsToInventoryPercent)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ServiceFee_Returns_ToInventory_Percent");

                entity.Property(e => e.ServiceFeeReturnsToSupplierPercent)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ServiceFee_Returns_ToSupplier_Percent");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingProcessTypeId).HasColumnName("ShippingProcessTypeID");

                entity.Property(e => e.StoreAddress2OnSlip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddressOnSlip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCityOnSlip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreEmailOnSlip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFaxOnSlip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreNameOnSlip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhoneOnSlip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreStateOnSlip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZipOnSlip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TermsDays)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TermsType)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.Property(e => e.UseCaforCaaddresses).HasColumnName("UseCAforCAAddresses");

                entity.Property(e => e.UseNcforNcaddresses).HasColumnName("UseNCforNCAddresses");

                entity.Property(e => e.WhlsSalesTaxPercentCa)
                    .HasColumnType("smallmoney")
                    .HasColumnName("WhlsSalesTaxPercent_CA");

                entity.Property(e => e.WhlsSalesTaxPercentNc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("WhlsSalesTaxPercent_NC");

                entity.Property(e => e.WholesaleCreditLimit).HasColumnType("money");

                entity.HasMany(d => d.CandCs)
                    .WithMany(p => p.Storefronts)
                    .UsingEntity<Dictionary<string, object>>(
                        "StorefrontsCarrierAndClass",
                        l => l.HasOne<CarriersAndClass>().WithMany().HasForeignKey("CandCid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Storefronts_CarrierAndClasses_CarriersAndClasses"),
                        r => r.HasOne<StorefrontInfo>().WithMany().HasForeignKey("StorefrontId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Storefronts_CarrierAndClasses_StorefrontInfo"),
                        j =>
                        {
                            j.HasKey("StorefrontId", "CandCid");

                            j.ToTable("Storefronts_CarrierAndClasses");

                            j.IndexerProperty<short>("StorefrontId").HasColumnName("StorefrontID");

                            j.IndexerProperty<byte>("CandCid").HasColumnName("CandCID");
                        });

                entity.HasMany(d => d.Links)
                    .WithMany(p => p.Storefronts)
                    .UsingEntity<Dictionary<string, object>>(
                        "StorefrontLink",
                        l => l.HasOne<StorefrontControlPanelLink>().WithMany().HasForeignKey("LinkId").HasConstraintName("FK_StorefrontLinks_StorefrontControlPanelLinks"),
                        r => r.HasOne<StorefrontInfo>().WithMany().HasForeignKey("StorefrontId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_StorefrontLinks_StorefrontInfo"),
                        j =>
                        {
                            j.HasKey("StorefrontId", "LinkId");

                            j.ToTable("StorefrontLinks");

                            j.IndexerProperty<short>("StorefrontId").HasColumnName("StorefrontID");

                            j.IndexerProperty<short>("LinkId").HasColumnName("LinkID");
                        });

                entity.HasMany(d => d.Wrhs)
                    .WithMany(p => p.Storefronts)
                    .UsingEntity<Dictionary<string, object>>(
                        "StorefrontWarehouse",
                        l => l.HasOne<Warehouse>().WithMany().HasForeignKey("WrhsId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Storefront_Warehouses_Warehouses"),
                        r => r.HasOne<StorefrontInfo>().WithMany().HasForeignKey("StorefrontId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Storefront_Warehouses_StorefrontInfo"),
                        j =>
                        {
                            j.HasKey("StorefrontId", "WrhsId");

                            j.ToTable("Storefront_Warehouses");

                            j.IndexerProperty<short>("StorefrontId").HasColumnName("StorefrontID");

                            j.IndexerProperty<short>("WrhsId").HasColumnName("WrhsID");
                        });
            });

            modelBuilder.Entity<StorefrontInfoMerchantId>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.CurrencyId });

                entity.ToTable("StorefrontInfo_MerchantIDs");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.PaymentechMerchantId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PaymentechMerchantID");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.StorefrontInfoMerchantIds)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.StorefrontInfoMerchantIds)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<StorefrontInfoXmlmessageAccess>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.XmlmessageId });

                entity.ToTable("StorefrontInfo_XMLMessageAccess");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.XmlmessageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("XMLMessageID");
            });

            modelBuilder.Entity<StorefrontNoteLog>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("StorefrontNoteLog");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.DateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.FollowupDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NoteTypeId).HasColumnName("NoteTypeID");

                entity.Property(e => e.Notes).HasMaxLength(4000);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<StorefrontNoteLogNoteType>(entity =>
            {
                entity.HasKey(e => e.NoteTypeId)
                    .HasName("PK_StorefrontNotesLog_NoteTypes");

                entity.ToTable("StorefrontNoteLog_NoteTypes");

                entity.Property(e => e.NoteTypeId)
                    .ValueGeneratedNever()
                    .HasColumnName("NoteTypeID");

                entity.Property(e => e.NoteAbbrev)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NoteDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StorefrontProdInfo>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.ProdId })
                    .HasName("PK_ProdSourceForStorefronts");

                entity.ToTable("StorefrontProdInfo");

                entity.HasIndex(e => e.CurPubPrice, "IX_StorefrontProdInfo_CurPubPrice")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.LastInfoChangeTimestamp, "IX_StorefrontProdInfo_LastInfoChangeTimestamp")
                    .HasFillFactor(90);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.AllowMapinstantCoupon).HasColumnName("AllowMAPInstantCoupon");

                entity.Property(e => e.CurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.FollowUpDate).HasColumnType("datetime");

                entity.Property(e => e.LastInfoChangeTimestamp).HasColumnType("datetime");

                entity.Property(e => e.MinAdvertisedPrice).HasColumnType("smallmoney");

                entity.Property(e => e.PriceToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.StdPubPrice).HasColumnType("smallmoney");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.StorefrontProdInfos)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontProdInfo_StorefrontInfo");
            });

            modelBuilder.Entity<StorefrontProdInfoChangeLog>(entity =>
            {
                entity.HasKey(e => e.ProdInfoLogId)
                    .IsClustered(false);

                entity.ToTable("StorefrontProdInfo_ChangeLog");

                entity.Property(e => e.ProdInfoLogId).HasColumnName("ProdInfoLogID");

                entity.Property(e => e.DateTimeStamp).HasColumnType("smalldatetime");

                entity.Property(e => e.NewCurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.NewMinAdvertisedPrice).HasColumnType("smallmoney");

                entity.Property(e => e.NewPriceToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.NewStdPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldCurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.OldMinAdvertisedPrice).HasColumnType("smallmoney");

                entity.Property(e => e.OldPriceToStorefront).HasColumnType("smallmoney");

                entity.Property(e => e.OldStdPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProviderAdminId).HasColumnName("ProviderAdminID");

                entity.Property(e => e.StorefrontAdminId).HasColumnName("StorefrontAdminID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Prod)
                    .WithMany(p => p.StorefrontProdInfoChangeLogs)
                    .HasForeignKey(d => d.ProdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontProdInfo_ChangeLog_Prods_Products");

                entity.HasOne(d => d.ProviderAdmin)
                    .WithMany(p => p.StorefrontProdInfoChangeLogs)
                    .HasForeignKey(d => d.ProviderAdminId)
                    .HasConstraintName("FK_StorefrontProdInfo_ChangeLog_Admins_Provider");

                entity.HasOne(d => d.StorefrontAdmin)
                    .WithMany(p => p.StorefrontProdInfoChangeLogs)
                    .HasForeignKey(d => d.StorefrontAdminId)
                    .HasConstraintName("FK_StorefrontProdInfo_ChangeLog_Admins_Storefronts");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.StorefrontProdInfoChangeLogs)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontProdInfo_ChangeLog_StorefrontInfo");
            });

            modelBuilder.Entity<StorefrontProdInfoPricerLog>(entity =>
            {
                entity.ToTable("StorefrontProdInfo_Pricer_Log");

                entity.Property(e => e.Ash28dayVelocity).HasColumnName("ASH28DayVelocity");

                entity.Property(e => e.AshpricePosition).HasColumnName("ASHPricePosition");

                entity.Property(e => e.AvgCost).HasColumnType("smallmoney");

                entity.Property(e => e.AvgEdlp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("AvgEDLP");

                entity.Property(e => e.CurPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.DateInserted).HasColumnType("datetime");

                entity.Property(e => e.LowestGoogleTotalPrice).HasColumnType("smallmoney");

                entity.Property(e => e.MarkupAmount).HasColumnType("smallmoney");

                entity.Property(e => e.MarkupPercent).HasColumnType("smallmoney");

                entity.Property(e => e.MinimumPrice).HasColumnType("smallmoney");

                entity.Property(e => e.NewCalculatedPrice).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.StdPubPrice).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Upc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<StorefrontShipToInfo>(entity =>
            {
                entity.HasKey(e => e.ShipToId);

                entity.ToTable("StorefrontShipToInfo");

                entity.Property(e => e.ShipToId).HasColumnName("ShipToID");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountryID");

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToFName");

                entity.Property(e => e.ShipToLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToLName");

                entity.Property(e => e.ShipToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToMName");

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.StorefrontShipToInfos)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShipToInfo_StorefrontInfo");
            });

            modelBuilder.Entity<StorefrontShippingMethod>(entity =>
            {
                entity.HasKey(e => e.ShipMethodId)
                    .IsClustered(false);

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.DomOrInt)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlatOrZipDependent)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxProdValue).HasColumnType("smallmoney");

                entity.Property(e => e.MaxShipWeightInOz).HasColumnType("smallmoney");

                entity.Property(e => e.NotesToPublic).HasMaxLength(500);

                entity.Property(e => e.RemoteAreaSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ShipMethodDescToPublic)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodDescToStorefront)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.HasOne(d => d.RemoteAreaSurchargeCarrierNavigation)
                    .WithMany(p => p.StorefrontShippingMethods)
                    .HasForeignKey(d => d.RemoteAreaSurchargeCarrier)
                    .HasConstraintName("FK_StorefrontShippingMethods_RemoteAreaSurchargeCarrier");

                entity.HasOne(d => d.Storefront)
                    .WithMany(p => p.StorefrontShippingMethods)
                    .HasForeignKey(d => d.StorefrontId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShippingMethods_StorefrontInfo");
            });

            modelBuilder.Entity<StorefrontShippingMethodsCarrierandClass>(entity =>
            {
                entity.ToTable("StorefrontShippingMethods_CarrierandClasses");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CandCid).HasColumnName("CandCID");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.HasOne(d => d.CandC)
                    .WithMany(p => p.StorefrontShippingMethodsCarrierandClasses)
                    .HasForeignKey(d => d.CandCid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShippingMethods_CarrierandClasses_CarriersAndClasses");

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.StorefrontShippingMethodsCarrierandClasses)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShippingMethods_CarrierandClasses_StorefrontShippingMethods");
            });

            modelBuilder.Entity<StorefrontShippingMethodsMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("StorefrontShippingMethods_Messages");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.MessageText).HasMaxLength(3000);

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StorefrontShippingMethodsMessages)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShippingMethods_Messages_ShipToCountries");

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.StorefrontShippingMethodsMessages)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShippingMethods_Messages_StorefrontShippingMethods");
            });

            modelBuilder.Entity<StorefrontShippingMethodsShipInfo>(entity =>
            {
                entity.ToTable("StorefrontShippingMethods_ShipInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.PerItemFee).HasColumnType("smallmoney");

                entity.Property(e => e.PerOrderFee).HasColumnType("smallmoney");

                entity.Property(e => e.PerOunceFee).HasColumnType("smallmoney");

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.StorefrontShippingMethodsShipInfos)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShippingMethods_ShipInfo_StorefrontShippingMethods");
            });

            modelBuilder.Entity<StorefrontShippingMethodsShipInfoFeeOverride>(entity =>
            {
                entity.ToTable("StorefrontShippingMethods_ShipInfo_FeeOverrides");

                entity.HasIndex(e => new { e.StorefrontShippingMethodsShipInfoId, e.WeightInPounds }, "IX_StorefrontShippingMethods_ShipInfo_FeeOverrides")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StorefrontShippingMethodsShipInfoId).HasColumnName("StorefrontShippingMethods_ShipInfo_ID");

                entity.Property(e => e.TotalFee).HasColumnType("smallmoney");

                entity.HasOne(d => d.StorefrontShippingMethodsShipInfo)
                    .WithMany(p => p.StorefrontShippingMethodsShipInfoFeeOverrides)
                    .HasForeignKey(d => d.StorefrontShippingMethodsShipInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StorefrontShippingMethods_ShipInfo_FeeOverrides_StorefrontShippingMethods_ShipInfo");
            });

            modelBuilder.Entity<StorefrontWebRequestFilter>(entity =>
            {
                entity.ToTable("Storefront_WebRequest_Filter");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsFixedLength();

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StorefrontsPubSiteKeywordRedirect>(entity =>
            {
                entity.ToTable("Storefronts_PubSite_KeywordRedirects");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Keyword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(900)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationAllNutriCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Syndication_AllNutri_Categories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationAllNutriProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_AllNutri_Prods");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.AllNutriCategory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<SyndicationAllNutriSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_AllNutri_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationAmazonDiscod>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("Syndication_Amazon_Discod");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProdID");
            });

            modelBuilder.Entity<SyndicationAmazonItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("Syndication_Amazon_ItemTypes");

                entity.Property(e => e.ItemTypeId).HasColumnName("ItemTypeID");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationAmazonProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_Amazon_Prods");

                entity.HasIndex(e => e.Asin, "IX_Syndication_Amazon_Prods_ASIN_notnull")
                    .IsUnique();

                entity.HasIndex(e => e.MarketplaceId, "IX_Syndication_Amazon_Prods_MarketplaceID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_Syndication_Amazon_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_Amazon_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.AmazonCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Asin)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ASIN");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Flavor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredients1)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredients2)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ingredients3)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemPriceObsolete)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ItemPrice_OBSOLETE");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LaunchDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MainImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MainImageURL");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarketplaceId).HasColumnName("MarketplaceID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SearchTerms1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTerms2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTerms3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTerms4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTerms5)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingObsolete)
                    .HasColumnType("smallmoney")
                    .HasColumnName("Shipping_OBSOLETE");

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<SyndicationAmazonProdAdsProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_AmazonProdAds_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_AmazonProdAds_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_AmazonProdAds_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Condition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleProductType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.ImageLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mpn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MPN");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAccepted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pickup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.PriceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Shipping)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<SyndicationAmazonProdAdsProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.ToTable("Syndication_AmazonProdAds_ProductTypes");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationAmazonProdAdsSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_AmazonProdAds_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.FtphostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPHostName");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.FtpuserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPUserName");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationAmazonProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId)
                    .HasName("PK_Syndication_Amazon_Categories");

                entity.ToTable("Syndication_Amazon_ProductTypes");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationAmazonSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_Amazon_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationBingProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_Bing_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_Bing_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_Bing_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Availability)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BingAdsGrouping)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BingAds_Grouping");

                entity.Property(e => e.BingAdsLabel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BingAds_Label");

                entity.Property(e => e.BingAdsRedirect)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BingAds_Redirect");

                entity.Property(e => e.Brand)
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Condition)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CustomLabel0)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_0");

                entity.Property(e => e.CustomLabel1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_1");

                entity.Property(e => e.CustomLabel2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_2");

                entity.Property(e => e.CustomLabel3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_3");

                entity.Property(e => e.CustomLabel4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_4");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Expiration_Date");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GTIN");

                entity.Property(e => e.ImageLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MobileLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Mpn)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("MPN");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Product_Category");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(750)
                    .IsUnicode(false)
                    .HasColumnName("Product_Type");

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SalePrice).HasColumnType("smallmoney");

                entity.Property(e => e.SalePriceEffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationBingSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_Bing_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationBizRateCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Syndication_BizRate_Categories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationBizRateProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_BizRate_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_BizRate_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_BizRate_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.BizRateCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ProductURL");

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.StockStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<SyndicationBizRateSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_BizRate_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.FtphostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPHostName");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.FtpuserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPUserName");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationEBayProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_eBay_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_eBay_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_eBay_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PriceOverride).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<SyndicationFacebookProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_Facebook_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_Facebook_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_Facebook_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<SyndicationFacebookSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_Facebook_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationGeneralSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_General_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.HomeDir)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HomeUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HomeURL");
            });

            modelBuilder.Entity<SyndicationGoogleCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Syndication_Google_Countries");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Culture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationGoogleDisapproval>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Syndication_Google_Disapprovals");

                entity.Property(e => e.AdditionalInformation)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Channel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DisapprovalTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IssueTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTitle)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.SamplingTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueInFeed)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ValueOnWebsite)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationGoogleProd>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK_Syndication_Froogle_Prods");

                entity.ToTable("Syndication_Google_Prods");

                entity.HasIndex(e => e.GoogleCountryId, "IX_Syndication_Google_Prods_GoogleCountryID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ProdId, "IX_Syndication_Google_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_Google_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.AdwordsGrouping)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Condition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomLabel0)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_0");

                entity.Property(e => e.CustomLabel1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_1");

                entity.Property(e => e.CustomLabel2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_2");

                entity.Property(e => e.CustomLabel3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_3");

                entity.Property(e => e.CustomLabel4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_4");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleCountryId).HasColumnName("GoogleCountryID");

                entity.Property(e => e.GoogleProductType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.ImageLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mpn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MPN");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAccepted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pickup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.PriceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Shipping)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.HasOne(d => d.GoogleCountry)
                    .WithMany(p => p.SyndicationGoogleProds)
                    .HasForeignKey(d => d.GoogleCountryId)
                    .HasConstraintName("FK_Syndication_Google_Prods_Syndication_Google_Countries");
            });

            modelBuilder.Entity<SyndicationGoogleProdsStaging>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.ProdId, e.GoogleCountryId })
                    .HasName("PK_Syndication_Google_Prods_STAGING_1");

                entity.ToTable("Syndication_Google_Prods_STAGING");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.GoogleCountryId).HasColumnName("GoogleCountryID");

                entity.Property(e => e.Availability)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Condition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomLabel0)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_0");

                entity.Property(e => e.CustomLabel1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_1");

                entity.Property(e => e.CustomLabel2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_2");

                entity.Property(e => e.CustomLabel3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_3");

                entity.Property(e => e.CustomLabel4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Custom_Label_4");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleProductType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gtin)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .HasColumnName("GTIN");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.ImageLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Mpn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MPN");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.Prop65).HasMaxLength(500);

                entity.Property(e => e.ShippingCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPrice).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingService)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxPercent).HasColumnType("smallmoney");

                entity.Property(e => e.TaxRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxShip)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationGoogleProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId)
                    .HasName("PK_Syndication_Froogle_ProductTypes");

                entity.ToTable("Syndication_Google_ProductTypes");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationGoogleSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId)
                    .HasName("PK_Syndication_Froogle_Settings");

                entity.ToTable("Syndication_Google_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.CancelledLastOrderIdprocessed).HasColumnName("CancelledLastOrderIDProcessed");

                entity.Property(e => e.CancelledOrdersLocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelLink)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChannelTitle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FtphostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPHostName");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.FtpuserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPUserName");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPPassword");

                entity.Property(e => e.SftpserverFingerprint)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPServerFingerprint");

                entity.Property(e => e.SftpserverName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPServerName");

                entity.Property(e => e.SftpserverPort)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPServerPort");

                entity.Property(e => e.Sftpusername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFTPUsername");

                entity.Property(e => e.ShippedLastOrderIdprocessed).HasColumnName("ShippedLastOrderIDProcessed");

                entity.Property(e => e.ShippedOrdersLocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationHealthPricerProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_HealthPricer_Prods");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<SyndicationHealthPricerSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_HealthPricer_Settings");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationJetProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_Jet_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_Jet_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_Jet_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.DiscountPercent).HasColumnType("smallmoney");

                entity.Property(e => e.MarkupPercent).HasColumnType("smallmoney");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<SyndicationNextagCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Syndication_Nextag_Categories");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationNextagProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_Nextag_Prods");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Availability)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.NextagCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ProductURL");

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<SyndicationNextagSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_Nextag_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationPriceGrabberCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Syndication_PriceGrabber_Categories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationPriceGrabberProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_PriceGrabber_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_PriceGrabber_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_PriceGrabber_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PriceGrabberCategory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<SyndicationPriceGrabberSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_PriceGrabber_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationShopComAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.ToTable("Syndication_ShopCom_Attributes");

                entity.Property(e => e.AttributeId)
                    .ValueGeneratedNever()
                    .HasColumnName("AttributeID");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationShopComProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_ShopCom_Prods");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.ADept1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A_Dept_1");

                entity.Property(e => e.ADept2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A_Dept_2");

                entity.Property(e => e.ADept3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A_Dept_3");

                entity.Property(e => e.ADept4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A_Dept_4");

                entity.Property(e => e.ADept5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("A_Dept_5");

                entity.Property(e => e.Attribute)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BDept1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B_Dept_1");

                entity.Property(e => e.BDept2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B_Dept_2");

                entity.Property(e => e.BDept3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B_Dept_3");

                entity.Property(e => e.BDept4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B_Dept_4");

                entity.Property(e => e.BDept5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("B_Dept_5");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CDept1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_Dept_1");

                entity.Property(e => e.CDept2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_Dept_2");

                entity.Property(e => e.CDept3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_Dept_3");

                entity.Property(e => e.CDept4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_Dept_4");

                entity.Property(e => e.CDept5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("C_Dept_5");

                entity.Property(e => e.DDept1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("D_Dept_1");

                entity.Property(e => e.DDept2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("D_Dept_2");

                entity.Property(e => e.DDept3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("D_Dept_3");

                entity.Property(e => e.DDept4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("D_Dept_4");

                entity.Property(e => e.DDept5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("D_Dept_5");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.EDept1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_Dept_1");

                entity.Property(e => e.EDept2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_Dept_2");

                entity.Property(e => e.EDept3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_Dept_3");

                entity.Property(e => e.EDept4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_Dept_4");

                entity.Property(e => e.EDept5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("E_Dept_5");

                entity.Property(e => e.GroupDescription)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImageReference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Keywords)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemInventoryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemSalePrice).HasColumnType("smallmoney");

                entity.Property(e => e.LineItemTaxable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineItemWeight)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<SyndicationShopComSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_ShopCom_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.FtphostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPHostName");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.FtpuserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPUserName");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationShoppingCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Syndication_Shopping_Categories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationShoppingProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_Shopping_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_Shopping_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_Shopping_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mpn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MPN");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUrl)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("ProductURL");

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingRate).HasColumnType("smallmoney");

                entity.Property(e => e.ShoppingCategory)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Stock)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<SyndicationShoppingSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_Shopping_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationTheFindProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_TheFind_Prods");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Brand)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Condition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(6000)
                    .IsUnicode(false);

                entity.Property(e => e.ExpirationDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GoogleProductType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.ImageLink)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModelNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mpn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MPN");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentAccepted)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentNotes)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pickup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.PriceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.Quantity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Shipping)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Size)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxPercent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<SyndicationTheFindProductType>(entity =>
            {
                entity.HasKey(e => e.ProductTypeId);

                entity.ToTable("Syndication_TheFind_ProductTypes");

                entity.Property(e => e.ProductTypeId).HasColumnName("ProductTypeID");

                entity.Property(e => e.ProductType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationTheFindSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_TheFind_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationWalmartProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_Walmart_Prods");

                entity.HasIndex(e => e.ProdId, "IX_Syndication_Walmart_Prods_ProdID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.StorefrontId, "IX_Syndication_Walmart_Prods_StorefrontID")
                    .HasFillFactor(90);

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<SyndicationYahooShoppingCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Syndication_YahooShopping_Categories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationYahooShoppingMerchantCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("Syndication_YahooShopping_MerchantCategories");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationYahooShoppingProd>(entity =>
            {
                entity.HasKey(e => e.DetailId);

                entity.ToTable("Syndication_YahooShopping_Prods");

                entity.Property(e => e.DetailId).HasColumnName("DetailID");

                entity.Property(e => e.Availability)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DateAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.MerchantCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ProductURL");

                entity.Property(e => e.RefTrack)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingPrice).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.YahooShoppingCategory)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SyndicationYahooShoppingSetting>(entity =>
            {
                entity.HasKey(e => e.StorefrontId);

                entity.ToTable("Syndication_YahooShopping_Settings");

                entity.Property(e => e.StorefrontId)
                    .ValueGeneratedNever()
                    .HasColumnName("StorefrontID");

                entity.Property(e => e.FtphostName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPHostName");

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.FtpuserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("FTPUserName");

                entity.Property(e => e.LocalDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocalZipFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RemoteDir)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SalesTaxPercentWholesale)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SalesTaxPercent_Wholesale");
            });

            modelBuilder.Entity<TaxLookup>(entity =>
            {
                entity.ToTable("TaxLookup");

                entity.HasIndex(e => e.JurisdictionCity, "IX_TaxLookup_JurisdictionCity")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.JurisdictionState, "IX_TaxLookup_JurisdictionState")
                    .HasFillFactor(90);

                entity.Property(e => e.AmountTaxable).HasColumnType("money");

                entity.Property(e => e.AmountToCollect).HasColumnType("money");

                entity.Property(e => e.CityTaxCollectable).HasColumnType("money");

                entity.Property(e => e.CityTaxRate).HasColumnType("money");

                entity.Property(e => e.CityTaxableAmount).HasColumnType("money");

                entity.Property(e => e.CombinedTaxRate).HasColumnType("money");

                entity.Property(e => e.CountyTaxCollectable).HasColumnType("money");

                entity.Property(e => e.CountyTaxRate).HasColumnType("money");

                entity.Property(e => e.CountyTaxableAmount).HasColumnType("money");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExemptionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCountry)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionCounty)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JurisdictionState)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderTotalAmount).HasColumnType("money");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Shipping).HasColumnType("money");

                entity.Property(e => e.SpecialDistrictTaxCollectable).HasColumnType("money");

                entity.Property(e => e.SpecialDistrictTaxRate).HasColumnType("money");

                entity.Property(e => e.SpecialDistrictTaxableAmount).HasColumnType("money");

                entity.Property(e => e.StateTaxCollectable).HasColumnType("money");

                entity.Property(e => e.StateTaxRate).HasColumnType("money");

                entity.Property(e => e.StateTaxableAmount).HasColumnType("money");

                entity.Property(e => e.TaxCollectable).HasColumnType("money");

                entity.Property(e => e.TaxSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxableAmount).HasColumnType("money");
            });

            modelBuilder.Entity<TaxLookupLine>(entity =>
            {
                entity.ToTable("TaxLookupLine");

                entity.Property(e => e.CityAmount).HasColumnType("money");

                entity.Property(e => e.CityTaxRate).HasColumnType("money");

                entity.Property(e => e.CityTaxableAmount).HasColumnType("money");

                entity.Property(e => e.CombinedTaxRate).HasColumnType("money");

                entity.Property(e => e.CountyAmount).HasColumnType("money");

                entity.Property(e => e.CountyTaxRate).HasColumnType("money");

                entity.Property(e => e.CountyTaxableAmount).HasColumnType("money");

                entity.Property(e => e.SpecialDistrictAmount).HasColumnType("money");

                entity.Property(e => e.SpecialDistrictTaxRate).HasColumnType("money");

                entity.Property(e => e.SpecialDistrictTaxableAmount).HasColumnType("money");

                entity.Property(e => e.StateAmount).HasColumnType("money");

                entity.Property(e => e.StateTaxRate).HasColumnType("money");

                entity.Property(e => e.StateTaxableAmount).HasColumnType("money");

                entity.Property(e => e.TaxCollectable).HasColumnType("money");

                entity.Property(e => e.TaxableAmount).HasColumnType("money");

                entity.HasOne(d => d.TaxLookup)
                    .WithMany(p => p.TaxLookupLines)
                    .HasForeignKey(d => d.TaxLookupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxLookupLine_TaxLookup");
            });

            modelBuilder.Entity<TempAccountingSalesFix20200110>(entity =>
            {
                entity.HasKey(e => e.ProviderOrderId);

                entity.ToTable("Temp_AccountingSales_Fix_20200110");

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.ShipAmountTaxable).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<TempAddressApiLog>(entity =>
            {
                entity.HasKey(e => e.RowId);

                entity.ToTable("Temp_AddressAPI_Log");

                entity.HasIndex(e => e.DateAndTime, "IX_Temp_AddressAPI_Log_DateAndTime")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipMethodId, "IX_Temp_AddressAPI_Log_ShipMethodID")
                    .HasFillFactor(90);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.ResponseText)
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodId).HasColumnName("ShipMethodID");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempCaseQtyEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("tempCaseQtyEntry");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdName).HasMaxLength(177);

                entity.Property(e => e.UnitNumber).HasColumnType("smallmoney");

                entity.Property(e => e.UnitTypeName).HasMaxLength(5);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<TempGoogleAnalyticsConversion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_GoogleAnalyticsConversions");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");
            });

            modelBuilder.Entity<TempGoogleBannedKeyword>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_Google_Banned_Keywords");

                entity.Property(e => e.BannedKeywords)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempHealthZoneUkMatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_HealthZone_UK_Matches");

                entity.Property(e => e.Asin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASIN");

                entity.Property(e => e.Column4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Column 4");

                entity.Property(e => e.Price)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName(" Price ");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.UkTitle)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("UK Title");
            });

            modelBuilder.Entity<TempHealthZoneUkMatchesPart2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_HealthZone_UK_Matches_Part_2");

                entity.Property(e => e.Asin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASIN");

                entity.Property(e => e.Title)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Upc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<TempJetSkusAvailable20160920>(entity =>
            {
                entity.HasKey(e => e.ProdId);

                entity.ToTable("Temp_Jet_SKUs_Available_20160920");

                entity.Property(e => e.ProdId)
                    .ValueGeneratedNever()
                    .HasColumnName("ProdID");

                entity.Property(e => e.Ashprice)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ASHPrice");

                entity.Property(e => e.Ashshipping)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ASHShipping");

                entity.Property(e => e.DiscountPercent).HasColumnType("smallmoney");

                entity.Property(e => e.EffectivePrice).HasColumnType("smallmoney");

                entity.Property(e => e.EffectiveShipping).HasColumnType("smallmoney");

                entity.Property(e => e.Inventory)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarkupPercent).HasColumnType("smallmoney");

                entity.Property(e => e.MaxPrice).HasColumnType("smallmoney");

                entity.Property(e => e.MinPrice).HasColumnType("smallmoney");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Substatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempJetTax>(entity =>
            {
                entity.ToTable("Temp_Jet_Tax");

                entity.Property(e => e.ReferenceOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ReferenceOrderID");

                entity.Property(e => e.TaxAmount).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<TempProjectWiltCategory>(entity =>
            {
                entity.HasKey(e => new { e.FamId, e.DeptId });

                entity.ToTable("Temp_ProjectWilt_Categories");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");
            });

            modelBuilder.Entity<TempRefTrackPerformanceResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_RefTrack_Performance_Results");

                entity.Property(e => e.Conversionrate).HasColumnName("conversionrate");

                entity.Property(e => e.Fromdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("fromdate");

                entity.Property(e => e.Grossprofit)
                    .HasColumnType("money")
                    .HasColumnName("grossprofit");

                entity.Property(e => e.Numofclicks).HasColumnName("numofclicks");

                entity.Property(e => e.Numoforders).HasColumnName("numoforders");

                entity.Property(e => e.Numofsessions).HasColumnName("numofsessions");

                entity.Property(e => e.Numofuniquevis).HasColumnName("numofuniquevis");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Reftrackcode)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("reftrackcode");

                entity.Property(e => e.Todate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("todate");
            });

            modelBuilder.Entity<TempTopSellersOct2015>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Temp_TopSellers_Oct2015");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");
            });

            modelBuilder.Entity<TempTrung>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempTrung");

                entity.Property(e => e.Sm)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SM");

                entity.Property(e => e.Text)
                    .HasMaxLength(4000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempWorkingAverageShippingCost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("temp_Working_Average_ShippingCost");

                entity.Property(e => e.AvgEconomyShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.AvgStandardShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.FromOunces).HasColumnType("smallmoney");

                entity.Property(e => e.ToOunces).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<TempWorkingProdsShippingCost>(entity =>
            {
                entity.HasKey(e => e.Asin);

                entity.ToTable("temp_Working_Prods_ShippingCost");

                entity.Property(e => e.Asin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ASIN");

                entity.Property(e => e.ActualShippingWeightOz).HasColumnType("smallmoney");

                entity.Property(e => e.ActualShippingWeightOzRounded).HasColumnType("smallmoney");

                entity.Property(e => e.EconomyShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.EstimatedShippingWeightOz).HasColumnType("smallmoney");

                entity.Property(e => e.EstimatedShippingWeightOzRounded).HasColumnType("smallmoney");

                entity.Property(e => e.GrossWeight).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.StandardShippingCost).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("test");

                entity.Property(e => e.Codamount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODAmount");

                entity.Property(e => e.CodcurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODCurrencyCode");

                entity.Property(e => e.Codoption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODOption");

                entity.Property(e => e.DeclaredValueAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeclaredValueOption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfGoods)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructionsForShipment)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress).HasMaxLength(50);

                entity.Property(e => e.StoreCity).HasMaxLength(25);

                entity.Property(e => e.StoreCountry).HasMaxLength(30);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState).HasMaxLength(25);

                entity.Property(e => e.StoreZip).HasMaxLength(25);

                entity.Property(e => e.StorefrontIdforRef2).HasColumnName("StorefrontIDForRef2");

                entity.Property(e => e.StorefrontName).HasMaxLength(50);
            });

            modelBuilder.Entity<TransferOrder>(entity =>
            {
                entity.HasKey(e => e.Tonum);

                entity.Property(e => e.Tonum).HasColumnName("TONum");

                entity.Property(e => e.DatePlaced).HasColumnType("smalldatetime");

                entity.Property(e => e.DateShipped).HasColumnType("smalldatetime");

                entity.Property(e => e.EstimatedReceiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FromWrhsId).HasColumnName("FromWrhsID");

                entity.Property(e => e.Notes)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveSignOffByAdminId).HasColumnName("ReceiveSignOffByAdminID");

                entity.Property(e => e.ReceiveSignOffDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ShippedByAdminId).HasColumnName("ShippedByAdminID");

                entity.Property(e => e.ToWrhsId).HasColumnName("ToWrhsID");

                entity.HasOne(d => d.ReceiveSignOffByAdmin)
                    .WithMany(p => p.TransferOrderReceiveSignOffByAdmins)
                    .HasForeignKey(d => d.ReceiveSignOffByAdminId)
                    .HasConstraintName("FK_TransferOrders_Admins_Provider1");

                entity.HasOne(d => d.ShippedByAdmin)
                    .WithMany(p => p.TransferOrderShippedByAdmins)
                    .HasForeignKey(d => d.ShippedByAdminId)
                    .HasConstraintName("FK_TransferOrders_Admins_Provider");
            });

            modelBuilder.Entity<TransferOrdersLineItem>(entity =>
            {
                entity.HasKey(e => e.Uniquefier);

                entity.ToTable("TransferOrders_LineItems");

                entity.Property(e => e.AddedToPoLiUniquefier).HasColumnName("AddedToPO_LI_Uniquefier");

                entity.Property(e => e.CheckedInByAdminId).HasColumnName("CheckedInByAdminID");

                entity.Property(e => e.CheckedOutByAdminId).HasColumnName("CheckedOutByAdminID");

                entity.Property(e => e.DateCheckedIn).HasColumnType("smalldatetime");

                entity.Property(e => e.DateCheckedOut).HasColumnType("smalldatetime");

                entity.Property(e => e.TakenFromPoLiUniquefier).HasColumnName("TakenFromPO_LI_Uniquefier");

                entity.Property(e => e.Tonum).HasColumnName("TONum");

                entity.HasOne(d => d.TonumNavigation)
                    .WithMany(p => p.TransferOrdersLineItems)
                    .HasForeignKey(d => d.Tonum)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransferOrders_LineItems_TransferOrders");
            });

            modelBuilder.Entity<Translation>(entity =>
            {
                entity.HasIndex(e => new { e.LangId, e.Token }, "IX_Translations_LangID_Token")
                    .HasFillFactor(90);

                entity.Property(e => e.LangId).HasColumnName("LangID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpsBasicRate>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone })
                    .HasName("PK_UPSBasic_Rates");

                entity.ToTable("UPS_Basic_Rates");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<UpsBasicRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId)
                    .HasName("PK_UPSBasic_Rates_Period");

                entity.ToTable("UPS_Basic_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<UpsGroundRate>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("UPS_Ground_Rates");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.UpsGroundRates)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UPS_Ground_Rates_UPS_Ground_Rates_Period");
            });

            modelBuilder.Entity<UpsGroundRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("UPS_Ground_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<UpsMiIpaFuelSurcharge>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("UPS_MI_IPA_FuelSurcharge");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UpsMiIsalFuelSurcharge>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("UPS_MI_ISAL_FuelSurcharge");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UpsQuantumView>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("UPS_QuantumView");

                entity.HasIndex(e => e.DateImported, "IX_UPS_QuantumView_DateImported")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.FileId, "IX_UPS_QuantumView_FileID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.RecordTypeId, "IX_UPS_QuantumView_RecordTypeID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ShipmentNum, "IX_UPS_QuantumView_ShipmentNum")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.TrackingNumber, "IX_UPS_QuantumView_TrackingNumber")
                    .HasFillFactor(90);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ActLocCountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ActLocPoliticalDiv1)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ActLocPoliticalDiv2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAccountNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAccountOption)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DateImported).HasColumnType("smalldatetime");

                entity.Property(e => e.DelLocCode)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocConsigneeName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocCountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocPoliticalDiv1)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocPoliticalDiv2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocPostcodePrimaryLow)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocResAddressIndicator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocStreetName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocStreetNumberLow)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocStreetPrefix)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocStreetSuffix)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DelLocStreetType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentsOnly)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.PackageDimHeight)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PackageDimLength)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PackageDimUnitCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PackageDimWeight)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PackageDimWeightUnitCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PackageDimWidth)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.PackageReferences)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PackageWeight)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PickupDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RecordTypeId).HasColumnName("RecordTypeID");

                entity.Property(e => e.RescheduledDeliveryDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.RescheduledDeliveryTime)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ResolutionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ResolutionDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledDeliveryDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddressLine1)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToConsigneeName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPostalCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToStateProvinceCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentChargeType)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ShipmentReferences)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine1)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCity)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperNumber)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPostalCode)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperStateProvinceCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SignedForByName)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatusDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.HasOne(d => d.File)
                    .WithMany(p => p.UpsQuantumViews)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UPS_QuantumView_UPS_QuantumView_Files");
            });

            modelBuilder.Entity<UpsQuantumViewFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("UPS_QuantumView_Files");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.LocalFileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpsfileName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPSFileName");
            });

            modelBuilder.Entity<UpsQuantumViewReference>(entity =>
            {
                entity.HasKey(e => e.ReferenceId);

                entity.ToTable("UPS_QuantumView_References");

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.Code)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ReferenceTypeId).HasColumnName("ReferenceTypeID");

                entity.Property(e => e.Value)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.HasOne(d => d.Record)
                    .WithMany(p => p.UpsQuantumViewReferences)
                    .HasForeignKey(d => d.RecordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UPS_QuantumView_References_UPS_QuantumView");
            });

            modelBuilder.Entity<UpsShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("UPS_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.AccessLicenseNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BasicAccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BasicPoaccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BasicPOAccountNumber");

                entity.Property(e => e.FuelSurchargeExpeditedPercent).HasColumnType("smallmoney");

                entity.Property(e => e.FuelSurchargeGroundPercent).HasColumnType("smallmoney");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAddressLine3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperAttentionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperCountryCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperPostalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperStateProvinceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<UpsShippingStatus>(entity =>
            {
                entity.HasKey(e => new { e.ProviderOrderId, e.StepId });

                entity.ToTable("UPS_Shipping_Status");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.StepDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .HasColumnType("text")
                    .HasColumnName("XML");
            });

            modelBuilder.Entity<UpsStatusCode>(entity =>
            {
                entity.HasKey(e => e.StatusCodeId);

                entity.ToTable("UPS_Status_Codes");

                entity.HasIndex(e => e.StatusCode, "IX_UPS_Status_Codes_StatusCode")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.StatusCodeId).HasColumnName("StatusCodeID");

                entity.Property(e => e.InternalDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsNotUpsErrorObsolete).HasColumnName("IsNotUpsError_OBSOLETE");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpsSurePostRate>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("UPS_SurePost_Rates");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.UpsSurePostRates)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UPS_SurePost_Rates_UPS_SurePost_Rates_Period");
            });

            modelBuilder.Entity<UpsSurePostRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("UPS_SurePost_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<UpsSurepostZipCodeSurcharge>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("PK_UPS_Surepost_ZipCode_Extended");

                entity.ToTable("UPS_Surepost_ZipCode_Surcharge");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(12)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpsworldshipLookuptable>(entity =>
            {
                entity.HasKey(e => e.UniqueId);

                entity.ToTable("UPSworldship_lookuptable");

                entity.Property(e => e.UniqueId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("UniqueID");

                entity.Property(e => e.ServiceTypeDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTypeId).HasColumnName("ServiceTypeID");
            });

            modelBuilder.Entity<UrlMapping>(entity =>
            {
                entity.HasKey(e => e.MapId);

                entity.ToTable("Url_Mapping");

                entity.Property(e => e.MapId).HasColumnName("MapID");

                entity.Property(e => e.InternalNotes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MapFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MapTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.UserName, e.StorefrontId }, "IX_UserAccounts_Name_Unique_Constraint")
                    .IsUnique();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Baddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAddress");

                entity.Property(e => e.Baddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BAddress2");

                entity.Property(e => e.Bcity)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BCity");

                entity.Property(e => e.Bcountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BCountry");

                entity.Property(e => e.Bemail)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("BEmail");

                entity.Property(e => e.Bfname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BFName");

                entity.Property(e => e.Blname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BLName");

                entity.Property(e => e.Bmname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BMName");

                entity.Property(e => e.Bphone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BPhone");

                entity.Property(e => e.BphoneFiltered)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BPhoneFiltered");

                entity.Property(e => e.Bstate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("BState");

                entity.Property(e => e.Btitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BTitle");

                entity.Property(e => e.Bzip)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BZip");

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.CcinfoFaxOnFile).HasColumnName("CCInfoFaxOnFile");

                entity.Property(e => e.CcnumberEnc)
                    .HasMaxLength(256)
                    .HasColumnName("CCNumberEnc");

                entity.Property(e => e.CcnumberObsolete)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CCNumber_OBSOLETE");

                entity.Property(e => e.CctypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CCTypeCode")
                    .IsFixedLength();

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.LastTaxLookupOn).HasColumnType("datetime");

                entity.Property(e => e.NameAsOnCc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NameAsOnCC");

                entity.Property(e => e.PayTechCustRefNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Saddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAddress");

                entity.Property(e => e.Saddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SAddress2");

                entity.Property(e => e.SavedCartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("SavedCartID");

                entity.Property(e => e.Scity)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SCity");

                entity.Property(e => e.ScountryId).HasColumnName("SCountryID");

                entity.Property(e => e.ScreenName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Semail)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("SEmail");

                entity.Property(e => e.Sfname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SFName");

                entity.Property(e => e.Slname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLName");

                entity.Property(e => e.Smname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SMName");

                entity.Property(e => e.Sphone)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SPhone");

                entity.Property(e => e.SphoneFiltered)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SPhoneFiltered");

                entity.Property(e => e.Sstate)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SState");

                entity.Property(e => e.Stitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STitle");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.Szip)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SZip");

                entity.Property(e => e.TaxCityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCityRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCityRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCityRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCityRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCountryRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountryRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCountyRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxCountyRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxDistrictRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxDistrictRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaxStateRateFood).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateRateGeneral).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateRateShipping).HasColumnType("smallmoney");

                entity.Property(e => e.TaxStateRateSupplement).HasColumnType("smallmoney");

                entity.Property(e => e.UserName)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAccountsNote>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.NoteTypeId });

                entity.ToTable("UserAccounts_Notes");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.NoteTypeId).HasColumnName("NoteTypeID");

                entity.Property(e => e.LastModified).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.UserAccountsNotes)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAccounts_Notes_UserAccounts");
            });

            modelBuilder.Entity<UserAccountsPwreset>(entity =>
            {
                entity.ToTable("UserAccounts_PWReset");

                entity.HasIndex(e => e.AccountId, "IX_UserAccounts_PWReset_AccountID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Token, "IX_UserAccounts_PWReset_Token")
                    .HasFillFactor(90);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpiresOn).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAgent)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAgent>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UspsFee>(entity =>
            {
                entity.HasKey(e => e.FeeId);

                entity.ToTable("USPS_Fees");

                entity.Property(e => e.FeeId)
                    .ValueGeneratedNever()
                    .HasColumnName("FeeID");

                entity.Property(e => e.CarrierId).HasColumnName("CarrierID");

                entity.Property(e => e.FeeAmount).HasColumnType("smallmoney");

                entity.Property(e => e.FeeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FeeStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ServiceTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.UspsFees)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USPS_Fees_CarriersAndClasses");
            });

            modelBuilder.Entity<UspsMailXmlAction>(entity =>
            {
                entity.ToTable("USPS_Mail_XML_Action");

                entity.Property(e => e.ActionGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ErredOn).HasColumnType("datetime");

                entity.Property(e => e.ErrorMsg).IsUnicode(false);

                entity.Property(e => e.MessageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageParameters)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTrackingId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MessageTrackingID");

                entity.Property(e => e.OnCompletedTriggerMessage)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingOn).HasColumnType("datetime");

                entity.Property(e => e.RequestXml)
                    .IsUnicode(false)
                    .HasColumnName("RequestXML");

                entity.Property(e => e.Response).IsUnicode(false);
            });

            modelBuilder.Entity<UspsManifest>(entity =>
            {
                entity.HasKey(e => e.ManifestId);

                entity.ToTable("USPS_Manifests");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.DelivConfFeeFc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("DelivConfFeeFC");

                entity.Property(e => e.DelivConfFeePm)
                    .HasColumnType("smallmoney")
                    .HasColumnName("DelivConfFeePM");

                entity.Property(e => e.FileUploadDate).HasColumnType("datetime");

                entity.Property(e => e.Ssfid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SSFID");

                entity.Property(e => e.TotalDelivConfPostageFc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalDelivConfPostageFC");

                entity.Property(e => e.TotalDelivConfPostagePm)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalDelivConfPostagePM");

                entity.Property(e => e.TotalInsuranceFc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalInsuranceFC");

                entity.Property(e => e.TotalInsurancePm)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalInsurancePM");

                entity.Property(e => e.TotalInsuredPiecesFc).HasColumnName("TotalInsuredPiecesFC");

                entity.Property(e => e.TotalInsuredPiecesPm).HasColumnName("TotalInsuredPiecesPM");

                entity.Property(e => e.TotalPiecesFc).HasColumnName("TotalPiecesFC");

                entity.Property(e => e.TotalPiecesPm).HasColumnName("TotalPiecesPM");

                entity.Property(e => e.TotalPiecesPostageFc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalPiecesPostageFC");

                entity.Property(e => e.TotalPiecesPostagePm)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalPiecesPostagePM");

                entity.Property(e => e.TotalPostageFc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalPostageFC");

                entity.Property(e => e.TotalPostagePm)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalPostagePM");

                entity.Property(e => e.TotalWeightFc)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalWeightFC");

                entity.Property(e => e.TotalWeightPm)
                    .HasColumnType("smallmoney")
                    .HasColumnName("TotalWeightPM");

                entity.Property(e => e.UspsAccountSettingId).HasColumnName("USPS_Account_SettingID");
            });

            modelBuilder.Entity<UspsRatesFirstClass>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.WeightInOunces, e.Rate });

                entity.ToTable("USPS_Rates_FirstClass");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.WeightInOunces).HasColumnType("smallmoney");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<UspsRatesPeriod>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("USPS_Rates_Period");

                entity.Property(e => e.PeriodId)
                    .ValueGeneratedNever()
                    .HasColumnName("PeriodID");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<UspsRatesPriorityMail>(entity =>
            {
                entity.HasKey(e => new { e.PeriodId, e.Weight, e.Zone });

                entity.ToTable("USPS_Rates_PriorityMail");

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Rate).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<UspsScanFile>(entity =>
            {
                entity.ToTable("USPS_Scan_File");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");
            });

            modelBuilder.Entity<UspsScanFileEvent>(entity =>
            {
                entity.ToTable("USPS_Scan_File_Event");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.CustomerReferenceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationCountryCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationZip4)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ElectronicFileNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EventName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GuaranteedDeliveryDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GuaranteedDeliveryTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticsManagerMailerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LogisticsManagerMailerID");

                entity.Property(e => e.MailOwnerMailerId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MailOwnerMailerID");

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalLabel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanningFacilityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScanningFacilityZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitOfMeasureCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ScanFile)
                    .WithMany(p => p.UspsScanFileEvents)
                    .HasForeignKey(d => d.ScanFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USPS_Scan_File_Event_USPS_Scan_File");
            });

            modelBuilder.Entity<UspsShippingSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId);

                entity.ToTable("USPS_Shipping_Settings");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Bcgpassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BCGPassword");

                entity.Property(e => e.Bcgusername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BCGUsername");

                entity.Property(e => e.ConfServFtp)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ConfServFTP");

                entity.Property(e => e.ConfServPassword)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ConfServUserId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ConfServUserID");

                entity.Property(e => e.Crid)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("CRID");

                entity.Property(e => e.Duns)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("DUNS");

                entity.Property(e => e.MailerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailerId)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("MailerID");

                entity.Property(e => e.MailerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MailerState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailerZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PermitNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Pocity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POCity");

                entity.Property(e => e.Postate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("POState");

                entity.Property(e => e.Pozip)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POZip");

                entity.Property(e => e.Pozip9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("POZip9");

                entity.Property(e => e.SettingDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UspsTransitTime>(entity =>
            {
                entity.HasKey(e => new { e.FromWrhsId, e.CarrierAndClassId, e.ToZip });

                entity.ToTable("USPS_Transit_Time");

                entity.Property(e => e.FromWrhsId).HasColumnName("FromWrhsID");

                entity.Property(e => e.CarrierAndClassId).HasColumnName("CarrierAndClassID");

                entity.Property(e => e.ToZip)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VelocityBoostRange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VelocityBoostRange");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasIndex(e => new { e.ProviderId, e.Abbrev }, "IX_Vendors_Abbrev")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.ProviderId, e.Name }, "IX_Vendors_Name")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.VendorId).HasColumnName("VendorID");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IsSpecialCasePo).HasColumnName("IsSpecialCasePO");

                entity.Property(e => e.MinimumTypeId).HasColumnName("MinimumTypeID");

                entity.Property(e => e.MinimumValue).HasColumnType("smallmoney");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.SendPofri).HasColumnName("SendPOFri");

                entity.Property(e => e.SendPomon).HasColumnName("SendPOMon");

                entity.Property(e => e.SendPosat).HasColumnName("SendPOSat");

                entity.Property(e => e.SendPosun).HasColumnName("SendPOSun");

                entity.Property(e => e.SendPothu).HasColumnName("SendPOThu");

                entity.Property(e => e.SendPotue).HasColumnName("SendPOTue");

                entity.Property(e => e.SendPowed).HasColumnName("SendPOWed");

                entity.Property(e => e.ShowPriceOnPo).HasColumnName("ShowPriceOnPO");

                entity.Property(e => e.ShowVendorCodeOnPo).HasColumnName("ShowVendorCodeOnPO");

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Terms)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewDhleasyShipOrders2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_DHLEasyShip_Orders2");

                entity.Property(e => e.BillToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.BillToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToFName");

                entity.Property(e => e.BillToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToLName");

                entity.Property(e => e.BillToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BillToMName");

                entity.Property(e => e.BillToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BillToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CcexpMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpMonth")
                    .IsFixedLength();

                entity.Property(e => e.CcexpYear)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CCExpYear")
                    .IsFixedLength();

                entity.Property(e => e.Ccnumber)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("CCNumber");

                entity.Property(e => e.CctypeCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CCTypeCode")
                    .IsFixedLength();

                entity.Property(e => e.CcverificationNum)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("CCVerificationNum");

                entity.Property(e => e.CheckAccountNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CheckRoutingNum)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientIpaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ClientIPAddress");

                entity.Property(e => e.CommentsFromConsumer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConsumerAccountId).HasColumnName("ConsumerAccountID");

                entity.Property(e => e.CouponAppliedAmount).HasColumnType("smallmoney");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CouponDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateFollowUp).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeImported).HasColumnType("smalldatetime");

                entity.Property(e => e.DateTimeOrderPlaced).HasColumnType("smalldatetime");

                entity.Property(e => e.ExtAreaSurcharge).HasColumnType("smallmoney");

                entity.Property(e => e.InProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.InProcessInvalidShipAddress)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_InvalidShipAddress");

                entity.Property(e => e.InProcessProdNotAvail)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_ProdNotAvail");

                entity.Property(e => e.InProcessProdRemovalRequired)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("InProcess_ProdRemovalRequired");

                entity.Property(e => e.InsAmount).HasColumnType("smallmoney");

                entity.Property(e => e.InsDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsTypeIddesired).HasColumnName("InsTypeIDDesired");

                entity.Property(e => e.NameAsOnCc)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NameAsOnCC");

                entity.Property(e => e.OrderGrandTotal).HasColumnType("smallmoney");

                entity.Property(e => e.PaymentMethod)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProviderOrderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProviderOrderID");

                entity.Property(e => e.PubPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.ReadyForPickup).HasColumnType("smalldatetime");

                entity.Property(e => e.ReadyForReview).HasColumnType("smalldatetime");

                entity.Property(e => e.ReadyToProcess).HasColumnType("smalldatetime");

                entity.Property(e => e.RetailPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.SalesTaxAmount).HasColumnType("smallmoney");

                entity.Property(e => e.SalesTaxDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesTaxPercent).HasColumnType("smallmoney");

                entity.Property(e => e.ShipAmount).HasColumnType("smallmoney");

                entity.Property(e => e.ShipMethodDescDesired)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodIddesired).HasColumnName("ShipMethodIDDesired");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountryId).HasColumnName("ShipToCountryID");

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToFname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToFName");

                entity.Property(e => e.ShipToLname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToLName");

                entity.Property(e => e.ShipToMname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ShipToMName");

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreFooter)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreMemo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreZip)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StorefrontAdminId).HasColumnName("StorefrontAdminID");

                entity.Property(e => e.StorefrontCartId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontCartID");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.StorefrontOrderId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontOrderID");

                entity.Property(e => e.StorefrontPriceTot).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontSessionId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("StorefrontSessionID");

                entity.Property(e => e.SuggestedCarrierId).HasColumnName("SuggestedCarrierID");

                entity.Property(e => e.Void).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ViewDhleasyShipOrdersLineItems2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_DHLEasyShip_Orders_LineItems2");

                entity.Property(e => e.CocountryOfOrigin)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COCountryOfOrigin");

                entity.Property(e => e.DescOfGoods).HasMaxLength(151);

                entity.Property(e => e.InvoiceUnitsOfMeasure)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SedunitPrice)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SEDUnitPrice");
            });

            modelBuilder.Entity<ViewDhlshipOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_DHLship_Orders");

                entity.Property(e => e.Codamount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODAmount");

                entity.Property(e => e.CodcurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODCurrencyCode");

                entity.Property(e => e.CodguaranteedFunds)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODGuaranteedFunds");

                entity.Property(e => e.Codoption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODOption");

                entity.Property(e => e.DeclaredValueAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeclaredValueOption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfGoods)
                    .HasMaxLength(23)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAmount).HasColumnType("smallmoney");

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ShipperContactName)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructionsForShipment)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress).HasMaxLength(50);

                entity.Property(e => e.StoreCity).HasMaxLength(25);

                entity.Property(e => e.StoreCountry).HasMaxLength(30);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState).HasMaxLength(25);

                entity.Property(e => e.StoreZip).HasMaxLength(25);

                entity.Property(e => e.StorefrontIdforRef2).HasColumnName("StorefrontIDForRef2");

                entity.Property(e => e.StorefrontName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewDhlshipOrdersLineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_DHLship_Orders_LineItems");

                entity.Property(e => e.CocountryOfOrigin)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("COCountryOfOrigin");

                entity.Property(e => e.DescOfGoods).HasMaxLength(151);

                entity.Property(e => e.InvoiceUnitsOfMeasure)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SedunitPrice)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SEDUnitPrice");
            });

            modelBuilder.Entity<ViewFedExCafeOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_FedExCafe_Orders");

                entity.Property(e => e.ProviderId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ProviderID");
            });

            modelBuilder.Entity<ViewFedExCafeOrdersLineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_FedExCafe_Orders_LineItems");

                entity.Property(e => e.CocountryOfOrigin)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("COCountryOfOrigin");

                entity.Property(e => e.DescOfGoods).HasMaxLength(151);

                entity.Property(e => e.InvoiceUnitsOfMeasure)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SedunitPrice)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SEDUnitPrice");
            });

            modelBuilder.Entity<ViewGsoshipOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_GSOship_Orders");

                entity.Property(e => e.Codamount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODAmount");

                entity.Property(e => e.CodcurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODCurrencyCode");

                entity.Property(e => e.CodguaranteedFunds)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODGuaranteedFunds");

                entity.Property(e => e.Codoption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODOption");

                entity.Property(e => e.DeclaredValueAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeclaredValueOption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfGoods)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SignatureRequired)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructionsForShipment)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress).HasMaxLength(50);

                entity.Property(e => e.StoreCity).HasMaxLength(25);

                entity.Property(e => e.StoreCountry).HasMaxLength(30);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState).HasMaxLength(25);

                entity.Property(e => e.StoreZip).HasMaxLength(25);

                entity.Property(e => e.StorefrontIdforRef2).HasColumnName("StorefrontIDForRef2");

                entity.Property(e => e.StorefrontName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewGsoshipOrdersLineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_GSOship_Orders_LineItems");

                entity.Property(e => e.CocountryOfOrigin)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("COCountryOfOrigin");

                entity.Property(e => e.DescOfGoods).HasMaxLength(151);

                entity.Property(e => e.InvoiceUnitsOfMeasure)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SedunitPrice)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SEDUnitPrice");
            });

            modelBuilder.Entity<ViewProductsEnglish>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_Products_English");

                entity.Property(e => e.BrandAbbrev)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandLogoUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BrandLogoURL");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateProdCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.DescLastUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.DescMarkerInfo).HasMaxLength(1000);

                entity.Property(e => e.DetailedFamDesc).HasMaxLength(2000);

                entity.Property(e => e.DetailedProdDesc).HasMaxLength(2000);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EconomyShippingCost).HasColumnType("smallmoney");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.FamName).HasMaxLength(100);

                entity.Property(e => e.FamName2).HasMaxLength(100);

                entity.Property(e => e.FamNameSuffix).HasMaxLength(200);

                entity.Property(e => e.FamNameSuffix2).HasMaxLength(200);

                entity.Property(e => e.FamPicFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullProdName).HasMaxLength(459);

                entity.Property(e => e.FullProdName2).HasMaxLength(464);

                entity.Property(e => e.GrossWeight).HasColumnType("smallmoney");

                entity.Property(e => e.Height).HasColumnType("smallmoney");

                entity.Property(e => e.Length).HasColumnType("smallmoney");

                entity.Property(e => e.ManagementNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MfgDesc).HasMaxLength(2000);

                entity.Property(e => e.MfgDirections).HasMaxLength(1250);

                entity.Property(e => e.MfgDisclaimer).HasMaxLength(1500);

                entity.Property(e => e.MfgFactNotes).HasMaxLength(1000);

                entity.Property(e => e.MfgIngredients).HasMaxLength(1450);

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.OwnedByStorefrontId).HasColumnName("OwnedByStorefrontID");

                entity.Property(e => e.PopupNoteToConsumer).HasMaxLength(400);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdId2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ProdID2");

                entity.Property(e => e.ProdPicFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Prop65).HasMaxLength(2000);

                entity.Property(e => e.RestockToDaysCa).HasColumnName("RestockToDaysCA");

                entity.Property(e => e.RestockToDaysNc).HasColumnName("RestockToDaysNC");

                entity.Property(e => e.ServingSize).HasColumnType("smallmoney");

                entity.Property(e => e.ServingUnit).HasMaxLength(20);

                entity.Property(e => e.ServingsPerContainer).HasColumnType("smallmoney");

                entity.Property(e => e.ShortFamDesc).HasMaxLength(250);

                entity.Property(e => e.ShortProdDesc).HasMaxLength(1000);

                entity.Property(e => e.StdCostToProvider).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxableCa).HasColumnName("taxable_CA");

                entity.Property(e => e.UnitNumber).HasColumnType("smallmoney");

                entity.Property(e => e.UnitNumber2).HasColumnType("smallmoney");

                entity.Property(e => e.UnitTypeName).HasMaxLength(5);

                entity.Property(e => e.UnitTypeName2).HasMaxLength(10);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.Width).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<ViewProductsEnglishAsh>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_Products_English_ASH");

                entity.Property(e => e.BrandAbbrev)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandLogoUrl)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("BrandLogoURL");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BrandName2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescLastUpdated).HasColumnType("smalldatetime");

                entity.Property(e => e.DescMarkerInfo).HasMaxLength(1000);

                entity.Property(e => e.DetailedFamDesc).HasMaxLength(2000);

                entity.Property(e => e.DetailedProdDesc).HasMaxLength(2000);

                entity.Property(e => e.DiscontinuedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.FamName).HasMaxLength(100);

                entity.Property(e => e.FamName2).HasMaxLength(100);

                entity.Property(e => e.FamNameSuffix).HasMaxLength(50);

                entity.Property(e => e.FamNameSuffix2).HasMaxLength(75);

                entity.Property(e => e.FamPicFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullProdName).HasMaxLength(309);

                entity.Property(e => e.FullProdName2).HasMaxLength(339);

                entity.Property(e => e.GrossWeight).HasColumnType("smallmoney");

                entity.Property(e => e.ManagementNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.MfgDesc).HasMaxLength(2000);

                entity.Property(e => e.MfgDirections).HasMaxLength(1250);

                entity.Property(e => e.MfgDisclaimer).HasMaxLength(1500);

                entity.Property(e => e.MfgFactNotes).HasMaxLength(1000);

                entity.Property(e => e.MfgIngredients).HasMaxLength(1450);

                entity.Property(e => e.Msrp)
                    .HasColumnType("smallmoney")
                    .HasColumnName("MSRP");

                entity.Property(e => e.PopupNoteToConsumer).HasMaxLength(400);

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProdId2)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("ProdID2");

                entity.Property(e => e.ProdPicFileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServingSize).HasColumnType("smallmoney");

                entity.Property(e => e.ServingUnit).HasMaxLength(20);

                entity.Property(e => e.ServingsPerContainer).HasColumnType("smallmoney");

                entity.Property(e => e.ShortFamDesc).HasMaxLength(250);

                entity.Property(e => e.ShortProdDesc).HasMaxLength(1000);

                entity.Property(e => e.StdCostToProvider).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.TaxableCa).HasColumnName("taxable_CA");

                entity.Property(e => e.UnitNumber).HasColumnType("smallmoney");

                entity.Property(e => e.UnitNumber2).HasColumnType("smallmoney");

                entity.Property(e => e.UnitTypeName).HasMaxLength(5);

                entity.Property(e => e.UnitTypeName2).HasMaxLength(10);

                entity.Property(e => e.Upc)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("UPC");
            });

            modelBuilder.Entity<ViewProductsInventoryAvailable>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_Products_Inventory_Available");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<ViewProductsInventoryInInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_Products_Inventory_InInv");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<ViewProductsInventoryOnShelf>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_Products_Inventory_OnShelf");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");
            });

            modelBuilder.Entity<ViewUpsShipmentCostsByWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_UPS_Shipment_Costs_By_Warehouse");

                entity.Property(e => e.Cacost)
                    .HasColumnType("smallmoney")
                    .HasColumnName("CACost");

                entity.Property(e => e.CatransitTime).HasColumnName("CATransitTime");

                entity.Property(e => e.Cazone).HasColumnName("CAZone");

                entity.Property(e => e.Nccost)
                    .HasColumnType("smallmoney")
                    .HasColumnName("NCCost");

                entity.Property(e => e.NctransitTime).HasColumnName("NCTransitTime");

                entity.Property(e => e.Nczone).HasColumnName("NCZone");

                entity.Property(e => e.ProviderOrderId).HasColumnName("ProviderOrderID");

                entity.Property(e => e.Weight).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<ViewUpsworldshipOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_UPSworldship_Orders");

                entity.Property(e => e.Codamount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODAmount");

                entity.Property(e => e.CodcurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODCurrencyCode");

                entity.Property(e => e.CodguaranteedFunds)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODGuaranteedFunds");

                entity.Property(e => e.Codoption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODOption");

                entity.Property(e => e.DeclaredValueAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeclaredValueOption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfGoods)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructionsForShipment)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress).HasMaxLength(50);

                entity.Property(e => e.StoreCity).HasMaxLength(25);

                entity.Property(e => e.StoreCountry).HasMaxLength(30);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState).HasMaxLength(25);

                entity.Property(e => e.StoreZip).HasMaxLength(25);

                entity.Property(e => e.StorefrontIdforRef2).HasColumnName("StorefrontIDForRef2");

                entity.Property(e => e.StorefrontName).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewUpsworldshipOrdersLineItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_UPSworldship_Orders_LineItems");

                entity.Property(e => e.CocountryOfOrigin)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasColumnName("COCountryOfOrigin");

                entity.Property(e => e.DescOfGoods).HasMaxLength(151);

                entity.Property(e => e.InvoiceUnitsOfMeasure)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.SedunitPrice)
                    .HasColumnType("smallmoney")
                    .HasColumnName("SEDUnitPrice");
            });

            modelBuilder.Entity<ViewUpsworldshipOrdersObsolete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("view_UPSworldship_Orders_obsolete");

                entity.Property(e => e.Codamount)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CODAmount");

                entity.Property(e => e.CodcurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CODCurrencyCode");

                entity.Property(e => e.CodguaranteedFunds)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODGuaranteedFunds");

                entity.Property(e => e.Codoption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("CODOption");

                entity.Property(e => e.DeclaredValueAmount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeclaredValueOption)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DescriptionOfGoods)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceCurrencyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.Ponumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PONumber");

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToAttention)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToEmail)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToName)
                    .HasMaxLength(152)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToZip)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialInstructionsForShipment)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.StoreAddress).HasMaxLength(50);

                entity.Property(e => e.StoreCity).HasMaxLength(25);

                entity.Property(e => e.StoreCountry).HasMaxLength(30);

                entity.Property(e => e.StorePhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StoreState).HasMaxLength(25);

                entity.Property(e => e.StoreZip).HasMaxLength(25);

                entity.Property(e => e.StorefrontIdforRef2).HasColumnName("StorefrontIDForRef2");

                entity.Property(e => e.StorefrontName).HasMaxLength(50);
            });

            modelBuilder.Entity<WalmartFeed>(entity =>
            {
                entity.ToTable("Walmart_Feed");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FeedId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WalmartOrder>(entity =>
            {
                entity.ToTable("Walmart_Order");

                entity.HasIndex(e => e.CustomerOrderId, "IX_Walmart_Order_CustomerOrderID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PurchaseOrderId, "IX_Walmart_Order_PurchaseOrderID")
                    .IsUnique();

                entity.Property(e => e.AcceptedOn).HasColumnType("datetime");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CustomerEmailId)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CustomerEmailID");

                entity.Property(e => e.CustomerOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CustomerOrderID");

                entity.Property(e => e.EstimatedDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedShipDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderTotal).HasColumnType("smallmoney");

                entity.Property(e => e.PurchaseOrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PurchaseOrderID");

                entity.Property(e => e.RejectedOn).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddressType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShipCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethodCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipPhone)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShipState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingTotal).HasColumnType("smallmoney");

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.SubTotal).HasColumnType("smallmoney");

                entity.Property(e => e.TaxTotal).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<WalmartOrderLine>(entity =>
            {
                entity.ToTable("Walmart_Order_Line");

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ShippedOn).HasColumnType("datetime");

                entity.Property(e => e.Shipping).HasColumnType("smallmoney");

                entity.Property(e => e.Sku)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SKU");

                entity.Property(e => e.Tax).HasColumnType("smallmoney");

                entity.HasOne(d => d.WalmartOrder)
                    .WithMany(p => p.WalmartOrderLines)
                    .HasForeignKey(d => d.WalmartOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Walmart_Order_Line_Walmart_Order");
            });

            modelBuilder.Entity<WalmartPayment>(entity =>
            {
                entity.ToTable("Walmart_Payment");

                entity.HasIndex(e => e.FileName, "IX_Walmart_Payment_FileName")
                    .IsUnique()
                    .HasFillFactor(90);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WalmartPaymentLine>(entity =>
            {
                entity.ToTable("Walmart_Payment_Line");

                entity.HasIndex(e => e.WalmartOrderNum, "IX_Walmart_Payment_Line_ClientOrderNumber")
                    .HasFillFactor(90);

                entity.Property(e => e.AdjustmentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustmentDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CommissionFromSale).HasColumnType("smallmoney");

                entity.Property(e => e.CommissionRate).HasColumnType("smallmoney");

                entity.Property(e => e.CountyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveTaxRate).HasColumnType("smallmoney");

                entity.Property(e => e.FeeRefundForEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.GiftWrapRefundForEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.GiftWrapTaxCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GrossFeeRefunded).HasColumnType("smallmoney");

                entity.Property(e => e.GrossFeeRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.GrossGiftWrapRefunded).HasColumnType("smallmoney");

                entity.Property(e => e.GrossGiftWrapRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.GrossSalesRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.GrossShippingRefunded).HasColumnType("smallmoney");

                entity.Property(e => e.GrossShippingRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.NetFeeRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.NetGiftWrapRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.NetShippingRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.PartnerGtin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PartnerGTIN");

                entity.Property(e => e.PartnerItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PartnerItemID");

                entity.Property(e => e.PartnerItemName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerOrderNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayableToPartnerFromSale).HasColumnType("smallmoney");

                entity.Property(e => e.ProductTaxCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RefundedRetailSales).HasColumnType("smallmoney");

                entity.Property(e => e.SalesRefundForEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.ShipToCity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToState)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingMethod)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingRefundForEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.ShippingTaxCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TaxOnFeeRefund).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnFeeRefundForEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnFeeRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnGiftWrapRefund).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnGiftWrapRefundForEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnGiftWrapRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnRefundedSales).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnSalesRefundForEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnSalesRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnShippingRefund).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnShippingRefundforEscalation).HasColumnType("smallmoney");

                entity.Property(e => e.TaxOnShippingRevenue).HasColumnType("smallmoney");

                entity.Property(e => e.TotalNetTaxCollected).HasColumnType("smallmoney");

                entity.Property(e => e.TotalToOrFromCustomer).HasColumnType("smallmoney");

                entity.Property(e => e.TransactionDateTime).HasColumnType("datetime");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WalmartOrderNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WalmartPolineNum).HasColumnName("WalmartPOLineNum");

                entity.Property(e => e.WalmartPonum)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WalmartPONum");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.WalmartPayment)
                    .WithMany(p => p.WalmartPaymentLines)
                    .HasForeignKey(d => d.WalmartPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Walmart_Payment_Line_Walmart_Payment");
            });

            modelBuilder.Entity<WalmartReportItem>(entity =>
            {
                entity.HasKey(e => new { e.StorefrontId, e.ProdId })
                    .HasName("PK_Walmart_Report_Item_1");

                entity.ToTable("Walmart_Report_Item");

                entity.HasIndex(e => e.PublishStatus, "IX_Walmart_Report_Item_PublishStatus")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.Upc, "IX_Walmart_Report_Item_UPC")
                    .HasFillFactor(90);

                entity.Property(e => e.StorefrontId).HasColumnName("StorefrontID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.AverageRating).HasColumnType("smallmoney");

                entity.Property(e => e.BuyBoxItemPrice).HasColumnType("smallmoney");

                entity.Property(e => e.BuyBoxShippingPrice).HasColumnType("smallmoney");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Gtin)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GTIN");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ItemID");

                entity.Property(e => e.LifecycleStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("smallmoney");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PublishStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipMethods)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusChangeReason)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UPC");

                entity.Property(e => e.Wpid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("WPID");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.HasKey(e => e.WrhsId);

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BufferPonumber).HasColumnName("BufferPONumber");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FedExDefaultSettingIdObsolete).HasColumnName("FedEx_DefaultSettingID_OBSOLETE");

                entity.Property(e => e.PostalCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpsDefaultSettingIdObsolete).HasColumnName("UPS_DefaultSettingID_OBSOLETE");

                entity.Property(e => e.UspsDefaultSettingIdObsolete).HasColumnName("USPS_DefaultSettingID_OBSOLETE");

                entity.Property(e => e.WrhsDescription)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WarehouseDhlShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_DHL_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseDhlShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_DHL_Shipping_Settings_DHL_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseFedexShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_Fedex_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseFedexShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_Fedex_Shipping_Settings_Fedex_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseGsoShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_GSO_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseGsoShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_GSO_Shipping_Settings_GSO_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseLaserShipShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_LaserShip_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseLaserShipShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_LaserShip_Shipping_Settings_LaserShip_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseMailExpressShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_MailExpress_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseMailExpressShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_MailExpress_Shipping_Settings_MailExpress_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseNgsShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_NGS_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseNgsShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_NGS_Shipping_Settings_NGS_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseOnTracShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_OnTrac_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseOnTracShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_OnTrac_Shipping_Settings_OnTrac_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseUpsShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_UPS_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseUpsShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_UPS_Shipping_Settings_UPS_Shipping_Settings");
            });

            modelBuilder.Entity<WarehouseUspsShippingSetting>(entity =>
            {
                entity.HasKey(e => new { e.WrhsId, e.SettingId });

                entity.ToTable("Warehouse_USPS_Shipping_Settings");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.WarehouseUspsShippingSettings)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Warehouse_USPS_Shipping_Settings_USPS_Shipping_Settings");
            });

            modelBuilder.Entity<WorkingTableProdsToPurchase>(entity =>
            {
                entity.HasKey(e => new { e.AdminId, e.ProdId, e.WrhsId });

                entity.ToTable("WorkingTable_ProdsToPurchase");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.WrhsId).HasColumnName("WrhsID");

                entity.Property(e => e.ConfidenceFactor4wk)
                    .HasColumnType("smallmoney")
                    .HasColumnName("ConfidenceFactor_4Wk");

                entity.Property(e => e.DateTimeInserted).HasColumnType("smalldatetime");

                entity.Property(e => e.EndOrderId).HasColumnName("EndOrderID");

                entity.Property(e => e.InPobutnotinInventory).HasColumnName("InPObutnotinInventory");

                entity.Property(e => e.SavedFormValuePonum)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("SavedFormValuePONum");

                entity.Property(e => e.SavedFormValueQty)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StartOrderId).HasColumnName("StartOrderID");

                entity.Property(e => e.Vel12wk).HasColumnName("Vel_12Wk");

                entity.Property(e => e.Vel4wk).HasColumnName("Vel_4Wk");
            });

            modelBuilder.Entity<WorkingTableSfmanageProductsPage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkingTable_SFManageProductsPage");

                entity.Property(e => e.ProdId).HasColumnName("ProdID");

                entity.Property(e => e.UniqueQueryId)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("UniqueQueryID");
            });

            modelBuilder.Entity<ZipCodeDatum>(entity =>
            {
                entity.HasKey(e => e.ZipCode)
                    .HasName("PK_ZipCode");

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
