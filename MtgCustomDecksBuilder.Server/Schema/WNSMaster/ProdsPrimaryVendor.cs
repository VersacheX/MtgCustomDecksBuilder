using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsPrimaryVendor
    {
        public int ProdId { get; set; }
        public short ProviderId { get; set; }
        public short VendorId { get; set; }

        public virtual Provider Provider { get; set; } = null!;
        public virtual Vendor Vendor { get; set; } = null!;
    }
}
