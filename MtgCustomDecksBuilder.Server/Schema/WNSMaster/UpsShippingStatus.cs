using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsShippingStatus
    {
        public int ProviderOrderId { get; set; }
        public byte StepId { get; set; }
        public string? StepDesc { get; set; }
        public string? Xml { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
