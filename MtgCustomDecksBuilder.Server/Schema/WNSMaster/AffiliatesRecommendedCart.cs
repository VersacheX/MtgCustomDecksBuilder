using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesRecommendedCart
    {
        public string RecommendedCartId { get; set; } = null!;
        public string CampaignCode { get; set; } = null!;
        public string RecommendedCartName { get; set; } = null!;
        public bool IsCustom { get; set; }

        public virtual AffiliatesCampaign CampaignCodeNavigation { get; set; } = null!;
    }
}
