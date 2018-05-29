using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_AssetStorageLocationMap : EntityTypeConfiguration<Ac_AssetStorageLocation>
    {
        public Ac_AssetStorageLocationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Deleted });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Location)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Ac_AssetStorageLocation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.Location).HasColumnName("Location");
        }
    }
}
