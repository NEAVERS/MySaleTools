using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_ReplacementGoodsMap : EntityTypeConfiguration<OM_ReplacementGoods>
    {
        public OM_ReplacementGoodsMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberId);

            // Properties
            this.Property(t => t.Reason)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OM_ReplacementGoods");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.BillIndex_ID).HasColumnName("BillIndex_ID");
            this.Property(t => t.OrderDetails_ID).HasColumnName("OrderDetails_ID");
            this.Property(t => t.ReplacementGoodsQty).HasColumnName("ReplacementGoodsQty");
            this.Property(t => t.ReplacementGoodsableQty).HasColumnName("ReplacementGoodsableQty");
            this.Property(t => t.Reason).HasColumnName("Reason");
        }
    }
}
