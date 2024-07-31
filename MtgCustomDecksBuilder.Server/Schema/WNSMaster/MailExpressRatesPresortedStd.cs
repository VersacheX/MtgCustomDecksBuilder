using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressRatesPresortedStd
    {
        public short PeriodId { get; set; }
        public byte WeightInOunces { get; set; }
        public decimal Rate { get; set; }

        public virtual MailExpressRatesPeriod Period { get; set; } = null!;
    }
}
