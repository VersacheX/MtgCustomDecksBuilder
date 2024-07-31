using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersRefillRemindersV2
    {
        public int RefillId { get; set; }
        public int ProviderOrderId { get; set; }
        public byte PosNum { get; set; }
        public DateTime? SendDate { get; set; }
        public DateTime? SentDate { get; set; }
        public string? EmailId { get; set; }
        public byte? StatusCode { get; set; }
        public DateTime? LastModified { get; set; }

        public virtual OrdersRefillRemindersStatus? StatusCodeNavigation { get; set; }
    }
}
