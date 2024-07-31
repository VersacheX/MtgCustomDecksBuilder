using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class CurrenciesExchangeRate
    {
        public int RateId { get; set; }
        public short CurrencyId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Rate { get; set; }
        public decimal? MarkupPercent { get; set; }

        public virtual Currency Currency { get; set; } = null!;
    }
}
