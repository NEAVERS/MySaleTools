using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class QP_RepairSetMealMap : EntityTypeConfiguration<QP_RepairSetMeal>
    {
        public QP_RepairSetMealMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TypeID, t.ParID, t.Leveal, t.SonCount, t.SonNum, t.UserCode, t.FullName, t.Failure, t.DealTenet });

            // Properties
            this.Property(t => t.TypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ParID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonCount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SonNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Failure)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.DealTenet)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.PYCode)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QP_RepairSetMeal");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.ParID).HasColumnName("ParID");
            this.Property(t => t.Leveal).HasColumnName("Leveal");
            this.Property(t => t.SonCount).HasColumnName("SonCount");
            this.Property(t => t.SonNum).HasColumnName("SonNum");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.Failure).HasColumnName("Failure");
            this.Property(t => t.DealTenet).HasColumnName("DealTenet");
            this.Property(t => t.PYCode).HasColumnName("PYCode");
        }
    }
}
