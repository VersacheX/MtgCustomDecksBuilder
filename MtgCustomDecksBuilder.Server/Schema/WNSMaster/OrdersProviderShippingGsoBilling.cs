using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingGsoBilling
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? RecordType { get; set; }
        public int? InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? TrackingNumber { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string? ShipperCompany { get; set; }
        public string? PickupAddress { get; set; }
        public string? PickupCity { get; set; }
        public string? PickupState { get; set; }
        public string? PickupZip { get; set; }
        public string? ShipToCompany { get; set; }
        public string? DeliveryAddress { get; set; }
        public string? DeliveryCity { get; set; }
        public string? DeliveryState { get; set; }
        public string? DeliveryZip { get; set; }
        public string? Reference { get; set; }
        public string? ServiceCode { get; set; }
        public int? PackageWeight { get; set; }
        public string? DeliveryTime { get; set; }
        public string? SignedBy { get; set; }
        public decimal? TransportationCharge { get; set; }
        public decimal? Codcharge { get; set; }
        public decimal? InsuranceCharge { get; set; }
        public decimal? OtherCharge { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? TotalShippingCharge { get; set; }
        public string? BillingComments { get; set; }
        public string? DeliveryZone { get; set; }

        public virtual OrdersProviderShippingGsoBillingImport Import { get; set; } = null!;
    }
}
