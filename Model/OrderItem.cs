using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 订单子项
    /// </summary>
    public class OrderItem
    {
        /// <summary>
        /// 订单子项Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 订单Id
        /// </summary>
        public Guid OrderId { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNum { get; set; }

        /// <summary>
        /// 商品Id
        /// </summary>
        public Guid ProductId { get; set; }

        /// <summary>
        /// 商品名
        /// </summary>
        public string ProductTittle { get; set; }


        /// <summary>
        /// 商品类目
        /// </summary>
        public string ProductType { get; set; }
        /// <summary>
        /// 商品类目Id
        /// </summary>
        public Guid ProductTypeId { get; set; }

        /// <summary>
        /// 商品条形码
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 规格信息
        /// </summary>
        public string Spec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// 供应商Id
        /// </summary>
        public int SupplierId { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        public string SupplierName { get; set; }


        public string Brand { get; set; }
        /// <summary>
        /// 原价  
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 实际价格
        /// </summary>
        public decimal RealPrice { get; set; }


        public int Count { get; set; }
        /// <summary>
        /// 小计
        /// </summary>
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// 折扣
        /// </summary>
        public decimal LessPrice { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public bool IsEffective { get; set; }


        /// <summary>
        /// 是否在购物车中
        /// </summary>
        public bool IsInShoppingCar { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// 图片链接
        /// </summary>
        public string Pic { get; set; }


        /// <summary>
        /// 是否异常
        /// </summary>
        public bool IsError { get; set; }

        /// <summary>
        /// 异常类型编号
        /// </summary>
        public string ErrorTypeCode { get; set; }

        /// <summary>
        /// 异常类型
        /// </summary>
        public string  ErrorType { get; set; }
        /// <summary>
        /// 异常数量
        /// </summary>
        public int  ErrorCount { get; set; }
        /// <summary>
        /// 异常原因ID
        /// </summary>
        public string ErrorReasonCode { get; set; }

        /// <summary>
        /// 异常原因
        /// </summary>
        public string ErrorReason { get; set; }

        /// <summary>
        /// 原因备注
        /// </summary>
        public string ErrorMark { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public OrderItem()
        {
            this.Id = Guid.Empty;
            this.OrderId = Guid.Empty;
            this.OrderNum = string.Empty;
            this.ProductId = Guid.Empty;
            this.ProductTittle = string.Empty;
            this.Price = 0;
            this.RealPrice = 0;
            this.Count =  0;
            this.TotalPrice = 0;
            this.LessPrice = 0;
            this.IsDelete = false;
            this.IsEffective = true;
            this.IsInShoppingCar = true;
            this.CreateUserId = Guid.Empty;
            this.Pic = string.Empty;
        }

    }
}
