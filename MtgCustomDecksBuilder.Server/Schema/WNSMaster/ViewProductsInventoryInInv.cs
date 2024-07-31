using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ViewProductsInventoryInInv
    {
        public int ProdId { get; set; }
        public short WrhsId { get; set; }
        public int? Inventory { get; set; }
    }
}
