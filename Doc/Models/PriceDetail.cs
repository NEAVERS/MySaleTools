using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class PriceDetail
    {
        public decimal ID { get; set; }
        public decimal PriceBillIndexID { get; set; }
        public int State { get; set; }
        public string Ptypeid { get; set; }
        public Nullable<int> FreeID { get; set; }
        public Nullable<byte> IsCombined { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> PriceStyle { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> DiscountPrice { get; set; }
        public Nullable<decimal> BeforeRetailPrice { get; set; }
        public Nullable<decimal> Tax { get; set; }
        public Nullable<decimal> TaxPrice { get; set; }
        public Nullable<byte> IsPriceControl { get; set; }
        public string Comment { get; set; }
        public string Checke { get; set; }
        public string Checker { get; set; }
        public Nullable<System.DateTime> VaildDate { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public string DeletedR { get; set; }
        public Nullable<int> SortID { get; set; }
        public Nullable<decimal> OldID { get; set; }
    }
}
