using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class EshopGoodsInfoMap : EntityTypeConfiguration<EshopGoodsInfo>
    {
        public EshopGoodsInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EshopId, t.NumIid, t.OuterId });

            // Properties
            this.Property(t => t.EshopId)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.NumIid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OuterId)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SkuId)
                .HasMaxLength(100);

            this.Property(t => t.GoodsName)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("EshopGoodsInfo");
            this.Property(t => t.EshopId).HasColumnName("EshopId");
            this.Property(t => t.NumIid).HasColumnName("NumIid");
            this.Property(t => t.OuterId).HasColumnName("OuterId");
            this.Property(t => t.SkuId).HasColumnName("SkuId");
            this.Property(t => t.GoodsName).HasColumnName("GoodsName");
        }
    }
}
