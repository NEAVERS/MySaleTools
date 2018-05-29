using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosPtypeAttributeViewMap : EntityTypeConfiguration<PosPtypeAttributeView>
    {
        public PosPtypeAttributeViewMap()
        {
            // Primary Key
            this.HasKey(t => t.attributeid);

            // Properties
            this.Property(t => t.ptypeid)
                .HasMaxLength(30);

            this.Property(t => t.attributeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosPtypeAttributeView");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.attributeid).HasColumnName("attributeid");
        }
    }
}
