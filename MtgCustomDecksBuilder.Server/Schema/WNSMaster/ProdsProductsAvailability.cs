using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsAvailability
    {
        public int ProdId { get; set; }
        public short WrhsId { get; set; }
        public int? Inv { get; set; }
        public int? Shelf { get; set; }
        public int? Available { get; set; }
        public int? ReserveQty { get; set; }
        public DateTime? ExpectedDate { get; set; }
        public DateTime LastChangeTimestamp { get; set; }
        public string? DebugSource { get; set; }

        public virtual ProdsProduct Prod { get; set; } = null!;
        public virtual Warehouse Wrhs { get; set; } = null!;
    }
}
