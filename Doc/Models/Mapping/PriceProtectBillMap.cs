using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PriceProtectBillMap : EntityTypeConfiguration<PriceProtectBill>
    {
        public PriceProtectBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberid, t.Serial, t.ID });

            // Properties
            this.Property(t => t.BillNumberid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Serial)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Ptypeid)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PriceProtectBill");
            this.Property(t => t.BillNumberid).HasColumnName("BillNumberid");
            this.Property(t => t.Serial).HasColumnName("Serial");
            this.Property(t => t.Ptypeid).HasColumnName("Ptypeid");
            this.Property(t => t.OldTotal).HasColumnName("OldTotal");
            this.Property(t => t.OldPrice).HasColumnName("OldPrice");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.NewPrice).HasColumnName("NewPrice");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
            this.Property(t => t.ItemID).HasColumnName("ItemID");
            this.Property(t => t.IsCombined).HasColumnName("IsCombined");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
        }
    }
}
