using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AssetBusinessTypeMap : EntityTypeConfiguration<Ac_AssetBusinessType>
    {
        public Ac_AssetBusinessTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Deleted });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .HasMaxLength(66);

            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_AssetBusinessType");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BusinessType).HasColumnName("BusinessType");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Atid).HasColumnName("Atid");
            this.Property(t => t.AuditType).HasColumnName("AuditType");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
        }
    }
}
