using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class UpsQuantumView
    {
        public UpsQuantumView()
        {
            UpsQuantumViewReferences = new HashSet<UpsQuantumViewReference>();
        }

        public int RecordId { get; set; }
        public int FileId { get; set; }
        public byte RecordTypeId { get; set; }
        public int? ShipmentNum { get; set; }
        public string? ShipperNumber { get; set; }
        public string? TrackingNumber { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? ActLocPoliticalDiv2 { get; set; }
        public string? ActLocPoliticalDiv1 { get; set; }
        public string? ActLocCountryCode { get; set; }
        public string? DelLocConsigneeName { get; set; }
        public string? DelLocStreetNumberLow { get; set; }
        public string? DelLocStreetPrefix { get; set; }
        public string? DelLocStreetName { get; set; }
        public string? DelLocStreetType { get; set; }
        public string? DelLocStreetSuffix { get; set; }
        public string? DelLocPoliticalDiv2 { get; set; }
        public string? DelLocPoliticalDiv1 { get; set; }
        public string? DelLocCountryCode { get; set; }
        public string? DelLocPostcodePrimaryLow { get; set; }
        public string? DelLocResAddressIndicator { get; set; }
        public string? DelLocCode { get; set; }
        public string? DelLocDescription { get; set; }
        public string? SignedForByName { get; set; }
        public string? BillToAccountOption { get; set; }
        public string? BillToAccountNumber { get; set; }
        public string? ShipperName { get; set; }
        public string? ShipperAddressLine1 { get; set; }
        public string? ShipperCity { get; set; }
        public string? ShipperStateProvinceCode { get; set; }
        public string? ShipperPostalCode { get; set; }
        public string? ShipperCountryCode { get; set; }
        public string? ShipToConsigneeName { get; set; }
        public string? ShipToAddressLine1 { get; set; }
        public string? ShipToCity { get; set; }
        public string? ShipToStateProvinceCode { get; set; }
        public string? ShipToPostalCode { get; set; }
        public string? ShipToCountryCode { get; set; }
        public string? ServiceCode { get; set; }
        public string? PickupDate { get; set; }
        public string? ScheduledDeliveryDate { get; set; }
        public string? DocumentsOnly { get; set; }
        public string? ShipmentChargeType { get; set; }
        public string? PackageDimLength { get; set; }
        public string? PackageDimWidth { get; set; }
        public string? PackageDimHeight { get; set; }
        public string? PackageDimUnitCode { get; set; }
        public string? PackageDimWeight { get; set; }
        public string? PackageDimWeightUnitCode { get; set; }
        public string? PackageWeight { get; set; }
        public string? ReasonCode { get; set; }
        public string? ReasonDescription { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusDescription { get; set; }
        public string? ResolutionCode { get; set; }
        public string? ResolutionDescription { get; set; }
        public string? RescheduledDeliveryDate { get; set; }
        public string? RescheduledDeliveryTime { get; set; }
        public string? PackageReferences { get; set; }
        public string? ShipmentReferences { get; set; }
        public DateTime DateImported { get; set; }

        public virtual UpsQuantumViewFile File { get; set; } = null!;
        public virtual ICollection<UpsQuantumViewReference> UpsQuantumViewReferences { get; set; }
    }
}
