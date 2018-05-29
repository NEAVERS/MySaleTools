using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_TransportMap : EntityTypeConfiguration<QP_Transport>
    {
        public QP_TransportMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.FullName, t.BTypeID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.PYCode)
                .HasMaxLength(200);

            this.Property(t => t.BTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Comment)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("QP_Transport");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
            this.Property(t => t.BTypeID).HasColumnName("BTypeID");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
