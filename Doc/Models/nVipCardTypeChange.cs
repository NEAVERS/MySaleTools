using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class nVipCardTypeChange
    {
        public int VipCardID { get; set; }
        public int OldVipCardTypeID { get; set; }
        public int NewVipCardTypeID { get; set; }
        public string etypeid { get; set; }
        public Nullable<System.DateTime> ChangeDate { get; set; }
        public string Comment { get; set; }
        public Nullable<int> OperatStyle { get; set; }
    }
}
