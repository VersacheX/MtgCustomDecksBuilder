using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class PaymentechSubmission
    {
        public int RecordId { get; set; }
        public int ProviderOrderId { get; set; }
        public DateTime? AuthDate { get; set; }
        public string? AuthCode { get; set; }
        public string? ActionCode { get; set; }
        public decimal? DepositAmount { get; set; }
        public int? SubmissionRecordNum { get; set; }
        public string? SubmissionNumber { get; set; }
        public DateTime? SubmissionDate { get; set; }
    }
}
