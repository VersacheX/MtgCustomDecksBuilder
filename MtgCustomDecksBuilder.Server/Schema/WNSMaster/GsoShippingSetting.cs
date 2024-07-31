using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GsoShippingSetting
    {
        public GsoShippingSetting()
        {
            WarehouseGsoShippingSettings = new HashSet<WarehouseGsoShippingSetting>();
        }

        public byte SettingId { get; set; }
        public string? SettingDescription { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string? ShipperName { get; set; }
        public string? ShipperAddressLine1 { get; set; }
        public string? ShipperAddressLine2 { get; set; }
        public string? ShipperCity { get; set; }
        public string? ShipperStateProvinceCode { get; set; }
        public string? ShipperPostalCode { get; set; }
        public string? ShipperCountryCode { get; set; }
        public string? ShipperPhoneNumber { get; set; }
        public decimal? FuelSurchargePercent { get; set; }

        public virtual ICollection<WarehouseGsoShippingSetting> WarehouseGsoShippingSettings { get; set; }
    }
}
