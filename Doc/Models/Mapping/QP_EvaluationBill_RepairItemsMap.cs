using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_EvaluationBill_RepairItemsMap : EntityTypeConfiguration<QP_EvaluationBill_RepairItems>
    {
        public QP_EvaluationBill_RepairItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.RepairItemsTypeID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairItemsTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("QP_EvaluationBill_RepairItems");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.StandardManHour).HasColumnName("StandardManHour");
            this.Property(t => t.CheckHour).HasColumnName("CheckHour");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
