namespace MtgCustomDecksBuilder.Server.Models.SearchCriteria
{
    public class OrderSearchCriteria
    {
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public bool? ReadyToProcess { get; set; }
        public int? ProviderOrderRangeFrom { get; set; }
        public int? ProviderOrderRangeTo { get; set; }
        public bool? InProcess { get; set; }
        public int? StoreOrderRangeFrom { get; set; }
        public int? StoreOrderRangeTo { get; set; }
        public bool? Void { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public bool? ReadyForPickup { get; set; }
        public string? Balance { get; set; }
        public string? Email { get; set; }
        public bool? HasRecentOrders { get; set; }
        public string? TrackingNum { get; set; }
        public string? ProcessingType { get; set; }
        public int? MaxRow { get; set; }
        public string? Source { get; set; }
        public int? CarrierId { get; set; }
        public string? Warehouse { get; set; }
        public string? PopupOrder { get; set; }
        public DateTime? FollowUpDate { get; set; }
    }
}
