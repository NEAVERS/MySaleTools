using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_DepreciationAlteration
    {
        public int Id { get; set; }
        public Nullable<int> CardId { get; set; }
        public Nullable<decimal> OldNetSalvage { get; set; }
        public Nullable<decimal> NetSalvage { get; set; }
        public Nullable<decimal> OldNetSalvageRate { get; set; }
        public Nullable<decimal> NetSalvageRate { get; set; }
        public Nullable<int> OldDepreciationMean { get; set; }
        public Nullable<int> DepreciationMean { get; set; }
        public Nullable<int> OldDurYear { get; set; }
        public Nullable<int> DurYear { get; set; }
        public Nullable<System.DateTime> BusinessDate { get; set; }
        public Nullable<System.DateTime> OperationDate { get; set; }
        public string ETypeId { get; set; }
        public int durmonth { get; set; }
        public Nullable<decimal> ExpectWork { get; set; }
        public Nullable<decimal> OldExpectWork { get; set; }
        public Nullable<decimal> FinishWork { get; set; }
        public Nullable<decimal> OldFinishWork { get; set; }
        public string WorkUnit { get; set; }
        public string OldWorkUnit { get; set; }
    }
}
