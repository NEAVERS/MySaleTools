using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_DiscountBillMap : EntityTypeConfiguration<OM_DiscountBill>
    {
        public OM_DiscountBillMap()
        {
            // Primary Key
            this.HasKey(t => t.BillNumberID);

            // Properties
            this.Property(t => t.ModReason)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("OM_DiscountBill");
            this.Property(t => t.BillNumberID).HasColumnName("BillNumberID");
            this.Property(t => t.BillIndex_ID).HasColumnName("BillIndex_ID");
            this.Property(t => t.OldDiscount).HasColumnName("OldDiscount");
            this.Property(t => t.NewDiscount).HasColumnName("NewDiscount");
            this.Property(t => t.ModReason).HasColumnName("ModReason");
        }
    }
}
