using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CompleteTotalMap : EntityTypeConfiguration<CompleteTotal>
    {
        public CompleteTotalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.GoodsBillID, t.MoneyBillID, t.ID });

            // Properties
            this.Property(t => t.GoodsBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MoneyBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EtypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CompleteTotal");
            this.Property(t => t.GoodsBillID).HasColumnName("GoodsBillID");
            this.Property(t => t.MoneyBillID).HasColumnName("MoneyBillID");
            this.Property(t => t.CompleteTotal1).HasColumnName("CompleteTotal");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.Billdate).HasColumnName("Billdate");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.GoodsBillDetailID).HasColumnName("GoodsBillDetailID");
            this.Property(t => t.IsSelect).HasColumnName("IsSelect");
            this.Property(t => t.BillType).HasColumnName("BillType");
        }
    }
}
