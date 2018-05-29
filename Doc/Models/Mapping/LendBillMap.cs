using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class LendBillMap : EntityTypeConfiguration<LendBill>
    {
        public LendBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.Id, t.BackItemId });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .HasMaxLength(50);

            this.Property(t => t.JobNumber)
                .HasMaxLength(20);

            this.Property(t => t.comment)
                .HasMaxLength(255);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.BackItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(50);

            this.Property(t => t.ValidDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LendBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.JobNumber).HasColumnName("JobNumber");
            this.Property(t => t.GoodsNo).HasColumnName("GoodsNo");
            this.Property(t => t.OutFactoryDate).HasColumnName("OutFactoryDate");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.BackQty).HasColumnName("BackQty");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.CargoID).HasColumnName("CargoID");
            this.Property(t => t.BackItemId).HasColumnName("BackItemId");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.NQty).HasColumnName("NQty");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.UnitRate).HasColumnName("UnitRate");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
            this.Property(t => t.BuyQty).HasColumnName("BuyQty");
            this.Property(t => t.SaleQty).HasColumnName("SaleQty");
        }
    }
}
