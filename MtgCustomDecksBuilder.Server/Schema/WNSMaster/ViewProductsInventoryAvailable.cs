using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ViewProductsInventoryAvailable
    {
        public int ProdId { get; set; }
        public short WrhsId { get; set; }
        public int? Available { get; set; }
    }
}
