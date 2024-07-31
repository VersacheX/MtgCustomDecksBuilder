using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ShippingUpsbasicZipDeliveredBy
    {
        public string Zip { get; set; } = null!;
        public int Upsdeliveries { get; set; }
        public int Uspsdeliveries { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
