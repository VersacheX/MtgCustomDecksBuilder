using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CartsLineItem
    {
        public string CartId { get; set; } = null!;
        public short LineNum { get; set; }
        public int? ProdId { get; set; }
        public short? Qty { get; set; }
        public decimal? CurPubPrice { get; set; }
        public DateTime? LastModified { get; set; }
        public bool? IsSavedForLater { get; set; }

        public virtual Cart Cart { get; set; } = null!;
        public virtual ProdsProduct? Prod { get; set; }
    }
}
