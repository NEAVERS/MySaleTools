using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Old_CompleteGoodTotalMap : EntityTypeConfiguration<Old_CompleteGoodTotal>
    {
        public Old_CompleteGoodTotalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.GoodsBillID, t.MoneyBillID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.GoodsBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MoneyBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InOrOut)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.PtypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Old_CompleteGoodTotal");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GoodsBillID).HasColumnName("GoodsBillID");
            this.Property(t => t.MoneyBillID).HasColumnName("MoneyBillID");
            this.Property(t => t.InOrOut).HasColumnName("InOrOut");
            this.Property(t => t.CompleteGoodQTY).HasColumnName("CompleteGoodQTY");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.Billdate).HasColumnName("Billdate");
            this.Property(t => t.PtypeID).HasColumnName("PtypeID");
            this.Property(t => t.Billid).HasColumnName("Billid");
            this.Property(t => t.CompleteGoodTotal).HasColumnName("CompleteGoodTotal");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.BillType).HasColumnName("BillType");
        }
    }
}
