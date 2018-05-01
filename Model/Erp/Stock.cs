using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Erp
{
    /// <summary>
    /// 仓库表
    /// </summary>
    public partial class Stock
    {
        public string typeId { get; set; }
        public string parid { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string UserCode { get; set; }
        public string Comment { get; set; }
        public bool deleted { get; set; }
        public string Add { get; set; }
        public string Tel { get; set; }
        public string LinkMan { get; set; }
        public string PyCode { get; set; }
        public Nullable<decimal> XiWaMaxNumber { get; set; }
        public string STypeID { get; set; }
        public int Kid { get; set; }
    }
}
