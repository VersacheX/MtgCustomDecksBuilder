using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersAutoCaptureUserAccount
    {
        public int Id { get; set; }
        public short StorefrontId { get; set; }
        public int? AccountId { get; set; }
        public string? BillToEmail { get; set; }
        public string? MaskedCcnumber { get; set; }
        public bool? IsArchived { get; set; }
    }
}
