using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BrandOfGoodsType
    {
        /// <summary>
        /// 关联Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 类型Id
        /// </summary>
        public Guid TypeId { get; set; }

        /// <summary>
        /// 品牌Id
        /// </summary>
        public Guid BandsId { get; set; }
    }
}
