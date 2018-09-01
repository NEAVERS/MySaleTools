using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 活动黑名单
    /// </summary>
    public  class BlackForActive
    {

        public Guid Id { get; set; }

        public string GoodsNum { get; set; }

        public Guid GoodsId { get; set; }

        public string GoodsName { get; set; }


        public string ProviderName { get; set; }

        public string  Satutas { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        public int ActiveType { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid CreateUserId { get; set; }

        public BlackForActive()
        {
            this.Id = Guid.NewGuid();
            this.GoodsNum = string.Empty;
            this.GoodsId = Guid.Empty;
            this.CreateTime = DateTime.Now;
            this.CreateUserId = Guid.Empty;
        }
    }
}
