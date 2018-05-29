using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class vWeb_GatheringPay_SaleBuyMap : EntityTypeConfiguration<vWeb_GatheringPay_SaleBuy>
    {
        public vWeb_GatheringPay_SaleBuyMap()
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

            this.Property(t => t.FullName)
                .HasMaxLength(66);

            this.Property(t => t.ETypeID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("vWeb_GatheringPay_SaleBuy");
            this.Property(t => t.BillDate).HasColumnName("BillDate");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.NCompleteTotal).HasColumnName("NCompleteTotal");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.GoodsBillID).HasColumnName("GoodsBillID");
            this.Property(t => t.MoneyBillID).HasColumnName("MoneyBillID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.GoodsBillDetailID).HasColumnName("GoodsBillDetailID");
            this.Property(t => t.ifYearBill).HasColumnName("ifYearBill");
        }
    }
}
