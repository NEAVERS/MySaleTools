using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class BtypePriceInfoMap : EntityTypeConfiguration<BtypePriceInfo>
    {
        public BtypePriceInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.stypeid)
                .HasMaxLength(50);

            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.btypeid)
                .HasMaxLength(50);

            this.Property(t => t.areatypeid)
                .HasMaxLength(50);

            this.Property(t => t.ktypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BtypePriceInfo");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.stypeid).HasColumnName("stypeid");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.areatypeid).HasColumnName("areatypeid");
            this.Property(t => t.ktypeid).HasColumnName("ktypeid");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.TopbuyPrice).HasColumnName("TopbuyPrice");
            this.Property(t => t.BuyPrice).HasColumnName("BuyPrice");
            this.Property(t => t.LowSalePrice).HasColumnName("LowSalePrice");
        }
    }
}
