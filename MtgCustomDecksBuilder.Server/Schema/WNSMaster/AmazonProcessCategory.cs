using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AmazonProcessCategory
    {
        public AmazonProcessCategory()
        {
            AmazonFeedsProcesses = new HashSet<AmazonFeedsProcess>();
        }

        public byte ProcessCatId { get; set; }
        public string ProcessCatName { get; set; } = null!;

        public virtual ICollection<AmazonFeedsProcess> AmazonFeedsProcesses { get; set; }
    }
}
