using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户收藏表
    /// </summary>
    public class UserCollect
    {
        public int Id { get; set; }

        public Guid UserId { get; set; }

        public Guid GoodsId { get; set; }

        public DateTime CreateTime { get; set; }

        public UserCollect()
        {
            this.UserId = Guid.Empty;
            this.GoodsId = Guid.Empty;
            this.CreateTime = DateTime.Now;
        }
    }
}
