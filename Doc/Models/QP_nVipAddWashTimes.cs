using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_nVipAddWashTimes
    {
        public int nID { get; set; }
        public string CardId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string ETypeId { get; set; }
        public Nullable<decimal> aMoney { get; set; }
        public Nullable<decimal> TotalInMoney { get; set; }
        public Nullable<decimal> PreferenceMoney { get; set; }
        public Nullable<int> AddTimes { get; set; }
        public string ATypeId { get; set; }
        public string Comment { get; set; }
    }
}
