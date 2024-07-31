using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PickupGroupsMapping
    {
        public byte PickupGroupId { get; set; }
        public int ShipMethodId { get; set; }
        public byte CarrierAndClassId { get; set; }
        public bool CarrierReqSupervisorAppr { get; set; }

        public virtual CarriersAndClass CarrierAndClass { get; set; } = null!;
        public virtual PickupGroup PickupGroup { get; set; } = null!;
        public virtual ShippingMethod ShipMethod { get; set; } = null!;
    }
}
