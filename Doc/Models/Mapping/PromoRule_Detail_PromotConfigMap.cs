using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PromoRule_Detail_PromotConfigMap : EntityTypeConfiguration<PromoRule_Detail_PromotConfig>
    {
        public PromoRule_Detail_PromotConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.PromoRuleID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PromoRuleID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.BindPtypeId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PromoRule_Detail_PromotConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PromoRuleID).HasColumnName("PromoRuleID");
            this.Property(t => t.PromoStylePtype).HasColumnName("PromoStylePtype");
            this.Property(t => t.PromoStyleDiscount).HasColumnName("PromoStyleDiscount");
            this.Property(t => t.BuyTotal).HasColumnName("BuyTotal");
            this.Property(t => t.BuyQty).HasColumnName("BuyQty");
            this.Property(t => t.DisCount).HasColumnName("DisCount");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.OtherTotal).HasColumnName("OtherTotal");
            this.Property(t => t.GiftTypeID).HasColumnName("GiftTypeID");
            this.Property(t => t.CardTypeID).HasColumnName("CardTypeID");
            this.Property(t => t.BindPtypeId).HasColumnName("BindPtypeId");
        }
    }
}
