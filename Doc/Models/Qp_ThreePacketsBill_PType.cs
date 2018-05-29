using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Qp_ThreePacketsBill_PType
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public Nullable<decimal> InsuranceTotal { get; set; }
        public string Comment { get; set; }
        public Nullable<int> IsUnit2 { get; set; }
        public Nullable<int> QuickOrReceptionBillId { get; set; }
        public Nullable<int> Virtual { get; set; }
    }
}
