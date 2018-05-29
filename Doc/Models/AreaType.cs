using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AreaType
    {
        public string typeId { get; set; }
        public string parid { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string UserCode { get; set; }
        public string Comment { get; set; }
        public string TEL { get; set; }
        public string LinkMan { get; set; }
        public string sysflag { get; set; }
        public bool deleted { get; set; }
        public string PyCode { get; set; }
        public Nullable<bool> ifCanEdit { get; set; }
        public Nullable<bool> ifCanClass { get; set; }
        public Nullable<bool> ifCanDel { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
    }
}
