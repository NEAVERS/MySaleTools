using Common;
using Common.Entities;
using Dal;
using Dal.Mapping.Erp;
using Model;
using Model.Erp;
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

        private ErpContext _erp = new ErpContext();

        private ResponseModel _response = new ResponseModel();

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
                    && c.CreateUserId == userId
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
            foreach (var item in list)
            {
                item.OrderId = order.Id;
                item.OrderNum = order.OrderNum;
                item.IsInShoppingCar = false;
                totalPrice += item.TotalPrice;
            }

            order.TotalMoney = totalPrice;
            order.RealMoney = totalPrice - order.LessMoney;
            order.Stutas = (int)OrderStatus.等待商家发货;
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

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="createUserId"></param>
        /// <returns></returns>
        public List<OrderInfo> GetOrderListPage(Guid createUserId, int index, int stutas)
        {
            var q = from c in _context.OrderInfoes
                    where c.CreateUserId == createUserId
                    select c;
            if (stutas != -1)
            {
                if (stutas == 1)///待收货
                    q = q.Where(x => x.Stutas == 1 || x.Stutas == 2);
                else///已收货
                    q = q.Where(x => x.Stutas == 3);
            }
            var list = q.OrderByDescending(x => x.CreateTime).Skip((index - 1) * 5).Take(5).ToList();
            return list;

        }

        public PageData<OrderInfo> GetOrderList(int index, int size, DateTime start, DateTime end, string province, string city, string area, int stutas, string saleManId, int userType, string key, Guid managerId, bool isAdmin = false, decimal orderPay = 0)
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
            key = key.Trim();
            q = q.Where(x => x.OrderNum.Contains(key) || x.StoreName.Contains(key) || x.CreateUserNum.Contains(key));
            if (managerId != Guid.Empty)
            {
                if (isAdmin)
                    q = q.Where(x => x.RootUserId == managerId);///系统管理员查看
                else
                    q = q.Where(x => x.SaleManGuid == managerId);//业务员查看
            }
            q = q.Where(x => x.TotalMoney >= orderPay);///根据订单金额筛选
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

        public bool ReBuy(Guid orderId)
        {
            var Items = _context.OrderItems.Where(x => x.OrderId == orderId && !x.IsDelete && !x.IsInShoppingCar).ToList();

            var list = Utils.DeepCopyByJson(Items);
            list.ForEach(x => {
                x.Id = Guid.NewGuid();
                x.OrderId = Guid.Empty;
                x.OrderNum = string.Empty;
                x.IsInShoppingCar = true;
            });
            _context.OrderItems.AddRange(list);
            return _context.SaveChanges() > 0;
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
                model.Stutas = (int)OrderStatus.订单取消成功;
            return _context.SaveChanges() > 0;
        }


        /// <summary>
        /// 取货单
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="SupplierId"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 拣货单
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="SupplierId"></param>
        /// <returns></returns>
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
        public MemoryStream CreateOrderFile(DateTime start, DateTime end,string key)
        {
            var q = from c in _context.OrderInfoes
                    join d in _context.OrderItems on c.Id equals d.OrderId
                    join u in _context.UserInfoes on c.CreateUserId equals u.UserId
                    join g in _context.GoodInfoes on d.ProductId equals g.Id
                    where c.CreateTime > start && c.CreateTime < end
                    &&(c.OrderNum.Contains(key) || c.StoreName.Contains(key) || c.CreateUserNum.Contains(key))
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



        public MemoryStream CreateOrderCountFile(List<OrderCountByStore> list)
        {
            System.IO.MemoryStream output = new System.IO.MemoryStream();

            System.IO.StreamWriter writer = new System.IO.StreamWriter(output, System.Text.Encoding.UTF8);

                writer.Write("序号,小店编号,小店名称,小店地址,客户类型,业务员,订单总数,订单总金额,应付总金额,实收总金额,联系方式,区域");//输出标题，逗号分割（注意最后一列不加逗号）

                writer.WriteLine();
            //输出内容
            int num = 0;
                foreach (var item in list)
                {
                num++;
                    writer.Write(num + ",");//第一列
                    writer.Write(item.StoreNum + ",");//第一列
                    writer.Write(item.StoreName + ",");//第一列
                    writer.Write(item.Addr+ ",");//第一列
                    writer.Write(item.UserType + ",");//第一列
                    writer.Write(item.SaleMan + ",");//第一列
                    writer.Write(item.OrderCount + ",");//第一列
                    writer.Write(item.TotalMoeny + ",");//第一列
                    writer.Write(item.TotalPayMoney + ",");//第一列
                    writer.Write(item.TotalRealMoney + ",");//第一列
                    writer.Write(item.Tel + ",");//第一列
                    writer.Write(item.Areas + ",");//第一列

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
            if (type == 2 && !string.IsNullOrEmpty(parent))
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
        /// 整单退货
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="typeCode"></param>
        /// <param name="type"></param>
        /// <param name="reasonCode"></param>
        /// <param name="reason"></param>
        /// <returns></returns>
        public bool SetAllOrderError(Guid orderId, string typeCode, string type, string reasonCode, string reason)
        {
            var list = _context.OrderItems.Where(x => x.OrderId == orderId);
            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            order.Stutas = (int)OrderStatus.退货中;
            order.IsError = true;
            foreach (var model in list)
            {
                model.ErrorTypeCode = typeCode;
                model.ErrorType = type;
                model.ErrorReasonCode = reasonCode;
                model.ErrorReason = reason;
                model.ErrorMark = "";
                model.ErrorCount = model.Count;
                model.IsError = true;
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
        public bool ConfirmOrderPay(Guid confirmId, Guid orderId, decimal payMoney, string remark, Guid sendPeopleId)
        {
            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            if (order != null)
            {
                var sendPeople = _context.UserInfoes.FirstOrDefault(x => x.UserId == sendPeopleId);
                var confirmPeople = _context.UserInfoes.FirstOrDefault(x => x.UserId == confirmId);
                order.Stutas = (int)OrderStatus.交易完成;
                order.PayMoney = payMoney;
                order.ReceiveUserId = confirmPeople.UserId;
                order.ReceiveUserName = confirmPeople.UserName;
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
        public List<OrderInfo> GetErrorOrders(DateTime start, DateTime end, Guid userId)
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

        public List<OrderInfo> GetOrderForPayContrast(Guid managerId, int timeType, DateTime start, DateTime end, string orderNum, Guid send, Guid sale, int userTypeId, int payStutas)
        {
            var q = from c in _context.OrderInfoes
                    where !c.IsDelete
                    && c.RootUserId == managerId
                    select c;
            if (timeType == 1)
                q = q.Where(x => x.CreateTime > start && x.CreateTime < end);
            else
                q = q.Where(x => x.PayTime > start && x.PayTime < end);
            if (!string.IsNullOrWhiteSpace(orderNum))
                q = q.Where(x => x.OrderNum.Contains(orderNum));
            if (send != Guid.Empty)
                q = q.Where(x => x.SendPeopleId == send);
            if (sale != Guid.Empty)
                q = q.Where(x => x.SaleManGuid == sale);
            if (userTypeId != -1)
                q = q.Where(x => x.CreateUserTypeId == userTypeId);
            if (payStutas != -1)
            {
                q = q.Where(x => x.IsPay == (payStutas == 1));
            }
            return q.ToList();
        }

        public List<OrderCountByStore> GetOrderTotal(DateTime start, DateTime end, string province, string city, string area, Guid userId, decimal orderMoney = 0)
        {
            var uerTypelist = Utils.GetUserTypes().Select(x => x.TypeId).ToList();
            var user = from c in _context.UserInfoes
                       where !c.IsDelete
                       && uerTypelist.Contains(c.TypeId)
                       && c.CreateUserId == userId
                       select c;

            if (province != "-1" && !string.IsNullOrWhiteSpace(province))
                user = user.Where(x => x.ProvinceNum == province);
            if (city != "-1" && !string.IsNullOrWhiteSpace(city))
                user = user.Where(x => x.CityNum == city);
            if (area != "-1" && !string.IsNullOrWhiteSpace(area))
                user = user.Where(x => x.AreaNum == area);
            var list = new List<OrderCountByStore>();
            var userList = user.ToList();
            int num = 0;
            foreach (var item in userList)
            {
                var model = new OrderCountByStore();
                var orderList = _context.OrderInfoes.Where(x => x.CreateUserId == item.UserId && x.CreateTime > start && x.CreateTime < end);
                if (orderList == null || orderList.Count() < 1)
                    continue;
                num++;
                model.Addr = item.Addr;
                model.Num = num;
                model.OrderCount = orderList.Count();
                model.StoreName = item.SotreName;
                model.StoreNum = item.UserNum;
                model.Tel = item.Tel;
                model.UserType = item.TypeName;
                model.SaleMan = item.SaleManName;
                model.TotalMoeny = orderList.Sum(x => x.TotalMoney);
                model.TotalPayMoney = orderList.Sum(x => x.PayMoney);
                model.TotalRealMoney = orderList.Sum(x => x.RealMoney);
                model.Areas = item.Province + item.City + item.Area;
                list.Add(model);

            }
            list = list.Where(x => x.TotalMoeny > orderMoney).ToList();
            return list;
        }

        



        public List<OrderCountByStore> GetOrderTotalBySaleMan(DateTime start, DateTime end, Guid userId)
        {
           
            var uerTypelist = Utils.GetUserTypes().Select(x => x.TypeId).ToList();
            var user = from c in _context.UserInfoes
                       where !c.IsDelete
                       && c.TypeId == (int)SystemUserType.业务员
                       && c.CreateUserId == userId
                       select c;

            var list = new List<OrderCountByStore>();
            var userList = user.ToList();
            int num = 0;
            foreach (var item in userList)
            {
                var model = new OrderCountByStore();
                var orderList = _context.OrderInfoes.Where(x => x.SaleManGuid == item.UserId && x.CreateTime > start && x.CreateTime < end);
                if (orderList == null || orderList.Count() < 1)
                    continue;
                num++;
                model.Addr = item.UserName;
                model.Num = num;
                model.OrderCount = orderList.Count();
                model.TotalMoeny = orderList.Sum(x => x.TotalMoney);
                model.TotalPayMoney = orderList.Sum(x => x.PayMoney);
                model.TotalRealMoney = orderList.Sum(x => x.RealMoney);
                list.Add(model);

            }
            return list;
        }



        /// <summary>
        /// 商品销售统计
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="fst"></param>
        /// <returns></returns>
        public List<GoodsSaleMode> GetGoodsSaleInfo(DateTime start, DateTime end, string key, string fst, Guid UserId)
        {
            var q = from c in _context.OrderInfoes
                    join d in _context.OrderItems on c.Id equals d.OrderId
                    where c.CreateTime > start
                    && c.CreateTime < end
                    && c.RootUserId == UserId
                    && d.ProductTittle.Contains(key)
                    select new
                    {
                        info = c,
                        item = d
                    };
            if (!string.IsNullOrWhiteSpace(fst))
                q = q.Where(x => x.item.ProductTypeId.ToString() == fst);
            var itemList = q.Select(x => x.item).ToList();

            var goodsIdList = from c in itemList
                              group c by c.ProductId into g
                              select g.Key;
            int index = 0;
            var list = new List<GoodsSaleMode>();
            foreach (var id in goodsIdList)
            {
                index++;
                var saleModel = new GoodsSaleMode();
                var goodModel = _context.GoodInfoes.FirstOrDefault(x => x.Id == id);
                var itemOrder = itemList.FirstOrDefault(x => x.ProductId == id);
                saleModel.Num = index;
                saleModel.BarCode = goodModel.BarCode;
                saleModel.CostPrice = goodModel.CostPrice;
                saleModel.SalePrice = itemOrder.Price;
                saleModel.ProductName = goodModel.GoodsTittle;
                saleModel.Supplier = goodModel.SupplierName;
                saleModel.TypeName = goodModel.FirstTypeName;
                saleModel.TotalCount = itemList.Where(x => x.ProductId == id).Sum(x => x.Count);
                saleModel.TotalMoney = itemList.Where(x => x.ProductId == id).Sum(x => x.TotalPrice);
                list.Add(saleModel);
            }
            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="errorType"></param>
        /// <param name="SupplierId"></param>
        /// <param name="SType"> 1 根据异常类型统计，2根据食品大类统计</param>
        public List<ErrorInfoModel> GetErrorInfo(DateTime start, DateTime end, string errorType, int SupplierId, string typeId, int SType)
        {
            var itemList = from c in _context.OrderInfoes
                           join d in _context.OrderItems on c.Id equals d.OrderId
                           where c.CreateTime > start
                           && c.CreateTime < end
                           && c.IsError
                           && d.ErrorCount > 0
                           select d;
            if (!string.IsNullOrWhiteSpace(errorType) && errorType != "-1")
                itemList = itemList.Where(x => x.ErrorTypeCode == errorType);
            if (SupplierId > -1)
                itemList = itemList.Where(x => x.SupplierId == SupplierId);
            if (!string.IsNullOrWhiteSpace(typeId) && typeId != "-1")
                itemList = itemList.Where(x => x.ProductTypeId.ToString() == typeId);

            var items = itemList.ToList();
            var list = new List<ErrorInfoModel>();
            if (SType == 1)
            {
                var group = from c in items
                            group c by new { c.ErrorReasonCode } into g
                            select new
                            {
                                ErrorReasonCode = g.Key.ErrorReasonCode
                            };
                foreach (var item in group)
                {
                    var model = new ErrorInfoModel();
                    var orderItem = items.FirstOrDefault(x => x.ErrorReasonCode == item.ErrorReasonCode);
                    model.ErrorType = orderItem.ErrorType;
                    model.ErrorReason = orderItem.ErrorReason;
                    model.ErrorCout = items.Where(x => x.ErrorReasonCode == item.ErrorReasonCode).Sum(x => x.ErrorCount);
                    model.ErrorTotal = items.Where(x => x.ErrorReasonCode == item.ErrorReasonCode).Sum(x => (x.ErrorCount * x.Price));
                    list.Add(model);
                }
            }
            else if (SType == 2)
            {

                var group = from c in items
                            group c by new { c.ProductId, c.ErrorTypeCode } into g
                            select g.Key;

                foreach (var key in group)
                {
                    var item = items.FirstOrDefault(x => x.ProductId == key.ProductId && x.ErrorTypeCode == key.ErrorTypeCode);
                    var _items = items.Where(x => x.ProductId == key.ProductId && x.ErrorTypeCode == key.ErrorTypeCode);
                    var model = new ErrorInfoModel();
                    model.ErrorType = item.ErrorType;
                    model.ErrorCout = _items.Sum(x => x.ErrorCount);
                    model.ErrorTotal = _items.Sum(x => x.ErrorCount * x.Price);
                    model.ProductType = item.ProductType;
                    model.ProductName = item.ProductTittle;
                    list.Add(model);
                }
            }
            return list;
        }


        /// <summary>
        /// 异常天数统计
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>

        public List<ErrorDayModel> GetErrDays(DateTime start, DateTime end, Guid UserId)
        {

            var q = from c in _context.OrderItems
                    join d in _context.OrderInfoes on c.OrderId equals d.Id
                    where d.CreateTime > start
                    && d.CreateTime < end
                    && d.RootUserId == UserId
                    && c.ErrorCount > 0
                    select new
                    {
                        orderItem = c,
                        createTime = d.CreateTime
                    };

            var res = from c in q
                      group c by new { c.createTime.Year, c.createTime.Month, c.createTime.Day, c.orderItem.ProductId } into g
                      select new
                      {
                          id = g.Key.ProductId,
                          TotalCount = g.Sum(p => p.orderItem.ErrorCount),
                          Days = g.Count()
                      };
            var list = new List<ErrorDayModel>();
            var resList = res.ToList();
            foreach (var item in resList)
            {
                var model = new ErrorDayModel();
                var goods = _context.GoodInfoes.FirstOrDefault(x => x.Id == item.id);
                model.Suplier = goods.SupplierName;
                model.ProductId = goods.ErpId;
                model.ProductName = goods.GoodsTittle;
                model.Spec = goods.Spec;
                model.Unit = goods.Unit;
                model.ErrorCount = item.TotalCount;
                model.ErrorDays = item.Days;
                list.Add(model);
            }
            return list;

        }

        public List<OrderInfo> UserGetOrderInfos(DateTime start, DateTime end, Guid userId)
        {
            var q = from c in _context.OrderInfoes
                    where c.CreateTime > start
                    && c.CreateTime < end
                    && c.CreateUserId == userId
                    select c;

            return q.ToList();
        }

        public ResponseModel UserCancelOrder(Guid orderId)
        {
            
            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId);
            if (order != null)
            {
                var now = DateTime.Now;
                var yesterday = DateTime.Now.AddDays(-1);
                DateTime start = new DateTime(yesterday.Year, yesterday.Month, yesterday.Day, 16, 0, 0);
                DateTime end = new DateTime(now.Year, now.Month, now.Day, 16, 0, 0);
                if ((order.CreateTime>start&&order.CreateTime<end&&DateTime.Now<end)||(order.CreateTime>end&&DateTime.Now>end))
                {
                    order.Stutas = (int)OrderStatus.订单取消中;
                    order.OrderCancelTime = DateTime.Now;
                    _response.Stutas = _context.SaveChanges() > 0;
                    _response.Msg = "保存失败！请刷新后重试";
                }
                else
                    _response.Msg = "超出时限无法取消";

                if ((order.CreateTime > start && order.CreateTime < end) || (order.CreateTime < start && order.CreateTime > start.AddDays(-1) && order.CreateTime < end))
                {
                    order.Stutas = (int)OrderStatus.订单取消中;
                    order.OrderCancelTime = DateTime.Now;
                    _response.Stutas = _context.SaveChanges() > 0;
                    _response.Msg = "保存失败！请刷新后重试";
                }
                else
                    _response.Msg = "超出时限无法取消";
            }
            else
                _response.Msg = "该订单不存在！";
            
            return _response;
        }

        public ResponseModel CheckCancel(Guid orderId,bool isAgree)
        {

            var order = _context.OrderInfoes.FirstOrDefault(x => x.Id == orderId&&x.Stutas==(int)OrderStatus.订单取消中);

            if (order != null)
            {
                if (isAgree)
                    order.Stutas = (int)OrderStatus.订单取消成功;
                else
                    order.Stutas = (int)OrderStatus.等待商家发货;
                order.CheckCancelTime = DateTime.Now;
                _response.Stutas =  _context.SaveChanges() > 0;
                _response.Msg = "操作失败，请重试";
            }
            else
                _response.Msg = "该待取消的订单不存在！";
            return _response;
        }

        #region 订单生成后倒入销售订单到erp

        private string GetCode(int count)
        {
            count = 9999 - count;
            var str = count.ToString();
            int zeroCount = 4 - str.Length;
            str = new string('0', zeroCount) + str;
            return str;
        }


        public bool InsertErp(Guid orderId, int baseSupplierId)
        {
            var orderDetail = GetOrderDetail(orderId);
            var list = orderDetail.Items.Where(x => x.SupplierId == baseSupplierId);
            var date = DateTime.Now.Date;
            var cout = _erp.OrderIndexes.Count(x => x.billtype == 300 && x.BillDate == date);
            OrderIndex orderIndex = new OrderIndex();
            #region 初始化
            orderIndex.btypeid = "0000100001";
            orderIndex.etypeid = "000010004100004";
            orderIndex.ktypeid = "00001";
            orderIndex.BillDate = date;
            orderIndex.ReachDate = date;
            orderIndex.Billcode = "XD-T-" + DateTime.Now.ToString("yyyy-MM-dd") + "-" + GetCode(cout + 1);
            orderIndex.billtype = 300;
            orderIndex.totalmoney = list.Sum(x => x.TotalPrice);
            orderIndex.totalqty = list.Sum(x => x.Count);
            orderIndex.period = 1;
            orderIndex.@checked = false;
            orderIndex.redWord = false;
            orderIndex.BillOver = false;
            orderIndex.comment = string.Empty;
            orderIndex.explain = string.Empty;
            orderIndex.Checke = "000010004100004";
            orderIndex.Tax = 0;
            orderIndex.BillStatus = 0;
            orderIndex.etypeid2 = string.Empty;
            orderIndex.WayMode = string.Empty;
            orderIndex.WayBillCode = string.Empty;
            orderIndex.GoodsNumber = string.Empty;
            orderIndex.PackWay = string.Empty;
            orderIndex.TEL = string.Empty;
            orderIndex.IfAudit = 1;
            orderIndex.DtypeId = "000010004100004";
            orderIndex.IsFinished = null;
            orderIndex.CanAlert = "1";
            orderIndex.DelayType = "0";
            orderIndex.DelayValue = "0";
            orderIndex.OrderState = "0";
            orderIndex.Stypeid = "00001";
            orderIndex.FromBillNumberID = null;
            orderIndex.CustomerTotal = 0;
            orderIndex.IsIni = false;
            orderIndex.Ntotalmoney = list.Sum(x => x.TotalPrice);
            orderIndex.CID = 1;
            orderIndex.Rate = 1;
            orderIndex.billproperty = -1;
            orderIndex.PrePriceNum = 1;
            orderIndex.IsYapi = false;
            orderIndex.YapiOrderID = string.Empty;
            orderIndex.NCustomerTotal = 0;
            orderIndex.DealBTypeID = "0000100001";
            orderIndex.atypeID = "0";
            orderIndex.totalinmoney = 0;
            orderIndex.ntotalinmoney = 0;
            orderIndex.checkTime = DateTime.Now;
            orderIndex.Discount = 1;
            int showOrder = 1;
            var billList = new List<OrderBill>();
            foreach (var x in orderDetail.Items)
            {
                var model = new OrderBill();

                var goods = _context.GoodInfoes.FirstOrDefault(c => c.Id == x.ProductId);
                if (goods == null || string.IsNullOrWhiteSpace(goods.GoodsNum))
                    continue;
                var pinfo = _erp.ptypes.FirstOrDefault(c => c.typeId == goods.GoodsNum);
                if (pinfo == null)
                    continue;
                var unit_ex = _erp.PType_Units_Exts.FirstOrDefault(c => c.PtypeID == pinfo.typeId && c.UnitsId == pinfo.SaleUnitId);
                if (unit_ex == null)
                    continue;
                model.ptypeid = goods.GoodsNum;
                model.qty = x.Count * unit_ex.Rate;
                model.price = x.RealPrice / unit_ex.Rate;
                model.total = x.TotalPrice;
                model.ReachQty = 0;
                model.comment = string.Empty;
                model.Checked = false;
                model.TeamNO1 = null;
                model.PassQty = 0;
                model.IsUnit2 = false;
                model.Discount = 0;
                model.DiscountPrice = x.RealPrice / unit_ex.Rate;
                model.TaxPrice = x.RealPrice / unit_ex.Rate;
                model.TaxTotal = x.TotalPrice;
                model.SaleTotal = x.TotalPrice;
                model.Tax = 0;
                model.KTypeID = "00001";
                model.Stypeid = "00001";
                model.FromBillNumberID = 0;
                model.entrycode = goods.BarCode;
                model.FromBillID = 0;
                model.ReachTotal = 0;
                model.ReachTaxTotal = 0;
                model.RequestBillNumberID = 0;
                model.RequestBillID = 0;
                model.AskBillNumberID = 0;
                model.AskBillID = 0;
                model.TaxMoney = 0;
                model.NSalePrice = x.RealPrice / unit_ex.Rate;
                model.NSaleTotal = x.TotalPrice;
                model.NDiscountPrice = x.RealPrice / unit_ex.Rate;
                model.NTotal = x.TotalPrice;
                model.NTaxPrice = x.RealPrice / unit_ex.Rate;
                model.NTaxTotal = x.TotalPrice;
                model.NTaxMoney = 0;
                model.UnitID = pinfo.baseUnitId;
                model.NUnitID = 0;
                model.NQty = 0;
                model.UnitRate = 0;
                model.NUnitMsg = null;
                model.MUnitID = unit_ex.UnitsId;
                model.MQty = x.Count;
                model.MUnitRate = unit_ex.Rate;
                model.MUnitMsg = null;
                model.MSalePrice = x.RealPrice;
                model.MDiscountPrice = x.RealPrice;
                model.MTaxPrice = x.RealPrice;
                model.CurMSalePrice = x.RealPrice;
                model.CurMDiscountPrice = x.RealPrice;
                model.CurMTaxPrice = x.RealPrice;
                model.ItemID = 0;
                model.IsCombined = 0;
                model.GoodsCostPrice = -1;
                model.GoodsOrder = -1;
                model.ProduceDate = string.Empty;
                model.ValidDate = string.Empty;
                model.IsGift = x.IsGift ? 1 : 0;
                model.YapiID = string.Empty;
                model.PriceSource = string.Empty;
                model.Id = showOrder;
                model.PromoType = 0;
                model.ShowOrder = showOrder;
                model.WaitQty = 0;
                model.BillOver = false;
                model.GoodsNumber = string.Empty;
                model.CargoID = 0;
                model.stopreason = string.Empty;
                showOrder++;
                billList.Add(model);
            };
            #endregion
            using (var scope = _erp.Database.BeginTransaction())
            {
                try
                {
                    _erp.OrderIndexes.Add(orderIndex);
                    _erp.SaveChanges();
                    billList.ForEach(x => x.billNumberID = orderIndex.billNumberId);
                    _erp.OrderBills.AddRange(billList);
                    _erp.SaveChanges();
                    scope.Commit();//正常完成就可以提交
                }
                catch (Exception ex)
                {
                    LogsHelper.WriteErrorLog("导入ERP失败",ex, "订单管理");
                    scope.Rollback();//发生异常就回滚
                    return false;
                }
            }
            return true;
        }


        #endregion
    }

}
