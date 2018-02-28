using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GoodsType
    {
        /// <summary>
        /// 商品类型Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 商品类型名
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// 上级类型Id
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        /// 上级类型名
        /// </summary>
        public string  ParentName { get; set; }


        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public Guid CreateUserId { get; set; }


        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateUserName { get; set; }
    }
}
