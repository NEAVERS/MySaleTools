using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceTrackMap : EntityTypeConfiguration<PriceTrack>
    {
        public PriceTrackMap()
        {
            // Primary Key
            this.HasKey(t => t.BTypeFlag);

            // Properties
            this.Property(t => t.BtypeID)
                .HasMaxLength(50);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.BTypeFlag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PriceTrack");
            this.Property(t => t.BtypeID).HasColumnName("BtypeID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.CostPrice).HasColumnName("CostPrice");
            this.Property(t => t.SaleOrderPrice).HasColumnName("SaleOrderPrice");
            this.Property(t => t.BuyOrderPrice).HasColumnName("BuyOrderPrice");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.BTypeFlag).HasColumnName("BTypeFlag");
            this.Property(t => t.BuyOrBackOriginalPrice).HasColumnName("BuyOrBackOriginalPrice");
            this.Property(t => t.BuyOrBackDiscountRate).HasColumnName("BuyOrBackDiscountRate");
            this.Property(t => t.SaleOrBackOriginalPrice).HasColumnName("SaleOrBackOriginalPrice");
            this.Property(t => t.SaleOrBackDiscountRate).HasColumnName("SaleOrBackDiscountRate");
            this.Property(t => t.QueryPrice).HasColumnName("QueryPrice");
            this.Property(t => t.ResponsePrice).HasColumnName("ResponsePrice");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.UID).HasColumnName("UID");
            this.Property(t => t.CID).HasColumnName("CID");
        }
    }
}
