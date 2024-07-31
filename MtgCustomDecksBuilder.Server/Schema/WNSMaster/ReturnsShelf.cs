using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ReturnsShelf
    {
        public int RowId { get; set; }
        public short WrhsId { get; set; }
        public int ProdId { get; set; }
        public string Classification { get; set; } = null!;
        public short Qty { get; set; }

        public virtual ProdsProduct Prod { get; set; } = null!;
    }
}
