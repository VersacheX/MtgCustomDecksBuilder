using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontInfoXmlmessageAccess
    {
        public short StorefrontId { get; set; }
        public string XmlmessageId { get; set; } = null!;
    }
}
