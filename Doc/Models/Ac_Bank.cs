using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_Bank
    {
        public int nId { get; set; }
        public string STypeId { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string CreateBank { get; set; }
        public string BankType { get; set; }
        public string ATypeId { get; set; }
        public Nullable<int> IsBank { get; set; }
        public string Comment { get; set; }
        public Nullable<int> Deleted { get; set; }
    }
}
