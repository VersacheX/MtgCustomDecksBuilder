using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WalmartOrder
    {
        public WalmartOrder()
        {
            WalmartOrderLines = new HashSet<WalmartOrderLine>();
        }

        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string PurchaseOrderId { get; set; } = null!;
        public string CustomerOrderId { get; set; } = null!;
        public string CustomerEmailId { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public DateTime? EstimatedDeliveryDate { get; set; }
        public DateTime? EstimatedShipDate { get; set; }
        public string? ShipFirstName { get; set; }
        public string? ShipMiddleName { get; set; }
        public string? ShipLastName { get; set; }
        public string? ShipAddress1 { get; set; }
        public string? ShipAddress2 { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipState { get; set; }
        public string? ShipZipCode { get; set; }
        public string? ShipCountry { get; set; }
        public string? ShipPhone { get; set; }
        public string? ShipMethodCode { get; set; }
        public string? ShipAddressType { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? ShippingTotal { get; set; }
        public decimal? OrderTotal { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? AcceptedOn { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string? RejectedReason { get; set; }
        public DateTime? CompletedOn { get; set; }

        public virtual ICollection<WalmartOrderLine> WalmartOrderLines { get; set; }
    }
}
