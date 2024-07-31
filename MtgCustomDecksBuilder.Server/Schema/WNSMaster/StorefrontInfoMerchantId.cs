using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontInfoMerchantId
    {
        public short StorefrontId { get; set; }
        public short CurrencyId { get; set; }
        public string PaymentechMerchantId { get; set; } = null!;

        public virtual Currency Currency { get; set; } = null!;
        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
