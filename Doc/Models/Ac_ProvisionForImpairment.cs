using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_ProvisionForImpairment
    {
        public int Id { get; set; }
        public Nullable<int> CardId { get; set; }
        public Nullable<decimal> DevalueReady { get; set; }
        public Nullable<decimal> UsedDevalueReady { get; set; }
        public Nullable<decimal> AfterNetValue { get; set; }
        public Nullable<System.DateTime> BusinessDate { get; set; }
        public Nullable<System.DateTime> OperationDate { get; set; }
        public string ETypeId { get; set; }
        public Nullable<int> FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public int IfRecalculate { get; set; }
        public Nullable<int> BillnumberId { get; set; }
    }
}
