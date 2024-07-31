using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class AuthNetCommLog
    {
        public Guid Uniquefier { get; set; }
        public string? OrderId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OrderAmount { get; set; }
        public string? Ccrequest { get; set; }
        public string? Ccresponse { get; set; }
        public string? Ccexp { get; set; }
        public string? Email { get; set; }
        public DateTime TimeSaved { get; set; }
        public byte[]? CcnumberEnc { get; set; }
    }
}
