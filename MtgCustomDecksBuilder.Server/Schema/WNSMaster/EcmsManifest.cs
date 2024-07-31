using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class EcmsManifest
    {
        public int ManifestId { get; set; }
        public short AdminId { get; set; }
        public string? FileName { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
