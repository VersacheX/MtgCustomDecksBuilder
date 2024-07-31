using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontShippingMethodsCarrierandClass
    {
        public int Id { get; set; }
        public int ShipMethodId { get; set; }
        public byte CandCid { get; set; }

        public virtual CarriersAndClass CandC { get; set; } = null!;
        public virtual StorefrontShippingMethod ShipMethod { get; set; } = null!;
    }
}
