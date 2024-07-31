using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsManifest
    {
        public int ManifestId { get; set; }
        public byte UspsAccountSettingId { get; set; }
        public short AdminId { get; set; }
        public decimal? DelivConfFeePm { get; set; }
        public short? TotalPiecesPm { get; set; }
        public decimal? TotalWeightPm { get; set; }
        public decimal? TotalDelivConfPostagePm { get; set; }
        public short? TotalInsuredPiecesPm { get; set; }
        public decimal? TotalInsurancePm { get; set; }
        public decimal? TotalPiecesPostagePm { get; set; }
        public decimal? TotalPostagePm { get; set; }
        public decimal? DelivConfFeeFc { get; set; }
        public short? TotalPiecesFc { get; set; }
        public decimal? TotalWeightFc { get; set; }
        public decimal? TotalDelivConfPostageFc { get; set; }
        public short? TotalInsuredPiecesFc { get; set; }
        public decimal? TotalInsuranceFc { get; set; }
        public decimal? TotalPiecesPostageFc { get; set; }
        public decimal? TotalPostageFc { get; set; }
        public DateTime? FileUploadDate { get; set; }
        public DateTime DateAndTime { get; set; }
        public string? Ssfid { get; set; }
    }
}
