using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AuditingStepReasonMap : EntityTypeConfiguration<AuditingStepReason>
    {
        public AuditingStepReasonMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditingID, t.AuditingStep, t.AuditingReason, t.OutKty, t.Id });

            // Properties
            this.Property(t => t.AuditingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditingStep)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditingReason)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.OutKty)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("AuditingStepReason");
            this.Property(t => t.AuditingID).HasColumnName("AuditingID");
            this.Property(t => t.AuditingStep).HasColumnName("AuditingStep");
            this.Property(t => t.AuditingReason).HasColumnName("AuditingReason");
            this.Property(t => t.OutKty).HasColumnName("OutKty");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
