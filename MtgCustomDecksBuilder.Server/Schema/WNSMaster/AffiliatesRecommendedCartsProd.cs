using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesRecommendedCartsProd
    {
        public string RecommendedCartId { get; set; } = null!;
        public int ProdId { get; set; }
        public int Qty { get; set; }

        public virtual AffiliatesRecommendedCart RecommendedCart { get; set; } = null!;
    }
}
