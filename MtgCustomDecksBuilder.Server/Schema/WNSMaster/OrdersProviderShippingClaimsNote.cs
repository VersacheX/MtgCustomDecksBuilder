using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingClaimsNote
    {
        public int NoteId { get; set; }
        public int ClaimId { get; set; }
        public short? SfadminId { get; set; }
        public short? AdminId { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual OrdersProviderShippingClaim Claim { get; set; } = null!;
    }
}
