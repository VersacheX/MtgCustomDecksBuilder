using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressSortCode
    {
        public short PeriodId { get; set; }
        public short ClassId { get; set; }
        public string SortZip { get; set; } = null!;
        public string SortCode { get; set; } = null!;

        public virtual MailExpressSortCodePeriod Period { get; set; } = null!;
    }
}
