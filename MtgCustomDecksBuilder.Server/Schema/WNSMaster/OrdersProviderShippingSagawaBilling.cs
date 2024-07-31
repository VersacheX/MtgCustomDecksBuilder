using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersProviderShippingSagawaBilling
    {
        public int DetailId { get; set; }
        public int? ImportId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? ReferenceNum { get; set; }
        public int? Pcs { get; set; }
        public decimal? WeightInKgs { get; set; }
        public string? Product { get; set; }
        public string? ConsigneeName { get; set; }
        public decimal? ValueJpy { get; set; }
        public decimal? Rate { get; set; }

        public virtual OrdersProviderShippingSagawaBillingImport? Import { get; set; }
    }
}
