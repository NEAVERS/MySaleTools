using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PubRecordMap : EntityTypeConfiguration<PubRecord>
    {
        public PubRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PublishDate, t.Version, t.isPack });

            // Properties
            this.Property(t => t.Version)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.isPack)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("PubRecord");
            this.Property(t => t.PublishDate).HasColumnName("PublishDate");
            this.Property(t => t.Version).HasColumnName("Version");
            this.Property(t => t.isPack).HasColumnName("isPack");
        }
    }
}
