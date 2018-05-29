using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_BankAccountMap : EntityTypeConfiguration<Te_BankAccount>
    {
        public Te_BankAccountMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.UserCode, t.FullName, t.DestroyReson, t.Comment });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.AccountNumber)
                .HasMaxLength(50);

            this.Property(t => t.STypeId)
                .HasMaxLength(50);

            this.Property(t => t.ATypeId)
                .HasMaxLength(50);

            this.Property(t => t.DestroyReson)
                .IsRequired()
                .HasMaxLength(1000);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Te_BankAccount");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.BankId).HasColumnName("BankId");
            this.Property(t => t.ATypeId).HasColumnName("ATypeId");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.IsDestroy).HasColumnName("IsDestroy");
            this.Property(t => t.DestroyDate).HasColumnName("DestroyDate");
            this.Property(t => t.DestroyReson).HasColumnName("DestroyReson");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Cid).HasColumnName("Cid");
            this.Property(t => t.XiWaMaxNumber).HasColumnName("XiWaMaxNumber");
            this.Property(t => t.YearClose).HasColumnName("YearClose");
        }
    }
}
