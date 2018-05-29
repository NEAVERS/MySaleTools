using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class VipCardSet
    {
        public int VipCardID { get; set; }
        public string VipCardName { get; set; }
        public Nullable<decimal> VipCardKL { get; set; }
        public Nullable<bool> VipCardAutoZK { get; set; }
        public Nullable<decimal> ConsumeMoney { get; set; }
        public Nullable<int> ConsumeTimes { get; set; }
        public Nullable<int> TimeLimit { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Note { get; set; }
        public Nullable<bool> VipCardKz { get; set; }
    }
}
