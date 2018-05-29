using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_OrderDetailsMap : EntityTypeConfiguration<OM_OrderDetails>
    {
        public OM_OrderDetailsMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberID);

            // Properties
            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            this.Property(t => t.StypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OM_OrderDetails");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.Billindex_ID).HasColumnName("Billindex_ID");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.StypeID).HasColumnName("StypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.TaxRate).HasColumnName("TaxRate");
            this.Property(t => t.TaxAmount).HasColumnName("TaxAmount");
            this.Property(t => t.PriceNoTax).HasColumnName("PriceNoTax");
            this.Property(t => t.TotalPriceNoTax).HasColumnName("TotalPriceNoTax");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.DiscountTotalPrice).HasColumnName("DiscountTotalPrice");
            this.Property(t => t.PriceNature).HasColumnName("PriceNature");
            this.Property(t => t.SpecalPrice).HasColumnName("SpecalPrice");
            this.Property(t => t.SpecalTotalPrice).HasColumnName("SpecalTotalPrice");
            this.Property(t => t.ShipmentsQty).HasColumnName("ShipmentsQty");
            this.Property(t => t.OutQty).HasColumnName("OutQty");
        }
    }
}
