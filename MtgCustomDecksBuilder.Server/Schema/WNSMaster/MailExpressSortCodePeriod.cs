using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressSortCodePeriod
    {
        public MailExpressSortCodePeriod()
        {
            MailExpressSortCodes = new HashSet<MailExpressSortCode>();
        }

        public short PeriodId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<MailExpressSortCode> MailExpressSortCodes { get; set; }
    }
}
