using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]

    public class CouponActivity
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 小店编号
        /// </summary>
        public string StoreNum { get; set; }
        /// <summary>
        /// 小店名称
        /// </summary>
        public Guid StoreId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime { get; set; }


        public int EffectTime { get; set; }

        public decimal SendMoney { get; set; }
        /// <summary>
        /// 使用满足条件
        /// </summary>
        public decimal Limit { get; set; }

        /// <summary>
        /// 优惠面额
        /// </summary>
        public decimal LessMoney { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }


        /// <summary>
        /// 优惠券类型
        /// </summary>
        public int CouponType { get; set; }

        /// <summary>
        /// 品牌Id
        /// </summary>
        public Guid? BrandId { get; set; }

        /// <summary>
        /// 品牌名
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// 供应商Id
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// 供应商名
        /// </summary>
        public string SupplierName { get; set; }
        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserNum { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        public string CreateUserName { get; set; }


        /// <summary>
        /// 优惠券使用时间
        /// </summary>
        public DateTime? UseTime { get; set; }

        public Guid? UserOrderId { get; set; }

        public string UserTypes { get; set; }
        public CouponActivity()
        {
            this.Id = Guid.NewGuid();
            this.BrandId = null;
            this.BrandName = string.Empty;
            this.CouponType = 0;
            this.CreateTime = DateTime.Now;
            this.CreateUserId = Guid.Empty;
            this.CreateUserName = string.Empty;
            this.EndTime = DateTime.MaxValue;
            this.LessMoney = 0;
            this.Limit = 0;
            this.Remark = string.Empty;
            this.StartTime = DateTime.MinValue;
            this.StoreId = Guid.Empty;
            this.StoreNum = string.Empty;
            this.SupplierId = 0;
            this.SupplierName = string.Empty;
            this.UserId = Guid.Empty;
            this.UserName = string.Empty;
            this.UserNum = string.Empty;
            this.UseTime = null;
            this.UserOrderId = null;
            this.SendMoney = 0;
        }

    }
}
