using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AuditingRelationMap : EntityTypeConfiguration<AuditingRelation>
    {
        public AuditingRelationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OffSet, t.KeyName, t.Id });

            // Properties
            this.Property(t => t.OffSet)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KeyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Relation)
                .HasMaxLength(50);

            this.Property(t => t.UnChecked)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(255);

            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            // Table & Column Mappings
            this.ToTable("AuditingRelation");
            this.Property(t => t.OffSet).HasColumnName("OffSet");
            this.Property(t => t.KeyName).HasColumnName("KeyName");
            this.Property(t => t.Relation).HasColumnName("Relation");
            this.Property(t => t.UnChecked).HasColumnName("UnChecked");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.TabOrder).HasColumnName("TabOrder");
            this.Property(t => t.Id).HasColumnName("Id");
        }
    }
}
