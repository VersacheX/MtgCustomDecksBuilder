using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontInfo
    {
        public StorefrontInfo()
        {
            CartsStorefrontOrders = new HashSet<CartsStorefrontOrder>();
            CartsWholesaleOrders = new HashSet<CartsWholesaleOrder>();
            Coupons = new HashSet<Coupon>();
            MarketingDealOfTheDays = new HashSet<MarketingDealOfTheDay>();
            MarketingPreferences = new HashSet<MarketingPreference>();
            MetatagsBrands = new HashSet<MetatagsBrand>();
            MetatagsDepts = new HashSet<MetatagsDept>();
            MetatagsKeywords = new HashSet<MetatagsKeyword>();
            NackPriceControls = new HashSet<NackPriceControl>();
            OrdersProviderDropshippingInvoices = new HashSet<OrdersProviderDropshippingInvoice>();
            OrdersProviderDropshippingPayments = new HashSet<OrdersProviderDropshippingPayment>();
            ProdsFamilies = new HashSet<ProdsFamily>();
            ProdsProductsInStockNotifications = new HashSet<ProdsProductsInStockNotification>();
            ProdsSamplesStorefronts = new HashSet<ProdsSamplesStorefront>();
            StorefrontBrandInfos = new HashSet<StorefrontBrandInfo>();
            StorefrontCcinfos = new HashSet<StorefrontCcinfo>();
            StorefrontInfoMerchantIds = new HashSet<StorefrontInfoMerchantId>();
            StorefrontProdInfoChangeLogs = new HashSet<StorefrontProdInfoChangeLog>();
            StorefrontProdInfos = new HashSet<StorefrontProdInfo>();
            StorefrontShipToInfos = new HashSet<StorefrontShipToInfo>();
            StorefrontShippingMethods = new HashSet<StorefrontShippingMethod>();
            CandCs = new HashSet<CarriersAndClass>();
            Groups = new HashSet<Group>();
            Links = new HashSet<StorefrontControlPanelLink>();
            Wrhs = new HashSet<Warehouse>();
        }

        public short StorefrontId { get; set; }
        public short ProviderId { get; set; }
        public DateTime DateCreated { get; set; }
        public bool HasSynchronousStorefront { get; set; }
        public string AccessPwd { get; set; } = null!;
        public string? LegalName { get; set; }
        public bool? HasAlturaHostedCart { get; set; }
        public bool? CanDropshipByWebService { get; set; }
        public bool? CanDropshipByControlPanel { get; set; }
        public bool? CanWholesaleByControlPanel { get; set; }
        public short? SalesRepAdminId { get; set; }
        public string? BillToContact { get; set; }
        public string? BillToAddress { get; set; }
        public string? BillToAddress2 { get; set; }
        public string? BillToCity { get; set; }
        public string? BillToState { get; set; }
        public string? BillToZip { get; set; }
        public string? BillToCountry { get; set; }
        public string? BillToPhone { get; set; }
        public string? BillToFax { get; set; }
        public string? BillToEmail { get; set; }
        public string? ShipToContact { get; set; }
        public string? ShipToAddress { get; set; }
        public string? ShipToAddress2 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToState { get; set; }
        public string? ShipToZip { get; set; }
        public string? ShipToCountry { get; set; }
        public string? ShipToPhone { get; set; }
        public string? ShipToFax { get; set; }
        public string? ShipToEmail { get; set; }
        public string? StoreNameOnSlip { get; set; }
        public string? StoreAddressOnSlip { get; set; }
        public string? StoreAddress2OnSlip { get; set; }
        public string? StoreCityOnSlip { get; set; }
        public string? StoreStateOnSlip { get; set; }
        public string? StoreZipOnSlip { get; set; }
        public string? StorePhoneOnSlip { get; set; }
        public string? StoreFaxOnSlip { get; set; }
        public string? StoreEmailOnSlip { get; set; }
        public bool ReceiptOrPackingSlip { get; set; }
        public string? MemoOnSlip { get; set; }
        public string? FooterOnSlip { get; set; }
        public string? Url { get; set; }
        public string? LinkUrl { get; set; }
        public string? LinkSecureUrl { get; set; }
        public string? MailServerAddress { get; set; }
        public string? MailReturnAddressPublicWebsite { get; set; }
        public decimal SalesTaxPercentCa { get; set; }
        public decimal? SalesTaxPercentNc { get; set; }
        public bool? AllowBackorders { get; set; }
        public byte? InventoryDisplayTypeId { get; set; }
        public bool? AuthorizeNetEnabled { get; set; }
        public string? AuthorizeNetUrltoPost { get; set; }
        public string? AuthorizeNetLogin { get; set; }
        public string? AuthorizeNetPassword { get; set; }
        public string? AuthorizeNetEmailMerchantSetting { get; set; }
        public bool? ChargeBridgeEnabled { get; set; }
        public int? ChargeBridgeId { get; set; }
        public string? ChargeBridgeUsername { get; set; }
        public string? ChargeBridgePassword { get; set; }
        public bool? PaymentechCcenabled { get; set; }
        public bool? PaymentechEcheckEnabled { get; set; }
        public string? PaymentechMerchantId { get; set; }
        public bool? PaperCheckEnabled { get; set; }
        public decimal? ServiceFeeFulfillmentPerOrder { get; set; }
        public decimal? ServiceFeeFulfillmentPerItem { get; set; }
        public decimal? ServiceFeeReturnsPerOrder { get; set; }
        public decimal? ServiceFeeReturnsToInventoryPercent { get; set; }
        public decimal? ServiceFeeReturnsToSupplierPercent { get; set; }
        public string? ResaleCertNum { get; set; }
        public string? AccountNotes { get; set; }
        public bool Inactive { get; set; }
        public bool? WhlsAccountApproved { get; set; }
        public bool? SalesTaxExemptionApproved { get; set; }
        public bool? PersonalGuaranteeApproved { get; set; }
        public bool? ManualApprovalRequired { get; set; }
        public string? CcorderConfirmationEmailsTo { get; set; }
        public bool? ShowReorderFormOnInvoice { get; set; }
        public bool? EnableRefillReminders { get; set; }
        public string? CcrefillReminderEmailsTo { get; set; }
        public decimal? DropShipCreditLimit { get; set; }
        public bool DoNotEnforceDropShipCreditLimit { get; set; }
        public decimal? WholesaleCreditLimit { get; set; }
        public string? EmailShipmentNotificationTo { get; set; }
        public string? EmailReturnsNotificationTo { get; set; }
        public string? EmailTextFileDropshipNotificationTo { get; set; }
        public bool? UseNcforNcaddresses { get; set; }
        public bool? UseCaforCaaddresses { get; set; }
        public string? TermsType { get; set; }
        public string? TermsDays { get; set; }
        public decimal? WhlsSalesTaxPercentCa { get; set; }
        public decimal? WhlsSalesTaxPercentNc { get; set; }
        public decimal? Cancelorderinprocessfee { get; set; }
        public byte? ShippingProcessTypeId { get; set; }
        public short? DisplayInventoryCap { get; set; }
        public string? CustomStorefrontMenuIds { get; set; }
        public short? DefaultWarehouseAssignment { get; set; }
        public bool? PaymentMethodsCreditCard { get; set; }
        public bool? PaymentMethodsECheck { get; set; }
        public bool? PaymentMethodsCod { get; set; }
        public bool? PaymentMethodsCodGtd { get; set; }
        public bool? PaymentMethodsTerms { get; set; }
        public short? PaymentMethodsTermsNet { get; set; }
        public bool? PaymentMethodsPrepay { get; set; }
        public bool? UseWarehouseAddressOnShippingLabel { get; set; }
        public bool? TrackProdInfoChange { get; set; }
        public bool? HideProdsFromGoogle { get; set; }
        public bool? HideProdsFromFeeds { get; set; }
        public short? OwnedByProviderId { get; set; }
        public bool EnabledInternalSfcpfeatures { get; set; }
        public bool IsClosed { get; set; }

        public virtual NackStorefront? NackStorefront { get; set; }
        public virtual ICollection<CartsStorefrontOrder> CartsStorefrontOrders { get; set; }
        public virtual ICollection<CartsWholesaleOrder> CartsWholesaleOrders { get; set; }
        public virtual ICollection<Coupon> Coupons { get; set; }
        public virtual ICollection<MarketingDealOfTheDay> MarketingDealOfTheDays { get; set; }
        public virtual ICollection<MarketingPreference> MarketingPreferences { get; set; }
        public virtual ICollection<MetatagsBrand> MetatagsBrands { get; set; }
        public virtual ICollection<MetatagsDept> MetatagsDepts { get; set; }
        public virtual ICollection<MetatagsKeyword> MetatagsKeywords { get; set; }
        public virtual ICollection<NackPriceControl> NackPriceControls { get; set; }
        public virtual ICollection<OrdersProviderDropshippingInvoice> OrdersProviderDropshippingInvoices { get; set; }
        public virtual ICollection<OrdersProviderDropshippingPayment> OrdersProviderDropshippingPayments { get; set; }
        public virtual ICollection<ProdsFamily> ProdsFamilies { get; set; }
        public virtual ICollection<ProdsProductsInStockNotification> ProdsProductsInStockNotifications { get; set; }
        public virtual ICollection<ProdsSamplesStorefront> ProdsSamplesStorefronts { get; set; }
        public virtual ICollection<StorefrontBrandInfo> StorefrontBrandInfos { get; set; }
        public virtual ICollection<StorefrontCcinfo> StorefrontCcinfos { get; set; }
        public virtual ICollection<StorefrontInfoMerchantId> StorefrontInfoMerchantIds { get; set; }
        public virtual ICollection<StorefrontProdInfoChangeLog> StorefrontProdInfoChangeLogs { get; set; }
        public virtual ICollection<StorefrontProdInfo> StorefrontProdInfos { get; set; }
        public virtual ICollection<StorefrontShipToInfo> StorefrontShipToInfos { get; set; }
        public virtual ICollection<StorefrontShippingMethod> StorefrontShippingMethods { get; set; }

        public virtual ICollection<CarriersAndClass> CandCs { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<StorefrontControlPanelLink> Links { get; set; }
        public virtual ICollection<Warehouse> Wrhs { get; set; }
    }
}
