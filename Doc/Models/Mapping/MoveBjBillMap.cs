using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class MoveBjBillMap : EntityTypeConfiguration<MoveBjBill>
    {
        public MoveBjBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.IsUnit2, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.Jobnumber)
                .HasMaxLength(20);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.NUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.MUnitMsg)
                .HasMaxLength(50);

            this.Property(t => t.KTypeId)
                .HasMaxLength(50);

            this.Property(t => t.KTypeId2)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MoveBjBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.Jobnumber).HasColumnName("Jobnumber");
            this.Property(t => t.GoodsNo).HasColumnName("GoodsNo");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
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
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.NUnitID).HasColumnName("NUnitID");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.NUnitMsg).HasColumnName("NUnitMsg");
            this.Property(t => t.MUnitID).HasColumnName("MUnitID");
            this.Property(t => t.MQty).HasColumnName("MQty");
            this.Property(t => t.MUnitRate).HasColumnName("MUnitRate");
            this.Property(t => t.MUnitMsg).HasColumnName("MUnitMsg");
            this.Property(t => t.MPrice).HasColumnName("MPrice");
            this.Property(t => t.InCargoID).HasColumnName("InCargoID");
            this.Property(t => t.OutCargoID).HasColumnName("OutCargoID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.KTypeId).HasColumnName("KTypeId");
            this.Property(t => t.KTypeId2).HasColumnName("KTypeId2");
        }
    }
}
