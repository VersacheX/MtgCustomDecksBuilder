using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Warehouse
    {
        public Warehouse()
        {
            ProdsProductsAvailabilities = new HashSet<ProdsProductsAvailability>();
            ProdsSamplesInbounds = new HashSet<ProdsSamplesInbound>();
            ProdsSamplesInventories = new HashSet<ProdsSamplesInventory>();
            Storefronts = new HashSet<StorefrontInfo>();
        }

        public short WrhsId { get; set; }
        public short ProviderId { get; set; }
        public string WrhsDescription { get; set; } = null!;
        public int BufferPonumber { get; set; }
        public byte UpsDefaultSettingIdObsolete { get; set; }
        public byte FedExDefaultSettingIdObsolete { get; set; }
        public byte UspsDefaultSettingIdObsolete { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? CountryCode { get; set; }
        public string? PostalCode { get; set; }

        public virtual ICollection<ProdsProductsAvailability> ProdsProductsAvailabilities { get; set; }
        public virtual ICollection<ProdsSamplesInbound> ProdsSamplesInbounds { get; set; }
        public virtual ICollection<ProdsSamplesInventory> ProdsSamplesInventories { get; set; }

        public virtual ICollection<StorefrontInfo> Storefronts { get; set; }
    }
}
