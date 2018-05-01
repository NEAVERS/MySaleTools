using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Erp
{
    /// <summary>
    /// 商品表
    /// </summary>
    public  class ptype
    {
        public string typeId { get; set; }
        public string ParId { get; set; }
        public short leveal { get; set; }
        public int sonnum { get; set; }
        public int soncount { get; set; }
        public string CanModify { get; set; }
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public string Type { get; set; }
        public string Area { get; set; }
        public string Unit1 { get; set; }
        public string Unit2 { get; set; }
        public decimal? UnitRate1 { get; set; }
        public decimal? UnitRate2 { get; set; }
        public decimal? preprice1 { get; set; }
        public decimal? preprice2 { get; set; }
        public decimal? preprice3 { get; set; }
        public decimal? preprice4 { get; set; }
        public decimal? preprice5 { get; set; }
        public short? UsefulLifeMonth { get; set; }
        public short? UsefulLifeDay { get; set; }
        public string Comment { get; set; }
        public decimal? recPrice { get; set; }
        public bool deleted { get; set; }
        public Nullable<int> ColorGroupID { get; set; }
        public Nullable<int> SizeGroupID { get; set; }
        public string EntryCode { get; set; }
        public string IfSerial { get; set; }
        public string PyCode { get; set; }
        public Nullable<int> SerialCount { get; set; }
        public Nullable<int> ValidDays { get; set; }
        public decimal? XiWaMaxNumber { get; set; }
        public string DwgNo { get; set; }
        public string ImgURL { get; set; }
        public Nullable<bool> IsDownLoad { get; set; }
        public byte[] PosDataVersion { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public int IsService { get; set; }
        public int SortID { get; set; }
        public Nullable<bool> OmUse { get; set; }
        public decimal? OmPrice { get; set; }
        public decimal? BuyDefaultRate { get; set; }
        public decimal? SaleDefaultRate { get; set; }
        public decimal? Integral { get; set; }
        public Nullable<int> StopBuy { get; set; }
        public Nullable<int> IsOm { get; set; }
        public string customitemid { get; set; }
        public string customitemfrom { get; set; }
        public string customitemname { get; set; }
        public string customitemrefid { get; set; }
        public Nullable<int> UnitsType { get; set; }
        public Nullable<int> AssistantUnitId { get; set; }
        public Nullable<int> SaleUnitId { get; set; }
        public Nullable<int> BuyUnitId { get; set; }
        public Nullable<int> ProduceUnitId { get; set; }
        public Nullable<int> StockUnitId { get; set; }
        public Nullable<int> JobUnitId { get; set; }
        public Nullable<int> baseUnitId { get; set; }
        public Nullable<bool> IfUseEntryCode { get; set; }
        public Nullable<bool> IfUseGoodsNum { get; set; }
        public int Pid { get; set; }
        public Nullable<bool> isyapi { get; set; }
    }
}
