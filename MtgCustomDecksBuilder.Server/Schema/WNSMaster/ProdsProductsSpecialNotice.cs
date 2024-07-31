using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsProductsSpecialNotice
    {
        public int Id { get; set; }
        public int ProdId { get; set; }
        public short NoticeId { get; set; }
    }
}
