using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_AutoTypeMap : EntityTypeConfiguration<QP_AutoType>
    {
        public QP_AutoTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.FullName });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(300);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QP_AutoType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
