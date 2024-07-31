using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempCaseQtyEntry
    {
        public int ProdId { get; set; }
        public string Upc { get; set; } = null!;
        public string? ProdName { get; set; }
        public decimal? UnitNumber { get; set; }
        public string? UnitTypeName { get; set; }
        public short? CaseQuantity { get; set; }
    }
}
