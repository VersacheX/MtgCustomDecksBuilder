using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontProdInfoChangeLog
    {
        public long ProdInfoLogId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public short? ProviderAdminId { get; set; }
        public short? StorefrontAdminId { get; set; }
        public decimal NewPriceToStorefront { get; set; }
        public bool NewDisplayToStorefront { get; set; }
        public bool NewProviderAllowDisplayToPublic { get; set; }
        public bool NewStorefrontDisplayToPublic { get; set; }
        public decimal NewStdPubPrice { get; set; }
        public decimal NewCurPubPrice { get; set; }
        public decimal? NewMinAdvertisedPrice { get; set; }
        public decimal OldPriceToStorefront { get; set; }
        public bool OldDisplayToStorefront { get; set; }
        public bool OldProviderAllowDisplayToPublic { get; set; }
        public bool OldStorefrontDisplayToPublic { get; set; }
        public decimal OldStdPubPrice { get; set; }
        public decimal OldCurPubPrice { get; set; }
        public decimal? OldMinAdvertisedPrice { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string? Notes { get; set; }

        public virtual ProdsProduct Prod { get; set; } = null!;
        public virtual AdminsProvider? ProviderAdmin { get; set; }
        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual AdminsStorefront? StorefrontAdmin { get; set; }
    }
}
