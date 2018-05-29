using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AuditingFlowDetailMap : EntityTypeConfiguration<AuditingFlowDetail>
    {
        public AuditingFlowDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditingID, t.BillType, t.AuditingStep, t.ETypeID, t.AuditingAlerm, t.OutKty, t.Id });

            // Properties
            this.Property(t => t.AuditingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditingDescription)
                .HasMaxLength(255);

            this.Property(t => t.AuditingStep)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuditingAlerm)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.OutKty)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("AuditingFlowDetail");
            this.Property(t => t.AuditingID).HasColumnName("AuditingID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.AuditingDescription).HasColumnName("AuditingDescription");
            this.Property(t => t.AuditingStep).HasColumnName("AuditingStep");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.AuditingAlerm).HasColumnName("AuditingAlerm");
            this.Property(t => t.OutKty).HasColumnName("OutKty");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
