using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_InvoiceRepairItems
    {
        public decimal BillNumberID { get; set; }
        public decimal BillType { get; set; }
        public Nullable<decimal> MainBillNumberID { get; set; }
        public string RepairItemsTypeID { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public string Comment { get; set; }
        public int ID { get; set; }
        public string Stypeid { get; set; }
    }
}
