using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Custom_Column
    {
        public int id { get; set; }
        public string ColumnName { get; set; }
        public Nullable<int> ColumnType { get; set; }
        public string Comment { get; set; }
    }
}
