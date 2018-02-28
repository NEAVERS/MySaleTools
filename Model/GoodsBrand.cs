using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GoodsBrand
    {
        /// <summary>
        /// 商品品牌ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 产地
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 是否删除
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

        public GoodsBrand()
        {
            this.Id = Guid.Empty;
            this.BrandName = string.Empty;
            this.Country = string.Empty;
            this.CreateUserId = Guid.Empty;
            this.CreateUserName = string.Empty;
            this.IsDelete = false;
        }
    }
}
