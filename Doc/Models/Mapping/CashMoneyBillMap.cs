using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CashMoneyBillMap : EntityTypeConfiguration<CashMoneyBill>
    {
        public CashMoneyBillMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AtypeId)
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(256);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Stypeid)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CashMoneyBill");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.AtypeId).HasColumnName("AtypeId");
            this.Property(t => t.total).HasColumnName("total");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.TeamNo).HasColumnName("TeamNo");
            this.Property(t => t.TeamNo1).HasColumnName("TeamNo1");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Stypeid).HasColumnName("Stypeid");
        }
    }
}
