using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OrdersAutoCaptureCondition
    {
        public int CondId { get; set; }
        public short StorefrontId { get; set; }
        public string? Description { get; set; }
        public short? SortIndex { get; set; }
        public decimal? MaxOrderAmount { get; set; }
        public byte? MaxNumOfPrevAttempts { get; set; }
        public string? ValidAvscodes { get; set; }
        public string? ValidCvvcodes { get; set; }
        public bool? ShipBillAddrMustMatch { get; set; }
        public byte? DatedOrders { get; set; }
        public byte? RecentOrders { get; set; }
        public string? ValidShipMethodIds { get; set; }
        public bool? CheckFpoapo { get; set; }
        public bool? AddInsurance { get; set; }
        public bool? AllowGiftCertificates { get; set; }
        public bool? IsArchived { get; set; }
    }
}
