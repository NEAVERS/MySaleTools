using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class nVipAddMoney
    {
        public int nID { get; set; }
        public int CardId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public string ETypeId { get; set; }
        public Nullable<decimal> aMoney { get; set; }
        public string ATypeId { get; set; }
        public string Comment { get; set; }
        public string Checke { get; set; }
        public Nullable<decimal> TotalInMoney { get; set; }
        public Nullable<decimal> PreferenceMoney { get; set; }
    }
}
