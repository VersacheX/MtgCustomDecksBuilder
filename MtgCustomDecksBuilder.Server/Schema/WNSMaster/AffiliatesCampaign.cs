using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesCampaign
    {
        public AffiliatesCampaign()
        {
            AffiliatesRecommendedCarts = new HashSet<AffiliatesRecommendedCart>();
            AffiliatesTransactions = new HashSet<AffiliatesTransaction>();
        }

        public string CampaignCode { get; set; } = null!;
        public int AffiliateId { get; set; }
        public string? Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsRecommendedCart { get; set; }

        public virtual Affiliate Affiliate { get; set; } = null!;
        public virtual ICollection<AffiliatesRecommendedCart> AffiliatesRecommendedCarts { get; set; }
        public virtual ICollection<AffiliatesTransaction> AffiliatesTransactions { get; set; }
    }
}
