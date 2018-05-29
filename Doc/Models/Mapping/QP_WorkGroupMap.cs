using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_WorkGroupMap : EntityTypeConfiguration<QP_WorkGroup>
    {
        public QP_WorkGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.UserCode, t.FullName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QP_WorkGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
