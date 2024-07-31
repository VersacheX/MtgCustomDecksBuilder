using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SagawaShippingSetting
    {
        public SagawaShippingSetting()
        {
            SagawaManifests = new HashSet<SagawaManifest>();
        }

        public byte SettingId { get; set; }
        public string? SettingDescription { get; set; }
        public string? MailerId { get; set; }
        public string? Ftpserver { get; set; }
        public string? Ftpusername { get; set; }
        public string? Ftppassword { get; set; }
        public string? ManifestEmailAddresses { get; set; }

        public virtual ICollection<SagawaManifest> SagawaManifests { get; set; }
    }
}
