using System;
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
        退货=-1,
        下单 =1,
        发货 = 2,
        完成=3,   
    }
}
