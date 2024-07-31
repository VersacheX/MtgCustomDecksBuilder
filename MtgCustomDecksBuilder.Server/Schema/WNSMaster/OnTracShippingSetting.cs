using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OnTracShippingSetting
    {
        public OnTracShippingSetting()
        {
            WarehouseOnTracShippingSettings = new HashSet<WarehouseOnTracShippingSetting>();
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
        public string? BaseUri { get; set; }
        public string? Password { get; set; }
        public decimal? FuelSurcharge { get; set; }

        public virtual ICollection<WarehouseOnTracShippingSetting> WarehouseOnTracShippingSettings { get; set; }
    }
}
