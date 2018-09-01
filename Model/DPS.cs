using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DPS
    {
        /// <summary>
        /// ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// 活动商品编号
        /// </summary>
        public string  GoodsNum { get; set; }

        /// <summary>
        /// 活动商品ID
        /// </summary>
        public Guid GoodsId { get; set; }

        /// <summary>
        /// 活动商品名
        /// </summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 起送数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 赠送商品编号
        /// </summary>
        public string SendGoodsNum { get; set; }

        /// <summary>
        /// 赠送商品ID
        /// </summary>
        public Guid SendGoodsId { get; set; }

        /// <summary>
        /// 赠送商品名
        /// </summary>
        public string SendGoodsName { get; set; }
        /// <summary>
        /// 赠送数量
        /// </summary>
        public int SendCount { get; set; }

        /// <summary>
        /// 是否只送一次
        /// </summary>
        public bool IsOnly { get; set; }

        /// <summary>
        /// 是否上不封顶
        /// </summary>
        public bool IsRepeat { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public string UserTypes { get; set; }

        /// <summary>
        /// 活动区域
        /// </summary>
        public string Areas { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

        public DPS()
        {
            this.Id = Guid.Empty;
            this.StartTime = DateTime.Now;
            this.EndTime = DateTime.Now.AddMonths(1);
            this.GoodsId = Guid.Empty;
            this.SendGoodsId = Guid.Empty;
            this.CreateTime = DateTime.Now;
            this.IsDelete = false;
            this.IsOnly = false;
            this.IsRepeat = true;
        }

    }
}
