using Common.Entities;
using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
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


        public bool IsExitInCar(Guid goodsId, Guid createUserId, out OrderItem baseItem)
        {
            var model = _context.OrderItems.FirstOrDefault(x => x.ProductId == goodsId
            && x.IsInShoppingCar
            && !x.IsDelete
            && x.CreateUserId == createUserId
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
            order.RealMoney = realPrice;
            order.Stutas = 1;
            _context.OrderInfoes.Add(order);
            return _context.SaveChanges() > 0;
        }


        public bool AddOrderItem(OrderItem item)
        {
            _context.OrderItems.Add(item);
            return _context.SaveChanges() > 0;
        }
        /// <summary>
        /// 修改商品数量
        /// </summary>
        /// <param name="itemId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public bool SaveOrderItem(Guid itemId, int count)
        {
            var item = _context.OrderItems.FirstOrDefault(x => x.Id == itemId);
            if (item != null)
            {
                item.Count = count;
                item.TotalPrice = count * item.Price;
            }
            return _context.SaveChanges() > 0;
        }

        public bool ClearShopping(Guid userId)
        {
            var list = from c in _context.OrderItems
                       where c.CreateUserId == userId
                       && c.IsInShoppingCar
                       && !c.IsDelete
                       select c;
            foreach (var item in list)
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
            return _context.SaveChanges() > 0;
        }


        /// <summary>
        /// 删除订单
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public bool DeleteOrder(Guid orderId)
        {
            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            if (order != null)
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
        public List<OrderInfo> GetOrderListByCreateUserId(DateTime start, DateTime end, Guid createUserId)
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

        public OrderDetail GetOrderDetail(string orderNUm)
        {
            var detail = new OrderDetail();
            detail.Info = _context.OrderInfoes.FirstOrDefault(x => x.OrderNum == orderNUm);
            detail.Items = _context.OrderItems.Where(x => x.OrderNum == orderNUm && !x.IsDelete && !x.IsInShoppingCar).ToList();
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
                model.Stutas = (int)OrderStatus.订单取消中;
            return _context.SaveChanges() > 0;
        }



        public List<GetProductModel> GetProductBill(DateTime start, DateTime end, int SupplierId)
        {
            var q = from c in _context.OrderItems
                    join d in _context.OrderInfoes on c.OrderId equals d.Id
                    where !c.IsInShoppingCar
                    && !c.IsDelete
                    && d.CreateTime > start
                    && d.CreateTime < end
                    && (SupplierId == -1 || c.SupplierId == SupplierId)
                    group c by c.SupplierId into g
                    select g.Key;

            List<GetProductModel> list = new List<GetProductModel>();
            var SupplierIds = q.ToList();
            foreach (var id in SupplierIds)
            {
                GetProductModel model = new GetProductModel();
                var items = new List<GetProductItem>();
                model.SupplierInfo = _context.Suppliers.FirstOrDefault(x => x.Id == id);
                var allitems = from c in _context.OrderItems
                               where !c.IsInShoppingCar
                                && !c.IsDelete
                                && c.SupplierId == id
                               select c;
                var ids = from c in allitems
                          group c by c.ProductId into g
                          select g.Key;
                var goodIds = ids.ToList();
                foreach (var itemId in goodIds)
                {
                    var item = allitems.FirstOrDefault(x => x.ProductId == itemId);
                    var goodsInfo = _context.GoodInfoes.FirstOrDefault(x => x.Id == item.ProductId);
                    var gItem = new GetProductItem();

                    gItem.Count = allitems.Where(x => x.ProductId == itemId).Sum(x => x.Count);
                    gItem.ProductName = goodsInfo.GoodsTittle;
                    gItem.BarCode = goodsInfo.BarCode;
                    gItem.Pirce = goodsInfo.CostPrice;
                    gItem.Spec = goodsInfo.Spec;
                    gItem.Unit = goodsInfo.Unit;
                    gItem.TotalPirce = gItem.Count * gItem.Pirce;
                    gItem.Remark = "";
                    items.Add(gItem);
                }
                model.Items = items;
                list.Add(model);
            }
            return list;
        }

        public List<PickUpModel> GetPickUpBill(DateTime start, DateTime end, int SupplierId)
        {
            List<PickUpModel> list = new List<PickUpModel>();

            var q = from c in _context.OrderItems
                    join d in _context.OrderInfoes on c.OrderId equals d.Id
                    where !c.IsInShoppingCar
                    && !c.IsDelete
                    && d.CreateTime > start
                    && d.CreateTime < end
                    && (SupplierId == -1 || c.SupplierId == SupplierId)
                    group c by c.OrderId into g
                    select g.Key;
            var orderIds = q.ToList();
            foreach (var orderId in orderIds)
            {
                var model = new PickUpModel();

                var items = new List<GetProductItem>();

                var orderInfo = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
                model.CreateTime = orderInfo.CreateTime;
                model.OrderNum = orderInfo.OrderNum;
                model.Mark = "乐清1";

                var allitems = from c in _context.OrderItems
                               where !c.IsInShoppingCar
                                && !c.IsDelete
                                && c.OrderId == orderId
                               select c;
                var ids = from c in allitems
                          group c by c.ProductId into g
                          select g.Key;
                var goodIds = ids.ToList();
                foreach (var itemId in goodIds)
                {
                    var item = allitems.FirstOrDefault(x => x.ProductId == itemId);
                    var goodsInfo = _context.GoodInfoes.FirstOrDefault(x => x.Id == item.ProductId);
                    var gItem = new GetProductItem();
                    gItem.Count = allitems.Where(x => x.ProductId == itemId).Sum(x => x.Count);
                    gItem.ProductName = goodsInfo.GoodsTittle;
                    gItem.BarCode = goodsInfo.BarCode;
                    gItem.Pirce = item.Price;
                    gItem.Spec = goodsInfo.Spec;
                    gItem.Unit = goodsInfo.Unit;
                    gItem.TotalPirce = item.Price;
                    gItem.Remark = "";
                    items.Add(gItem);
                }
                model.Items = items;
                list.Add(model);
            }
            return list;
        }



        /// <summary>
        /// 导出订单列表
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public MemoryStream CreateOrderFile(DateTime start, DateTime end)
        {
            var q = from c in _context.OrderInfoes
                    join d in _context.OrderItems on c.Id equals d.OrderId
                    join u in _context.UserInfoes on c.CreateUserId equals u.UserId
                    join g in _context.GoodInfoes on d.ProductId equals g.Id
                    where c.CreateTime > start && c.CreateTime < end
                    select new
                    {
                        info = c,
                        item = d,
                        user = u,
                        good = g,
                    };

            System.IO.MemoryStream output = new System.IO.MemoryStream();

            System.IO.StreamWriter writer = new System.IO.StreamWriter(output, System.Text.Encoding.UTF8);

            writer.Write("订单号,总订单号,商品条形码,商品父级id,商品id,商品类目,商品,商品品牌,规格,单位,总金额,订货人,客户类型,电话,订货服务站,地区,卖家,订单状态,订购日期,单价,成本价,实收金额,下单数量,异常数量,编号,标记,支付类型,小店名称,业务员,送货员,分拣员,订单完成日期,订单备注,供应商编号,加盟商");//输出标题，逗号分割（注意最后一列不加逗号）

            writer.WriteLine();
            //输出内容
            foreach (var item in q)
            {
                writer.Write(item.info.Id.ToString("N") + ",");//第一列
                writer.Write(item.info.OrderNum + ",");//第一列
                writer.Write(item.item.BarCode + ",");//第一列
                writer.Write("0" + ",");//第一列
                writer.Write(item.item.ProductId.ToString("N") + ",");//第一列
                writer.Write(item.good.FirstTypeName + ",");//第一列
                writer.Write(item.item.ProductTittle + ",");//第一列
                writer.Write(item.item.Brand + ",");//第一列
                writer.Write(item.item.Spec + ",");//第一列
                writer.Write(item.item.Unit + ",");//第一列
                writer.Write(item.item.TotalPrice + ",");//第一列
                writer.Write(item.info.CreateUserName + ",");//第一列
                writer.Write(item.info.CreateUserType + ",");//第一列
                writer.Write(item.info.CreateUserTel + ",");//第一列
                writer.Write("订货服务站" + ",");//第一列
                writer.Write(item.info.Province + item.info.City + item.info.Area + ",");//第一列
                writer.Write(item.item.SupplierName + ",");//第一列
                writer.Write(((OrderStatus)item.info.Stutas).ToString() + ",");//第一列
                writer.Write(item.info.CreateTime.ToString("yyyy-MM-dd HH:mm:ss") + ",");//第一列
                writer.Write(item.item.Price + ",");//第一列
                writer.Write(item.item.Price + ",");//第一列
                writer.Write(item.item.RealPrice + ",");//第一列
                writer.Write(item.item.Count + ",");//第一列
                writer.Write("0" + ",");//第一列
                writer.Write(item.user.UserNum + ",");//第一列
                writer.Write("0" + ",");//第一列
                writer.Write(item.info.PayType + ",");//第一列
                writer.Write(item.user.SotreName + ",");//第一列
                writer.Write(item.user.SaleManName + ",");//第一列
                writer.Write("" + ",");//第一列
                writer.Write("" + ",");//第一列
                ///订单完成时间
                writer.Write(item.info.CompleteTime.HasValue ? item.info.CompleteTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "" + ",");//第一列
                writer.Write(item.info.Remark + ",");//第一列
                writer.Write(item.good.SupplierNum + ",");//第一列
                writer.Write("");//第一列

                writer.WriteLine();
            }
            writer.Flush();

            output.Position = 0;

            //return File(output, "text/comma-separated-values", "demo1.csv");
            return output;
        }

        /// <summary>
        /// 获取异常类型
        /// </summary>
        /// <param name="type">1为异常类型，2为异常原因</param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public List<ErrorReason> GetErrorReasonByType(int type, string parent = "")
        {
            var q = _context.ErrorReasons.Where(x => x.Type == type);
            if (type == 2&&!string.IsNullOrEmpty(parent))
                q = q.Where(x => x.ParentCode == parent);
            return q.ToList();
        }

        /// <summary>
        /// 设置订单子项异常
        /// </summary>
        /// <param name="orderItemId"></param>
        /// <param name="count"></param>
        /// <param name="typeCode"></param>
        /// <param name="type"></param>
        /// <param name="reasonCode"></param>
        /// <param name="reason"></param>
        /// <param name="mark"></param>
        /// <returns></returns>
        public bool SetErrorInfo(Guid orderItemId, int count, string typeCode, string type, string reasonCode, string reason, string mark)
        {
            var model = _context.OrderItems.FirstOrDefault(x => x.Id == orderItemId);
            if (model != null)
            {
                model.ErrorTypeCode = typeCode;
                model.ErrorType = type;
                model.ErrorReasonCode = reasonCode;
                model.ErrorReason = reason;
                model.ErrorMark = mark;
                model.ErrorCount = count;
                model.IsError = true;
                var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == model.OrderId);
                order.IsError = true;
            }
            
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 保存订单备注
        /// </summary>
        /// <param name="ordeId"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public bool SaveOrderRemark(Guid ordeId, string remark)
        {
            var model = _context.OrderInfoes.FirstOrDefault(x => x.Id == ordeId);
            if (model != null)
            {
                model.AdminRemark = remark;
            }
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 订单收款登记
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="payMoney"></param>
        /// <param name="remark"></param>
        /// <param name="sendPeopleId"></param>
        /// <param name="ramrk"></param>
        /// <returns></returns>
        public bool ConfirmOrderPay(Guid orderId, decimal payMoney, string remark, Guid sendPeopleId)
        {
            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            if (order != null)
            {
                var sendPeople = _context.UserInfoes.FirstOrDefault(x => x.UserId == sendPeopleId);
                order.Stutas = (int)OrderStatus.交易完成;
                order.PayMoney = payMoney;
                if (sendPeople != null)
                {
                    order.SendPeople = sendPeople.UserName;
                    order.SendPeopleId = sendPeople.UserId;
                    order.SendPeopleTel = sendPeople.Tel;
                }
                order.PayTime = DateTime.Now;
                order.IsPay = true;
                order.AdminRemark = remark;

            }
            return _context.SaveChanges() > 0; ;
        }

        /// <summary>
        /// 撤销付款标记
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public bool RevertIsPay(Guid orderId)
        {
            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            if (order != null)
            {
                order.IsPay = false;
            }
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 获取异常订单
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<OrderInfo> GetErrorOrders(DateTime start ,DateTime end, Guid userId)
        {
            var q = from c in _context.OrderInfoes
                    where c.IsPay
                    && c.IsError
                    && c.PayTime > start
                    && c.PayTime < end
                    select c;
            return q.ToList();
        }


        /// <summary>
        /// 应收未收对比订单获取
        /// </summary>
        /// <param name="managerId"></param>
        /// <param name="timeType"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="orderNum"></param>
        /// <param name="send"></param>
        /// <param name="sale"></param>
        /// <param name="userTypeId"></param>
        /// <param name="payStutas"></param>
        /// <returns></returns>

        public List<OrderInfo> GetOrderForPayContrast(Guid managerId, int timeType, DateTime start,DateTime end,string orderNum,Guid send,Guid sale,int userTypeId,int payStutas)
        {
            var q = from c in _context.OrderInfoes
                    where !c.IsDelete
                    &&c.RootUserId == managerId
                    select c;
            if (timeType == 1)
                q = q.Where(x => x.CreateTime > start && x.CreateTime < end);
            else
                q = q.Where(x => x.PayTime > start && x.PayTime < end);
            if (!string.IsNullOrWhiteSpace(orderNum))
                q = q.Where(x => x.OrderNum.Contains(orderNum));
            if (send != Guid.Empty)
                q = q.Where(x => x.SendPeopleId == send);
            if(sale!=Guid.Empty)
                q = q.Where(x => x.SaleManGuid == sale);
            if(userTypeId!=-1)
                q = q.Where(x => x.CreateUserTypeId == userTypeId);
            if(payStutas!=-1)
            {
                q = q.Where(x => x.IsPay == (payStutas==1));
            }
            return q.ToList();
        }


        
    }

}
