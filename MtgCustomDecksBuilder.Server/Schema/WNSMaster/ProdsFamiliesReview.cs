using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class ProdsFamiliesReview
    {
        public int ReviewId { get; set; }
        public int FamId { get; set; }
        public DateTime DateAndTime { get; set; }
        public short? ApprovedBySfadminId { get; set; }
        public byte? RequiredEditing { get; set; }
        public int ReviewerAccountId { get; set; }
        public byte ProductRating { get; set; }
        public string? Summary { get; set; }
        public string Details { get; set; } = null!;
        public int? ReviewFoundHelpful { get; set; }
        public int? ReviewFoundNotHelpful { get; set; }
        public string? ModeratorComments { get; set; }
        public short? RejectedBySfadminId { get; set; }
        public bool? PurchasedProdInFamily { get; set; }
        public DateTime LastModified { get; set; }
    }
}
