using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedexFimsShippingSetting
    {
        public FedexFimsShippingSetting()
        {
            FedexFimsManifests = new HashSet<FedexFimsManifest>();
        }

        public int SettingId { get; set; }
        public string? SettingDescription { get; set; }
        public string? MailerName { get; set; }
        public string? MailerAddress { get; set; }
        public string? MailerAddress2 { get; set; }
        public string? MailerCity { get; set; }
        public string? MailerState { get; set; }
        public string? MailerZip { get; set; }
        public string? MailerPhone { get; set; }
        public string? MailerEmail { get; set; }

        public virtual ICollection<FedexFimsManifest> FedexFimsManifests { get; set; }
    }
}
