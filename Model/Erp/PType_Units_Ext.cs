using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Erp
{
    public partial class PType_Units_Ext
    {
        public string PtypeID { get; set; }
        public int UnitsId { get; set; }
        public int RateType { get; set; }
        public Nullable<decimal> Rate { get; set; }
        public string EntryCode { get; set; }
        public int IsDefaultUnit { get; set; }
        public Nullable<int> IsUse { get; set; }
    }
}
