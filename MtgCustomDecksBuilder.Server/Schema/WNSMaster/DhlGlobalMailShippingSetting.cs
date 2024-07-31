using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlGlobalMailShippingSetting
    {
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
        public string? Ftpserver { get; set; }
        public string? Ftpusername { get; set; }
        public string? Ftppassword { get; set; }
        public string? PickupNumber { get; set; }
    }
}
