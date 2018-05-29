using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ItemATypeIdPreset
    {
        public int Id { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string ATypeUserCode { get; set; }
        public string ATypeFullName { get; set; }
        public Nullable<int> SubId { get; set; }
    }
}
