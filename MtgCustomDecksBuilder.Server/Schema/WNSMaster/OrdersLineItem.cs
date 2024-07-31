using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersLineItem
    {
        public int RowId { get; set; }
        public short WrhsIdassignedTo { get; set; }
        public int ProviderOrderId { get; set; }
        public short LineNum { get; set; }
        public int ProdId { get; set; }
        public short Qty { get; set; }
        public string? Upc { get; set; }
        public short BrandId { get; set; }
        public string BrandDesc { get; set; } = null!;
        public string ProdName { get; set; } = null!;
        public decimal? UnitNum { get; set; }
        public string UnitTypeDesc { get; set; } = null!;
        public decimal? Msrp { get; set; }
        public decimal PriceToStorefront { get; set; }
        public decimal? PriceToConsumer { get; set; }
        public DateTime? Backordered { get; set; }
        public bool HideFromConsumer { get; set; }
        public short? ProviderAdminId { get; set; }
        public short? SfadminId { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? LineItemInProcess { get; set; }
        public DateTime? LineItemShipped { get; set; }
        public decimal? TempTestPtc { get; set; }

        public virtual Order ProviderOrder { get; set; } = null!;
    }
}
