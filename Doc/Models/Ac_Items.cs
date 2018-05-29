using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Items
    {
        public int nId { get; set; }
        public string nTypeId { get; set; }
        public string nParId { get; set; }
        public string TypeId { get; set; }
        public string ParId { get; set; }
        public Nullable<int> Leveal { get; set; }
        public Nullable<int> SonNum { get; set; }
        public Nullable<int> SonCount { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string CreateBank { get; set; }
        public string BankType { get; set; }
        public Nullable<int> IsBank { get; set; }
        public string Comment { get; set; }
        public string PyCode { get; set; }
        public int Deleted { get; set; }
        public string TypeName { get; set; }
        public Nullable<int> XiWaMaxNumber { get; set; }
        public Nullable<int> Sysrow { get; set; }
        public Nullable<int> IsModify { get; set; }
    }
}
