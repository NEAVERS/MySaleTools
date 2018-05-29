using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_StockIniDisByPMap : EntityTypeConfiguration<vWeb_StockIniDisByP>
    {
        public vWeb_StockIniDisByPMap()
        {
            // Primary Key
            this.HasKey(t => new { t.SFullName, t.PFullName });

            // Properties
            this.Property(t => t.SFullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.PFullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PTypeid)
                .HasMaxLength(50);

            this.Property(t => t.Ktypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vWeb_StockIniDisByP");
            this.Property(t => t.SFullName).HasColumnName("SFullName");
            this.Property(t => t.PFullName).HasColumnName("PFullName");
            this.Property(t => t.PTypeid).HasColumnName("PTypeid");
            this.Property(t => t.Ktypeid).HasColumnName("Ktypeid");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Price).HasColumnName("Price");
        }
    }
}
