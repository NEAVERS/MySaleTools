using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Ac_SubsidiaryEquipment
    {
        public int Id { get; set; }
        public Nullable<int> CardId { get; set; }
        public string FullName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Size { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Units { get; set; }
        public Nullable<decimal> Value { get; set; }
        public Nullable<System.DateTime> UseDate { get; set; }
        public string Comment { get; set; }
    }
}
