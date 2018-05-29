using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UserGroupLimitMap : EntityTypeConfiguration<UserGroupLimit>
    {
        public UserGroupLimitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.EtypeID, t.Lim, t.MangerETypeID, t.MangerPTypeID, t.MangerKTypeID, t.MangerSTypeID, t.MangerDTypeID, t.MangerBTypeID, t.MangerBTypeID2, t.MangerATypeID, t.MangerRevenue, t.MangerOwnerEquity, t.MangerExpense, t.MangerIncome, t.MangerCpaital, t.MangerOtherCpaital, t.MangerLiabilities, t.MangerPay, t.MangerBankID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EtypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Lim)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.MangerETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerPTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerKTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerSTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerDTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerBTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerBTypeID2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerATypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerRevenue)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerOwnerEquity)
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

            this.Property(t => t.MangerOtherCpaital)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerLiabilities)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerPay)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MangerBankID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("UserGroupLimit");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.Lim).HasColumnName("Lim");
            this.Property(t => t.MangerETypeID).HasColumnName("MangerETypeID");
            this.Property(t => t.MangerPTypeID).HasColumnName("MangerPTypeID");
            this.Property(t => t.MangerKTypeID).HasColumnName("MangerKTypeID");
            this.Property(t => t.MangerSTypeID).HasColumnName("MangerSTypeID");
            this.Property(t => t.MangerDTypeID).HasColumnName("MangerDTypeID");
            this.Property(t => t.MangerBTypeID).HasColumnName("MangerBTypeID");
            this.Property(t => t.MangerBTypeID2).HasColumnName("MangerBTypeID2");
            this.Property(t => t.MangerATypeID).HasColumnName("MangerATypeID");
            this.Property(t => t.MangerRevenue).HasColumnName("MangerRevenue");
            this.Property(t => t.MangerOwnerEquity).HasColumnName("MangerOwnerEquity");
            this.Property(t => t.MangerExpense).HasColumnName("MangerExpense");
            this.Property(t => t.MangerIncome).HasColumnName("MangerIncome");
            this.Property(t => t.MangerCpaital).HasColumnName("MangerCpaital");
            this.Property(t => t.MangerOtherCpaital).HasColumnName("MangerOtherCpaital");
            this.Property(t => t.MangerLiabilities).HasColumnName("MangerLiabilities");
            this.Property(t => t.MangerPay).HasColumnName("MangerPay");
            this.Property(t => t.MangerBankID).HasColumnName("MangerBankID");
        }
    }
}
