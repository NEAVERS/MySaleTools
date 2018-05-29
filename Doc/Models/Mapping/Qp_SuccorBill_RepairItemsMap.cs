using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_SuccorBill_RepairItemsMap : EntityTypeConfiguration<Qp_SuccorBill_RepairItems>
    {
        public Qp_SuccorBill_RepairItemsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairItemsTypeID)
                .HasMaxLength(50);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Qp_SuccorBill_RepairItems");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairItemsTypeID).HasColumnName("RepairItemsTypeID");
            this.Property(t => t.StandardManHour).HasColumnName("StandardManHour");
            this.Property(t => t.CheckHour).HasColumnName("CheckHour");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.CostTotal).HasColumnName("CostTotal");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
