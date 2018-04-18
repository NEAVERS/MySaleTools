using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GoodInfo
    {
        /// <summary>
        /// 商品Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 商品编号
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string GoodsNum { get; set; }
        /// <summary>
        /// 商品条形码
        /// </summary>

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string BarCode { get; set; }
        /// <summary>
        /// 商品中码
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string MiddleCode { get; set; }
        /// <summary>
        /// 商品箱码
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string BoxCode { get; set; }
        /// <summary>
        /// 供应商Id
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public int SupplierId { get; set; }
        /// <summary>
        /// 供应商编号
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string SupplierNum { get; set; }
        /// <summary>
        /// 供应商姓名
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string SupplierName { get; set; }
        /// <summary>
        /// 一级分类Id
        /// </summary>
        public Guid FirstTypeId { get; set; }
        /// <summary>
        /// 一级分类名
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string FirstTypeName { get; set; }
        /// <summary>
        /// 二级分类Id
        /// </summary>
        public Guid SecondTypeId { get; set; }
        /// <summary>
        /// 二级分类名
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string SecondTypeName { get; set; }
        /// <summary>
        /// 三级分类Id
        /// </summary>
        public Guid ThirdTYypeId { get; set; }
        /// <summary>
        /// 三级分类名
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string ThirdTypeName { get; set; }
        /// <summary>
        /// 商品标题
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string GoodsTittle { get; set; }
        /// <summary>
        /// 商品副标题
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string GoodsSubTittle { get; set; }
        /// <summary>
        /// 商品品牌Id
        /// </summary>
        public Guid BrandId { get; set; }
        /// <summary>
        /// 商品品牌名
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string BrandName { get; set; }
        /// <summary>
        /// 建议零售价
        /// </summary>
        public decimal RetailtPrice { get; set; }
        /// <summary>
        /// 参考价
        /// </summary>
        public decimal MarketPrice { get; set; }
        /// <summary>
        /// 成本价
        /// </summary>
        public decimal CostPrice { get; set; }


        /// <summary>
        /// 默认价格
        /// </summary>
        public decimal BasePrice { get; set; }

        /// <summary>
        /// A类用户价格
        /// </summary>
        public decimal PriceForA { get; set; }

        /// <summary>
        /// B类用户价格
        /// </summary>
        public decimal PriceForB { get; set; }
        /// <summary>
        /// C类用户价格
        /// </summary>
        public decimal PriceForC { get; set; }

        /// <summary>
        /// D类用户价格
        /// </summary>
        public decimal PriceForD { get; set; }

        /// <summary>
        /// 蚂蚁连锁价格
        /// </summary>
        public decimal PriceForLianSuo { get; set; }
        /// <summary>
        /// 商品库存
        /// </summary>
        public int Stock { get; set; }
        /// <summary>
        /// 锁定库存
        /// </summary>
        public bool IsLockStork { get; set; }
        /// <summary>
        /// 整箱规格信息
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string BoxSpec { get; set; }
        /// <summary>
        /// 商品规格信息
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Spec { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Unit { get; set; }
        /// <summary>
        /// 商品重量
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// 商品体积
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Size { get; set; }
        /// <summary>
        /// 商品保质期
        /// </summary>
        public int ShelfLife { get; set; }
        /// <summary>
        /// 最小起批数
        /// </summary>
        public int MinCount { get; set; }
        /// <summary>
        /// 限购数量
        /// </summary>
        public int LimitCount { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string pic1 { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string pic2 { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string pic3 { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string pic4 { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string pic5 { get; set; }
        /// <summary>
        /// 关键字
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string KeyWord { get; set; }
        /// <summary>
        /// 商品详情
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string Detail { get; set; }
        /// <summary>
        /// 创建人ID
        /// </summary>
        public Guid CreateUserId { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        /// 排序ID
        /// </summary>
        public int SortId { get; set; }
        /// <summary>
        /// 是否上架
        /// </summary>
        public bool IsUpShelves { get; set; }

        /// <summary>
        /// erp系统中该商品的ID
        /// </summary>
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string  ErpId { get; set; }

        public GoodInfo()
        {

            Id = Guid.Empty;
            GoodsNum = string.Empty;
            BarCode = string.Empty;
            MiddleCode = string.Empty;
            BoxCode = string.Empty;
            SupplierId = -1;
            SupplierNum = string.Empty;
            SupplierName = string.Empty;
            FirstTypeId = Guid.Empty;
            FirstTypeName = string.Empty;
            SecondTypeId = Guid.Empty;
            SecondTypeName = string.Empty;
            ThirdTYypeId = Guid.Empty;
            ThirdTypeName = string.Empty;
            GoodsTittle = string.Empty;
            GoodsSubTittle = string.Empty;
            BrandId = Guid.Empty;
            BrandName = string.Empty;
            RetailtPrice = 0;
            MarketPrice = 0;
            CostPrice = 0;
            Stock = 0;
            IsLockStork = false;
            BoxSpec = string.Empty;
            Spec = string.Empty;
            Unit = string.Empty;
            Weight = 0;
            Size = string.Empty;
            ShelfLife = 0;
            MinCount = 1;
            LimitCount = 100;
            pic1 = string.Empty;
            pic2 = string.Empty;
            pic3 = string.Empty;
            pic4 = string.Empty;
            pic5 = string.Empty;
            KeyWord = string.Empty;
            Detail = string.Empty;
            CreateUserId = Guid.Empty;
            CreateUserName = string.Empty;
            IsDelete = false;
            CreateTime = DateTime.MinValue;
            LastUpdateTime = DateTime.MinValue;
            SortId = 0;
            IsUpShelves = true;
            this.BasePrice = 0;
            this.PriceForA = 0;
            this.PriceForB = 0;
            this.PriceForC = 0;
            this.PriceForD = 0;
            this.PriceForLianSuo = 0;
        }

    }
}
