using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NorcoZipCode
    {
        public string Region { get; set; } = null!;
        public string Zip { get; set; } = null!;
    }
}
