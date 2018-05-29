using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ord_PopUpPage
    {
        public int Id { get; set; }
        public int PlugId { get; set; }
        public string Name { get; set; }
        public int parentmenuid { get; set; }
        public string NameSpaceAndClass { get; set; }
        public string NeedLoadAssembly { get; set; }
        public int Offset { get; set; }
        public Nullable<int> ismdi { get; set; }
        public string paramlist { get; set; }
        public string replacemenuid { get; set; }
        public Nullable<int> menutype { get; set; }
        public string webmenuname { get; set; }
        public string menuguid { get; set; }
        public string xapname { get; set; }
    }
}
