using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ProvinceMap : EntityTypeConfiguration<Province>
    {
        public ProvinceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.areacode, t.areaname, t.zaiyao, t.deleted });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.areacode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.areaname)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.zaiyao)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Province");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.areacode).HasColumnName("areacode");
            this.Property(t => t.areaname).HasColumnName("areaname");
            this.Property(t => t.zaiyao).HasColumnName("zaiyao");
            this.Property(t => t.deleted).HasColumnName("deleted");
        }
    }
}
