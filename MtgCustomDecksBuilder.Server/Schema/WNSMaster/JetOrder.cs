using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetOrder
    {
        public JetOrder()
        {
            JetOrderLines = new HashSet<JetOrderLine>();
        }

        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string MerchantOrderId { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string ReferenceOrderId { get; set; } = null!;
        public DateTime OrderPlacedDate { get; set; }
        public DateTime OrderTransmissionDate { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerPhoneNumber { get; set; }
        public string? HashEmail { get; set; }
        public string? ShipRecipientName { get; set; }
        public string? ShipRecipientPhoneNumber { get; set; }
        public string? ShipAddress1 { get; set; }
        public string? ShipAddress2 { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipState { get; set; }
        public string? ShipZipCode { get; set; }
        public bool JetRequestDirectedCancel { get; set; }
        public string? FulfillmentNode { get; set; }
        public string? RequestShippingCarrier { get; set; }
        public string? RequestServiceLevel { get; set; }
        public DateTime? RequestShipBy { get; set; }
        public DateTime? RequestDeliveryBy { get; set; }
        public string? RawJson { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? AcceptedOn { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string? RejectedReason { get; set; }
        public DateTime? CompletedOn { get; set; }

        public virtual ICollection<JetOrderLine> JetOrderLines { get; set; }
    }
}
