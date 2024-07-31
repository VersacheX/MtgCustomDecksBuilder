using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AmazonFbaInboundShipmentPlan
    {
        public AmazonFbaInboundShipmentPlan()
        {
            AmazonFbaInboundShipmentPlanItems = new HashSet<AmazonFbaInboundShipmentPlanItem>();
        }

        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string ShipmentId { get; set; } = null!;
        public string? DestinationFulfillmentCenterId { get; set; }
        public int? ProviderOrderId { get; set; }
        public string? ShipFromName { get; set; }
        public string? ShipFromAddress1 { get; set; }
        public string? ShipFromAddress2 { get; set; }
        public string? ShipFromCity { get; set; }
        public string? ShipFromStateCode { get; set; }
        public string? ShipFromPostalCode { get; set; }
        public string? ShipFromCountryCode { get; set; }
        public string? ShipToName { get; set; }
        public string? ShipToAddress1 { get; set; }
        public string? ShipToAddress2 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToStateCode { get; set; }
        public string? ShipToPostalCode { get; set; }
        public string? ShipToCountryCode { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public DateTime? OrderPlacedOn { get; set; }
        public DateTime? ShippedOn { get; set; }

        public virtual ICollection<AmazonFbaInboundShipmentPlanItem> AmazonFbaInboundShipmentPlanItems { get; set; }
    }
}
