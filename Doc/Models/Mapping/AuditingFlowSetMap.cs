using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AuditingFlowSetMap : EntityTypeConfiguration<AuditingFlowSet>
    {
        public AuditingFlowSetMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AuditingID, t.BillType, t.AuditingType, t.AuditingLevel, t.IfUse, t.ETypeID, t.AuditingReason, t.AuditingDate, t.AuditingLevel1 });

            // Properties
            this.Property(t => t.AuditingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditingType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AuditingLevel)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IfUse)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AuditingReason)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.AuditingLevel1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.LastStopETypeID)
                .HasMaxLength(100);

            this.Property(t => t.LastStartETypeID)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("AuditingFlowSet");
            this.Property(t => t.AuditingID).HasColumnName("AuditingID");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.AuditingType).HasColumnName("AuditingType");
            this.Property(t => t.AuditingLevel).HasColumnName("AuditingLevel");
            this.Property(t => t.IfUse).HasColumnName("IfUse");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.AuditingReason).HasColumnName("AuditingReason");
            this.Property(t => t.AuditingDate).HasColumnName("AuditingDate");
            this.Property(t => t.AuditingLevel1).HasColumnName("AuditingLevel1");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.LastStopETypeID).HasColumnName("LastStopETypeID");
            this.Property(t => t.LastStartETypeID).HasColumnName("LastStartETypeID");
            this.Property(t => t.LastStopTime).HasColumnName("LastStopTime");
            this.Property(t => t.LastStartTime).HasColumnName("LastStartTime");
            this.Property(t => t.Stoped).HasColumnName("Stoped");
        }
    }
}
