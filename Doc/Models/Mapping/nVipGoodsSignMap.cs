using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class nVipGoodsSignMap : EntityTypeConfiguration<nVipGoodsSign>
    {
        public nVipGoodsSignMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VipGoodsSignID, t.JFid });

            // Properties
            this.Property(t => t.VipGoodsSignID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.JFid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("nVipGoodsSign");
            this.Property(t => t.VipGoodsSignID).HasColumnName("VipGoodsSignID");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.VipDiscount1).HasColumnName("VipDiscount1");
            this.Property(t => t.VipDiscount2).HasColumnName("VipDiscount2");
            this.Property(t => t.VipDiscount3).HasColumnName("VipDiscount3");
            this.Property(t => t.VipDiscount4).HasColumnName("VipDiscount4");
            this.Property(t => t.VipPrice).HasColumnName("VipPrice");
            this.Property(t => t.JFid).HasColumnName("JFid");
            this.Property(t => t.VipPrice1).HasColumnName("VipPrice1");
            this.Property(t => t.VipPrice2).HasColumnName("VipPrice2");
            this.Property(t => t.VipPrice3).HasColumnName("VipPrice3");
            this.Property(t => t.VipPrice4).HasColumnName("VipPrice4");
            this.Property(t => t.VipPrice5).HasColumnName("VipPrice5");
        }
    }
}
