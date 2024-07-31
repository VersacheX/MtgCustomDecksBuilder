using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WalmartPaymentLine
    {
        public int Id { get; set; }
        public int WalmartPaymentId { get; set; }
        public string? WalmartOrderNum { get; set; }
        public int? WalmartOrderLineNum { get; set; }
        public string? WalmartPonum { get; set; }
        public int? WalmartPolineNum { get; set; }
        public string? PartnerOrderNum { get; set; }
        public string? TransactionType { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public int? ShippedQty { get; set; }
        public string? PartnerItemId { get; set; }
        public string? PartnerGtin { get; set; }
        public string? PartnerItemName { get; set; }
        public string? ProductTaxCode { get; set; }
        public string? ShippingTaxCode { get; set; }
        public string? GiftWrapTaxCode { get; set; }
        public string? ShipToState { get; set; }
        public string? ShipToCounty { get; set; }
        public string? CountyCode { get; set; }
        public string? ShipToCity { get; set; }
        public string? ZipCode { get; set; }
        public string? ShippingMethod { get; set; }
        public decimal? TotalToOrFromCustomer { get; set; }
        public decimal? PayableToPartnerFromSale { get; set; }
        public decimal? CommissionFromSale { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal? GrossSalesRevenue { get; set; }
        public decimal? RefundedRetailSales { get; set; }
        public decimal? SalesRefundForEscalation { get; set; }
        public decimal? GrossShippingRevenue { get; set; }
        public decimal? GrossShippingRefunded { get; set; }
        public decimal? ShippingRefundForEscalation { get; set; }
        public decimal? NetShippingRevenue { get; set; }
        public decimal? GrossFeeRevenue { get; set; }
        public decimal? GrossFeeRefunded { get; set; }
        public decimal? FeeRefundForEscalation { get; set; }
        public decimal? NetFeeRevenue { get; set; }
        public int? GiftWrapQuantity { get; set; }
        public decimal? GrossGiftWrapRevenue { get; set; }
        public decimal? GrossGiftWrapRefunded { get; set; }
        public decimal? GiftWrapRefundForEscalation { get; set; }
        public decimal? NetGiftWrapRevenue { get; set; }
        public decimal? TaxOnSalesRevenue { get; set; }
        public decimal? TaxOnShippingRevenue { get; set; }
        public decimal? TaxOnGiftWrapRevenue { get; set; }
        public decimal? TaxOnFeeRevenue { get; set; }
        public decimal? EffectiveTaxRate { get; set; }
        public decimal? TaxOnRefundedSales { get; set; }
        public decimal? TaxOnShippingRefund { get; set; }
        public decimal? TaxOnGiftWrapRefund { get; set; }
        public decimal? TaxOnFeeRefund { get; set; }
        public decimal? TaxOnSalesRefundForEscalation { get; set; }
        public decimal? TaxOnShippingRefundforEscalation { get; set; }
        public decimal? TaxOnGiftWrapRefundForEscalation { get; set; }
        public decimal? TaxOnFeeRefundForEscalation { get; set; }
        public decimal? TotalNetTaxCollected { get; set; }
        public string? AdjustmentCode { get; set; }
        public string? AdjustmentDescription { get; set; }

        public virtual WalmartPayment WalmartPayment { get; set; } = null!;
    }
}
