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
    public class GoodsManager
    {
        private SaleToolsContext _context = new SaleToolsContext();


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

        public bool AddGoodsBrand(GoodsBrand brand)
        {
            _context.GoodsBrands.Add(brand);
            return _context.SaveChanges() > 0;
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

        public List<PriceOfUserType> GetPriceOfUserTypeByGoodsId(Guid goodsId)
        {
            var q = _context.PriceOfUserTypes.Where(x => x.GoodsId == goodsId);
            return q.ToList();
        }

        public PageData<GoodsWithPrice> GetGoodsList(Guid CreaetUserId, int userTypeId , int index, int size, string SupplierId, string fstTypeId, string secTypeId, string thdTypeId,string brandId,  string keyWord)
        {
            PageData<GoodsWithPrice> page = new PageData<GoodsWithPrice>();
            page.PageIndex = index;
            page.PageSize = size;
            var q = from c in _context.GoodInfoes
                    where c.CreateUserId == CreaetUserId
                    && c.GoodsTittle.Contains(keyWord)
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
            page.TotalCount = q.Count();

            q = q.OrderByDescending(x => x.SortId).ThenBy(x=>x.CreateTime);
            var list = q.Skip((index - 1) * size).Take(size).ToList();
            var listData = new List<GoodsWithPrice>();
            list.ForEach(x =>
            {
                GoodsWithPrice item = new GoodsWithPrice();
                item.info = x;
                item.price = GetPriceOfUserType(x.Id, userTypeId);
                listData.Add(item);
            });
            page.ListData = listData;
            return page;
        }

        /// <summary>
        /// 根据Id获取商品详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public GoodInfo GetGoodInfoById(Guid id)
        {
            return _context.GoodInfoes.FirstOrDefault(x => x.Id == id);
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
                obj.pic1 = newInfo.pic1;
                obj.pic2 = newInfo.pic2;
                obj.pic3 = newInfo.pic3;
                obj.pic4 = newInfo.pic4;
                obj.pic5 = newInfo.pic5;
                obj.KeyWord = newInfo.KeyWord;
                obj.Detail = newInfo.Detail;
                obj.ErpId = newInfo.ErpId;
            }

            return _context.SaveChanges() > 0;
        }



        public List<GoddsTypeTree> GetGoddsTypeTree(Guid createUserId)
        {
            var top = _context.GoodsTypes.Where(x => x.CreateUserId == createUserId&&x.ParentId == Guid.Empty).ToList();
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


        public PriceOfUserType GetPriceOfUserType(Guid goodsId, int typeId)
        {
            var model = _context.PriceOfUserTypes.FirstOrDefault(x => x.GoodsId == goodsId && x.UserTypeId == typeId);
            if(model==null)
            {
                model = _context.PriceOfUserTypes.FirstOrDefault(x => x.GoodsId == goodsId && x.UserTypeId == 0);
            }
            return model;
        }


        public GoodsWithPrice GetGoodsWithPrice(Guid goodsId,int typeId)
        {
            GoodsWithPrice model = new GoodsWithPrice();
            model.info = GetGoodInfoById(goodsId);
            model.price = GetPriceOfUserType(goodsId, typeId);
            return model;
        }
    }
}
