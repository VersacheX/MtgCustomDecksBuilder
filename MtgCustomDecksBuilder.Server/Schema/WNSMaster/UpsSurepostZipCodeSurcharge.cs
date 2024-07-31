using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsSurepostZipCodeSurcharge
    {
        public string ZipCode { get; set; } = null!;
        public bool? IsExtended { get; set; }
    }
}
