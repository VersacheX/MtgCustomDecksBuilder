using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NgsManifest
    {
        public int ManifestId { get; set; }
        public byte SettingId { get; set; }
        public short AdminId { get; set; }
        public string? FileName { get; set; }
        public DateTime? FileUploadDate { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual NgsShippingSetting Setting { get; set; } = null!;
    }
}
