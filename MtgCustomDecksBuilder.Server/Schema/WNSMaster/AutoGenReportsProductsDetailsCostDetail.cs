using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsProductsDetailsCostDetail
    {
        public long Uniquefier { get; set; }
        public int ReportNumber { get; set; }
        public short WrhsId { get; set; }
        public int Ponum { get; set; }
        public int ProdId { get; set; }
        public int? QtyInInventory { get; set; }
        public decimal? UnitCost { get; set; }
        public decimal? RebatePercent { get; set; }
    }
}
