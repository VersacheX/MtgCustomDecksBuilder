using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsInStockNotification
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public short StorefrontId { get; set; }
        public string EmailAddress { get; set; } = null!;
        public string? CartId { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? SentOn { get; set; }
        public DateTime? ScheduledOn { get; set; }

        public virtual ProdsProduct Prod { get; set; } = null!;
        public virtual StorefrontInfo Storefront { get; set; } = null!;
    }
}
