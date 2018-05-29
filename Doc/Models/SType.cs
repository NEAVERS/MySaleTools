using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class SType
    {
        public string TypeId { get; set; }
        public string parid { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string UserCode { get; set; }
        public string Comment { get; set; }
        public string LinkMan { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string PostCode { get; set; }
        public string TaxNo { get; set; }
        public string Bank { get; set; }
        public string Account { get; set; }
        public bool deleted { get; set; }
        public string PyCode { get; set; }
        public string BTypeID1 { get; set; }
        public string BTypeID2 { get; set; }
        public Nullable<byte> PriceType { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public string ATypeID { get; set; }
        public string ATypeID2 { get; set; }
        public int IfAssetsIni { get; set; }
        public Nullable<int> IsUpLoad { get; set; }
        public string ATypeID3 { get; set; }
        public int IsSelfVerify { get; set; }
        public string VerifyID { get; set; }
        public string ATypeID4 { get; set; }
        public string calcFullName { get; set; }
        public int Sid { get; set; }
    }
}
