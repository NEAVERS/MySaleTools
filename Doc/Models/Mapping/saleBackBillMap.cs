using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class saleBackBillMap : EntityTypeConfiguration<saleBackBill>
    {
        public saleBackBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.IsUnit2, t.IsGift, t.PriceStyle, t.PromoType });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.jobnumber)
                .HasMaxLength(20);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OldID)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.GoodsBTypeID)
                .HasMaxLength(50);

            this.Property(t => t.KTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.NUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.MUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.IsGift)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceStyle)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PromoType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("saleBackBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.jobnumber).HasColumnName("jobnumber");
            this.Property(t => t.goodsno).HasColumnName("goodsno");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TeamNO1).HasColumnName("TeamNO1");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.OldID).HasColumnName("OldID");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.OldBillNumberID).HasColumnName("OldBillNumberID");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsBTypeID).HasColumnName("GoodsBTypeID");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.GoodsCostTotal).HasColumnName("GoodsCostTotal");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.CompleteQTY).HasColumnName("CompleteQTY");
            this.Property(t => t.SaleTotal).HasColumnName("SaleTotal");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.FromBillNumberID).HasColumnName("FromBillNumberID");
            this.Property(t => t.FromBillID).HasColumnName("FromBillID");
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
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.InvoiceQty).HasColumnName("InvoiceQty");
            this.Property(t => t.InvoiceMoney).HasColumnName("InvoiceMoney");
            this.Property(t => t.NInvoiceMoney).HasColumnName("NInvoiceMoney");
            this.Property(t => t.IsGift).HasColumnName("IsGift");
            this.Property(t => t.ReferPrice).HasColumnName("ReferPrice");
            this.Property(t => t.PriceStyle).HasColumnName("PriceStyle");
            this.Property(t => t.PromoType).HasColumnName("PromoType");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.OMBillID).HasColumnName("OMBillID");
            this.Property(t => t.CompleteTotal).HasColumnName("CompleteTotal");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
        }
    }
}
