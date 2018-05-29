using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class stype_lMap : EntityTypeConfiguration<stype_l>
    {
        public stype_lMap()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.typeid, t.flag });

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.typeid)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.flag)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("stype_l");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
