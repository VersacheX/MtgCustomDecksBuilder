using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ViewDhlshipOrder
    {
        public string? StorefrontName { get; set; }
        public string? StoreAddress { get; set; }
        public string? StoreCity { get; set; }
        public string? StoreState { get; set; }
        public string? StoreZip { get; set; }
        public string? StoreCountry { get; set; }
        public string? StorePhone { get; set; }
        public int OrderId { get; set; }
        public short? StorefrontIdforRef2 { get; set; }
        public string? ShipToName { get; set; }
        public string? ShipToAttention { get; set; }
        public string ShipToAddress { get; set; } = null!;
        public string? ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; } = null!;
        public string ShipToState { get; set; } = null!;
        public string ShipToZip { get; set; } = null!;
        public string ShipToCountry { get; set; } = null!;
        public string? ShipToPhone { get; set; }
        public string? ShipToEmail { get; set; }
        public string? ServiceType { get; set; }
        public string SpecialInstructionsForShipment { get; set; } = null!;
        public string DescriptionOfGoods { get; set; } = null!;
        public string InvoiceCurrencyCode { get; set; } = null!;
        public string? DeclaredValueOption { get; set; }
        public string? DeclaredValueAmount { get; set; }
        public string? Codoption { get; set; }
        public string? Codamount { get; set; }
        public string? CodcurrencyCode { get; set; }
        public string? CodguaranteedFunds { get; set; }
        public string? Ponumber { get; set; }
        public string SignatureRequired { get; set; } = null!;
        public decimal ShipAmount { get; set; }
        public string ShipperContactName { get; set; } = null!;
    }
}
