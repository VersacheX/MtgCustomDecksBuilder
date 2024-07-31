using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class DhlRatesPeriod
    {
        public DhlRatesPeriod()
        {
            DhlRatesParcelPlusExpediteds = new HashSet<DhlRatesParcelPlusExpedited>();
            DhlRatesParcelPlusGrounds = new HashSet<DhlRatesParcelPlusGround>();
            DhlRatesSmartMailExpediteds = new HashSet<DhlRatesSmartMailExpedited>();
            DhlRatesSmartMailGrounds = new HashSet<DhlRatesSmartMailGround>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<DhlRatesParcelPlusExpedited> DhlRatesParcelPlusExpediteds { get; set; }
        public virtual ICollection<DhlRatesParcelPlusGround> DhlRatesParcelPlusGrounds { get; set; }
        public virtual ICollection<DhlRatesSmartMailExpedited> DhlRatesSmartMailExpediteds { get; set; }
        public virtual ICollection<DhlRatesSmartMailGround> DhlRatesSmartMailGrounds { get; set; }
    }
}
