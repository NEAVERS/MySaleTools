﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{

    public enum SystemUserType
    {
        系统管理员 = -1,
        业务员  =-2,
        送货员 = -3
    }

    public enum OrderStatus
    {
        等待商家发货 =1,
        商家已发货,
        交易完成,
        订单取消中,
        订单取消成功,
        退货中,
        退货成功,
    }

    public enum SysConfigTypes
    {
        PageBottom,
        IsCanReturn,
        IsShowBill,
        ContactTell,
    }

    /// <summary>
    /// 优惠券类型
    /// </summary>
    public enum CouponType
    {
        通用券 =1,
        品牌券,
        供应商券
    }

}
