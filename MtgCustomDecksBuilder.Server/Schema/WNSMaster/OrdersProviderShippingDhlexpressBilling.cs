using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingDhlexpressBilling
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? AccountNumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? ShippersReference { get; set; }
        public string? ShipperName { get; set; }
        public string? Sender { get; set; }
        public string? SenderAddress { get; set; }
        public string? RecipientName { get; set; }
        public string? Receiver { get; set; }
        public string? ReceiverAddress { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public string? OriginCode { get; set; }
        public string? OriginCountryName { get; set; }
        public string? AirwayBillNo { get; set; }
        public string? DestinationCode { get; set; }
        public string? DestinationCountryName { get; set; }
        public string? Product { get; set; }
        public int? Pieces { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Charges { get; set; }
        public decimal? FuelSurcharge { get; set; }
        public decimal? TaxVat { get; set; }
        public decimal? SubAmount { get; set; }
        public string? Currency { get; set; }
        public DateTime? DateImported { get; set; }

        public virtual OrdersProviderShippingDhlexpressBillingImport Import { get; set; } = null!;
    }
}
