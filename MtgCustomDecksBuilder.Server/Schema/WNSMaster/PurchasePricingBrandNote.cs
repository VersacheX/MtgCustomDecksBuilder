using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PurchasePricingBrandNote
    {
        public int NoteId { get; set; }
        public short ProviderId { get; set; }
        public short BrandId { get; set; }
        public string? Notes { get; set; }

        public virtual ProdsBrand Brand { get; set; } = null!;
        public virtual Provider Provider { get; set; } = null!;
    }
}
