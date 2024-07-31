using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingMailExpressBilling
    {
        public int DetailId { get; set; }
        public int? ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? PackageId { get; set; }
        public int? MailExpressNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? Address { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        public byte? Zone { get; set; }
        public string? DeliveryConfirmation { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Cost { get; set; }
        public string? Reason { get; set; }
        public decimal? TotalChargesToStorefront { get; set; }

        public virtual OrdersProviderShippingMailExpressBillingImport? Import { get; set; }
    }
}
