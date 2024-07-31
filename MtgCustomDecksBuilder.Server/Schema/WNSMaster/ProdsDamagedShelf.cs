using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsDamagedShelf
    {
        public int Id { get; set; }
        public int Qty { get; set; }
        public string Upc { get; set; } = null!;
        public string? ExpDate { get; set; }
        public string? Defect { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
    }
}
