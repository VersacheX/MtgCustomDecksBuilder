using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlGlobalMailRatesPeriod
    {
        public DhlGlobalMailRatesPeriod()
        {
            DhlGlobalMailRatesPacketPriorityDdus = new HashSet<DhlGlobalMailRatesPacketPriorityDdu>();
            DhlGlobalMailRatesParcelPriorityDdus = new HashSet<DhlGlobalMailRatesParcelPriorityDdu>();
            DhlGlobalMailRatesParcelPriorityV2s = new HashSet<DhlGlobalMailRatesParcelPriorityV2>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<DhlGlobalMailRatesPacketPriorityDdu> DhlGlobalMailRatesPacketPriorityDdus { get; set; }
        public virtual ICollection<DhlGlobalMailRatesParcelPriorityDdu> DhlGlobalMailRatesParcelPriorityDdus { get; set; }
        public virtual ICollection<DhlGlobalMailRatesParcelPriorityV2> DhlGlobalMailRatesParcelPriorityV2s { get; set; }
    }
}
