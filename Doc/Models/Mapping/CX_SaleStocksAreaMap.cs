using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_SaleStocksAreaMap : EntityTypeConfiguration<CX_SaleStocksArea>
    {
        public CX_SaleStocksAreaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.KtypeId, t.IsHQ });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsHQ)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("CX_SaleStocksArea");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.KtypeId).HasColumnName("KtypeId");
            this.Property(t => t.IsHQ).HasColumnName("IsHQ");
        }
    }
}
