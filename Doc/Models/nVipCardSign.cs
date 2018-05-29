using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class nVipCardSign
    {
        public int VipCardID { get; set; }
        public string VipCardCode { get; set; }
        public int VipCardTypeID { get; set; }
        public string Bname { get; set; }
        public string Bsex { get; set; }
        public Nullable<System.DateTime> Bbirthday { get; set; }
        public string Btel { get; set; }
        public string Baddr { get; set; }
        public string Bpostcode { get; set; }
        public string Btrade { get; set; }
        public string BIDcard { get; set; }
        public string etypeid { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string deleted { get; set; }
        public Nullable<decimal> BeginMoney { get; set; }
        public Nullable<decimal> BeginCent { get; set; }
        public Nullable<decimal> totalMoney { get; set; }
        public Nullable<decimal> totalCent { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> qCczMoney { get; set; }
        public Nullable<decimal> lJczMoney { get; set; }
        public Nullable<decimal> xFczMoney { get; set; }
        public Nullable<decimal> cZyeMoney { get; set; }
        public string IsCz { get; set; }
        public string pWord { get; set; }
        public string RATypeID { get; set; }
        public string BTypeID { get; set; }
        public Nullable<int> CarType { get; set; }
        public Nullable<decimal> CarWashPrice { get; set; }
        public string IsWashTimes { get; set; }
        public Nullable<int> CanWashTimes00 { get; set; }
        public Nullable<int> CanWashTimes { get; set; }
        public Nullable<int> CanWashTimesTotal { get; set; }
        public string PyCode { get; set; }
    }
}
