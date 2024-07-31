using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsBatchType
    {
        public ProdsBatchType()
        {
            ProdsBatches = new HashSet<ProdsBatch>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<ProdsBatch> ProdsBatches { get; set; }
    }
}
