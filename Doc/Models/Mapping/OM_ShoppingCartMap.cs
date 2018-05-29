using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_ShoppingCartMap : EntityTypeConfiguration<OM_ShoppingCart>
    {
        public OM_ShoppingCartMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.CommodityId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CommodityName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BtypeName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.CreatorName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ModifierName)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("OM_ShoppingCart");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CommodityId).HasColumnName("CommodityId");
            this.Property(t => t.CommodityName).HasColumnName("CommodityName");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.TotalMoney).HasColumnName("TotalMoney");
            this.Property(t => t.SaleMoney).HasColumnName("SaleMoney");
            this.Property(t => t.UnitID).HasColumnName("UnitID");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.InventoryInfoId).HasColumnName("InventoryInfoId");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.BtypeName).HasColumnName("BtypeName");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.CreatorId).HasColumnName("CreatorId");
            this.Property(t => t.CreatorName).HasColumnName("CreatorName");
            this.Property(t => t.CreatedTime).HasColumnName("CreatedTime");
            this.Property(t => t.ModifierId).HasColumnName("ModifierId");
            this.Property(t => t.ModifierName).HasColumnName("ModifierName");
            this.Property(t => t.ModifiedTime).HasColumnName("ModifiedTime");
            this.Property(t => t.IsShopping).HasColumnName("IsShopping");
            this.Property(t => t.IsGift).HasColumnName("IsGift");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.bid).HasColumnName("bid");
        }
    }
}
