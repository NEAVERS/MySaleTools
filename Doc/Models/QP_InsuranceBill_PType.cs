using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_InsuranceBill_PType
    {
        public decimal BillNumberId { get; set; }
        public int ID { get; set; }
        public string PTypeID { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public Nullable<decimal> InsuranceTotal { get; set; }
        public Nullable<decimal> GoodsCostTotal { get; set; }
        public int Virtual { get; set; }
        public string Comment { get; set; }
        public int IsUnit2 { get; set; }
        public string Stypeid { get; set; }
        public Nullable<int> QuickOrReceptionBillId { get; set; }
    }
}
