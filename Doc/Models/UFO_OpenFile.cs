using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class UFO_OpenFile
    {
        public int nId { get; set; }
        public string STypeID { get; set; }
        public string AtypeID { get; set; }
        public Nullable<System.DateTime> BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public int Cid { get; set; }
        public Nullable<int> Fyear { get; set; }
        public Nullable<int> FPeriod { get; set; }
        public Nullable<int> ShowNotPost { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Assets { get; set; }
        public string FunctionName { get; set; }
    }
}
