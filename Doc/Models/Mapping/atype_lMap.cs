using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class atype_lMap : EntityTypeConfiguration<atype_l>
    {
        public atype_lMap()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.typeid, t.flag, t.type });

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

            this.Property(t => t.type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("atype_l");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.type).HasColumnName("type");
        }
    }
}
