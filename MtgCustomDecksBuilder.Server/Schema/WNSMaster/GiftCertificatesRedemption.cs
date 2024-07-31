using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GiftCertificatesRedemption
    {
        public long GiftCertificateId { get; set; }
        public int ProviderOrderId { get; set; }
        public decimal AmountRedeemed { get; set; }

        public virtual GiftCertificate GiftCertificate { get; set; } = null!;
    }
}
