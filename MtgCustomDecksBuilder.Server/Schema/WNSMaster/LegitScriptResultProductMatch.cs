using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class LegitScriptResultProductMatch
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public string? Manufacturer { get; set; }
        public string ResultTerm { get; set; } = null!;
        public int MatchType { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
