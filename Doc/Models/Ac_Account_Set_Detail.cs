using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Account_Set_Detail
    {
        public int DtId { get; set; }
        public int SubId { get; set; }
        public string Group { get; set; }
        public string TypeId { get; set; }
        public string ParId { get; set; }
        public Nullable<int> FLeveal { get; set; }
        public Nullable<int> Leveal { get; set; }
        public Nullable<int> SonNum { get; set; }
        public Nullable<int> SonCount { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public Nullable<int> Fdc { get; set; }
        public Nullable<int> IsCash { get; set; }
        public Nullable<int> IsBank { get; set; }
        public Nullable<int> IsOther { get; set; }
        public Nullable<int> fcontact { get; set; }
        public Nullable<int> checktype { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
    }
}
