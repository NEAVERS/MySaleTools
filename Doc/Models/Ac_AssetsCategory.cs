using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_AssetsCategory
    {
        public int Id { get; set; }
        public string StypeId { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Units { get; set; }
        public Nullable<int> DepreciationMean { get; set; }
        public Nullable<int> DurYear { get; set; }
        public Nullable<decimal> RemainsRate { get; set; }
        public string DepATypeId { get; set; }
        public string ExpenseATypeId { get; set; }
        public string AssertATypeId { get; set; }
        public bool Deleted { get; set; }
        public string Comment { get; set; }
    }
}
