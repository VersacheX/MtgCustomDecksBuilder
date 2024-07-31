using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class OnTracZipCodesOld
    {
        public string? ZipCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PickupService { get; set; }
        public string? SunriseGoldDeliveryTime { get; set; }
        public string? SunriseDeliveryTime { get; set; }
        public string? SaturdayDelivery { get; set; }
        public string? SaturdaySunriseGoldDeliveryTime { get; set; }
        public string? SaturdaySunriseDeliveryTime { get; set; }
        public string? HeavyweightService { get; set; }
        public int? UnknownColumn { get; set; }
    }
}
