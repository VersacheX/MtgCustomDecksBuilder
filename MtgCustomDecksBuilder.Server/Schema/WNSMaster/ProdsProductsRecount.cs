using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsRecount
    {
        public int RowId { get; set; }
        public short Wrhsid { get; set; }
        public int ProdId { get; set; }
        public int QtyBefore { get; set; }
        public int QtyAfter { get; set; }
        public DateTime DateAndTime { get; set; }
        public short? AdminId { get; set; }
    }
}
