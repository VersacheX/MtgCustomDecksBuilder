using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsworldshipLookuptable
    {
        public byte UniqueId { get; set; }
        public byte? ServiceTypeId { get; set; }
        public string? ServiceTypeDesc { get; set; }
    }
}
