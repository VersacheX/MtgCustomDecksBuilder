using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NorcoShippingSetting
    {
        public byte SettingId { get; set; }
        public string? SettingDescription { get; set; }
        public string? AccountNumber { get; set; }
        public string MailerName { get; set; } = null!;
        public string MailerAddress { get; set; } = null!;
        public string? MailerAddress2 { get; set; }
        public string MailerCity { get; set; } = null!;
        public string MailerState { get; set; } = null!;
        public string MailerZip { get; set; } = null!;
        public string MailerPhone { get; set; } = null!;
        public string? MailerEmail { get; set; }
        public decimal? MaxWeightInLbs { get; set; }
        public decimal? BaseRate { get; set; }
        public decimal? BaseRateWeightInLbs { get; set; }
        public decimal? PerPoundRateOverBaseRate { get; set; }
        public decimal? FuelSurcharge { get; set; }
    }
}
