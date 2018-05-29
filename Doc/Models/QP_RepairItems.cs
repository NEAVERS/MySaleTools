using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_RepairItems
    {
        public string TypeID { get; set; }
        public string ParID { get; set; }
        public int Leveal { get; set; }
        public int SonCount { get; set; }
        public int SonNum { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string ItemType { get; set; }
        public Nullable<decimal> StandardManHour { get; set; }
        public Nullable<decimal> CheckHour { get; set; }
        public Nullable<decimal> StandardPrice { get; set; }
        public Nullable<decimal> TopPrice { get; set; }
        public Nullable<decimal> LowPrice { get; set; }
        public Nullable<int> ChargeMode { get; set; }
        public string RepairAutoTypeID { get; set; }
        public Nullable<int> MaintainDays { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public Nullable<decimal> MaintainMileage { get; set; }
        public string UserDefine1 { get; set; }
        public string UserDefine2 { get; set; }
        public string UserDefine3 { get; set; }
        public string UserDefine4 { get; set; }
        public string UserDefine5 { get; set; }
        public string PyCode { get; set; }
    }
}
