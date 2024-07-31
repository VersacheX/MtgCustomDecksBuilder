using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AffiliatesStatus
    {
        public AffiliatesStatus()
        {
            Affiliates = new HashSet<Affiliate>();
        }

        public short StatusId { get; set; }
        public string StatusDesc { get; set; } = null!;

        public virtual ICollection<Affiliate> Affiliates { get; set; }
    }
}
