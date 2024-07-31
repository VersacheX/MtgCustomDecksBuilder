using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SalesRepCommissionsLineItem
    {
        public int RowId { get; set; }
        public byte? SalesCommissionLineItemClassId { get; set; }
        public short? AdminId { get; set; }
        public int? ProviderOrderId { get; set; }
        public int? ProdId { get; set; }
        public int? Qty { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? LineItemRowId { get; set; }
        public int? ShipmentNum { get; set; }
        public int? UpsbillingDetailId { get; set; }
        public int? StatementIdassignedTo { get; set; }
        public DateTime? DateAssignedToStatement { get; set; }
        public decimal? FinalProdCost { get; set; }
        public decimal? FinalProdSalePrice { get; set; }
        public int? FinalPodrawnFrom { get; set; }
        public decimal? CommissionAmount { get; set; }
        public string? Description { get; set; }
        public DateTime OrderDateTime { get; set; }
        public DateTime DateAndTime { get; set; }
        public int? MiscBillingDetailId { get; set; }
        public int? GsobillingDetailId { get; set; }
    }
}
