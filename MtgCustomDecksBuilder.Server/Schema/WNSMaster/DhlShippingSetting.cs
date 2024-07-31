using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlShippingSetting
    {
        public DhlShippingSetting()
        {
            DhlGlobalMailManifests = new HashSet<DhlGlobalMailManifest>();
            LandmarkGlobalManifests = new HashSet<LandmarkGlobalManifest>();
            WarehouseDhlShippingSettings = new HashSet<WarehouseDhlShippingSetting>();
        }

        public byte SettingId { get; set; }
        public string? SettingDescription { get; set; }
        public string PermitNumber { get; set; } = null!;
        public string? MailerId { get; set; }
        public string MailerName { get; set; } = null!;
        public string MailerAddress { get; set; } = null!;
        public string? MailerAddress2 { get; set; }
        public string MailerCity { get; set; } = null!;
        public string MailerState { get; set; } = null!;
        public string MailerZip { get; set; } = null!;
        public string MailerPhone { get; set; } = null!;
        public string? MailerEmail { get; set; }
        public string? Pozip { get; set; }
        public string? Pocity { get; set; }
        public string? Postate { get; set; }
        public decimal? FuelSurcharge { get; set; }

        public virtual ICollection<DhlGlobalMailManifest> DhlGlobalMailManifests { get; set; }
        public virtual ICollection<LandmarkGlobalManifest> LandmarkGlobalManifests { get; set; }
        public virtual ICollection<WarehouseDhlShippingSetting> WarehouseDhlShippingSettings { get; set; }
    }
}
