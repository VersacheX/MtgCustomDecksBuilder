using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsQuantumViewReference
    {
        public int ReferenceId { get; set; }
        public byte ReferenceTypeId { get; set; }
        public int RecordId { get; set; }
        public string? Code { get; set; }
        public string? Value { get; set; }

        public virtual UpsQuantumView Record { get; set; } = null!;
    }
}
