using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class Currency
    {
        public Currency()
        {
            CurrenciesExchangeRates = new HashSet<CurrenciesExchangeRate>();
            StorefrontInfoMerchantIds = new HashSet<StorefrontInfoMerchantId>();
        }

        public short CurrencyId { get; set; }
        public string IsonumericCode { get; set; } = null!;
        public string IsoalphaCode { get; set; } = null!;
        public string Symbol { get; set; } = null!;
        public decimal MarkupPercent { get; set; }
        public byte DecimalPlaces { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<CurrenciesExchangeRate> CurrenciesExchangeRates { get; set; }
        public virtual ICollection<StorefrontInfoMerchantId> StorefrontInfoMerchantIds { get; set; }
    }
}
