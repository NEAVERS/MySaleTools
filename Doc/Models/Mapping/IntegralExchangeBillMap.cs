using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IntegralExchangeBillMap : EntityTypeConfiguration<IntegralExchangeBill>
    {
        public IntegralExchangeBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.KTypeID, t.PTypeID, t.IsUnit2, t.HandZeroCost });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.KTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.IsUnit2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HandZeroCost)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IntegralExchangeBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.KTypeID).HasColumnName("KTypeID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsUnit2).HasColumnName("IsUnit2");
            this.Property(t => t.InputCostPrice).HasColumnName("InputCostPrice");
            this.Property(t => t.GoodsCostPrice).HasColumnName("GoodsCostPrice");
            this.Property(t => t.GoodsCostTotal).HasColumnName("GoodsCostTotal");
            this.Property(t => t.HandZeroCost).HasColumnName("HandZeroCost");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
