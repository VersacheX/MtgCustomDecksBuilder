using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderExtension
    {
        public int ProviderOrderId { get; set; }
        public string? ShipToFname { get; set; }
        public string? ShipToMname { get; set; }
        public string? ShipToLname { get; set; }
        public string? ShipToAddress { get; set; }
        public string? ShipToAddress2 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToState { get; set; }
        public string? ShipToZip { get; set; }
        public string? ShipToPhone { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? Extra1 { get; set; }
    }
}
