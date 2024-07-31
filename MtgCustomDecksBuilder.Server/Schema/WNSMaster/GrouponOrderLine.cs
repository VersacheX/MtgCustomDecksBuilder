using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GrouponOrderLine
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string? FulfillmentLineItemId { get; set; }
        public string? GrouponNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? MerchantSkuItem { get; set; }
        public int? QuantityRequested { get; set; }
        public string? ShipmentMethodRequested { get; set; }
        public string? ShipmentAddressName { get; set; }
        public string? ShipmentAddressStreet { get; set; }
        public string? ShipmentAddressStreet2 { get; set; }
        public string? ShipmentAddressCity { get; set; }
        public string? ShipmentAddressState { get; set; }
        public string? ShipmentAddressPostalCode { get; set; }
        public string? ShipmentAddressCountry { get; set; }
        public string? Gift { get; set; }
        public string? GiftMessage { get; set; }
        public int? QuantityShipped { get; set; }
        public string? ShipmentCarrier { get; set; }
        public string? ShipmentMethod { get; set; }
        public string? ShipmentTrackingNumber { get; set; }
        public DateTime? ShipDate { get; set; }
        public string? GrouponSku { get; set; }
        public string? CustomFieldValue { get; set; }
        public string? PermaLink { get; set; }
        public string? ItemName { get; set; }
        public string? VendorId { get; set; }
        public string? SalesForceDealOptionId { get; set; }
        public decimal? GrouponCost { get; set; }
        public string? BillingAddressName { get; set; }
        public string? BillingAddressStreet { get; set; }
        public string? BillingAddressCity { get; set; }
        public string? BillingAddressState { get; set; }
        public string? BillingAddressPostalCode { get; set; }
        public string? BillingAddressCountry { get; set; }
        public string? PurchaseOrderNumber { get; set; }
        public decimal? ProductWeight { get; set; }
        public string? ProductWeightUnit { get; set; }
        public decimal? ProductLength { get; set; }
        public decimal? ProductWidth { get; set; }
        public decimal? ProductHeight { get; set; }
        public string? ProductDimensionUnit { get; set; }
        public string? CustomerPhone { get; set; }
        public string? IncoTerms { get; set; }
        public string? HtsCode { get; set; }
        public string? ThirdPartyLogisticsName { get; set; }
        public string? ThirdPartyLogisticsWarehouseLocation { get; set; }
        public string? KittingDetails { get; set; }
        public decimal? SellPrice { get; set; }
        public string? DealOpportunityId { get; set; }
        public string? ShipmentStrategy { get; set; }
        public string? FulfillmentMethod { get; set; }
        public string? CountryOfOrigin { get; set; }
        public string? MerchantPermaLink { get; set; }
        public DateTime? FeatureStartDate { get; set; }
        public DateTime? FeatureEndDate { get; set; }
        public string? BomSku { get; set; }
        public string? ParentOrderId { get; set; }
        public string? Source { get; set; }
        public int? GrouponTrackingFileId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? AcceptedOn { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string? RejectedReason { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
