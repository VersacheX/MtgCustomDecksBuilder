using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontShippingMethod
    {
        public StorefrontShippingMethod()
        {
            StorefrontShippingMethodsCarrierandClasses = new HashSet<StorefrontShippingMethodsCarrierandClass>();
            StorefrontShippingMethodsMessages = new HashSet<StorefrontShippingMethodsMessage>();
            StorefrontShippingMethodsShipInfos = new HashSet<StorefrontShippingMethodsShipInfo>();
        }

        public int ShipMethodId { get; set; }
        public short StorefrontId { get; set; }
        public string ShipMethodCode { get; set; } = null!;
        public string? DomOrInt { get; set; }
        public string? ShipMethodDescToStorefront { get; set; }
        public string? ShipMethodDescToPublic { get; set; }
        public byte? SortOrder { get; set; }
        public string? FlatOrZipDependent { get; set; }
        public bool IsDefault { get; set; }
        public bool AllowedByStorefront { get; set; }
        public bool HideFromPublic { get; set; }
        public decimal RemoteAreaSurcharge { get; set; }
        public byte? RemoteAreaSurchargeCarrier { get; set; }
        public bool? IsFreeShippingEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public decimal? MaxProdValue { get; set; }
        public decimal? MaxShipWeightInOz { get; set; }
        public string? NotesToPublic { get; set; }

        public virtual RemoteAreaSurchargeCarrier? RemoteAreaSurchargeCarrierNavigation { get; set; }
        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual ICollection<StorefrontShippingMethodsCarrierandClass> StorefrontShippingMethodsCarrierandClasses { get; set; }
        public virtual ICollection<StorefrontShippingMethodsMessage> StorefrontShippingMethodsMessages { get; set; }
        public virtual ICollection<StorefrontShippingMethodsShipInfo> StorefrontShippingMethodsShipInfos { get; set; }
    }
}
