using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommonPosSaleIndexMap : EntityTypeConfiguration<CommonPosSaleIndex>
    {
        public CommonPosSaleIndexMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PosVchCode, t.BillCode, t.Branchid, t.BtypeID, t.KtypeID, t.Cashier, t.Salesman, t.VipCardID, t.Total, t.BillDiscount, t.Efface, t.FinallyTotal, t.PosID, t.SaleDate, t.SaleTime, t.Draft, t.DraftVchcode, t.CashSum, t.CreditSum, t.ReplaceCashSum, t.SaveAccountSum, t.ChangeSum, t.VipIntegral, t.BackGoodsVchCode, t.SGCXBillID, t.RetReplaceCashSum, t.IsUpSend, t.UpLoadPosVchCode, t.UniqueID });

            // Properties
            this.Property(t => t.PosVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.BillCode)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Branchid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.KtypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Cashier)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Salesman)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VipCardID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Total)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillDiscount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Efface)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FinallyTotal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PosID)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.SaleDate)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.SaleTime)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.Draft)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DraftVchcode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CashSum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CreditSum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReplaceCashSum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SaveAccountSum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ChangeSum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VipIntegral)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BackGoodsVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SGCXBillID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetReplaceCashSum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IsUpSend)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UpLoadPosVchCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UniqueID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommonPosSaleIndex");
            this.Property(t => t.PosVchCode).HasColumnName("PosVchCode");
            this.Property(t => t.BillCode).HasColumnName("BillCode");
            this.Property(t => t.Branchid).HasColumnName("Branchid");
            this.Property(t => t.BtypeID).HasColumnName("BtypeID");
            this.Property(t => t.KtypeID).HasColumnName("KtypeID");
            this.Property(t => t.Cashier).HasColumnName("Cashier");
            this.Property(t => t.Salesman).HasColumnName("Salesman");
            this.Property(t => t.VipCardID).HasColumnName("VipCardID");
            this.Property(t => t.Total).HasColumnName("Total");
            this.Property(t => t.BillDiscount).HasColumnName("BillDiscount");
            this.Property(t => t.Efface).HasColumnName("Efface");
            this.Property(t => t.FinallyTotal).HasColumnName("FinallyTotal");
            this.Property(t => t.PosID).HasColumnName("PosID");
            this.Property(t => t.SaleDate).HasColumnName("SaleDate");
            this.Property(t => t.SaleTime).HasColumnName("SaleTime");
            this.Property(t => t.Draft).HasColumnName("Draft");
            this.Property(t => t.DraftVchcode).HasColumnName("DraftVchcode");
            this.Property(t => t.CashSum).HasColumnName("CashSum");
            this.Property(t => t.CreditSum).HasColumnName("CreditSum");
            this.Property(t => t.ReplaceCashSum).HasColumnName("ReplaceCashSum");
            this.Property(t => t.SaveAccountSum).HasColumnName("SaveAccountSum");
            this.Property(t => t.ChangeSum).HasColumnName("ChangeSum");
            this.Property(t => t.VipIntegral).HasColumnName("VipIntegral");
            this.Property(t => t.BackGoodsVchCode).HasColumnName("BackGoodsVchCode");
            this.Property(t => t.SGCXBillID).HasColumnName("SGCXBillID");
            this.Property(t => t.RetReplaceCashSum).HasColumnName("RetReplaceCashSum");
            this.Property(t => t.IsUpSend).HasColumnName("IsUpSend");
            this.Property(t => t.UpLoadPosVchCode).HasColumnName("UpLoadPosVchCode");
            this.Property(t => t.UniqueID).HasColumnName("UniqueID");
        }
    }
}
