using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_ChargingStandardsMap : EntityTypeConfiguration<QP_ChargingStandards>
    {
        public QP_ChargingStandardsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.FullName, t.IfDefault });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.IfDefault)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QP_ChargingStandards");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.ManHourRate).HasColumnName("ManHourRate");
            this.Property(t => t.IfDefault).HasColumnName("IfDefault");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
