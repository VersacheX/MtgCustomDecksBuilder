using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class StorefrontCustomerMessage
    {
        public int Uniquefier { get; set; }
        public short StorefrontId { get; set; }
        public string MessageLabel { get; set; } = null!;
        public string MessageText { get; set; } = null!;
        public bool SendConsumerEmail { get; set; }
        public bool SendStorefrontEmail { get; set; }
        public bool AddNoteToInvoice { get; set; }
        public bool ShowSubstitutes { get; set; }
        public bool IsActive { get; set; }
        public byte SortOrder { get; set; }
        public bool? ShowOnSfcommPage { get; set; }
        public bool? ShowOnWrhsPendingPage { get; set; }
        public bool? ShowOnWrhsOrderDetailsPage { get; set; }
    }
}
