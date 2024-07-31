using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class LinkShareTransaction
    {
        public int TransactionId { get; set; }
        public byte StatusId { get; set; }
        public int OrderId { get; set; }
        public string SiteId { get; set; } = null!;
        public DateTime TimeEntered { get; set; }
        public DateTime TimeCompleted { get; set; }
        public string SkuNumber { get; set; } = null!;
        public byte Quantity { get; set; }
        public decimal Amount { get; set; }
        public string? Currency { get; set; }
        public string? Email { get; set; }
        public string? PaymentType { get; set; }
        public string? ZipCode { get; set; }
        public string? ProductName { get; set; }
        public DateTime? LastModified { get; set; }

        public virtual LinkShareTransactionsStatus Status { get; set; } = null!;
    }
}
