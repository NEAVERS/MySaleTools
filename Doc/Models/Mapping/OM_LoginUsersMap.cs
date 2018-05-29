using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_LoginUsersMap : EntityTypeConfiguration<OM_LoginUsers>
    {
        public OM_LoginUsersMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeID);

            // Properties
            this.Property(t => t.BtypeID)
                .HasMaxLength(50);

            this.Property(t => t.UserCode)
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.TelePhone)
                .HasMaxLength(50);

            this.Property(t => t.QQ)
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .HasMaxLength(50);

            this.Property(t => t.MobilePhone)
                .HasMaxLength(50);

            this.Property(t => t.Lim)
                .HasMaxLength(5000);

            this.Property(t => t.Password)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("OM_LoginUsers");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.BtypeID).HasColumnName("BtypeID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Level).HasColumnName("Level");
            this.Property(t => t.TelePhone).HasColumnName("TelePhone");
            this.Property(t => t.QQ).HasColumnName("QQ");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.MobilePhone).HasColumnName("MobilePhone");
            this.Property(t => t.Lim).HasColumnName("Lim");
            this.Property(t => t.Password).HasColumnName("Password");
        }
    }
}
