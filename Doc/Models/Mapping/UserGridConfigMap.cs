using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class UserGridConfigMap : EntityTypeConfiguration<UserGridConfig>
    {
        public UserGridConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.employeeid, t.rk, t.ck, t.qt });

            // Properties
            this.Property(t => t.employeeid)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.rk)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ck)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.qt)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("UserGridConfig");
            this.Property(t => t.employeeid).HasColumnName("employeeid");
            this.Property(t => t.rk).HasColumnName("rk");
            this.Property(t => t.ck).HasColumnName("ck");
            this.Property(t => t.qt).HasColumnName("qt");
        }
    }
}
