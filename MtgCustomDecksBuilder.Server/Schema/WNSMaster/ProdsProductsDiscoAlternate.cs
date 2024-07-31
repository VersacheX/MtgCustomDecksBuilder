using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsDiscoAlternate
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public int AlternateProdId { get; set; }
        public int? SortIndex { get; set; }
    }
}
