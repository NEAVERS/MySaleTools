using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosColorViewMap : EntityTypeConfiguration<PosColorView>
    {
        public PosColorViewMap()
        {
            // Primary Key
            this.HasKey(t => t.colorid);

            // Properties
            this.Property(t => t.colorid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ColorName)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PosColorView");
            this.Property(t => t.colorid).HasColumnName("colorid");
            this.Property(t => t.ColorName).HasColumnName("ColorName");
        }
    }
}
