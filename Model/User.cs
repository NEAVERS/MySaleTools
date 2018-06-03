using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserInfo
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserNum { get; set; }
        /// <summary>
        /// 用户账号
        /// </summary>
        public string  Account { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string  UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }

        /// <summary>
        /// 是否被锁定
        /// </summary>
        public bool IsLocked { get; set; }



        /// <summary>
        /// 电话号码
        /// </summary>
        public string Tel { get; set; }
        /// <summary>
        /// 用户类型Id
        /// </summary>
        public int TypeId { get; set; }

        /// <summary>
        /// 用户类型
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string  CreateUser { get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        public Guid CreateUserId { get; set; }



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
        public string AreaNum  { get; set; }
        /// <summary>
        /// 行政区名
        /// </summary>
        public string  Area { get; set; }
        /// <summary>
        /// 是否被删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 业务员ID
        /// </summary>
        public Guid SaleManGuid { get; set; }

        /// <summary>
        /// 业务员姓名
        /// </summary>
        public string SaleManName { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        public string ReceiveName { get; set; }

        /// <summary>
        /// 收货地址
        /// </summary>
        public string Addr { get; set; }

        /// <summary>
        /// 小店面积
        /// </summary>
        public decimal StoreArea { get; set; }

        /// <summary>
        /// 小店名称
        /// </summary>
        public string SotreName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 送货备注
        /// </summary>
        public string Remark { get; set; }


        public DateTime? LastLoginTime { get; set; }

        public string LastLoginIP { get; set; }

        /// <summary>
        /// 用户编码
        /// </summary>
        public string UserCode { get; set; }
        public UserInfo()
        {
            UserId = Guid.Empty;
            UserNum = string.Empty;
            Account = string.Empty;
            UserName = string.Empty;
            PassWord = string.Empty;
            CreateTime = DateTime.Now;
            Tel = string.Empty;
            IsLocked = false;
            CreateUser = string.Empty;
            CreateUserId = Guid.Empty;
            this.SaleManGuid = Guid.Empty;
            this.SaleManName = string.Empty;
            ReceiveName = string.Empty;
            Addr = string.Empty;
            StoreArea = 0;
            SotreName = string.Empty;
            Email = string.Empty;
            Remark = string.Empty;
            LastLoginIP = string.Empty;
            UserCode = string.Empty;
        }
    }
}
