using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class test_data
    {
        public string typeId { get; set; }
        public string ParId { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string CanModify { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public Nullable<decimal> UnitRate1 { get; set; }
        public Nullable<decimal> UnitRate2 { get; set; }
        public Nullable<decimal> preprice1 { get; set; }
        public Nullable<decimal> preprice2 { get; set; }
        public Nullable<decimal> preprice3 { get; set; }
        public Nullable<decimal> preprice4 { get; set; }
        public Nullable<decimal> preprice5 { get; set; }
        public Nullable<short> UsefulLifeMonth { get; set; }
        public Nullable<short> UsefulLifeDay { get; set; }
        public string Comment { get; set; }
        public Nullable<decimal> recPrice { get; set; }
        public bool deleted { get; set; }
        public Nullable<int> ColorGroupID { get; set; }
        public Nullable<int> SizeGroupID { get; set; }
        public string EntryCode { get; set; }
        public string IfSerial { get; set; }
        public string PyCode { get; set; }
        public Nullable<int> SerialCount { get; set; }
        public Nullable<int> ValidDays { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public string DwgNo { get; set; }
        public string ImgURL { get; set; }
        public Nullable<decimal> Integral { get; set; }
        public Nullable<int> StopBuy { get; set; }
        public Nullable<int> IsOm { get; set; }
    }
}
