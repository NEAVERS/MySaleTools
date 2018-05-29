using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Custom_Column_BillDetail
    {
        public Nullable<int> BillType { get; set; }
        public Nullable<int> CustomColumnId { get; set; }
        public string Label { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public Nullable<int> IsRequired { get; set; }
        public string InOut { get; set; }
    }
}
