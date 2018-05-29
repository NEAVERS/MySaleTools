using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UpdateVersionListMap : EntityTypeConfiguration<UpdateVersionList>
    {
        public UpdateVersionListMap()
        {
            // Primary Key
            this.HasKey(t => t.ListId);

            // Properties
            this.Property(t => t.VersionNo)
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .HasMaxLength(1000);

            this.Property(t => t.Content)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("UpdateVersionList");
            this.Property(t => t.ListId).HasColumnName("ListId");
            this.Property(t => t.VersionNo).HasColumnName("VersionNo");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.SortId).HasColumnName("SortId");
        }
    }
}
