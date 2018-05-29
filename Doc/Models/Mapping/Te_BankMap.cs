using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Te_BankMap : EntityTypeConfiguration<Te_Bank>
    {
        public Te_BankMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.UserCode, t.FullName, t.ContactMan, t.Comment });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.Address)
                .HasMaxLength(1000);

            this.Property(t => t.PhoneNum)
                .HasMaxLength(50);

            this.Property(t => t.ContactMan)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Te_Bank");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.PhoneNum).HasColumnName("PhoneNum");
            this.Property(t => t.ContactMan).HasColumnName("ContactMan");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsSys).HasColumnName("IsSys");
        }
    }
}
