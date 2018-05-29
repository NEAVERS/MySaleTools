using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class TemplateListTable
    {
        public int TemplateID { get; set; }
        public string Ptypeid { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string comment { get; set; }
    }
}
