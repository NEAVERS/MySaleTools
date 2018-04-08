using Common.Entities;
using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderManager
    {
        private SaleToolsContext _context = new SaleToolsContext();


        /// <summary>
        /// 获取购物车中的商品
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<OrderItem> GetShoppingCar(Guid userId)
        {
            var q = from c in _context.OrderItems
                    where c.IsInShoppingCar
                    && !c.IsDelete
                    && c.IsEffective
                    select c;
            return q.ToList();
        }


        public bool IsExitInCar(Guid goodsId ,Guid createUserId,out OrderItem baseItem)
        {
            var model = _context.OrderItems.FirstOrDefault(x => x.ProductId == goodsId
            && x.IsInShoppingCar
            && !x.IsDelete
            &&x.CreateUserId == createUserId
            && x.IsEffective);
            baseItem = model;
            if (model == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// 将购物车中的商品生成订单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public bool SaveOrder(OrderInfo order)
        {
            var list = from c in _context.OrderItems
                       where c.IsInShoppingCar
                       && !c.IsDelete
                       && c.IsEffective
                       select c;
            decimal totalPrice = 0;
            decimal realPrice = 0;
            foreach (var item in list)
            {
                item.OrderId = order.Id;
                item.OrderNum = order.OrderNum;
                item.IsInShoppingCar = false;
                totalPrice += item.TotalPrice;
                realPrice += item.TotalPrice - item.LessPrice;
            }

            order.TotalMoney = totalPrice;
            order.PayMoney = realPrice;
            order.RealMoney = realPrice;
            order.Stutas = 1;
            _context.OrderInfoes.Add(order);
            return _context.SaveChanges() > 0;
        }


        public bool AddOrderItem(OrderItem item)
        {
            _context.OrderItems.Add(item);
            return _context.SaveChanges()>0;
        }
        /// <summary>
        /// 修改商品数量
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public bool SaveOrderItem(Guid itemId,int count)
        {
            var item = _context.OrderItems.FirstOrDefault(x => x.Id == itemId);
            if(item!=null)
            {
                item.Count = count;
                item.TotalPrice = count * item.Price;
            }
            return _context.SaveChanges()>0;
        }

        public bool ClearShopping(Guid userId)
        {
            var list = from c in _context.OrderItems
                       where c.CreateUserId == userId
                       && c.IsInShoppingCar
                       && !c.IsDelete
                       select c;
            foreach(var item in list)
            {
                item.IsDelete = true;
            }
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 删除订单或购物车中的商品
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public bool DeleteOrderItem(List<Guid> itemIds)
        {
            var list = _context.OrderItems.Where(x => itemIds.Contains(x.Id));
            if (list != null)
            {
                foreach (var item in list)
                {
                    item.IsDelete = true;
                }
            }
            return _context.SaveChanges()>0;
        }


        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public bool DeleteOrder(Guid orderId)
        {
            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            if(order !=null)
            {
                order.IsDelete = true;
                var list = _context.OrderItems.Where(x => x.OrderId == order.Id);
                foreach (var item in list)
                {
                    item.IsDelete = true;
                }
            }
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 根据创建人获取订单列表
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="createUserId"></param>
        /// <returns></returns>
        public List<OrderInfo> GetOrderListByCreateUserId(DateTime start,DateTime end, Guid createUserId)
        {
            var q = from c in _context.OrderInfoes
                    where c.CreateTime > start
                    && c.CreateTime < end
                    && c.CreateUserId == createUserId
                    select c;
            return q.ToList();

        }

        public PageData<OrderInfo> GetOrderList(int index, int size, DateTime start, DateTime end, string province, string city, string area, int stutas, string saleManId, int userType, string key, Guid managerId, bool isAdmin = false)
        {
            PageData<OrderInfo> pager = new PageData<OrderInfo>();
            var q = from c in _context.OrderInfoes
                    where c.CreateTime > start
                    && c.CreateTime < end
                    select c;
            if (province != "-1" && !string.IsNullOrWhiteSpace(province))
                q = q.Where(x => x.ProvinceNum == province);
            if (city != "-1" && !string.IsNullOrWhiteSpace(city))
                q = q.Where(x => x.CityNum == city);
            if (area != "-1" && !string.IsNullOrWhiteSpace(area))
                q = q.Where(x => x.AreaNum == area);
            if (saleManId != "-1" && !string.IsNullOrWhiteSpace(saleManId))
                q = q.Where(x => x.SaleManGuid.ToString() == saleManId);
            if (userType != 0)
                q = q.Where(x => x.CreateUserTypeId == userType);
            if (stutas != 0)
                q = q.Where(x => x.Stutas == stutas);
            if (managerId != Guid.Empty)
            {
                if (isAdmin)
                    q = q.Where(x => x.RootUserId == managerId);///系统管理员查看
                else
                    q = q.Where(x => x.SaleManGuid == managerId);//业务员查看
            }
            pager.PageIndex = index;
            pager.PageSize = size;
            pager.TotalCount = q.Count();
            pager.ListData = q.OrderByDescending(x => x.CreateTime).Skip((index - 1) * size).Take(size).ToList();
            return pager;
        }

        public OrderDetail GetOrderDetail(Guid orderId)
        {
            var detail = new OrderDetail();
            detail.Info = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            detail.Items = _context.OrderItems.Where(x => x.OrderId == orderId && !x.IsDelete && !x.IsInShoppingCar).ToList();
            return detail;
        }

        /// <summary>
        /// 取消订单
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public bool CancelOrder(Guid orderId)
        {
            var model = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            if (model != null)
                model.Stutas =(int)OrderStatus.订单取消中;
            return _context.SaveChanges() > 0;
        }



        public void GetProductBill()
        {
            var list = from c in _context.OrderItems
                       where !c.IsInShoppingCar
                       && !c.IsDelete
                       select c;
        }



        public string CreateOrderFile()
        {
            var q = from c in _context.OrderInfoes
                    join d in _context.OrderItems on c.Id equals d.OrderId
                    select new
                    {
                        info = c,
                        item = d
                    };

            System.IO.MemoryStream output = new System.IO.MemoryStream();

            System.IO.StreamWriter writer = new System.IO.StreamWriter(output, System.Text.Encoding.UTF8);

            writer.Write("订单号,总订单号,商品条形码,商品父级id,商品id,商品类目,商品,商品品牌,规格,单位,总金额,订货人,客户类型,电话,订货服务站,地区,卖家,订单状态,订购日期,单价,成本价,实收金额,下单数量,异常数量,编号,标记,支付类型,小店名称,业务员,送货员,分拣员,订单完成日期,订单备注,供应商编号,加盟商");//输出标题，逗号分割（注意最后一列不加逗号）

            writer.WriteLine();
            //输出内容
            foreach(var item in q)
            {
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.OrderNum + ",");//第一列
                writer.Write(item.item.BarCode + ",");//第一列
                writer.Write("0" + ",");//第一列
                writer.Write(item.item.ProductId.ToString("N") + ",");//第一列
                writer.Write(item.item.ProductTittle + ",");//第一列
                writer.Write(item.item.Brand + ",");//第一列
                writer.Write(item.item.Spec + ",");//第一列
                writer.Write(item.item.Unit + ",");//第一列
                writer.Write(item.item.TotalPrice + ",");//第一列
                writer.Write(item.info.CreateUserName + ",");//第一列
                writer.Write(item.info.CreateUserType + ",");//第一列
                writer.Write(item.info.CreateUserTel + ",");//第一列
                writer.Write("订货服务站" + ",");//第一列
                writer.Write(item.info.Province+item.info.City+item.info.Area + ",");//第一列
                writer.Write(item.item.SupplierName + ",");//第一列
                writer.Write( ((OrderStatus)item.info.Stutas).ToString() + ",");//第一列
                writer.Write(item.info.CreateTime.ToString("yyyy-MM-dd HH:mm:ss") + ",");//第一列
                writer.Write(item.item.Price + ",");//第一列
                writer.Write(item.item.Price + ",");//第一列
                writer.Write(item.item.RealPrice + ",");//第一列
                writer.Write(item.item.Count + ",");//第一列
                writer.Write("0" + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.Id.ToString("N") + ",");//第一列

                writer.WriteLine();
            }
            writer.Flush();

            output.Position = 0;

            //return File(output, "text/comma-separated-values", "demo1.csv");
            return "";
        }
    }

}
