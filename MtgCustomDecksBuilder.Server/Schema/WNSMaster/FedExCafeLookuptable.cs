using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedExCafeLookuptable
    {
        public byte UniqueId { get; set; }
        public byte OurShipMethodId { get; set; }
        public short FedExCafeCode { get; set; }
        public string ServiceDescription { get; set; } = null!;
    }
}
