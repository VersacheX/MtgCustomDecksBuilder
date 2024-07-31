using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class JetReturn
    {
        public JetReturn()
        {
            JetReturnLines = new HashSet<JetReturnLine>();
        }

        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public bool IsMerchantInitiated { get; set; }
        public string ReturnId { get; set; } = null!;
        public string MerchantOrderId { get; set; } = null!;
        public string? ReferenceOrderId { get; set; }
        public string? MerchantReturnAuthorizationId { get; set; }
        public string? ReferenceReturnAuthorizationId { get; set; }
        public bool? RefundWithoutReturn { get; set; }
        public string? ReturnStatus { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string? ShippingCarrier { get; set; }
        public string? TrackingNumber { get; set; }
        public decimal? MerchantReturnCharge { get; set; }
        public bool? JetPickReturnLocation { get; set; }
        public string? RawJson { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? AgreeToReturnCharge { get; set; }
        public string? ReturnChargeFeedback { get; set; }
        public DateTime? CompletedOn { get; set; }

        public virtual ICollection<JetReturnLine> JetReturnLines { get; set; }
    }
}
