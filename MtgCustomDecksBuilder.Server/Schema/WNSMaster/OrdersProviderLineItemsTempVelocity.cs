using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderLineItemsTempVelocity
    {
        public int RowId { get; set; }
        public int ProviderOrderId { get; set; }
        public DateTime DateTimeOrderPlaced { get; set; }
        public short StorefrontId { get; set; }
        public string ShipToZip { get; set; } = null!;
        public short ShipToCountryId { get; set; }
        public int ProdId { get; set; }
        public short Qty { get; set; }
        public short WrhsIdassignedTo { get; set; }
        public byte? ProcessingType { get; set; }
    }
}
