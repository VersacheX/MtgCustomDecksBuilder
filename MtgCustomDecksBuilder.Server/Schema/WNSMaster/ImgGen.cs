using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ImgGen
    {
        public int ImgId { get; set; }
        public int? NumberNew { get; set; }
        public int? NumberDelete { get; set; }
        public int? NumberReplace { get; set; }
    }
}
