using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PosVipMoneyList
    {
        public decimal BillnumberID { get; set; }
        public int PosVchcode { get; set; }
        public int VipID { get; set; }
        public decimal SaveAccountSum { get; set; }
    }
}
