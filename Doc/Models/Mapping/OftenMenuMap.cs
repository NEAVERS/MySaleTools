using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OftenMenuMap : EntityTypeConfiguration<OftenMenu>
    {
        public OftenMenuMap()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.MenuID, t.MenuName, t.LimitName, t.ShowOrder });

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MenuID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.MenuName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LimitName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ShowOrder)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("OftenMenu");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.MenuName).HasColumnName("MenuName");
            this.Property(t => t.LimitName).HasColumnName("LimitName");
            this.Property(t => t.ShowOrder).HasColumnName("ShowOrder");
        }
    }
}
