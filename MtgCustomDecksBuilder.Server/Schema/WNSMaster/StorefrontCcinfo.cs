using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontCcinfo
    {
        public int CardId { get; set; }
        public short StorefrontId { get; set; }
        public string? CardLabel { get; set; }
        public string NameOnCard { get; set; } = null!;
        public string? CardTypeCode { get; set; }
        public string CardExpMonth { get; set; } = null!;
        public string CardExpYear { get; set; } = null!;
        public byte[]? CcnumberEnc { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
