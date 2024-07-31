using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsSamplesInbound
    {
        public int RowId { get; set; }
        public int SampleId { get; set; }
        public short WrhsId { get; set; }
        public DateTime? DateExpected { get; set; }
        public DateTime? DateReceived { get; set; }
        public int? QtyExpected { get; set; }
        public int? QtyReceived { get; set; }
        public string? Notes { get; set; }

        public virtual ProdsSample Sample { get; set; } = null!;
        public virtual Warehouse Wrhs { get; set; } = null!;
    }
}
