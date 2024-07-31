using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingFedexBilling
    {
        public OrdersProviderShippingFedexBilling()
        {
            OrdersProviderShippingFedexBillingCharges = new HashSet<OrdersProviderShippingFedexBillingCharge>();
        }

        public long DetailId { get; set; }
        public string? ShipmentNum { get; set; }
        public string InvoiceNumber { get; set; } = null!;
        public DateTime? InvoiceDate { get; set; }
        public string TrackingId { get; set; } = null!;
        public string? BillToAccountNumber { get; set; }
        public decimal? TransportationChargeAmount { get; set; }
        public decimal? NetChargeAmount { get; set; }
        public string? ServiceType { get; set; }
        public string? GroundService { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? PoddeliveryDate { get; set; }
        public string? PodserviceAreaCode { get; set; }
        public string? PodsignatureDescription { get; set; }
        public decimal? ActualWeightAmount { get; set; }
        public string? ActualWeightUnits { get; set; }
        public decimal? RatedWeightAmount { get; set; }
        public string? RatedWeightUnits { get; set; }
        public short? NumberOfPieces { get; set; }
        public int? BundleNumber { get; set; }
        public int? MeterNumber { get; set; }
        public string? RecipientName { get; set; }
        public string? RecipientCompany { get; set; }
        public string? RecipientAddressLine1 { get; set; }
        public string? RecipientAddressLine2 { get; set; }
        public string? RecipientCity { get; set; }
        public string? RecipientState { get; set; }
        public string? RecipientZipCode { get; set; }
        public string? RecipientCountry { get; set; }
        public string? ShipperCompany { get; set; }
        public string? ShipperName { get; set; }
        public string? ShipperAddressLine1 { get; set; }
        public string? ShipperAddressLine2 { get; set; }
        public string? ShipperCity { get; set; }
        public string? ShipperState { get; set; }
        public string? ShipperZipCode { get; set; }
        public string? ShipperCountry { get; set; }
        public string? OriginalCustomerRef { get; set; }
        public string? OriginalRef2 { get; set; }
        public string? OriginalRef3 { get; set; }
        public string? OriginalDeptRefDesc { get; set; }
        public string? UpdatedCustomerRef { get; set; }
        public string? UpdatedRef2 { get; set; }
        public string? UpdatedRef3 { get; set; }
        public string? UpdatedDeptRefDesc { get; set; }
        public string? Rmanumber { get; set; }
        public string? OriginalRecipientAddressLine1 { get; set; }
        public string? OriginalRecipientAddressLine2 { get; set; }
        public string? OriginalRecipientCity { get; set; }
        public string? OriginalRecipientState { get; set; }
        public string? OriginalRecipientZipCode { get; set; }
        public string? OriginalRecipientCountry { get; set; }
        public short? ZoneCode { get; set; }
        public DateTime? EntryDate { get; set; }
        public int? EntryNumber { get; set; }
        public decimal? CustomsValue { get; set; }
        public string? CustomsValueCurrencyCode { get; set; }
        public decimal? DeclaredValue { get; set; }
        public string? DeclaredValueCurrencyCode { get; set; }
        public string? CommodityDescription1 { get; set; }
        public string? CommodityCountryCode1 { get; set; }
        public string? CommodityDescription2 { get; set; }
        public string? CommodityCountryCode2 { get; set; }
        public string? CommodityDescription3 { get; set; }
        public string? CommodityCountryCode3 { get; set; }
        public string? CommodityDescription4 { get; set; }
        public string? CommodityCountryCode4 { get; set; }
        public DateTime? CurrencyConversionDate { get; set; }
        public decimal? CurrentyConversionRate { get; set; }
        public int? MultiweightNumber { get; set; }
        public short? MultiweightUnitsTotal { get; set; }
        public decimal? MultiweightWeightTotal { get; set; }
        public decimal? MultiweightShipmentChargeTotal { get; set; }
        public decimal? MultiweightShipmentWeightTotal { get; set; }
        public decimal? GroundTrkIdaddrCorrDiscAmount { get; set; }
        public decimal? GroundTrkIdaddrCorrGrossAmount { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual ICollection<OrdersProviderShippingFedexBillingCharge> OrdersProviderShippingFedexBillingCharges { get; set; }
    }
}
