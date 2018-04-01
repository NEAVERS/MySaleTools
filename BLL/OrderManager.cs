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
            if (saleManId != "0" && !string.IsNullOrWhiteSpace(saleManId))
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
    }

}
