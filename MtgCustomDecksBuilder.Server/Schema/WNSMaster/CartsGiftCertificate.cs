using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CartsGiftCertificate
    {
        public string CartId { get; set; } = null!;
        public long GiftCertificateId { get; set; }
        public decimal? AmountRedeemed { get; set; }

        public virtual Cart Cart { get; set; } = null!;
    }
}
