using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class VelocityBoostRange
    {
        public int FromVel { get; set; }
        public int ToVel { get; set; }
        public int Boost { get; set; }
    }
}
