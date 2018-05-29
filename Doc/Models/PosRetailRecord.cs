using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosRetailRecord
    {
        public int Id { get; set; }
        public int PosSaleBillId { get; set; }
        public int PosBillNumberId { get; set; }
        public int RetailBillId { get; set; }
        public decimal RetailBillNumberId { get; set; }
        public byte AuditingFlag { get; set; }
        public Nullable<System.DateTime> RecordTime { get; set; }
    }
}
