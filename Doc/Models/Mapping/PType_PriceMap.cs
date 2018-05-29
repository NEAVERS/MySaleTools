using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PType_PriceMap : EntityTypeConfiguration<PType_Price>
    {
        public PType_PriceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PTypeID, t.PosDataVersion });

            // Properties
            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PosDataVersion)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(8)
                .IsRowVersion();

            // Table & Column Mappings
            this.ToTable("PType_Price");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.PreBuyPrice1).HasColumnName("PreBuyPrice1");
            this.Property(t => t.PreBuyPrice2).HasColumnName("PreBuyPrice2");
            this.Property(t => t.PreBuyPrice3).HasColumnName("PreBuyPrice3");
            this.Property(t => t.PreBuyPrice4).HasColumnName("PreBuyPrice4");
            this.Property(t => t.PreBuyPrice5).HasColumnName("PreBuyPrice5");
            this.Property(t => t.PreSalePrice1).HasColumnName("PreSalePrice1");
            this.Property(t => t.PreSalePrice2).HasColumnName("PreSalePrice2");
            this.Property(t => t.PreSalePrice3).HasColumnName("PreSalePrice3");
            this.Property(t => t.PreSalePrice4).HasColumnName("PreSalePrice4");
            this.Property(t => t.PreSalePrice5).HasColumnName("PreSalePrice5");
            this.Property(t => t.PreSalePrice6).HasColumnName("PreSalePrice6");
            this.Property(t => t.PreSalePrice7).HasColumnName("PreSalePrice7");
            this.Property(t => t.PreSalePrice8).HasColumnName("PreSalePrice8");
            this.Property(t => t.PreSalePrice9).HasColumnName("PreSalePrice9");
            this.Property(t => t.PreSalePrice10).HasColumnName("PreSalePrice10");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.TopSalePrice).HasColumnName("TopSalePrice");
            this.Property(t => t.LowSalePrice).HasColumnName("LowSalePrice");
            this.Property(t => t.PosDataVersion).HasColumnName("PosDataVersion");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.RecAmgSTypeBuyPrice).HasColumnName("RecAmgSTypeBuyPrice");
            this.Property(t => t.RecAmgSTypeSalePrice).HasColumnName("RecAmgSTypeSalePrice");
            this.Property(t => t.TopBuyPrice).HasColumnName("TopBuyPrice");
            this.Property(t => t.ReferPrice).HasColumnName("ReferPrice");
        }
    }
}
