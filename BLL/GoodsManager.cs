﻿using Common;
using Common.Entities;
using Dal;
using Dal.Mapping.Erp;
using Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GoodsManager
    {
        private SaleToolsContext _context = new SaleToolsContext();
        private ErpContext _erp = new ErpContext();
        ResponseModel _response = new ResponseModel();

        /// <summary>
        /// 获取下级类型
        /// </summary>
        /// <param name="parentId"></param>
        /// <param name="createUserId"></param>
        /// <returns></returns>
        public List<GoodsType>  GetDownGoodsType(Guid parentId,Guid createUserId)
        {
            var q = _context.GoodsTypes.Where(x => x.ParentId == parentId&&x.CreateUserId == createUserId&&!x.IsDelete);
            return q.ToList();
        }

        public bool SetIsFirstPage(Guid id,bool isF)
        {
            var model = _context.GoodsTypes.FirstOrDefault(x => x.Id == id);
            if (model != null)
                model.IsShowFirstPage = isF;
            return _context.SaveChanges()>0;
        }

        public bool SetSortId(Guid id, int sortid)
        {
            var model = _context.GoodsTypes.FirstOrDefault(x => x.Id == id);
            if (model != null)
                model.SortId = sortid;
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 添加商品类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool AddGoodsType( GoodsType type)
        {
            _context.GoodsTypes.Add(type);
            return _context.SaveChanges()>0;
        }
        /// <summary>
        /// 删除商品类型
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public bool DelGoodsType(Guid typeId)
        {
            var model = _context.GoodsTypes.FirstOrDefault(x => x.Id == typeId);
            model.IsDelete = true;
            return _context.SaveChanges()>0;
        }
        /// <summary>
        /// 根据类型Id获取品牌
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public List<GoodsBrand> GetBrandList(Guid typeId)
        {
            var q = from a in _context.BrandOfGoodsTypes
                    join b in _context.GoodsBrands on a.BandsId equals b.Id
                    where a.TypeId == typeId
                    select b;
            return q.ToList();
        }

        public List<GoodsBrand> GetAllBrand(Guid userId)
        {
            var q = _context.GoodsBrands.Where(x=>!x.IsDelete&&x.CreateUserId == userId).ToList();
            return q;
        }

        public GoodInfo GetGoodsByNum(string num,Guid userid)
        {
            return _context.GoodInfoes.FirstOrDefault(x => x.GoodsNum == num && !x.IsDelete && x.CreateUserId == userid);
        }

        public bool AddGoodsBrand(GoodsBrand brand)
        {
            _context.GoodsBrands.Add(brand);
            return _context.SaveChanges() > 0;
        }


        public ResponseModel DeleteGoodsBrands(List<string> ids)
        {
            try
            {
                var q = _context.GoodsBrands.Where(x => ids.Contains(x.Id.ToString()));
                _context.GoodsBrands.RemoveRange(q);
                _response.Stutas = _context.SaveChanges() > 0;
            }
            catch(Exception ex)
            {
                LogsHelper.WriteErrorLog(ex);
                _response.Msg = "删除失败！请刷新后重试！";
            }
            return _response;
        }
        public GoodsType GetTypeById(Guid typeId)
        {
            var q = _context.GoodsTypes.FirstOrDefault(x => x.Id == typeId);
            return q;
        }

        public bool SaveBrandOfType(Guid typeId,List<Guid> brandList)
        {
            var typeList = GetBrandList(typeId);
            foreach(var item in typeList)
            {
                if(!brandList.Contains(item.Id))
                {
                    var model = _context.BrandOfGoodsTypes.FirstOrDefault(x => x.TypeId == typeId && x.BandsId == item.Id);
                    _context.BrandOfGoodsTypes.Remove(model);
                }
            }

            foreach(var item in brandList)
            {
                if(!typeList.Exists(x=>x.Id == item))
                {
                    var model = new BrandOfGoodsType();
                    model.TypeId = typeId;
                    model.BandsId = item;
                    _context.BrandOfGoodsTypes.Add(model);
                }
            }
            return _context.SaveChanges() > 0;
        }

        public bool SaveGoodsInfo(GoodInfo good)
        {
            _context.GoodInfoes.Add(good);
            return _context.SaveChanges() > 0;
        }
        public bool SavePrice(List<PriceOfUserType> priceList)
        {
            priceList.ForEach(x =>
            {
                var model = _context.PriceOfUserTypes.FirstOrDefault(c => c.GoodsId == x.GoodsId && c.UserTypeId == x.UserTypeId);
                if (model == null)
                    _context.PriceOfUserTypes.Add(x);
                else
                    model.Price = x.Price;
            });
            return _context.SaveChanges() > 0;
        }


        public PageData<GoodInfo> GetGoodsListByManager(Guid CreaetUserId, int userType, int index, int size, string SupplierId, string fstTypeId, string secTypeId, string thdTypeId, string brandId, string keyWord,string IsUpShelves, string sort , string order)
        {
            PageData<GoodInfo> page = new PageData<GoodInfo>();
            page.PageIndex = index;
            page.PageSize = size;
            var q = from c in _context.GoodInfoes
                    where c.CreateUserId == CreaetUserId
                    && (c.GoodsTittle.Contains(keyWord)||c.KeyWord.Contains(keyWord)||c.BarCode == keyWord||c.GoodsNum.Contains(keyWord))
                    && !c.IsDelete
                    select c;
            if (!string.IsNullOrWhiteSpace(SupplierId) && SupplierId != "0")
                q = q.Where(x => x.SupplierId.ToString() == SupplierId);
            if (!string.IsNullOrWhiteSpace(fstTypeId) && fstTypeId != "0")
                q = q.Where(x => x.FirstTypeId.ToString() == fstTypeId);
            if (!string.IsNullOrWhiteSpace(secTypeId) && secTypeId != "0")
                q = q.Where(x => x.SecondTypeId.ToString() == secTypeId);
            if (!string.IsNullOrWhiteSpace(thdTypeId) && thdTypeId != "0")
                q = q.Where(x => x.ThirdTYypeId.ToString() == thdTypeId);
            if (!string.IsNullOrWhiteSpace(brandId))
                q = q.Where(x => x.BrandId.ToString() == brandId);
            if(!string.IsNullOrWhiteSpace(IsUpShelves)&&IsUpShelves!="0")
            {
                q = q.Where(x => x.IsUpShelves ==(IsUpShelves =="1"));
            }
            page.TotalCount = q.Count();


            q = q.OrderByDescending(x => x.SortId).ThenBy(x=>x.CreateTime);
            if(order =="Asc")
            {
                switch(sort)
                {
                    case "price":
                        q = q.OrderBy(x => x.BasePrice);
                        break;
                    case "edittime":
                        q = q.OrderBy(x => x.LastUpdateTime);
                        break;
                    case "mincount":
                        q = q.OrderBy(x => x.MinCount);
                        break;
                    case "sortid":
                        q = q.OrderBy(x => x.SortId);
                        break;
                    default:
                        q = q.OrderBy(x => x.LastUpdateTime);
                        break;
                }
            }
            else
            {
                switch (sort)
                {
                    case "price":
                        q = q.OrderByDescending(x => x.BasePrice);
                        break;
                    case "edittime":
                        q = q.OrderByDescending(x => x.LastUpdateTime);
                        break;
                    case "mincount":
                        q = q.OrderByDescending(x => x.MinCount);
                        break;
                    case "sortid":
                        q = q.OrderByDescending(x => x.SortId);
                        break;
                    default:
                        q = q.OrderByDescending(x => x.LastUpdateTime);
                        break;

                }
            }
            var list = q.Skip((index - 1) * size).Take(size).ToList();

            foreach (var item in list)
            {
                string tittle = "";
                item.RetailtPrice = GetPriceOfUserType(item, userType,out tittle);
                item.GoodsTittle = tittle;
                string id = item.ErpId;
                int boxspec = Utils.ParseInt(item.BoxSpec);
                if (boxspec == 0||!item.IsBoxSale)
                    boxspec = 1;
                int stock = GetGoodsStock(id, boxspec);
                item.Stock = stock;

            }
            page.ListData = list;
            return  page;
        }


        public PageData<GoodInfo> GetGoodsList(Guid CreaetUserId, int userType, int index, int size, string SupplierId, string fstTypeId, string secTypeId, string thdTypeId, string brandId, string keyWord, string IsUpShelves, string orderBy = "")
        {
            PageData<GoodInfo> page = new PageData<GoodInfo>();
            page.PageIndex = index;
            page.PageSize = size;
            var q = from c in _context.GoodInfoes
                    where c.CreateUserId == CreaetUserId
                    && (c.GoodsTittle.Contains(keyWord) || c.KeyWord.Contains(keyWord) || c.BarCode == keyWord || c.GoodsNum.Contains(keyWord))
                    && !c.IsDelete
                    select c;
            if (!string.IsNullOrWhiteSpace(SupplierId) && SupplierId != "0")
                q = q.Where(x => x.SupplierId.ToString() == SupplierId);
            if (!string.IsNullOrWhiteSpace(fstTypeId) && fstTypeId != "0")
                q = q.Where(x => x.FirstTypeId.ToString() == fstTypeId);
            if (!string.IsNullOrWhiteSpace(secTypeId) && secTypeId != "0")
                q = q.Where(x => x.SecondTypeId.ToString() == secTypeId);
            if (!string.IsNullOrWhiteSpace(thdTypeId) && thdTypeId != "0")
                q = q.Where(x => x.ThirdTYypeId.ToString() == thdTypeId);
            if (!string.IsNullOrWhiteSpace(brandId))
                q = q.Where(x => x.BrandId.ToString() == brandId);
            if (!string.IsNullOrWhiteSpace(IsUpShelves) && IsUpShelves != "0")
            {
                q = q.Where(x => x.IsUpShelves == (IsUpShelves == "1"));
            }
            page.TotalCount = q.Count();

            if(orderBy==""|| orderBy == "0")
                q = q.OrderByDescending(x => x.SortId).ThenBy(x => x.CreateTime);
            else
            {
                if (orderBy == "1")
                    q = q.OrderByDescending(x => x.BasePrice);
                else
                    q = q.OrderBy(x => x.BasePrice);

            }
           
            var list = q.ToList();


            foreach (var item in list)
            {
                string tittle = "";
                item.RetailtPrice = GetPriceOfUserType(item, userType,out tittle);
                item.GoodsTittle = tittle;
                string id = item.ErpId;
                int boxspec = Utils.ParseInt(item.BoxSpec);
                if (boxspec == 0 || !item.IsBoxSale)
                    boxspec = 1;
                int stock = GetGoodsStock(id,boxspec);
                item.Stock = stock;

            }
            list.RemoveAll(x => x.RetailtPrice == -1);
            var templist = list.Skip((index - 1) * size).Take(size).ToList();


            page.ListData = templist;
            return page;
        }

        /// <summary>
        /// 根据Id获取商品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GoodInfo GetGoodInfoById(Guid id)
        {
            var item = _context.GoodInfoes.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                int boxspec = Utils.ParseInt(item.BoxSpec);
                if (boxspec == 0 || !item.IsBoxSale)
                    boxspec = 1;

                int stock = GetGoodsStock(item.ErpId, boxspec);
                item.Stock = stock;

            }
            return item;
        }

        /// <summary>
        /// 更新排序ID
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="sortId"></param>
        /// <returns></returns>
        public bool UpdateSortId(Guid goodsId,int sortId)
        {
            var model = _context.GoodInfoes.FirstOrDefault(x => x.Id == goodsId);
            if (model != null)
            {
                model.SortId = sortId;
                model.LastUpdateTime = DateTime.Now;
            }
            return _context.SaveChanges() > 0;
        }
        /// <summary>
        /// 更新最小起批量
        /// </summary>
        /// <param name="goodsId"></param>
        /// <param name="minCount"></param>
        /// <returns></returns>
        public bool UpdateMinCount(Guid goodsId, int minCount)
        {
            var model = _context.GoodInfoes.FirstOrDefault(x => x.Id == goodsId);
            if (model != null)
            {
                model.MinCount = minCount;
                model.LastUpdateTime = DateTime.Now;
            }
            return _context.SaveChanges() > 0;
        }


        /// <summary>
        /// 批量删除商品
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <returns></returns>
        public bool Delete(List<Guid> goodsIds)
        {
            var list = _context.GoodInfoes.Where(x => goodsIds.Contains(x.Id));
            foreach(var item in list)
            {
                item.IsDelete = true;
            }
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 更改商品的上架状态
        /// </summary>
        /// <param name="goodsIds"></param>
        /// <returns></returns>
        public bool ToggleShelves(List<Guid> goodsIds, bool IsUpShelves)
        {
            var list = _context.GoodInfoes.Where(x => goodsIds.Contains(x.Id));
            foreach (var item in list)
            {
                item.IsUpShelves = IsUpShelves;
            }
            return _context.SaveChanges() > 0;
        }
      
        public bool UpdateGoodsInfo(GoodInfo newInfo)
        {
            var obj = _context.GoodInfoes.FirstOrDefault(x => x.Id == newInfo.Id);
            if(obj==null)
            {
                _context.GoodInfoes.Add(newInfo);
            }
            else
            {
                obj.LastUpdateTime = DateTime.Now;
                obj.GoodsNum = newInfo.GoodsNum;
                obj.BarCode = newInfo.BarCode;
                obj.MiddleCode = newInfo.MiddleCode;
                obj.BoxCode = newInfo.BoxCode;
                obj.SupplierId = newInfo.SupplierId;
                obj.SupplierNum = newInfo.SupplierNum;
                obj.SupplierName = newInfo.SupplierName;
                obj.FirstTypeId = newInfo.FirstTypeId;
                obj.FirstTypeName = newInfo.FirstTypeName;
                obj.SecondTypeId = newInfo.SecondTypeId;
                obj.SecondTypeName = newInfo.SecondTypeName;
                obj.ThirdTYypeId = newInfo.ThirdTYypeId;
                obj.ThirdTypeName = newInfo.ThirdTypeName;
                obj.GoodsTittle = newInfo.GoodsTittle;
                obj.GoodsSubTittle = newInfo.GoodsSubTittle;
                obj.BrandId = newInfo.BrandId;
                obj.BrandName = newInfo.BrandName;
                obj.RetailtPrice = newInfo.RetailtPrice;
                obj.MarketPrice = newInfo.MarketPrice;
                obj.CostPrice = newInfo.CostPrice;
                obj.Stock = newInfo.Stock;
                obj.IsLockStork = newInfo.IsLockStork;
                obj.BoxSpec = newInfo.BoxSpec;
                obj.Spec = newInfo.Spec;
                obj.Unit = newInfo.Unit;
                obj.Weight = newInfo.Weight;
                obj.Size = newInfo.Size;
                obj.ShelfLife = newInfo.ShelfLife;
                obj.MinCount = newInfo.MinCount;
                obj.LimitCount = newInfo.LimitCount;
                obj.BasePrice = newInfo.BasePrice;
                obj.PriceForA = newInfo.PriceForA;
                obj.PriceForB = newInfo.PriceForB;
                obj.PriceForC = newInfo.PriceForC;
                obj.PriceForD = newInfo.PriceForD;
                obj.PriceForE = newInfo.PriceForE;
                obj.PriceForF = newInfo.PriceForF;
                obj.PriceForG = newInfo.PriceForG;
                obj.PriceForH = newInfo.PriceForH;
                obj.PriceForI = newInfo.PriceForI;
                obj.PriceForLianSuo = newInfo.PriceForLianSuo;
                obj.TitleForA = newInfo.TitleForA;
                obj.TitleForB = newInfo.TitleForB;
                obj.TitleForC = newInfo.TitleForC;
                obj.TittleForD = newInfo.TittleForD;
                obj.TitleForE = newInfo.TitleForE;
                obj.TitleForF = newInfo.TitleForF;
                obj.TitleForG = newInfo.TitleForG;
                obj.TitleForH = newInfo.TitleForH;
                obj.TitleForI = newInfo.TitleForI;
                obj.TittleForLianSuo = newInfo.TittleForLianSuo;

                obj.pic1 = newInfo.pic1;
                obj.pic2 = newInfo.pic2;
                obj.pic3 = newInfo.pic3;
                obj.pic4 = newInfo.pic4;
                obj.pic5 = newInfo.pic5;
                obj.KeyWord = newInfo.KeyWord;
                obj.Detail = newInfo.Detail;
                obj.ErpId = newInfo.ErpId;
                obj.SortId = newInfo.SortId;
                obj.IsBoxSale = newInfo.IsBoxSale;
            }

            return _context.SaveChanges() > 0;
        }



        public List<GoddsTypeTree> GetGoddsTypeTree(Guid createUserId)
        {
            var top = _context.GoodsTypes.Where(x => x.CreateUserId == createUserId&&x.ParentId == Guid.Empty&&x.IsShowFirstPage).OrderByDescending(x=>x.SortId).ToList();
            var list = new List<GoddsTypeTree>();
            foreach(var item in top)
            {
                var tempList = _context.GoodsTypes.Where(x => x.ParentId == item.Id).ToList();
                var treeNode = new GoddsTypeTree(item, tempList);
                list.Add(treeNode);
            }
            return list;
        }


        public GoodsType GetGoodsType(string typeId)
        {
            if (string.IsNullOrWhiteSpace(typeId))
            {
                return null;
            }
            return _context.GoodsTypes.FirstOrDefault(x => x.Id.ToString() == typeId);
        }

        /// <summary>
        /// 获取指定用户类型的价格
        /// </summary>
        /// <param name="x"></param>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public decimal GetPriceOfUserType(GoodInfo x, int typeId,out string name)
        {
            decimal price = 0;
            name = x.GoodsTittle;
            switch (typeId)
            {
                case 1:
                    price = x.BasePrice;
                    break;
                case 2:
                    price = x.PriceForA;
                    if (!string.IsNullOrWhiteSpace(x.TitleForA))
                        name = x.TitleForA;
                    break;
                case 3:
                    price = x.PriceForB;
                    if (!string.IsNullOrWhiteSpace(x.TitleForB))
                        name = x.TitleForB;
                    break;
                case 4:
                    price = x.PriceForC;
                    if (!string.IsNullOrWhiteSpace(x.TitleForC))
                        name = x.TitleForC;
                    break;
                case 5:
                    price = x.PriceForD;
                    if (!string.IsNullOrWhiteSpace(x.TittleForD))
                        name = x.TittleForD;

                    break;
                case 6:
                    price = x.PriceForLianSuo;
                    if (!string.IsNullOrWhiteSpace(x.TittleForLianSuo))
                        name = x.TittleForLianSuo;
                    break;
                case 7:
                    price = x.PriceForE;
                    if (!string.IsNullOrWhiteSpace(x.TitleForE))
                        name = x.TitleForE;
                    break;
                case 8:
                    price = x.PriceForF;
                    if (!string.IsNullOrWhiteSpace(x.TitleForF))
                        name = x.TitleForF;
                    break;
                case 9:
                    price = x.PriceForG;
                    if (!string.IsNullOrWhiteSpace(x.TitleForG))
                        name = x.TitleForG;
                    break;
                case 10:
                    price = x.PriceForH;
                    if (!string.IsNullOrWhiteSpace(x.TitleForH))
                        name = x.TitleForH;
                    break;
                case 11:
                    price = x.PriceForI;
                    if (!string.IsNullOrWhiteSpace(x.TitleForI))
                        name = x.TitleForI;
                    break;
            }
            if (price == 0)
                price = x.BasePrice;
            
            return price;
        }

        public decimal GetPriceOfUserType(Guid goodsId, int typeId)
        {
            decimal price = 0;
            GoodInfo x = GetGoodInfoById(goodsId);
            if (x == null)
            {
                return price;
            }
            switch (typeId)
            {
                case 1:
                    price = x.BasePrice;
                    break;
                case 2:
                    price = x.PriceForA;
                    break;
                case 3:
                    price = x.PriceForB;
                    break;
                case 4:
                    price = x.PriceForC;
                    break;
                case 5:
                    price = x.PriceForD;
                    break;
                case 6:
                    price = x.PriceForLianSuo;
                    break;
            }
            if (price == 0)
                price = x.BasePrice;

            return price;
        }


        public GoodInfo GetGoodsWithPrice(Guid goodsId,int typeId)
        {
            GoodInfo model = new GoodInfo();
            model = GetGoodInfoById(goodsId);
            string tittle = "";
            model.RetailtPrice = GetPriceOfUserType(model, typeId,out tittle);
            model.GoodsTittle = tittle;
            return model;
        }

        /// <summary>
        /// 导出商品信息
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public string ExportGoodInfo(List<GoodInfo> list)
        {
            string sWebRootFolder = AppDomain.CurrentDomain.BaseDirectory + "/DownLoadExcelexport";
            if (!Directory.Exists(sWebRootFolder))
                Directory.CreateDirectory(sWebRootFolder);
            string sFileName ="商品列表" + $"{Guid.NewGuid()}.xlsx";
            //把项目名加到指定存放的路径
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                //添加worksheet的名字
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("商品列表");

                string title = "商品Guid,商品编号,供应商名,商品条码,大类,商品id,商品父级ID,商品名称,批发价,A类销售价,B类销售价,C类销售价,D类销售价,E类销售价,成本价,商品规格信息,起批单位,单位总数,商品保质期,状态,最小起批数量,品牌,排序,关键字,限购数量,限购开始时间,限购结束时间,有无主图,客户类型,是否锁定,最小零售单位,建议零售价";
                var tittles = title.Split(',');

                for (int i = 0; i < tittles.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = tittles[i];

                }

                //添加值
                var rowNum = 2; // rowNum 1 is head
                foreach (var item in list)
                {
                    worksheet.Cells["A" + rowNum].Value = item.Id;//第一列
                    worksheet.Cells["B" + rowNum].Value = item.GoodsNum;//第一列
                    worksheet.Cells["C" + rowNum].Value = item.SupplierName;//第一列
                    worksheet.Cells["D" + rowNum].Value = item.BarCode;//第一列
                    worksheet.Cells["E" + rowNum].Value = item.FirstTypeName;//第一列
                    worksheet.Cells["F" + rowNum].Value = item.ErpId;//第一列
                    worksheet.Cells["G" + rowNum].Value = "0";//第一列
                    worksheet.Cells["H" + rowNum].Value = item.GoodsTittle;//第一列
                    worksheet.Cells["I" + rowNum].Value = item.BasePrice;//第一列
                    worksheet.Cells["J" + rowNum].Value = item.PriceForA;//第一列
                    worksheet.Cells["K" + rowNum].Value = item.PriceForB;//第一列
                    worksheet.Cells["L" + rowNum].Value = item.PriceForC;//第一列
                    worksheet.Cells["M" + rowNum].Value = item.PriceForD;//第一列
                    worksheet.Cells["N" + rowNum].Value = item.PriceForLianSuo;//第一列
                    worksheet.Cells["O" + rowNum].Value = item.CostPrice;//第一列
                    worksheet.Cells["P" + rowNum].Value = item.Spec;//第一列
                    worksheet.Cells["Q" + rowNum].Value = item.Unit;//第一列
                    worksheet.Cells["R" + rowNum].Value = item.MinCount;//第一列
                    worksheet.Cells["S" + rowNum].Value = item.ShelfLife;//第一列
                    worksheet.Cells["T" + rowNum].Value = item.IsUpShelves ? "上架" : "下架";//第一列
                    worksheet.Cells["U" + rowNum].Value = item.MinCount;//第一列
                    worksheet.Cells["V" + rowNum].Value = item.BrandName;//第一列
                    worksheet.Cells["W" + rowNum].Value = item.SortId;//第一列
                    worksheet.Cells["X" + rowNum].Value = item.KeyWord;//第一列
                    worksheet.Cells["Y" + rowNum].Value = item.LimitCount;//第一列
                    worksheet.Cells["Z" + rowNum].Value = "";//第一列
                    worksheet.Cells["AA" + rowNum].Value = "";//第一列
                    worksheet.Cells["AB" + rowNum].Value = (string.IsNullOrWhiteSpace(item.pic1) ? "无" : "有");//第一列
                    worksheet.Cells["AC" + rowNum].Value = "ABCDZ";//第一列
                    worksheet.Cells["AD" + rowNum].Value = (item.IsLockStork ? "是" : "否");//第一列
                    worksheet.Cells["AE" + rowNum].Value = "";//第一列
                    worksheet.Cells["AF" + rowNum].Value = item.RetailtPrice;//第一列
                    rowNum++;
                }
                package.Save();
            }

            var fileUrl = Path.Combine(sWebRootFolder, sFileName);
            return fileUrl;

        }


        public ResponseModel CollectGoods(Guid userId,Guid goodId)
        {
            var colloect = _context.UserCollects.FirstOrDefault(x => x.UserId == userId && x.GoodsId == goodId);
            if(colloect!=null)
            {
                _response.Msg = "已收藏！请勿重复添加！";
                return _response;
            }
            colloect = new UserCollect();
            colloect.UserId = userId;
            colloect.GoodsId = goodId;
            _context.UserCollects.Add(colloect);
            _response.Stutas = _context.SaveChanges() > 0;
            return _response;
        }


        public List<GoodInfo>  GetAllGoods()
        {
            var list = _context.GoodInfoes.Where(x => x.IsDelete == false);
            return list.ToList();
        }

        #region ERP相关
         
        public int GetGoodsStock(string goodsId,int boxspec, string KId = "00001")
        {
            var list = _erp.GoodsStockses.Where(x => x.PtypeId == goodsId && x.KtypeId == KId).ToList();
            var model = _erp.GoodsStockses.FirstOrDefault(x => x.PtypeId == goodsId && x.KtypeId == KId);
            if (model != null)
                return (int)model.Qty.Value / boxspec;
            return 0;
        }


        public string GetErpId(string goodNum)
        {
            var model = _erp.ptypes.FirstOrDefault(x => x.UserCode == goodNum);
            if (model != null)
                return model.typeId;
            return "";
        }
        #endregion

    }
}
