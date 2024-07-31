using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontShippingMethodsShipInfoFeeOverride
    {
        public int Id { get; set; }
        public int StorefrontShippingMethodsShipInfoId { get; set; }
        public byte WeightInPounds { get; set; }
        public decimal TotalFee { get; set; }

        public virtual StorefrontShippingMethodsShipInfo StorefrontShippingMethodsShipInfo { get; set; } = null!;
    }
}
