using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AuditingReasonMap : EntityTypeConfiguration<AuditingReason>
    {
        public AuditingReasonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditingID, t.ReasonNo, t.Id });

            // Properties
            this.Property(t => t.AuditingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReasonNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReasonValue)
                .HasMaxLength(200);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("AuditingReason");
            this.Property(t => t.AuditingID).HasColumnName("AuditingID");
            this.Property(t => t.ReasonNo).HasColumnName("ReasonNo");
            this.Property(t => t.ReasonValue).HasColumnName("ReasonValue");
            this.Property(t => t.AuditingStep).HasColumnName("AuditingStep");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
