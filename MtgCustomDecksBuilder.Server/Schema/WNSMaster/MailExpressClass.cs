using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MailExpressClass
    {
        public short ClassId { get; set; }
        public string ClassName { get; set; } = null!;
        public string ClassCode { get; set; } = null!;
        public string? ServiceTypeCode { get; set; }
        public decimal LowerBoundWeightInOunces { get; set; }
        public decimal UpperBoundWeightInOunces { get; set; }
        public decimal DeliveryConfirmationFee { get; set; }
    }
}
