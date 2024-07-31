using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsProductsNotShownToSf
    {
        public int? Prodid { get; set; }
        public string? Column1 { get; set; }
        public int? QtyInInventory { get; set; }
        public string? Discontinued { get; set; }
        public string? DisplayToStorefronts { get; set; }
        public string? ProviderAllowDisplayToPublic { get; set; }
        public string? StorefrontDisplayToPublic { get; set; }
        public int? ReportId { get; set; }
    }
}
