using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class GiveFromSaleOrBuyBill
    {
        public int BillID { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public string Stypeid { get; set; }
    }
}
