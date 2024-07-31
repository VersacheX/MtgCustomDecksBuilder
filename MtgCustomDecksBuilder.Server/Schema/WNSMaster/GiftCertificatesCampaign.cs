using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GiftCertificatesCampaign
    {
        public GiftCertificatesCampaign()
        {
            GiftCertificates = new HashSet<GiftCertificate>();
        }

        public int CampaignId { get; set; }
        public string CampaignName { get; set; } = null!;
        public string? CampaignDesc { get; set; }
        public decimal? MinEnableAmount { get; set; }
        public decimal? DefaultOriginalAmount { get; set; }
        public DateTime? DefaultExpirationDate { get; set; }
        public string? CampaignGuid { get; set; }

        public virtual ICollection<GiftCertificate> GiftCertificates { get; set; }
    }
}
