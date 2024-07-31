using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class RemoteAreaSurchargeCarrier
    {
        public RemoteAreaSurchargeCarrier()
        {
            RemoteAreaSurchargeZipCodes = new HashSet<RemoteAreaSurchargeZipCode>();
            RemoteAreaSurchargeZipCodes2015s = new HashSet<RemoteAreaSurchargeZipCodes2015>();
            StorefrontShippingMethods = new HashSet<StorefrontShippingMethod>();
        }

        public byte CarrierId { get; set; }
        public string CarrierDescription { get; set; } = null!;

        public virtual ICollection<RemoteAreaSurchargeZipCode> RemoteAreaSurchargeZipCodes { get; set; }
        public virtual ICollection<RemoteAreaSurchargeZipCodes2015> RemoteAreaSurchargeZipCodes2015s { get; set; }
        public virtual ICollection<StorefrontShippingMethod> StorefrontShippingMethods { get; set; }
    }
}
