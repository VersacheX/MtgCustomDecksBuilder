using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class GsoExtendedAreaZipCode
    {
        public string ZipCode { get; set; } = null!;
        public bool IsExtended { get; set; }
    }
}
