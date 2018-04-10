using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class OrderInfo
    {
        /// <summary>
        /// 订单编号
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        public string OrderNum { get; set; }

        /// <summary>
        /// 下单时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public int Stutas { get; set; }

        /// <summary>
        /// 配送员
        /// </summary>
        public string SendPeople { get; set; }

        /// <summary>
        /// 送货员ID
        /// </summary>
        public Guid? SendPeopleId { get; set; }

        /// <summary>
        /// 送货员姓名
        /// </summary>
        public string SendPeopleTel { get; set; }
        /// <summary>
        /// 付款时间
        /// </summary>
        public DateTime? PayTime { get; set; }

        /// <summary>
        /// 发货时间
        /// </summary>
        public DateTime? SendTime { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public string  PayType { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        public decimal TotalMoney { get; set; }

        /// <summary>
        /// 满减金额
        /// </summary>
        public decimal LessMoney { get; set; }

        /// <summary>
        /// 应付金额
        /// </summary>
        public decimal RealMoney { get; set; }
        /// <summary>
        /// 实付金额
        /// </summary>
        public decimal PayMoney { get; set; }
        public string Remark { get; set; }



        /// <summary>
        /// 省份编号
        /// </summary>
        public string ProvinceNum { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 城市编号
        /// </summary>
        public string CityNum { get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 行政区编号
        /// </summary>
        public string AreaNum { get; set; }
        /// <summary>
        /// 行政区名
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// 用户的创建人Id
        /// </summary>
        public Guid RootUserId { get; set; }
        /// <summary>
        /// 用户的创建人姓名
        /// </summary>
        public string RootUserName { get; set; }
        /// <summary>
        /// 订单创建人Id
        /// </summary>
        public Guid CreateUserId { get; set; }
        /// <summary>
        /// 订单创建人姓名
        /// </summary>
        public string  CreateUserName { get; set; }
        /// <summary>
        /// 小店编号
        /// </summary>
        public string CreateUserNum { get; set; }

        public string CreateUserTel { get; set; }
        /// <summary>
        /// 小店名
        /// </summary>
        public string  StoreName { get; set; }
        /// <summary>
        /// 创建人用户类型Id
        /// </summary>
        public int CreateUserTypeId { get; set; }
        /// <summary>
        /// 创建人用户类型
        /// </summary>
        public string CreateUserType { get; set; }


        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// 业务员ID
        /// </summary>
        public Guid SaleManGuid { get; set; }

        /// <summary>
        /// 业务员姓名
        /// </summary>
        public string SaleManName { get; set; }

        /// <summary>
        /// 订单完成时间
        /// </summary>
        public DateTime? CompleteTime { get; set; }

        /// <summary>
        /// 业务员电话
        /// </summary>
        public string SaleManTel { get; set; }

        
        /// <summary>
        /// 收款人ID
        /// </summary>
        public Guid? ReceiveUserId { get; set; }
        /// <summary>
        /// 收款人姓名
        /// </summary>
        public string ReceiveUserName { get; set; }

        /// <summary>
        /// 是否收款
        /// </summary>
        public bool IsPay { get; set; }
        /// <summary>
        /// 是否为异常订单
        /// </summary>
        public bool IsError { get; set; }


        public string AdminRemark { get; set; }
        public OrderInfo()
        {
            this.Id = Guid.NewGuid();
            this.OrderNum = DateTime.Now.ToString("yyMMddHHmmssfff");
            this.CreateTime = DateTime.Now;
            this.Stutas = 0;
            this.SendPeople = string.Empty;
            this.PayTime = null;
            this.SendTime = null;
            this.PayType = string.Empty;
            this.TotalMoney = 0;
            this.LessMoney = 0;
            this.RealMoney = 0;
            this.PayMoney = 0;
            this.Remark = string.Empty;
            this.RootUserId = Guid.Empty;
            this.RootUserName = string.Empty;
            this.CreateUserId = Guid.Empty;
            this.CreateUserName = string.Empty;
            this.CreateUserTypeId = 0;
            this.CreateUserType = string.Empty;
            this.IsDelete = false;
            this.SaleManGuid = Guid.Empty;
            this.SaleManName = string.Empty;
            this.CreateUserNum = string.Empty;
            this.StoreName = string.Empty;
            this.IsError = false;
            this.IsPay = false;
        }
    }
}
