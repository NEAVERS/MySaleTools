using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceProtect
    {
        public int PriceId { get; set; }
        public string Ptypeid { get; set; }
        public string Btypeid { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<decimal> NewPrice { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<System.DateTime> WriteDate { get; set; }
        public string WriteId { get; set; }
        public string State { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> BillType { get; set; }
        public string Billids { get; set; }
        public string Stypeid { get; set; }
    }
}
