using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AutoGenReportsProductsNotShownToAllSf
    {
        public int Prodid { get; set; }
        public string? Column1 { get; set; }
        public int? QtyInInventory { get; set; }
        public int? ReportId { get; set; }
    }
}
