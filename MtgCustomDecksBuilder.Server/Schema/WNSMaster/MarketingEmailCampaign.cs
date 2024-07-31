using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingEmailCampaign
    {
        public MarketingEmailCampaign()
        {
            MarketingEmailLinks = new HashSet<MarketingEmailLink>();
        }

        public int CampaignId { get; set; }
        public short StorefrontId { get; set; }
        public string CampaignName { get; set; } = null!;
        public DateTime DateCreated { get; set; }
        public string? Notes { get; set; }
        public string? Subject { get; set; }
        public string? FromName { get; set; }
        public string? FromEmail { get; set; }
        public string? Htmlsource { get; set; }
        public string? TextSource { get; set; }

        public virtual ICollection<MarketingEmailLink> MarketingEmailLinks { get; set; }
    }
}
