using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ShipToCountry
    {
        public ShipToCountry()
        {
            CarrierRates = new HashSet<CarrierRate>();
            DhlGlobalMailRatesPacketPriorityDdus = new HashSet<DhlGlobalMailRatesPacketPriorityDdu>();
            DhlGlobalMailRatesParcelPriorityDdus = new HashSet<DhlGlobalMailRatesParcelPriorityDdu>();
            FedexFimsPrmRatesOverrides = new HashSet<FedexFimsPrmRatesOverride>();
            FedexFimsStdRatesOverrides = new HashSet<FedexFimsStdRatesOverride>();
            ProdsProducts = new HashSet<ProdsProduct>();
            StorefrontShippingMethodsMessages = new HashSet<StorefrontShippingMethodsMessage>();
            CandCs = new HashSet<CarriersAndClass>();
        }

        public short CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public string? CountryCode { get; set; }

        public virtual ICollection<CarrierRate> CarrierRates { get; set; }
        public virtual ICollection<DhlGlobalMailRatesPacketPriorityDdu> DhlGlobalMailRatesPacketPriorityDdus { get; set; }
        public virtual ICollection<DhlGlobalMailRatesParcelPriorityDdu> DhlGlobalMailRatesParcelPriorityDdus { get; set; }
        public virtual ICollection<FedexFimsPrmRatesOverride> FedexFimsPrmRatesOverrides { get; set; }
        public virtual ICollection<FedexFimsStdRatesOverride> FedexFimsStdRatesOverrides { get; set; }
        public virtual ICollection<ProdsProduct> ProdsProducts { get; set; }
        public virtual ICollection<StorefrontShippingMethodsMessage> StorefrontShippingMethodsMessages { get; set; }

        public virtual ICollection<CarriersAndClass> CandCs { get; set; }
    }
}
