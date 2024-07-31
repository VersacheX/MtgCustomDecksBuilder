using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UspsScanFileEvent
    {
        public long Id { get; set; }
        public int ScanFileId { get; set; }
        public string? FileVersion { get; set; }
        public string? TrackingNumber { get; set; }
        public string? ElectronicFileNumber { get; set; }
        public string? MailerId { get; set; }
        public string? MailerName { get; set; }
        public string? DestinationZip { get; set; }
        public string? DestinationZip4 { get; set; }
        public string? ScanningFacilityZip { get; set; }
        public string? ScanningFacilityName { get; set; }
        public string? EventCode { get; set; }
        public string? EventName { get; set; }
        public string? EventDate { get; set; }
        public string? EventTime { get; set; }
        public string? MailOwnerMailerId { get; set; }
        public string? CustomerReferenceNumber { get; set; }
        public string? DestinationCountryCode { get; set; }
        public string? RecipientName { get; set; }
        public string? OriginalLabel { get; set; }
        public string? UnitOfMeasureCode { get; set; }
        public string? Weight { get; set; }
        public string? GuaranteedDeliveryDate { get; set; }
        public string? GuaranteedDeliveryTime { get; set; }
        public string? LogisticsManagerMailerId { get; set; }
        public DateTime CreatedOn { get; set; }

        public virtual UspsScanFile ScanFile { get; set; } = null!;
    }
}
