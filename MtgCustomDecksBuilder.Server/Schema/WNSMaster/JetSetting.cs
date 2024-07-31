using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetSetting
    {
        public short StorefrontId { get; set; }
        public string? LocalDir { get; set; }
        public string? ApiUser { get; set; }
        public string? ApiSecret { get; set; }
        public string? CaFulfillmentNodeId { get; set; }
        public string? NcFulfillmentNodeId { get; set; }
        public int? StandardShipMethodId { get; set; }
        public int? ExpeditedShipMethodId { get; set; }
    }
}
