using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ViewProductsEnglishAsh
    {
        public int ProdId { get; set; }
        public string? ProdId2 { get; set; }
        public int FamId { get; set; }
        public short BrandId { get; set; }
        public string BrandName { get; set; } = null!;
        public string FamName { get; set; } = null!;
        public string? FamNameSuffix { get; set; }
        public decimal? UnitNumber { get; set; }
        public string? UnitTypeName { get; set; }
        public string? FullProdName { get; set; }
        public string? BrandName2 { get; set; }
        public string? FamName2 { get; set; }
        public string? FamNameSuffix2 { get; set; }
        public decimal? UnitNumber2 { get; set; }
        public string? UnitTypeName2 { get; set; }
        public string? FullProdName2 { get; set; }
        public decimal Msrp { get; set; }
        public decimal StdCostToProvider { get; set; }
        public string Upc { get; set; } = null!;
        public string? ProdPicFileName { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? ServingSize { get; set; }
        public decimal? ServingsPerContainer { get; set; }
        public short? CaseQuantity { get; set; }
        public string? ManagementNotes { get; set; }
        public bool Discontinued { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public bool DisplayToStorefronts { get; set; }
        public bool? StopRestocking { get; set; }
        public bool? UnusualVelocityExpected { get; set; }
        public bool? IsBundleLocked { get; set; }
        public bool? CantShipInEnvelope { get; set; }
        public bool? DontAutoDisplayToNewStorefronts { get; set; }
        public DateTime DescLastUpdated { get; set; }
        public short? StorefrontId { get; set; }
        public string? FamPicFileName { get; set; }
        public bool TaxableCa { get; set; }
        public string? MfgDesc { get; set; }
        public string? MfgDirections { get; set; }
        public string? MfgFactNotes { get; set; }
        public string? MfgDisclaimer { get; set; }
        public string? MfgIngredients { get; set; }
        public string? DescMarkerInfo { get; set; }
        public string BrandAbbrev { get; set; } = null!;
        public string BrandLogoUrl { get; set; } = null!;
        public string? ShortFamDesc { get; set; }
        public string? DetailedFamDesc { get; set; }
        public string? ServingUnit { get; set; }
        public string? ShortProdDesc { get; set; }
        public string? DetailedProdDesc { get; set; }
        public string? PopupNoteToConsumer { get; set; }
        public bool? IsGiftCard { get; set; }
    }
}
