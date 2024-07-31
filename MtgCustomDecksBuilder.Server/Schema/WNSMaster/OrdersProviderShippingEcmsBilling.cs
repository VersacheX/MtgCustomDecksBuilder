using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingEcmsBilling
    {
        public int DetailId { get; set; }
        public int? ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? AcctPeriod { get; set; }
        public string? Customer { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? AmountDueUsd { get; set; }
        public string? TrackingNo { get; set; }
        public string? ReferenceNo { get; set; }
        public string? FromPort { get; set; }
        public string? ToPort { get; set; }
        public DateTime? ShippingDate { get; set; }
        public string? Mawbno { get; set; }
        public decimal? GrossWeightLb { get; set; }
        public decimal? ChargeableWeightLb { get; set; }
        public decimal? VolumeWeightLb { get; set; }

        public virtual OrdersProviderShippingEcmsBillingImport? Import { get; set; }
    }
}
