using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TempJetTax
    {
        public int Id { get; set; }
        public int Month { get; set; }
        public int? Year { get; set; }
        public string ReferenceOrderId { get; set; } = null!;
        public decimal TaxAmount { get; set; }
    }
}
