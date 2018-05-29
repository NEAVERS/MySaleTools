using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosAssistAttributeViewMap : EntityTypeConfiguration<PosAssistAttributeView>
    {
        public PosAssistAttributeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.attributeid, t.typeid });

            // Properties
            this.Property(t => t.attributeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.typename)
                .HasMaxLength(30);

            this.Property(t => t.username)
                .HasMaxLength(30);

            this.Property(t => t.usercode)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PosAssistAttributeView");
            this.Property(t => t.attributeid).HasColumnName("attributeid");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.typename).HasColumnName("typename");
            this.Property(t => t.username).HasColumnName("username");
            this.Property(t => t.usercode).HasColumnName("usercode");
        }
    }
}
