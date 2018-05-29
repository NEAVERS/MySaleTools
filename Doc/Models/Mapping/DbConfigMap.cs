using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DbConfigMap : EntityTypeConfiguration<DbConfig>
    {
        public DbConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OFFLINE, t.FLAG });

            // Properties
            this.Property(t => t.FLAG)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.STOCKID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DbConfig");
            this.Property(t => t.OFFLINE).HasColumnName("OFFLINE");
            this.Property(t => t.FLAG).HasColumnName("FLAG");
            this.Property(t => t.STOCKID).HasColumnName("STOCKID");
        }
    }
}
