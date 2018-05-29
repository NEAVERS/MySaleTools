using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PloyTypeMap : EntityTypeConfiguration<PloyType>
    {
        public PloyTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ploytypeid, t.name, t.deleted });

            // Properties
            this.Property(t => t.ploytypeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("PloyType");
            this.Property(t => t.ploytypeid).HasColumnName("ploytypeid");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.deleted).HasColumnName("deleted");
        }
    }
}
