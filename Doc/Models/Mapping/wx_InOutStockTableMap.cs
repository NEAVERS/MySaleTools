using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class wx_InOutStockTableMap : EntityTypeConfiguration<wx_InOutStockTable>
    {
        public wx_InOutStockTableMap()
        {
            // Primary Key
            this.HasKey(t => t.SortID);

            // Properties
            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.EtypeId)
                .HasMaxLength(50);

            this.Property(t => t.KtypeId)
                .HasMaxLength(50);

            this.Property(t => t.JobNumber)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            this.Property(t => t.GoodsBTypeID)
                .HasMaxLength(50);

            this.Property(t => t.DTypeID)
                .HasMaxLength(50);

            this.Property(t => t.STypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("wx_InOutStockTable");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.KtypeId).HasColumnName("KtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.GoodsNo).HasColumnName("GoodsNo");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.Audited).HasColumnName("Audited");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsBTypeID).HasColumnName("GoodsBTypeID");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Tax).HasColumnName("Tax");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.SaleTotal).HasColumnName("SaleTotal");
            this.Property(t => t.TaxPrice).HasColumnName("TaxPrice");
            this.Property(t => t.TaxTotal).HasColumnName("TaxTotal");
            this.Property(t => t.DTypeID).HasColumnName("DTypeID");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.NPrice).HasColumnName("NPrice");
            this.Property(t => t.NTotal).HasColumnName("NTotal");
            this.Property(t => t.NSalePrice).HasColumnName("NSalePrice");
            this.Property(t => t.NSaleTotal).HasColumnName("NSaleTotal");
            this.Property(t => t.NTaxPrice).HasColumnName("NTaxPrice");
            this.Property(t => t.NTaxTotal).HasColumnName("NTaxTotal");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.MUNITID).HasColumnName("MUNITID");
            this.Property(t => t.SortID).HasColumnName("SortID");
            this.Property(t => t.IsService).HasColumnName("IsService");
            this.Property(t => t.MUnitRate).HasColumnName("MUnitRate");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
