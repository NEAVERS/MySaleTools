using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_BackOrderDetailMap : EntityTypeConfiguration<OM_BackOrderDetail>
    {
        public OM_BackOrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.comment)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("OM_BackOrderDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.billNumberID).HasColumnName("billNumberID");
            this.Property(t => t.ptypeid).HasColumnName("ptypeid");
            this.Property(t => t.qty).HasColumnName("qty");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.taxprice).HasColumnName("taxprice");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.SaleTotal).HasColumnName("SaleTotal");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.ReachQty).HasColumnName("ReachQty");
            this.Property(t => t.ConfirmQty).HasColumnName("ConfirmQty");
            this.Property(t => t.StopQty).HasColumnName("StopQty");
            this.Property(t => t.STATUS).HasColumnName("STATUS");
            this.Property(t => t.InventoryInfoId).HasColumnName("InventoryInfoId");
            this.Property(t => t.OrderIndexId).HasColumnName("OrderIndexId");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
        }
    }
}
