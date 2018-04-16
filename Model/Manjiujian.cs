using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 满减
    /// </summary>
    public class Manjiujian
    {
        public Guid Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal LimitMoney { get; set; }

        public decimal LessMoeny { get; set; }

        public string UserTypes { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid CreateUserId { get; set; }

        public int TypeId { get; set; }

        /// <summary>
        /// 供应商Id
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// 供应商名
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 品牌Id
        /// </summary>
        public Guid? BrandId { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        public string BrandName { get; set; }



    }
}
