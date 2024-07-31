using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EBayOrder
    {
        public EBayOrder()
        {
            EBayOrderLines = new HashSet<EBayOrderLine>();
        }

        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public string OrderId { get; set; } = null!;
        public DateTime? OrderDate { get; set; }
        public string? OrderStatus { get; set; }
        public string? PaymentHoldStatus { get; set; }
        public string? CheckoutStatus { get; set; }
        public string? PaymentMethod { get; set; }
        public string? ExternalTransactionId { get; set; }
        public string? ExternalTransactionStatus { get; set; }
        public string? BuyerName { get; set; }
        public string? BuyerPhone { get; set; }
        public string? BuyerUserId { get; set; }
        public string? BuyerCheckoutMessage { get; set; }
        public string? ShipFirstName { get; set; }
        public string? ShipMiddleName { get; set; }
        public string? ShipLastName { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipAddress1 { get; set; }
        public string? ShipAddress2 { get; set; }
        public string? ShipCity { get; set; }
        public string? ShipState { get; set; }
        public string? ShipZipCode { get; set; }
        public string? ShipCountry { get; set; }
        public string? ShipPhone { get; set; }
        public string? ShippingService { get; set; }
        public decimal? ShippingServiceCost { get; set; }
        public decimal? ShippingServiceAdditionalCost { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? AdjustmentTotal { get; set; }
        public decimal? TaxTotal { get; set; }
        public decimal? ShippingTotal { get; set; }
        public decimal? OrderTotal { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? AcceptedOn { get; set; }
        public DateTime? RejectedOn { get; set; }
        public string? RejectedReason { get; set; }
        public DateTime? CompletedOn { get; set; }
        public string? ExtendedOrderId { get; set; }

        public virtual ICollection<EBayOrderLine> EBayOrderLines { get; set; }
    }
}
