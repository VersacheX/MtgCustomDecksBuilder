using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ViewUpsShipmentCostsByWarehouse
    {
        public int ProviderOrderId { get; set; }
        public decimal? Weight { get; set; }
        public byte? Cazone { get; set; }
        public byte? CatransitTime { get; set; }
        public decimal? Cacost { get; set; }
        public byte? Nczone { get; set; }
        public byte? NctransitTime { get; set; }
        public decimal? Nccost { get; set; }
    }
}
