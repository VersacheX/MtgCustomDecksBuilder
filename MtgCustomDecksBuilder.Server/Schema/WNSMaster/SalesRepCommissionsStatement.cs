using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class SalesRepCommissionsStatement
    {
        public int StatementId { get; set; }
        public short ProviderId { get; set; }
        public short AdminId { get; set; }
        public bool IsClosed { get; set; }
        public DateTime StatementDate { get; set; }
        public decimal StatementAmount { get; set; }
        public string? StatementNotes { get; set; }
    }
}
