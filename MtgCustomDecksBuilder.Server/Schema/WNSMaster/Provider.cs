using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Provider
    {
        public Provider()
        {
            InterProviderBillingInvoiceFromProviders = new HashSet<InterProviderBillingInvoice>();
            InterProviderBillingInvoiceToProviders = new HashSet<InterProviderBillingInvoice>();
            InterProviderBillingPaymentFromProviders = new HashSet<InterProviderBillingPayment>();
            InterProviderBillingPaymentToProviders = new HashSet<InterProviderBillingPayment>();
            InterProviderBillingTransactionFromProviders = new HashSet<InterProviderBillingTransaction>();
            InterProviderBillingTransactionToProviders = new HashSet<InterProviderBillingTransaction>();
            ProdsPrimaryVendors = new HashSet<ProdsPrimaryVendor>();
            PurchasePricingBrandNotes = new HashSet<PurchasePricingBrandNote>();
        }

        public short ProviderId { get; set; }
        public string Abbreviation { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public int DefaultPricingGroupId { get; set; }
        public decimal OverheadDeductionPercentForCommissions { get; set; }
        public string? FromEmailForCustomerComm { get; set; }
        public string? BounceBackEmailForCustomerComm { get; set; }
        public string? WhlsAccountApprovalRequestAddress { get; set; }
        public string? MailServerForCustomerComm { get; set; }
        public decimal? SfaccountDefaultWholesaleCreditLimit { get; set; }
        public decimal? SfaccountDefaultWhlsSalesTaxPercentCa { get; set; }
        public decimal? SfaccountDefaultWhlsSalesTaxPercentNc { get; set; }
        public bool? SfaccountDefaultPaymentMethodsCreditCard { get; set; }
        public bool? SfaccountDefaultPaymentMethodsCod { get; set; }
        public bool? SfaccountDefaultPaymentMethodsCodGtd { get; set; }
        public bool? SfaccountDefaultPaymentMethodsTerms { get; set; }
        public short? SfaccountDefaultPaymentMethodsTermsNet { get; set; }
        public bool? SfaccountDefaultPaymentMethodsPrepay { get; set; }
        public byte? SfaccountDefaultInventoryDisplayTypeId { get; set; }
        public short? SfaccountDefaultDisplayInventoryCap { get; set; }
        public bool? SfaccountDefaultAllowBackorders { get; set; }
        public byte? SfaccountDefaultShippingProcessTypeId { get; set; }
        public string? SfaccountDefaultTermsType { get; set; }
        public short? SfaccountDefaultDefaultWarehouseAssignment { get; set; }
        public bool? SfaccountDefaultManualApprovalRequired { get; set; }

        public virtual ICollection<InterProviderBillingInvoice> InterProviderBillingInvoiceFromProviders { get; set; }
        public virtual ICollection<InterProviderBillingInvoice> InterProviderBillingInvoiceToProviders { get; set; }
        public virtual ICollection<InterProviderBillingPayment> InterProviderBillingPaymentFromProviders { get; set; }
        public virtual ICollection<InterProviderBillingPayment> InterProviderBillingPaymentToProviders { get; set; }
        public virtual ICollection<InterProviderBillingTransaction> InterProviderBillingTransactionFromProviders { get; set; }
        public virtual ICollection<InterProviderBillingTransaction> InterProviderBillingTransactionToProviders { get; set; }
        public virtual ICollection<ProdsPrimaryVendor> ProdsPrimaryVendors { get; set; }
        public virtual ICollection<PurchasePricingBrandNote> PurchasePricingBrandNotes { get; set; }
    }
}
