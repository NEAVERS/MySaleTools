using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_MiantenanceInfoMap : EntityTypeConfiguration<QP_MiantenanceInfo>
    {
        public QP_MiantenanceInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.RepairAutoTypeID, t.Suggestion });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.RepairAutoTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Suggestion)
                .IsRequired()
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("QP_MiantenanceInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RepairAutoTypeID).HasColumnName("RepairAutoTypeID");
            this.Property(t => t.hightMileage).HasColumnName("hightMileage");
            this.Property(t => t.lowMileage).HasColumnName("lowMileage");
            this.Property(t => t.Suggestion).HasColumnName("Suggestion");
        }
    }
}
