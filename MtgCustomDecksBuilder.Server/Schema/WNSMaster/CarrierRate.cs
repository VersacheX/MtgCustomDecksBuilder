using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CarrierRate
    {
        public int Id { get; set; }
        public int PeriodId { get; set; }
        public short CountryId { get; set; }
        public byte? ZoneId { get; set; }
        public decimal WeightInOz { get; set; }
        public decimal Rate { get; set; }

        public virtual ShipToCountry Country { get; set; } = null!;
        public virtual CarrierRatePeriod Period { get; set; } = null!;
    }
}
