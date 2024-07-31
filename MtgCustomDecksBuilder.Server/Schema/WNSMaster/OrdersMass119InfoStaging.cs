using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersMass119InfoStaging
    {
        public string StorefrontOrderId { get; set; } = null!;
        public string? BarCode { get; set; }
        public string? BarCodeSmall { get; set; }
        public string? FullDescription { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public string? ShipperName { get; set; }
        public string? ShipperName2 { get; set; }
        public string? ShipperAddress { get; set; }
        public string? ShipperPhone { get; set; }
        public string? CosigneeName { get; set; }
        public string? CosigneeAddress { get; set; }
        public string? CosigneePhone { get; set; }
        public string? CosigneeCellphone { get; set; }
        public string? Item { get; set; }
        public int? Var1 { get; set; }
        public string? Var2 { get; set; }
        public string? City1 { get; set; }
        public string? City2 { get; set; }
        public short? Pieces { get; set; }
        public decimal? ValueDeclared { get; set; }
        public decimal? Weight { get; set; }
        public DateTime? DateAndTime { get; set; }
    }
}
