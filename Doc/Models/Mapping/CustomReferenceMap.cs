using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CustomReferenceMap : EntityTypeConfiguration<CustomReference>
    {
        public CustomReferenceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.id, t.itemsId, t.childCount });

            // Properties
            this.Property(t => t.id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.itemsId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.childCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("CustomReference");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.itemsId).HasColumnName("itemsId");
            this.Property(t => t.selfDataId).HasColumnName("selfDataId");
            this.Property(t => t.childCount).HasColumnName("childCount");
        }
    }
}
