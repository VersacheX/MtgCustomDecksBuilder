using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GiftCertificate
    {
        public GiftCertificate()
        {
            CartsStorefrontOrdersGiftCertificates = new HashSet<CartsStorefrontOrdersGiftCertificate>();
            GiftCertificatesRedemptions = new HashSet<GiftCertificatesRedemption>();
            GiftCertificatesRestrictions = new HashSet<GiftCertificatesRestriction>();
        }

        public long GiftCertificateId { get; set; }
        public string RedemptionCode { get; set; } = null!;
        public DateTime DateTimeCreated { get; set; }
        public DateTime ExpirationDate { get; set; }
        public decimal OriginalAmount { get; set; }
        public int CampaignId { get; set; }
        public bool IsPurchasedCertificiate { get; set; }
        public string? TextToShowConsumer { get; set; }
        public int? GeneratedForOrderId { get; set; }
        public int? GeneratedForMarketingPreferenceId { get; set; }
        public string? GeneratedForEmail { get; set; }
        public int? GeneratedByAccountId { get; set; }
        public long? GeneratedByGiftCertificateId { get; set; }
        public DateTime? SentNotificationEmailOn { get; set; }
        public bool? IsExclusive { get; set; }
        public string? GeneratedForEmailName { get; set; }
        public string? GeneratedForEmailNotes { get; set; }

        public virtual GiftCertificatesCampaign Campaign { get; set; } = null!;
        public virtual ICollection<CartsStorefrontOrdersGiftCertificate> CartsStorefrontOrdersGiftCertificates { get; set; }
        public virtual ICollection<GiftCertificatesRedemption> GiftCertificatesRedemptions { get; set; }
        public virtual ICollection<GiftCertificatesRestriction> GiftCertificatesRestrictions { get; set; }
    }
}
