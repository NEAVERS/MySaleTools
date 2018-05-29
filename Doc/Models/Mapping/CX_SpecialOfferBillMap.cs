using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_SpecialOfferBillMap : EntityTypeConfiguration<CX_SpecialOfferBill>
    {
        public CX_SpecialOfferBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.Row });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Row)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PtypeId)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CX_SpecialOfferBill");
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
