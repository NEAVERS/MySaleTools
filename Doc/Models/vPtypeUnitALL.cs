using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class vPtypeUnitALL
    {
        public string typeId { get; set; }
        public string ParId { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string EntryCode { get; set; }
        public bool deleted { get; set; }
        public string Area { get; set; }
        public int baseUnitRate { get; set; }
        public decimal buyUnitRate { get; set; }
        public decimal saleUnitRate { get; set; }
        public decimal stockUnitRate { get; set; }
        public string buyunitfullname { get; set; }
        public string saleunitfullname { get; set; }
        public string stockunitfullname { get; set; }
        public string baseunitfullname { get; set; }
        public string assistantfullname { get; set; }
    }
}
