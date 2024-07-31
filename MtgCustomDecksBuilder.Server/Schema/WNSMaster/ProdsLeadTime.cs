using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsLeadTime
    {
        public int ProdId { get; set; }
        public short WrhsId { get; set; }
        public short? LeadTimeInDays { get; set; }
    }
}
