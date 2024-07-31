using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CarriersAndClass
    {
        public CarriersAndClass()
        {
            CarrierRatePeriods = new HashSet<CarrierRatePeriod>();
            OrdersProviderShippings = new HashSet<OrdersProviderShipping>();
            PickupGroupsMappings = new HashSet<PickupGroupsMapping>();
            StorefrontShippingMethodsCarrierandClasses = new HashSet<StorefrontShippingMethodsCarrierandClass>();
            UspsFees = new HashSet<UspsFee>();
            Countries = new HashSet<ShipToCountry>();
            Storefronts = new HashSet<StorefrontInfo>();
        }

        public byte CandCid { get; set; }
        public string CarrierCode { get; set; } = null!;
        public string ClassCode { get; set; } = null!;
        public string CandCdesc { get; set; } = null!;
        public bool IsActive { get; set; }
        public bool? IsPostal { get; set; }
        public decimal? MaxWeightInOz { get; set; }

        public virtual ICollection<CarrierRatePeriod> CarrierRatePeriods { get; set; }
        public virtual ICollection<OrdersProviderShipping> OrdersProviderShippings { get; set; }
        public virtual ICollection<PickupGroupsMapping> PickupGroupsMappings { get; set; }
        public virtual ICollection<StorefrontShippingMethodsCarrierandClass> StorefrontShippingMethodsCarrierandClasses { get; set; }
        public virtual ICollection<UspsFee> UspsFees { get; set; }

        public virtual ICollection<ShipToCountry> Countries { get; set; }
        public virtual ICollection<StorefrontInfo> Storefronts { get; set; }
    }
}
