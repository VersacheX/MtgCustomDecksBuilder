using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontShippingMethodsMessage
    {
        public int MessageId { get; set; }
        public int ShipMethodId { get; set; }
        public short CountryId { get; set; }
        public string? MessageText { get; set; }

        public virtual ShipToCountry Country { get; set; } = null!;
        public virtual StorefrontShippingMethod ShipMethod { get; set; } = null!;
    }
}
