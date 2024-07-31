using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CarrierRatePeriod
    {
        public CarrierRatePeriod()
        {
            CarrierRates = new HashSet<CarrierRate>();
        }

        public int Id { get; set; }
        public byte CandCid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual CarriersAndClass CandC { get; set; } = null!;
        public virtual ICollection<CarrierRate> CarrierRates { get; set; }
    }
}
