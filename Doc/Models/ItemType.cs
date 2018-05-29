using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ItemType
    {
        public int nId { get; set; }
        public string typeId { get; set; }
        public string ParId { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string CanModify { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public short Attribute { get; set; }
        public string Comment { get; set; }
        public string STypeid { get; set; }
        public bool deleted { get; set; }
        public string PyCode { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
    }
}
