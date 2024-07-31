using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class MarketingDealOfTheDay
    {
        public MarketingDealOfTheDay()
        {
            MarketingDealOfTheDayProds = new HashSet<MarketingDealOfTheDayProd>();
        }

        public int DealId { get; set; }
        public short StorefrontId { get; set; }
        public string DealName { get; set; } = null!;
        public DateTime StartDateTime { get; set; }
        public DateTime? ActualStartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public DateTime? ActualEndDateTime { get; set; }
        public string? DealDescription { get; set; }
        public DateTime CreatedOnDateTime { get; set; }

        public virtual StorefrontInfo Storefront { get; set; } = null!;
        public virtual ICollection<MarketingDealOfTheDayProd> MarketingDealOfTheDayProds { get; set; }
    }
}
