using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderWholesalePaymentsCreditMemoLineItem
    {
        public int Uniquefier { get; set; }
        public int PaymentId { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; } = null!;
        public decimal UnitAmount { get; set; }

        public virtual OrdersProviderWholesalePayment Payment { get; set; } = null!;
    }
}
