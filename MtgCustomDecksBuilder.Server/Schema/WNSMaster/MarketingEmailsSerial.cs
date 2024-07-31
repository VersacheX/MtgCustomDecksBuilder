using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingEmailsSerial
    {
        public string SerialNum { get; set; } = null!;
        public string? EmailId { get; set; }
        public int? LinkId { get; set; }
        public int? CampaignId { get; set; }
        public int? ProspectId { get; set; }
        public DateTime? DateTimeSent { get; set; }

        public virtual MarketingPreference? Prospect { get; set; }
    }
}
