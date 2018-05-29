using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosAtypeViewMap : EntityTypeConfiguration<PosAtypeView>
    {
        public PosAtypeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.fullname, t.Sonnum, t.name, t.deleted, t.usercode });

            // Properties
            this.Property(t => t.Atypeid)
                .HasMaxLength(50);

            this.Property(t => t.fullname)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.usercode)
                .IsRequired()
                .HasMaxLength(26);

            // Table & Column Mappings
            this.ToTable("PosAtypeView");
            this.Property(t => t.Atypeid).HasColumnName("Atypeid");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.Sonnum).HasColumnName("Sonnum");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.usercode).HasColumnName("usercode");
        }
    }
}
