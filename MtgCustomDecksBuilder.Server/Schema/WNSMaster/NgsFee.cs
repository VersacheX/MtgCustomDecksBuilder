using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class NgsFee
    {
        public byte PeriodId { get; set; }
        public string CarrierId { get; set; } = null!;
        public string FeeCode { get; set; } = null!;
        public decimal FeeAmount { get; set; }
    }
}
