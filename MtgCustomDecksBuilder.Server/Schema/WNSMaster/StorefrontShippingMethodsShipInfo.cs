using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontShippingMethodsShipInfo
    {
        public StorefrontShippingMethodsShipInfo()
        {
            StorefrontShippingMethodsShipInfoFeeOverrides = new HashSet<StorefrontShippingMethodsShipInfoFeeOverride>();
        }

        public int Id { get; set; }
        public int ShipMethodId { get; set; }
        public short CountryId { get; set; }
        public byte ZoneId { get; set; }
        public decimal PerOrderFee { get; set; }
        public decimal PerItemFee { get; set; }
        public decimal PerOunceFee { get; set; }
        public bool AllowedByStorefront { get; set; }
        public bool HideFromPublic { get; set; }

        public virtual StorefrontShippingMethod ShipMethod { get; set; } = null!;
        public virtual ICollection<StorefrontShippingMethodsShipInfoFeeOverride> StorefrontShippingMethodsShipInfoFeeOverrides { get; set; }
    }
}
