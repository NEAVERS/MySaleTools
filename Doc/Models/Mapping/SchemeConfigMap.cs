using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class SchemeConfigMap : EntityTypeConfiguration<SchemeConfig>
    {
        public SchemeConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.SchemeID, t.IP, t.Port, t.ConName, t.ConPwd, t.DbName, t.CreateTime, t.CreateID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.SchemeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IP)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Port)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.instancename)
                .HasMaxLength(100);

            this.Property(t => t.ConName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ConPwd)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.DbName)
                .IsRequired()
                .HasMaxLength(256);

            this.Property(t => t.CreateID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("SchemeConfig");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SchemeID).HasColumnName("SchemeID");
            this.Property(t => t.IP).HasColumnName("IP");
            this.Property(t => t.Port).HasColumnName("Port");
            this.Property(t => t.instancename).HasColumnName("instancename");
            this.Property(t => t.ConName).HasColumnName("ConName");
            this.Property(t => t.ConPwd).HasColumnName("ConPwd");
            this.Property(t => t.DbName).HasColumnName("DbName");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.CreateID).HasColumnName("CreateID");
        }
    }
}
