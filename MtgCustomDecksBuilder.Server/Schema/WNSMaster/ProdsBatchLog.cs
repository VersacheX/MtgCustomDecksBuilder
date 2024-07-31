using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsBatchLog
    {
        public int Id { get; set; }
        public int ProdsBatchId { get; set; }
        public short AdminId { get; set; }
        public DateTime StartedOn { get; set; }
        public DateTime? CompletedOn { get; set; }

        public virtual ProdsBatch ProdsBatch { get; set; } = null!;
    }
}
