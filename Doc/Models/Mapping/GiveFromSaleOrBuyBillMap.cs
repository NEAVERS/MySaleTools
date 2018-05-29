using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class GiveFromSaleOrBuyBillMap : EntityTypeConfiguration<GiveFromSaleOrBuyBill>
    {
        public GiveFromSaleOrBuyBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillID, t.ID });

            // Properties
            this.Property(t => t.BillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GiveFromSaleOrBuyBill");
            this.Property(t => t.BillID).HasColumnName("BillID");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
