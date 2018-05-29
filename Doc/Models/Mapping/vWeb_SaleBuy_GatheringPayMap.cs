using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_SaleBuy_GatheringPayMap : EntityTypeConfiguration<vWeb_SaleBuy_GatheringPay>
    {
        public vWeb_SaleBuy_GatheringPayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillDate, t.BillCode, t.BillType, t.GoodsBillID, t.MoneyBillID });

            // Properties
            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GoodsBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MoneyBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vWeb_SaleBuy_GatheringPay");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.totalinmoney).HasColumnName("totalinmoney");
            this.Property(t => t.NTotalInMoney).HasColumnName("NTotalInMoney");
            this.Property(t => t.CompleteTotal).HasColumnName("CompleteTotal");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.jsbilltype).HasColumnName("jsbilltype");
            this.Property(t => t.GoodsBillID).HasColumnName("GoodsBillID");
            this.Property(t => t.MoneyBillID).HasColumnName("MoneyBillID");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.GoodsBillDetailID).HasColumnName("GoodsBillDetailID");
            this.Property(t => t.ifYearBill).HasColumnName("ifYearBill");
            this.Property(t => t.ComBillType).HasColumnName("ComBillType");
        }
    }
}
