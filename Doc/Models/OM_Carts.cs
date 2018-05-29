using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OM_Carts
    {
        public int TypeID { get; set; }
        public string PtypeID { get; set; }
        public int LoginUser_ID { get; set; }
        public int Qty { get; set; }
        public System.DateTime Date { get; set; }
    }
}
