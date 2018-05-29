using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class ListTable
    {
        public decimal BillNumberId { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public decimal BillType { get; set; }
        public string AtypeId { get; set; }
        public string PtypeId { get; set; }
        public string BtypeId { get; set; }
        public string EtypeId { get; set; }
        public string KtypeId { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> CostPrice { get; set; }
        public Nullable<decimal> CostTotal { get; set; }
        public string JobNumber { get; set; }
        public Nullable<int> GoodsNo { get; set; }
        public Nullable<System.DateTime> OutFactoryDate { get; set; }
        public bool Audited { get; set; }
        public string Ifout { get; set; }
        public string DTypeID { get; set; }
        public string STypeID { get; set; }
        public string STypeID2 { get; set; }
        public Nullable<int> CID { get; set; }
        public Nullable<decimal> Ntotal { get; set; }
        public int Id { get; set; }
        public Nullable<decimal> Rate { get; set; }
    }
}
