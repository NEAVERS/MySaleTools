using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosBranchViewMap : EntityTypeConfiguration<PosBranchView>
    {
        public PosBranchViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Sonnum, t.Leveal, t.Rec, t.Soncount, t.branchtype, t.UserCode, t.FullName, t.Name, t.Comment, t.Deleted, t.CheckAndAccept, t.DefTaxRate, t.CashAsBillMoney, t.RoundType, t.PayType });

            // Properties
            this.Property(t => t.BranchID)
                .HasMaxLength(50);

            this.Property(t => t.ParID)
                .HasMaxLength(50);

            this.Property(t => t.Sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Rec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.branchtype)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Namepy)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.Area)
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            this.Property(t => t.Tel)
                .HasMaxLength(100);

            this.Property(t => t.Email)
                .HasMaxLength(30);

            this.Property(t => t.CheckAndAccept)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BtypeId)
                .HasMaxLength(30);

            this.Property(t => t.DefTaxRate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DefBtypeId)
                .HasMaxLength(30);

            this.Property(t => t.DefKtypeId)
                .HasMaxLength(30);

            this.Property(t => t.DefAtypeId)
                .HasMaxLength(30);

            this.Property(t => t.CashAsBillMoney)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoundType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PayType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExtId)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("PosBranchView");
            this.Property(t => t.BranchID).HasColumnName("BranchID");
            this.Property(t => t.ParID).HasColumnName("ParID");
            this.Property(t => t.Sonnum).HasColumnName("Sonnum");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.Rec).HasColumnName("Rec");
            this.Property(t => t.Soncount).HasColumnName("Soncount");
            this.Property(t => t.branchtype).HasColumnName("branchtype");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Namepy).HasColumnName("Namepy");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Deleted).HasColumnName("Deleted");
            this.Property(t => t.CheckAndAccept).HasColumnName("CheckAndAccept");
            this.Property(t => t.BtypeId).HasColumnName("BtypeId");
            this.Property(t => t.DefTaxRate).HasColumnName("DefTaxRate");
            this.Property(t => t.DefBtypeId).HasColumnName("DefBtypeId");
            this.Property(t => t.DefKtypeId).HasColumnName("DefKtypeId");
            this.Property(t => t.DefAtypeId).HasColumnName("DefAtypeId");
            this.Property(t => t.CashAsBillMoney).HasColumnName("CashAsBillMoney");
            this.Property(t => t.RoundType).HasColumnName("RoundType");
            this.Property(t => t.PayType).HasColumnName("PayType");
            this.Property(t => t.UpdateTag).HasColumnName("UpdateTag");
            this.Property(t => t.ExtId).HasColumnName("ExtId");
        }
    }
}
