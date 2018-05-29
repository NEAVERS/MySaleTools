using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosBtypeDistributeViewMap : EntityTypeConfiguration<PosBtypeDistributeView>
    {
        public PosBtypeDistributeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.TaxRate, t.Flag });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BranchId)
                .HasMaxLength(30);

            this.Property(t => t.BtypeId)
                .HasMaxLength(50);

            this.Property(t => t.PriceTypeid)
                .HasMaxLength(30);

            this.Property(t => t.MarketDiscountId)
                .HasMaxLength(30);

            this.Property(t => t.DiscountTypeId)
                .HasMaxLength(30);

            this.Property(t => t.TaxRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Flag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosBtypeDistributeView");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.BranchId).HasColumnName("BranchId");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.PriceTypeid).HasColumnName("PriceTypeid");
            this.Property(t => t.MarketDiscountId).HasColumnName("MarketDiscountId");
            this.Property(t => t.DiscountTypeId).HasColumnName("DiscountTypeId");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");
            this.Property(t => t.Flag).HasColumnName("Flag");
        }
    }
}
