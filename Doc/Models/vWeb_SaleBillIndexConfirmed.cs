using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vWeb_SaleBillIndexConfirmed
    {
        public decimal BillNumberId { get; set; }
        public System.DateTime BillDate { get; set; }
        public string BillCode { get; set; }
        public string etypeid { get; set; }
        public string Comment { get; set; }
        public string shdw { get; set; }
        public string shdwID { get; set; }
        public string jsr { get; set; }
        public Nullable<decimal> totalmoney { get; set; }
        public Nullable<decimal> totalqty { get; set; }
        public Nullable<decimal> tax { get; set; }
        public string Stypeid { get; set; }
        public string DTypeId { get; set; }
        public string StockOut { get; set; }
        public string StockIn { get; set; }
    }
}
