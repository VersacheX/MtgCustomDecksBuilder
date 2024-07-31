using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingClaim
    {
        public OrdersProviderShippingClaim()
        {
            OrdersProviderShippingClaimsNotes = new HashSet<OrdersProviderShippingClaimsNote>();
        }

        public int ClaimId { get; set; }
        public int ShipmentNum { get; set; }
        public byte ClaimStatusId { get; set; }
        public byte ClaimReasonId { get; set; }
        public short? SfadminId { get; set; }
        public short? AdminId { get; set; }
        public short? ProviderId { get; set; }
        public string? ClaimReferenceNum { get; set; }
        public decimal? AmountClaimed { get; set; }
        public decimal? AmountLost { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? RefundToDropshipper { get; set; }
        public DateTime? FollowUpOn { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual OrdersProviderShippingClaimsReason ClaimReason { get; set; } = null!;
        public virtual OrdersProviderShippingClaimsStatus ClaimStatus { get; set; } = null!;
        public virtual OrdersProviderShipping ShipmentNumNavigation { get; set; } = null!;
        public virtual ICollection<OrdersProviderShippingClaimsNote> OrdersProviderShippingClaimsNotes { get; set; }
    }
}
