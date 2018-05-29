using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class loginuserMap : EntityTypeConfiguration<loginuser>
    {
        public loginuserMap()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.MangerBTypeID, t.MangerPTypeID, t.MangerBTypeID2, t.MangerETypeID, t.MangerKTypeID, t.MangerATypeID, t.MangerExpense, t.MangerIncome, t.MangerCpaital, t.MangerSTypeID, t.MangerOtherCpaital, t.MangerLiabilities, t.MangerRevenue, t.MangerPay, t.MangerDTypeID, t.MangerOwnerEquity, t.LockScreenTime });

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.sysid)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.lim)
                .HasMaxLength(5000);

            this.Property(t => t.BTypeID)
                .HasMaxLength(50);

            this.Property(t => t.MangerBTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerPTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerBTypeID2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerKTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.password)
                .HasMaxLength(32);

            this.Property(t => t.MangerATypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerExpense)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerIncome)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerCpaital)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerSTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerOtherCpaital)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerLiabilities)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerRevenue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerPay)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IpAddr)
                .HasMaxLength(100);

            this.Property(t => t.IpMax)
                .HasMaxLength(100);

            this.Property(t => t.InfoFixUp)
                .HasMaxLength(100);

            this.Property(t => t.MangerDTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LockNum)
                .HasMaxLength(20);

            this.Property(t => t.SmsSendID)
                .HasMaxLength(10);

            this.Property(t => t.MangerBankID)
                .HasMaxLength(50);

            this.Property(t => t.userPrintPassword)
                .HasMaxLength(50);

            this.Property(t => t.MangerOwnerEquity)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LockScreenTime)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("loginuser");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.sysid).HasColumnName("sysid");
            this.Property(t => t.lim).HasColumnName("lim");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.MangerBTypeID).HasColumnName("MangerBTypeID");
            this.Property(t => t.MangerPTypeID).HasColumnName("MangerPTypeID");
            this.Property(t => t.MangerBTypeID2).HasColumnName("MangerBTypeID2");
            this.Property(t => t.MangerETypeID).HasColumnName("MangerETypeID");
            this.Property(t => t.MangerKTypeID).HasColumnName("MangerKTypeID");
            this.Property(t => t.LogNum).HasColumnName("LogNum");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.MangerATypeID).HasColumnName("MangerATypeID");
            this.Property(t => t.MangerExpense).HasColumnName("MangerExpense");
            this.Property(t => t.MangerIncome).HasColumnName("MangerIncome");
            this.Property(t => t.MangerCpaital).HasColumnName("MangerCpaital");
            this.Property(t => t.MangerSTypeID).HasColumnName("MangerSTypeID");
            this.Property(t => t.MangerOtherCpaital).HasColumnName("MangerOtherCpaital");
            this.Property(t => t.MangerLiabilities).HasColumnName("MangerLiabilities");
            this.Property(t => t.MangerRevenue).HasColumnName("MangerRevenue");
            this.Property(t => t.MangerPay).HasColumnName("MangerPay");
            this.Property(t => t.IpAddr).HasColumnName("IpAddr");
            this.Property(t => t.IpMax).HasColumnName("IpMax");
            this.Property(t => t.InfoFixUp).HasColumnName("InfoFixUp");
            this.Property(t => t.MangerDTypeID).HasColumnName("MangerDTypeID");
            this.Property(t => t.LockNum).HasColumnName("LockNum");
            this.Property(t => t.OpenLock).HasColumnName("OpenLock");
            this.Property(t => t.UserRank).HasColumnName("UserRank");
            this.Property(t => t.LockRank).HasColumnName("LockRank");
            this.Property(t => t.SmsSendID).HasColumnName("SmsSendID");
            this.Property(t => t.UserDeRowCount).HasColumnName("UserDeRowCount");
            this.Property(t => t.ValidateLogin).HasColumnName("ValidateLogin");
            this.Property(t => t.MacAddress).HasColumnName("MacAddress");
            this.Property(t => t.HardDiskNo).HasColumnName("HardDiskNo");
            this.Property(t => t.IsLoadPage).HasColumnName("IsLoadPage");
            this.Property(t => t.isPosLogin).HasColumnName("isPosLogin");
            this.Property(t => t.LastLoginTime).HasColumnName("LastLoginTime");
            this.Property(t => t.MangerBankID).HasColumnName("MangerBankID");
            this.Property(t => t.userPrintCount).HasColumnName("userPrintCount");
            this.Property(t => t.userPrintPassword).HasColumnName("userPrintPassword");
            this.Property(t => t.AutoWindow).HasColumnName("AutoWindow");
            this.Property(t => t.playmsg).HasColumnName("playmsg");
            this.Property(t => t.loginTime).HasColumnName("loginTime");
            this.Property(t => t.logoutTime).HasColumnName("logoutTime");
            this.Property(t => t.belongToGroup).HasColumnName("belongToGroup");
            this.Property(t => t.isErp).HasColumnName("isErp");
            this.Property(t => t.isMobile).HasColumnName("isMobile");
            this.Property(t => t.isPos).HasColumnName("isPos");
            this.Property(t => t.IsDownLoad).HasColumnName("IsDownLoad");
            this.Property(t => t.MangerOwnerEquity).HasColumnName("MangerOwnerEquity");
            this.Property(t => t.LockScreenTime).HasColumnName("LockScreenTime");
        }
    }
}
