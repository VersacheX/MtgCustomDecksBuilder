using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class WorkingTableProdsToPurchase
    {
        public short AdminId { get; set; }
        public int ProdId { get; set; }
        public short WrhsId { get; set; }
        public DateTime DateTimeInserted { get; set; }
        public bool Processed { get; set; }
        public bool Cancelled { get; set; }
        public int? StartOrderId { get; set; }
        public int? EndOrderId { get; set; }
        public int? MaxInvWeeks { get; set; }
        public int? CurrentInventory { get; set; }
        public int? InPobutnotinInventory { get; set; }
        public int? AwaitingPacking { get; set; }
        public int? OrderedInRange { get; set; }
        public int? OrderedButNotReadyToProcess { get; set; }
        public int? Vel4wk { get; set; }
        public int? Vel12wk { get; set; }
        public decimal? ConfidenceFactor4wk { get; set; }
        public string? SavedFormValueQty { get; set; }
        public string? SavedFormValuePonum { get; set; }
    }
}
