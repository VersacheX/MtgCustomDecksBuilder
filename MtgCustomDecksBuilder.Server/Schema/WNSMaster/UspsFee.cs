using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsFee
    {
        public short FeeId { get; set; }
        public byte CarrierId { get; set; }
        public string ServiceTypeCode { get; set; } = null!;
        public string FeeCode { get; set; } = null!;
        public DateTime FeeStartDate { get; set; }
        public DateTime FeeEndDate { get; set; }
        public decimal FeeAmount { get; set; }

        public virtual CarriersAndClass Carrier { get; set; } = null!;
    }
}
