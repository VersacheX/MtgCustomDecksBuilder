using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class InventoryLog
    {
        public int RowId { get; set; }
        public int? ProdId { get; set; }
        public int? Qty { get; set; }
        public int? Ponum { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAndTime { get; set; }
        public int? QtyInInventory { get; set; }
        public int? Cainv { get; set; }
        public int? Ncinv { get; set; }
    }
}
