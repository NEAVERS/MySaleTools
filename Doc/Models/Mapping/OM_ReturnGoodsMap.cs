using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_ReturnGoodsMap : EntityTypeConfiguration<OM_ReturnGoods>
    {
        public OM_ReturnGoodsMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberID);

            // Properties
            this.Property(t => t.Reason)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OM_ReturnGoods");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillIndex_ID).HasColumnName("BillIndex_ID");
            this.Property(t => t.OrderDetails_ID).HasColumnName("OrderDetails_ID");
            this.Property(t => t.ReturnGoodsableQty).HasColumnName("ReturnGoodsableQty");
            this.Property(t => t.ReturnGoodsQty).HasColumnName("ReturnGoodsQty");
            this.Property(t => t.Reason).HasColumnName("Reason");
            this.Property(t => t.ReturnPrice).HasColumnName("ReturnPrice");
            this.Property(t => t.ReturnTotalPrice).HasColumnName("ReturnTotalPrice");
        }
    }
}
