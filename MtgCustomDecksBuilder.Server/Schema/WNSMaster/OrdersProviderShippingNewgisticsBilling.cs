using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingNewgisticsBilling
    {
        public int DetailId { get; set; }
        public int? ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountName { get; set; }
        public string? EntryFacility { get; set; }
        public DateTime? ManifestDate { get; set; }
        public DateTime? RatedDate { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? ShipToZip { get; set; }
        public string? ServiceName { get; set; }
        public string? TrackingNumber { get; set; }
        public string? TrailerNumber { get; set; }
        public decimal? Weight { get; set; }
        public bool? BaloonFlag { get; set; }
        public bool? OversizeFlag { get; set; }
        public bool? NonMachinableFlag { get; set; }
        public decimal? DeliveryConfirmationFee { get; set; }
        public int? Zone { get; set; }
        public decimal? PostageTotal { get; set; }
        public decimal? ServiceCharges { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? Total { get; set; }

        public virtual OrdersProviderShippingNewgisticsBillingImport? Import { get; set; }
    }
}
