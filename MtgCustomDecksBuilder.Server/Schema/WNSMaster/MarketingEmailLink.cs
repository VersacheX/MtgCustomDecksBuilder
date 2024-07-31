using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingEmailLink
    {
        public int LinkId { get; set; }
        public int CampaignId { get; set; }
        public string? LinkDescription { get; set; }

        public virtual MarketingEmailCampaign Campaign { get; set; } = null!;
    }
}
