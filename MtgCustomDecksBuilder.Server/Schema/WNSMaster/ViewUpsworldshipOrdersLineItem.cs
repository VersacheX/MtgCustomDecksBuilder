using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ViewUpsworldshipOrdersLineItem
    {
        public int OrderId { get; set; }
        public short InvoiceUnits { get; set; }
        public string DescOfGoods { get; set; } = null!;
        public decimal? SedunitPrice { get; set; }
        public string InvoiceUnitsOfMeasure { get; set; } = null!;
        public string CocountryOfOrigin { get; set; } = null!;
    }
}
