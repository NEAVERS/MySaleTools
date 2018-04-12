using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
    public class ErrorInfoModel
    {
        /// <summary>
        /// 商品类型
        /// </summary>
        public string ProductType { get; set; }
        /// <summary>
        /// 商品名
        /// </summary>

        public string  ProductName { get; set; }
        /// <summary>
        /// 异常类型
        /// </summary>
        public string  ErrorType { get; set; }

        /// <summary>
        /// 异常数量
        /// </summary>
        public int ErrorCout { get; set; }

        /// <summary>
        /// 异常金额
        /// </summary>

        public decimal ErrorTotal { get; set; }
        /// <summary>
        /// 异常原因
        /// </summary>
        public string ErrorReason { get; set; }

        /// <summary>
        /// 订单编号Id
        /// </summary>
        public Guid OrderItemId { get; set; }
    }
}
