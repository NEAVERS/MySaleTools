using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Manjiusong 
    {
        public Guid Id { get; set; }

        public string Tittle { get; set; }
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal LimitMoney { get; set; }

        public Guid SendGoodId { get; set; }

        public string  SendGoodNum { get; set; }

        public string  SendGoodName { get; set; }

        public int  SendGoodCount { get; set; } 

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
