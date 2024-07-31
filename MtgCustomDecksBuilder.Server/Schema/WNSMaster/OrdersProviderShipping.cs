using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShipping
    {
        public OrdersProviderShipping()
        {
            OrdersProviderLineItemsShipments = new HashSet<OrdersProviderLineItemsShipment>();
            OrdersProviderShippingClaims = new HashSet<OrdersProviderShippingClaim>();
            OrdersProviderShippingMiscCarriersBillings = new HashSet<OrdersProviderShippingMiscCarriersBilling>();
            OrdersProviderShippingNewgisticsActivities = new HashSet<OrdersProviderShippingNewgisticsActivity>();
            OrdersProviderShippingUpsActivities = new HashSet<OrdersProviderShippingUpsActivity>();
            OrdersProviderShippingUspsActivities = new HashSet<OrdersProviderShippingUspsActivity>();
        }

        public int ShipmentNum { get; set; }
        public int ProviderOrderId { get; set; }
        public short WrhsId { get; set; }
        public byte? CarrierAndClassId { get; set; }
        public string CarrierAndClassDesc { get; set; } = null!;
        public string? InternalShipNotes { get; set; }
        public DateTime ShipDate { get; set; }
        public decimal? ShipCostToStorefront { get; set; }
        public decimal? InsuranceAmount { get; set; }
        public decimal? PackageWeight { get; set; }
        public string? TrackingNum { get; set; }
        public string? ParentTrackingNum { get; set; }
        public DateTime? CarrierScheduledDeliveryDate { get; set; }
        public DateTime? CarrierReportedDeliveryDate { get; set; }
        public DateTime? Void { get; set; }
        public short? UserId { get; set; }
        public string? SourceName { get; set; }
        public byte? UpsAccountSettingId { get; set; }
        public byte? FedExAccountSettingId { get; set; }
        public byte? UspsAccountSettingId { get; set; }
        public decimal? PostageRate { get; set; }
        public byte? PostageZone { get; set; }
        public decimal? InsuranceFee { get; set; }
        public int? ManifestId { get; set; }
        public int? MasterShipmentNum { get; set; }
        public DateTime? ConfirmationEmailSentDate { get; set; }
        public int? TransitDays { get; set; }
        public string? Uspspicnumber { get; set; }
        public string? Uspszip9 { get; set; }

        public virtual CarriersAndClass? CarrierAndClass { get; set; }
        public virtual ICollection<OrdersProviderLineItemsShipment> OrdersProviderLineItemsShipments { get; set; }
        public virtual ICollection<OrdersProviderShippingClaim> OrdersProviderShippingClaims { get; set; }
        public virtual ICollection<OrdersProviderShippingMiscCarriersBilling> OrdersProviderShippingMiscCarriersBillings { get; set; }
        public virtual ICollection<OrdersProviderShippingNewgisticsActivity> OrdersProviderShippingNewgisticsActivities { get; set; }
        public virtual ICollection<OrdersProviderShippingUpsActivity> OrdersProviderShippingUpsActivities { get; set; }
        public virtual ICollection<OrdersProviderShippingUspsActivity> OrdersProviderShippingUspsActivities { get; set; }
    }
}
