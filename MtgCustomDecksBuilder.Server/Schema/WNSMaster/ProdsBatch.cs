using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsBatch
    {
        public ProdsBatch()
        {
            ProdsBatchLogs = new HashSet<ProdsBatchLog>();
        }

        public int Id { get; set; }
        public int ProdsBatchTypeId { get; set; }
        public int? TotalSkus { get; set; }
        public int? TotalUnits { get; set; }
        public decimal? TotalWeightInLbs { get; set; }
        public int? TotalBins { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? OrdersBatchesPrintingId { get; set; }

        public virtual ProdsBatchType ProdsBatchType { get; set; } = null!;
        public virtual ICollection<ProdsBatchLog> ProdsBatchLogs { get; set; }
    }
}
