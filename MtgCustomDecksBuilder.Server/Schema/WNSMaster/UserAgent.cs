using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UserAgent
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
