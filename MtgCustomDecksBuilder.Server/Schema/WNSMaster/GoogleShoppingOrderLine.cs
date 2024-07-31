using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GoogleShoppingOrderLine
    {
        public int Id { get; set; }
        public int GoogleShoppingOrderId { get; set; }
        public int ProdId { get; set; }
        public string? GoogleOrderItemId { get; set; }
        public string? ItemId { get; set; }
        public string? Gtin { get; set; }
        public string? Mpn { get; set; }
        public string? OfferId { get; set; }
        public string? Brand { get; set; }
        public string? Title { get; set; }
        public string? Condition { get; set; }
        public int? QuantityOrdered { get; set; }
        public int? QuantityPending { get; set; }
        public int? QuantityCanceled { get; set; }
        public decimal Price { get; set; }
        public decimal? Tax { get; set; }
        public DateTime? ShippingDeliveryByDate { get; set; }
        public string? ShippingMethodCarrier { get; set; }
        public int? ShippingMethodMaxDaysInTransit { get; set; }
        public string? ShippingMethodName { get; set; }
        public int? ShippingMethodMinDaysInTransit { get; set; }
        public DateTime? ShippingShipByDate { get; set; }
        public string? ShippingType { get; set; }
        public DateTime? ShippedOn { get; set; }
        public DateTime? CancelledOn { get; set; }

        public virtual GoogleShoppingOrder GoogleShoppingOrder { get; set; } = null!;
    }
}
