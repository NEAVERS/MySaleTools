using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DisassembleBillMap : EntityTypeConfiguration<DisassembleBill>
    {
        public DisassembleBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.MUnitId, t.IsUnit2 });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.jobnumber)
                .HasMaxLength(20);

            this.Property(t => t.inorout)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

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

            this.Property(t => t.MUnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("DisassembleBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.costprice).HasColumnName("costprice");
            this.Property(t => t.jobnumber).HasColumnName("jobnumber");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.inorout).HasColumnName("inorout");
            this.Property(t => t.outfactorydate).HasColumnName("outfactorydate");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.goodsno).HasColumnName("goodsno");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.GoodsOrder).HasColumnName("GoodsOrder");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsBTypeID).HasColumnName("GoodsBTypeID");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.GoodsCostTotal).HasColumnName("GoodsCostTotal");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.MUnitId).HasColumnName("MUnitId");
            this.Property(t => t.MUnitRate).HasColumnName("MUnitRate");
            this.Property(t => t.MQty).HasColumnName("MQty");
            this.Property(t => t.CurMSalePrice).HasColumnName("CurMSalePrice");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
        }
    }
}
