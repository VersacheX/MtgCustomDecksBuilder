using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingUpsBilling
    {
        public int DetailId { get; set; }
        public int? ShipmentNum { get; set; }
        public int? ProviderOrderId { get; set; }
        public string? TrackingNumber { get; set; }
        public string? ChargeCategoryCode { get; set; }
        public string? ChargeCategoryDetailCode { get; set; }
        public string? ChargeClassificationCode { get; set; }
        public string? ChargeDescriptionCode { get; set; }
        public string? ShipperNumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? BillDate { get; set; }
        public decimal? InvoiceAmount { get; set; }
        public string? PickupRecordNumber { get; set; }
        public decimal? ActualWeight { get; set; }
        public decimal? BilledWeight { get; set; }
        public string? WeightIndicator { get; set; }
        public string? DimensionalWeightIndicator { get; set; }
        public string? Oversize1Indicator { get; set; }
        public string? Oversize2Indicator { get; set; }
        public short? ZoneNumber { get; set; }
        public string? TransactionCode { get; set; }
        public string? ServiceDescription { get; set; }
        public short? BillOption { get; set; }
        public string? PickupDate { get; set; }
        public string? SenderName { get; set; }
        public string? SenderCompany { get; set; }
        public string? SenderStreet { get; set; }
        public string? SenderCity { get; set; }
        public string? SenderState { get; set; }
        public string? SenderZip { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverCompany { get; set; }
        public string? ReceiverStreet { get; set; }
        public string? ReceiverCity { get; set; }
        public string? ReceiverState { get; set; }
        public string? ReceiverZip { get; set; }
        public string? ReceiverCountry { get; set; }
        public decimal? NetCharges { get; set; }
        public decimal? Incentive { get; set; }
        public string? DeclaredValueIndicator { get; set; }
        public string? Codindicator { get; set; }
        public string? AddtHandlingIndicator { get; set; }
        public string? EarlyAmsurchargeIndicator { get; set; }
        public string? DeliveryConfIndicator { get; set; }
        public string? ExtDestSurchargeIndicator { get; set; }
        public string? InvalidAcctChargeIndicator { get; set; }
        public string? DeliveryAreaSurchargeIndicator { get; set; }
        public string? CurrencySurchargeIndicator { get; set; }
        public string? ChargebackSurchargeIndicator { get; set; }
        public string? PickupFeeIndicator { get; set; }
        public string? BillingOptionIndicator { get; set; }
        public string? ConsolidatedClearanceIndicator { get; set; }
        public string? SplitDuty { get; set; }
        public string? ExportLicVerificationIndicator { get; set; }
        public string? Misc1 { get; set; }
        public string? Misc2 { get; set; }
        public string? Misc3 { get; set; }
        public string? Misc4 { get; set; }
        public string? Misc5 { get; set; }
        public DateTime? DateImported { get; set; }
        public decimal? TotalCharges { get; set; }
    }
}
