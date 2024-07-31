using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsShippingSetting
    {
        public UpsShippingSetting()
        {
            WarehouseUpsShippingSettings = new HashSet<WarehouseUpsShippingSetting>();
        }

        public byte SettingId { get; set; }
        public string? SettingDescription { get; set; }
        public string AccountNumber { get; set; } = null!;
        public string? BasicAccountNumber { get; set; }
        public string? BasicPoaccountNumber { get; set; }
        public string UserId { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string AccessLicenseNumber { get; set; } = null!;
        public string? ShipperName { get; set; }
        public string? ShipperAttentionName { get; set; }
        public string? ShipperAddressLine1 { get; set; }
        public string? ShipperAddressLine2 { get; set; }
        public string? ShipperAddressLine3 { get; set; }
        public string? ShipperCity { get; set; }
        public string? ShipperStateProvinceCode { get; set; }
        public string? ShipperPostalCode { get; set; }
        public string? ShipperCountryCode { get; set; }
        public string? ShipperPhoneNumber { get; set; }
        public decimal? FuelSurchargeGroundPercent { get; set; }
        public decimal? FuelSurchargeExpeditedPercent { get; set; }

        public virtual ICollection<WarehouseUpsShippingSetting> WarehouseUpsShippingSettings { get; set; }
    }
}
