using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AmazonFeedsProcess
    {
        public int ProcessId { get; set; }
        public byte ProcessCatId { get; set; }
        public short ProcessTypeId { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateLastChecked { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string? DocId { get; set; }
        public DateTime? DateErrored { get; set; }
        public string? ErrorMsg { get; set; }
        public string? Notes { get; set; }

        public virtual AmazonProcessCategory ProcessCat { get; set; } = null!;
        public virtual AmazonProcessType ProcessType { get; set; } = null!;
    }
}
