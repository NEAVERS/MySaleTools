using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_QuickRepairBill_RepairItemsMap : EntityTypeConfiguration<QP_QuickRepairBill_RepairItems>
    {
        public QP_QuickRepairBill_RepairItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.RepairItemsTypeID, t.RepairManTypeID, t.Insurance, t.Limited });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairItemsTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.RepairManTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(250);

            this.Property(t => t.Insurance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Limited)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_QuickRepairBill_RepairItems");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.StandardManHour).HasColumnName("StandardManHour");
            this.Property(t => t.CheckHour).HasColumnName("CheckHour");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountTotal).HasColumnName("DiscountTotal");
            this.Property(t => t.RepairManTypeID).HasColumnName("RepairManTypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Insurance).HasColumnName("Insurance");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.Limited).HasColumnName("Limited");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.CounterClaimStatus).HasColumnName("CounterClaimStatus");
        }
    }
}
