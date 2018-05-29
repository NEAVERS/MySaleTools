using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OrderBillMap : EntityTypeConfiguration<OrderBill>
    {
        public OrderBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.billNumberID, t.OrderID, t.Checked, t.IsUnit2, t.IsGift, t.PriceSource, t.Id, t.PromoType });

            // Properties
            this.Property(t => t.billNumberID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .HasMaxLength(250);

            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.NUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.MUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.IsGift)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.YapiID)
                .HasMaxLength(20);

            this.Property(t => t.PriceSource)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PromoType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OrderBill");
            this.Property(t => t.billNumberID).HasColumnName("billNumberID");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.ReachQty).HasColumnName("ReachQty");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.Checked).HasColumnName("Checked");
            this.Property(t => t.TeamNO1).HasColumnName("TeamNO1");
            this.Property(t => t.PassQty).HasColumnName("PassQty");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.SaleTotal).HasColumnName("SaleTotal");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.FromBillNumberID).HasColumnName("FromBillNumberID");
            this.Property(t => t.entrycode).HasColumnName("entrycode");
            this.Property(t => t.FromBillID).HasColumnName("FromBillID");
            this.Property(t => t.ReachTotal).HasColumnName("ReachTotal");
            this.Property(t => t.ReachTaxTotal).HasColumnName("ReachTaxTotal");
            this.Property(t => t.RequestBillNumberID).HasColumnName("RequestBillNumberID");
            this.Property(t => t.RequestBillID).HasColumnName("RequestBillID");
            this.Property(t => t.AskBillNumberID).HasColumnName("AskBillNumberID");
            this.Property(t => t.AskBillID).HasColumnName("AskBillID");
            this.Property(t => t.TaxMoney).HasColumnName("TaxMoney");
            this.Property(t => t.NSalePrice).HasColumnName("NSalePrice");
            this.Property(t => t.NSaleTotal).HasColumnName("NSaleTotal");
            this.Property(t => t.NDiscountPrice).HasColumnName("NDiscountPrice");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.NTaxPrice).HasColumnName("NTaxPrice");
            this.Property(t => t.NTaxTotal).HasColumnName("NTaxTotal");
            this.Property(t => t.NTaxMoney).HasColumnName("NTaxMoney");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.NUnitID).HasColumnName("NUnitID");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.NUnitMsg).HasColumnName("NUnitMsg");
            this.Property(t => t.MUnitID).HasColumnName("MUnitID");
            this.Property(t => t.MQty).HasColumnName("MQty");
            this.Property(t => t.MUnitRate).HasColumnName("MUnitRate");
            this.Property(t => t.MUnitMsg).HasColumnName("MUnitMsg");
            this.Property(t => t.MSalePrice).HasColumnName("MSalePrice");
            this.Property(t => t.MDiscountPrice).HasColumnName("MDiscountPrice");
            this.Property(t => t.MTaxPrice).HasColumnName("MTaxPrice");
            this.Property(t => t.CurMSalePrice).HasColumnName("CurMSalePrice");
            this.Property(t => t.CurMDiscountPrice).HasColumnName("CurMDiscountPrice");
            this.Property(t => t.CurMTaxPrice).HasColumnName("CurMTaxPrice");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.IsGift).HasColumnName("IsGift");
            this.Property(t => t.YapiID).HasColumnName("YapiID");
            this.Property(t => t.PriceSource).HasColumnName("PriceSource");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PromoType).HasColumnName("PromoType");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.WaitQty).HasColumnName("WaitQty");
            this.Property(t => t.BillOver).HasColumnName("BillOver");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.stopreason).HasColumnName("stopreason");
        }
    }
}
