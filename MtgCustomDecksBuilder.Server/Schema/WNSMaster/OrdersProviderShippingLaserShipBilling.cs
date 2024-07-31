using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingLaserShipBilling
    {
        public int DetailId { get; set; }
        public int? ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? InvNo { get; set; }
        public string? JobNumber { get; set; }
        public string? Tdate { get; set; }
        public string? Reference { get; set; }
        public string? LstrackingNumber { get; set; }
        public string? Caller { get; set; }
        public string? FromName { get; set; }
        public string? FromNumber { get; set; }
        public string? FromStreet { get; set; }
        public string? FromRoom { get; set; }
        public string? FromCity { get; set; }
        public string? FromZip { get; set; }
        public string? ToName { get; set; }
        public string? ToNumber { get; set; }
        public string? ToStreet { get; set; }
        public string? ToRoom { get; set; }
        public string? ToCity { get; set; }
        public string? ToZip { get; set; }
        public string? ServiceCode { get; set; }
        public decimal? ServiceAmount { get; set; }
        public string? ExtraCode1 { get; set; }
        public decimal? Extra1Amount { get; set; }
        public string? ExtraCode2 { get; set; }
        public decimal? Extra2Amount { get; set; }
        public string? ExtraCode3 { get; set; }
        public decimal? Extra3Amount { get; set; }
        public string? ExtraCode4 { get; set; }
        public decimal? Extra4Amount { get; set; }
        public decimal? En { get; set; }
        public decimal? Tax { get; set; }
        public decimal? Total { get; set; }
        public int? Zone { get; set; }
        public decimal? Weight { get; set; }
        public string? Pod { get; set; }
        public string? Poddate { get; set; }
        public string? Podtime { get; set; }

        public virtual OrdersProviderShippingLaserShipBillingImport? Import { get; set; }
    }
}
