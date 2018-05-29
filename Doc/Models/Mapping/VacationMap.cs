using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VacationMap : EntityTypeConfiguration<Vacation>
    {
        public VacationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.Fullname, t.STypeID, t.StartTime, t.EndTime });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Fullname)
                .IsRequired();

            this.Property(t => t.STypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vacation");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Fullname).HasColumnName("Fullname");
            this.Property(t => t.STypeID).HasColumnName("STypeID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
        }
    }
}
