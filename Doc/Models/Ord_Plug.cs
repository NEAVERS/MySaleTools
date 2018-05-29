using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ord_Plug
    {
        public int Id { get; set; }
        public string PlugName { get; set; }
        public string AppropriateVerSion { get; set; }
        public string XmlPath { get; set; }
        public int IsInstalled { get; set; }
        public string plugversion { get; set; }
        public string plugfuncdescription { get; set; }
        public Nullable<System.DateTime> InstallDate { get; set; }
    }
}
