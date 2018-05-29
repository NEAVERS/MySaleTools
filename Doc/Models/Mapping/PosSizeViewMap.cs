using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosSizeViewMap : EntityTypeConfiguration<PosSizeView>
    {
        public PosSizeViewMap()
        {
            // Primary Key
            this.HasKey(t => t.Sizeid);

            // Properties
            this.Property(t => t.Sizeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Sizename)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PosSizeView");
            this.Property(t => t.Sizeid).HasColumnName("Sizeid");
            this.Property(t => t.Sizename).HasColumnName("Sizename");
        }
    }
}
