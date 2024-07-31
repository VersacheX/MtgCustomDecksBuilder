using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CartsViewedProduct
    {
        public string CartId { get; set; } = null!;
        public int ProdId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
