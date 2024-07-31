using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProduct
    {
        public ProdsProduct()
        {
            BinProdRelationships = new HashSet<BinProdRelationship>();
            CartsLineItems = new HashSet<CartsLineItem>();
            GroupsDiscountsProdOverrides = new HashSet<GroupsDiscountsProdOverride>();
            OrdersProviderLineItemsOutOfStocks = new HashSet<OrdersProviderLineItemsOutOfStock>();
            ProdsProductsAvailabilities = new HashSet<ProdsProductsAvailability>();
            ProdsProductsInStockNotifications = new HashSet<ProdsProductsInStockNotification>();
            ProdsProductsProp65Logs = new HashSet<ProdsProductsProp65Log>();
            ProdsSamplesProdsRelationships = new HashSet<ProdsSamplesProdsRelationship>();
            ReturnsShelves = new HashSet<ReturnsShelf>();
            StorefrontProdInfoChangeLogs = new HashSet<StorefrontProdInfoChangeLog>();
        }

        public int ProdId { get; set; }
        public int FamId { get; set; }
        public string? ProdId2 { get; set; }
        public string Upc { get; set; } = null!;
        public string? PicFileName { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? UnitNumber { get; set; }
        public short? UnitTypeId { get; set; }
        public decimal Msrp { get; set; }
        public decimal StdCostToProvider { get; set; }
        public decimal? ServingSize { get; set; }
        public decimal? ServingsPerContainer { get; set; }
        public short? CaseQuantity { get; set; }
        public string? ManagementNotes { get; set; }
        public bool Discontinued { get; set; }
        public bool DisplayToStorefronts { get; set; }
        public int? MinLevel { get; set; }
        public int? MaxLevel { get; set; }
        public bool? StopRestocking { get; set; }
        public bool? UnusualVelocityExpected { get; set; }
        public bool? IsBundleLocked { get; set; }
        public bool? CantShipInEnvelope { get; set; }
        public bool? DontAutoDisplayToNewStorefronts { get; set; }
        public DateTime DescLastUpdated { get; set; }
        public DateTime? UnusualVelocityRemovalDate { get; set; }
        public short? ForceRoutingToWrhs { get; set; }
        public short? RestockLessThanDaysCa { get; set; }
        public short? RestockToDaysCa { get; set; }
        public short? RestockLessThanDaysNc { get; set; }
        public short? RestockToDaysNc { get; set; }
        public DateTime? DateProdCreated { get; set; }
        public DateTime? DiscontinuedDate { get; set; }
        public string? SpellingVerified { get; set; }
        public DateTime? PictureVerified { get; set; }
        public decimal? Length { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public short? CountryOfOriginId { get; set; }
        public byte? AccountingSalesClassId { get; set; }
        public decimal? EconomyShippingCost { get; set; }
        public decimal? StandardShippingCost { get; set; }
        public decimal? EstimatedShippingWeightOz { get; set; }
        public decimal? ActualShippingWeightOz { get; set; }
        public bool? IsGiftCard { get; set; }
        public string? UnusualVelocityReason { get; set; }
        public int? NormalVelocity30DaysCa { get; set; }
        public int? NormalVelocity30DaysNc { get; set; }
        public bool? ApplyProp65Sticker { get; set; }

        public virtual ShipToCountry? CountryOfOrigin { get; set; }
        public virtual ProdsFamily Fam { get; set; } = null!;
        public virtual ICollection<BinProdRelationship> BinProdRelationships { get; set; }
        public virtual ICollection<CartsLineItem> CartsLineItems { get; set; }
        public virtual ICollection<GroupsDiscountsProdOverride> GroupsDiscountsProdOverrides { get; set; }
        public virtual ICollection<OrdersProviderLineItemsOutOfStock> OrdersProviderLineItemsOutOfStocks { get; set; }
        public virtual ICollection<ProdsProductsAvailability> ProdsProductsAvailabilities { get; set; }
        public virtual ICollection<ProdsProductsInStockNotification> ProdsProductsInStockNotifications { get; set; }
        public virtual ICollection<ProdsProductsProp65Log> ProdsProductsProp65Logs { get; set; }
        public virtual ICollection<ProdsSamplesProdsRelationship> ProdsSamplesProdsRelationships { get; set; }
        public virtual ICollection<ReturnsShelf> ReturnsShelves { get; set; }
        public virtual ICollection<StorefrontProdInfoChangeLog> StorefrontProdInfoChangeLogs { get; set; }
    }
}
