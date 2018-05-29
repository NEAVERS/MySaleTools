using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class AreaMap : EntityTypeConfiguration<Area>
    {
        public AreaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.typeid, t.Fullname, t.deleted });

            // Properties
            this.Property(t => t.typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.usercode)
                .HasMaxLength(10);

            this.Property(t => t.Fullname)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Area");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.deleted).HasColumnName("deleted");
        }
    }
}
