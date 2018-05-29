using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_SpecialOfferBillViewMap : EntityTypeConfiguration<CX_SpecialOfferBillView>
    {
        public CX_SpecialOfferBillViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.Row, t.PtypeId });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Row)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CX_SpecialOfferBillView");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Row).HasColumnName("Row");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.MemberIntegral).HasColumnName("MemberIntegral");
            this.Property(t => t.MemberPrice).HasColumnName("MemberPrice");
        }
    }
}
