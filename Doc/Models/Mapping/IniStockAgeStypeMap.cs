using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class IniStockAgeStypeMap : EntityTypeConfiguration<IniStockAgeStype>
    {
        public IniStockAgeStypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.KtypeID)
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.InStockDate)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IniStockAgeStype");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.InStockDate).HasColumnName("InStockDate");
            this.Property(t => t.StockAge).HasColumnName("StockAge");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Total).HasColumnName("Total");
        }
    }
}
