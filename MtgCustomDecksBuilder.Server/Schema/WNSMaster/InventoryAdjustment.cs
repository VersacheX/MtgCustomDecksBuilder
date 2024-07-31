using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class InventoryAdjustment
    {
        public int RowId { get; set; }
        public short WrhsId { get; set; }
        public int ProdId { get; set; }
        public int Qty { get; set; }
        public string? Reason { get; set; }
        public short UserId { get; set; }
        public DateTime DateAndTime { get; set; }

        public virtual AdminsProvider User { get; set; } = null!;
    }
}
