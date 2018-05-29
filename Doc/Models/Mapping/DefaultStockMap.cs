using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DefaultStockMap : EntityTypeConfiguration<DefaultStock>
    {
        public DefaultStockMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Ptypeid, t.Stypeid });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Ptypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DefaultStock");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
        }
    }
}
