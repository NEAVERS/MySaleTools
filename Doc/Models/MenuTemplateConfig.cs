using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class MenuTemplateConfig
    {
        public int NId { get; set; }
        public int MenuID { get; set; }
        public string Caption { get; set; }
        public string Name { get; set; }
        public Nullable<int> IsChecked { get; set; }
    }
}
