using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsDictionary
    {
        public int Id { get; set; }
        public string Word { get; set; } = null!;
    }
}
