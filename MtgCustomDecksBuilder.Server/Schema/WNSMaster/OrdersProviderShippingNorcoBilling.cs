using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingNorcoBilling
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public int? InvoiceNumber { get; set; }
        public string? OriginName { get; set; }
        public string? OriginAddress { get; set; }
        public string? OriginCity { get; set; }
        public string? OriginState { get; set; }
        public string? OriginZip { get; set; }
        public string? OriginPhone { get; set; }
        public string? DestName { get; set; }
        public string? DestAddress { get; set; }
        public string? DestCity { get; set; }
        public string? DestState { get; set; }
        public string? DestZip { get; set; }
        public string? DestPhone { get; set; }
        public string? ServiceDesc { get; set; }
        public string? VehicleTypeDescription { get; set; }
        public decimal? Service { get; set; }
        public decimal? OtherFees { get; set; }
        public decimal? AmountCharged { get; set; }
        public string? Auth { get; set; }
        public int? PiecesValue { get; set; }
        public int? WeightValue { get; set; }
        public string? OrderNumber { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public DateTime? PodDateTime { get; set; }
        public DateTime? Orderdate { get; set; }

        public virtual OrdersProviderShippingNorcoBillingImport Import { get; set; } = null!;
    }
}
