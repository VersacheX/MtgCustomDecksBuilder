using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            Orders = new HashSet<Order>();
            PickupGroupsMappings = new HashSet<PickupGroupsMapping>();
        }

        public int ShipMethodId { get; set; }
        public string ShipMethodCode { get; set; } = null!;
        public string? DomOrInt { get; set; }
        public string? FlatOrZipDependent { get; set; }
        public string? ShipMethodDescToStorefront { get; set; }
        public string? ShipMethodDescToPublic { get; set; }
        public byte? SortOrder { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PickupGroupsMapping> PickupGroupsMappings { get; set; }
    }
}
