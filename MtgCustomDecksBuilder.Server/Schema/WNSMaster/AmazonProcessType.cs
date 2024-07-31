using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AmazonProcessType
    {
        public AmazonProcessType()
        {
            AmazonFeedsProcesses = new HashSet<AmazonFeedsProcess>();
        }

        public short ProcessTypeId { get; set; }
        public string ProcessTypeName { get; set; } = null!;

        public virtual ICollection<AmazonFeedsProcess> AmazonFeedsProcesses { get; set; }
    }
}
