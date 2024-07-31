using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsRatesFirstClass
    {
        public short PeriodId { get; set; }
        public decimal WeightInOunces { get; set; }
        public decimal Rate { get; set; }
    }
}
