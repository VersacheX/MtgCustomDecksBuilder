using System;
using System.Collections.Generic;

namespace MtgCustomDecksBuilder.Server.Schema.WNSMaster
{
    public partial class TransferOrder
    {
        public TransferOrder()
        {
            TransferOrdersLineItems = new HashSet<TransferOrdersLineItem>();
        }

        public int Tonum { get; set; }
        public short FromWrhsId { get; set; }
        public short ToWrhsId { get; set; }
        public DateTime DatePlaced { get; set; }
        public DateTime? EstimatedReceiveDate { get; set; }
        public DateTime? DateShipped { get; set; }
        public short? ShippedByAdminId { get; set; }
        public DateTime? ReceiveSignOffDate { get; set; }
        public short? ReceiveSignOffByAdminId { get; set; }
        public string? Notes { get; set; }

        public virtual AdminsProvider? ReceiveSignOffByAdmin { get; set; }
        public virtual AdminsProvider? ShippedByAdmin { get; set; }
        public virtual ICollection<TransferOrdersLineItem> TransferOrdersLineItems { get; set; }
    }
}
