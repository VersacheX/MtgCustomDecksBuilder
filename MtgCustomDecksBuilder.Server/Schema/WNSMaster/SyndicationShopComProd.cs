using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SyndicationShopComProd
    {
        public int DetailId { get; set; }
        public short StorefrontId { get; set; }
        public int ProdId { get; set; }
        public bool Initialize { get; set; }
        public bool Hide { get; set; }
        public string? GroupName { get; set; }
        public string? GroupDescription { get; set; }
        public string? LineItemCode { get; set; }
        public string? LineItemName { get; set; }
        public decimal? Price { get; set; }
        public string? ImageReference { get; set; }
        public string? ADept1 { get; set; }
        public string? ADept2 { get; set; }
        public string? ADept3 { get; set; }
        public string? ADept4 { get; set; }
        public string? ADept5 { get; set; }
        public string? BDept1 { get; set; }
        public string? BDept2 { get; set; }
        public string? BDept3 { get; set; }
        public string? BDept4 { get; set; }
        public string? BDept5 { get; set; }
        public string? CDept1 { get; set; }
        public string? CDept2 { get; set; }
        public string? CDept3 { get; set; }
        public string? CDept4 { get; set; }
        public string? CDept5 { get; set; }
        public string? DDept1 { get; set; }
        public string? DDept2 { get; set; }
        public string? DDept3 { get; set; }
        public string? DDept4 { get; set; }
        public string? DDept5 { get; set; }
        public string? EDept1 { get; set; }
        public string? EDept2 { get; set; }
        public string? EDept3 { get; set; }
        public string? EDept4 { get; set; }
        public string? EDept5 { get; set; }
        public string? Keywords { get; set; }
        public decimal? LineItemSalePrice { get; set; }
        public string? LineItemInventoryStatus { get; set; }
        public string? LineItemTaxable { get; set; }
        public string? LineItemWeight { get; set; }
        public string? Upc { get; set; }
        public string? Brand { get; set; }
        public string? Attribute { get; set; }
        public string? Notes { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
