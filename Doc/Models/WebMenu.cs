using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class WebMenu
    {
        public int SysID { get; set; }
        public int MenuID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public bool IsRoot { get; set; }
        public bool IsSubMenu { get; set; }
        public int Tabord { get; set; }
        public string Caption { get; set; }
        public string Name { get; set; }
        public bool AllUser { get; set; }
        public int CallType { get; set; }
        public string Title { get; set; }
        public int Offset { get; set; }
        public string img { get; set; }
        public string ShortCut { get; set; }
    }
}
