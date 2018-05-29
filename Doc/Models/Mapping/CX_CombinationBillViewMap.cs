using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CX_CombinationBillViewMap : EntityTypeConfiguration<CX_CombinationBillView>
    {
        public CX_CombinationBillViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.Row });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Row)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .HasMaxLength(66);

            this.Property(t => t.EntryCode)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CX_CombinationBillView");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.Row).HasColumnName("Row");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.EntryCode).HasColumnName("EntryCode");
            this.Property(t => t.SalePrice).HasColumnName("SalePrice");
            this.Property(t => t.Discount).HasColumnName("Discount");
            this.Property(t => t.DiscountPrice).HasColumnName("DiscountPrice");
            this.Property(t => t.MemberPrice).HasColumnName("MemberPrice");
        }
    }
}
