using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CartsStorefrontOrdersGiftCertificate
    {
        public string SessionId { get; set; } = null!;
        public long GiftCertificateId { get; set; }
        public decimal AmountRedeemed { get; set; }

        public virtual GiftCertificate GiftCertificate { get; set; } = null!;
    }
}
