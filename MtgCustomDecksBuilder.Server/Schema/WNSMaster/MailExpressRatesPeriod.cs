using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressRatesPeriod
    {
        public MailExpressRatesPeriod()
        {
            MailExpressRatesParcelSelects = new HashSet<MailExpressRatesParcelSelect>();
            MailExpressRatesPresortedStds = new HashSet<MailExpressRatesPresortedStd>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<MailExpressRatesParcelSelect> MailExpressRatesParcelSelects { get; set; }
        public virtual ICollection<MailExpressRatesPresortedStd> MailExpressRatesPresortedStds { get; set; }
    }
}
