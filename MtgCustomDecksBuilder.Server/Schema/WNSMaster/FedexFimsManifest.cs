using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class FedexFimsManifest
    {
        public int ManifestId { get; set; }
        public int SettingId { get; set; }
        public short AdminId { get; set; }
        public decimal? TotalWeightInOzStd { get; set; }
        public int? TotalPiecesStd { get; set; }
        public decimal? TotalCostStd { get; set; }
        public decimal? TotalWeightInOzPrm { get; set; }
        public int? TotalPiecesPrm { get; set; }
        public decimal? TotalCostPrm { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual FedexFimsShippingSetting Setting { get; set; } = null!;
    }
}
