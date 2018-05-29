using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_ProfitAndLoss_Detail
    {
        public string STypeId { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> Cid { get; set; }
        public Nullable<int> Ascids { get; set; }
        public string FieldValue { get; set; }
        public Nullable<decimal> FFTotal { get; set; }
        public Nullable<decimal> FFTotalFor { get; set; }
        public Nullable<decimal> FYTotal { get; set; }
        public Nullable<decimal> FYTotalFor { get; set; }
        public string FYear { get; set; }
        public Nullable<int> FPeriod { get; set; }
    }
}
