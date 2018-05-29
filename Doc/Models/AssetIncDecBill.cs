using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class AssetIncDecBill
    {
        public int Id { get; set; }
        public int BillNumberId { get; set; }
        public int AssetCardId { get; set; }
        public int BillType { get; set; }
        public Nullable<decimal> NTotal { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> NTaxMoney { get; set; }
        public Nullable<decimal> TaxMoney { get; set; }
        public Nullable<decimal> NTaxTotal { get; set; }
        public Nullable<decimal> TaxTotal { get; set; }
        public Nullable<decimal> NDepTotal { get; set; }
        public Nullable<decimal> DepTotal { get; set; }
        public Nullable<decimal> NNetValue { get; set; }
        public Nullable<decimal> NetValue { get; set; }
        public string Comment { get; set; }
    }
}
