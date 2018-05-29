using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class QP_PType_Ext
    {
        public string PTypeID { get; set; }
        public string Brand { get; set; }
        public string Import { get; set; }
        public string GeneralType { get; set; }
        public string GeneralDwgNo { get; set; }
        public string Property { get; set; }
        public string PackageQty { get; set; }
        public string Weight { get; set; }
        public string TaxNumber { get; set; }
        public Nullable<decimal> Taxrate { get; set; }
        public string BTypeID { get; set; }
        public string FcUnit { get; set; }
        public Nullable<decimal> FcPrice { get; set; }
    }
}
