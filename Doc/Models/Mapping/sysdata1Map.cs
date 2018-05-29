using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sysdata1Map : EntityTypeConfiguration<sysdata1>
    {
        public sysdata1Map()
        {
            // Primary Key
            this.HasKey(t => new { t.SubNo, t.SubValue });

            // Properties
            this.Property(t => t.SubNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SubName)
                .HasMaxLength(30);

            this.Property(t => t.SubValue)
                .IsRequired()
                .HasMaxLength(5000);

            this.Property(t => t.SubComment)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("sysdata1");
            this.Property(t => t.SubNo).HasColumnName("SubNo");
            this.Property(t => t.SubName).HasColumnName("SubName");
            this.Property(t => t.SubValue).HasColumnName("SubValue");
            this.Property(t => t.SubComment).HasColumnName("SubComment");
        }
    }
}
