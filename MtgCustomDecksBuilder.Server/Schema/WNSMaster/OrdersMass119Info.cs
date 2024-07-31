using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersMass119Info
    {
        public int ProviderOrderId { get; set; }
        public string? BarCode { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? BarCodeSmall { get; set; }
        public string? FullDescription { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? Origin { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? Destination { get; set; }
        public string? ShipperName { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? ShipperName2 { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? ShipperAddress { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? ShipperPhone { get; set; }
        public string? CosigneeName { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? CosigneeAddress { get; set; }
        public string? CosigneePhone { get; set; }
        public string? CosigneeCellphone { get; set; }
        public string? ZipCode { get; set; }
        public string? ShipToAddress { get; set; }
        public string? ShipToAddress2 { get; set; }
        public string? Type { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? Item { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public int? Var1 { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? Var2 { get; set; }
        public string? City1 { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public string? City2 { get; set; }
        public short? Pieces { get; set; }
        public string? FreightType { get; set; }
        public string? Freight { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public decimal? ValueDeclared { get; set; }
        /// <summary>
        /// _OBSOLETE
        /// </summary>
        public decimal? Weight { get; set; }
        public string? WeightAndValue { get; set; }
        public string? Trname { get; set; }
        public string? NewVar1 { get; set; }
        public string? NewVar2 { get; set; }
        public DateTime? DateAndTime { get; set; }
        public string? Comment { get; set; }
    }
}
