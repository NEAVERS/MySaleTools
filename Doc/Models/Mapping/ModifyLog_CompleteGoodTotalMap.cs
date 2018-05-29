using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ModifyLog_CompleteGoodTotalMap : EntityTypeConfiguration<ModifyLog_CompleteGoodTotal>
    {
        public ModifyLog_CompleteGoodTotalMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.GoodsBillID, t.MoneyBillID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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
            this.ToTable("ModifyLog_CompleteGoodTotal");
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
            this.Property(t => t.NCompleteGoodTotal).HasColumnName("NCompleteGoodTotal");
            this.Property(t => t.IsSelect).HasColumnName("IsSelect");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.ModifyTime).HasColumnName("ModifyTime");
            this.Property(t => t.ModifyCount).HasColumnName("ModifyCount");
        }
    }
}
