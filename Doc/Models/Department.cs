using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Department
    {
        public string typeid { get; set; }
        public string parid { get; set; }
        public int leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string usercode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool deleted { get; set; }
        public string Tel { get; set; }
        public string LinkMan { get; set; }
        public string Fax { get; set; }
        public int rec { get; set; }
        public string namepy { get; set; }
        public int parrec { get; set; }
        public int OrderNo { get; set; }
        public string PyCode { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
    }
}
