using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsShippingSetting
    {
        public UspsShippingSetting()
        {
            WarehouseUspsShippingSettings = new HashSet<WarehouseUspsShippingSetting>();
        }

        public byte SettingId { get; set; }
        public string? SettingDescription { get; set; }
        public string PermitNumber { get; set; } = null!;
        public string? Duns { get; set; }
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
        public string? ConfServFtp { get; set; }
        public string? ConfServUserId { get; set; }
        public string? ConfServPassword { get; set; }
        public bool IsActive { get; set; }
        public string? Crid { get; set; }
        public string? Pozip9 { get; set; }
        public string? AccountNumber { get; set; }
        public string? Bcgusername { get; set; }
        public string? Bcgpassword { get; set; }

        public virtual ICollection<WarehouseUspsShippingSetting> WarehouseUspsShippingSettings { get; set; }
    }
}
