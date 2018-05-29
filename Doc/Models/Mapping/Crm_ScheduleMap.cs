using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Crm_ScheduleMap : EntityTypeConfiguration<Crm_Schedule>
    {
        public Crm_ScheduleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.TYPE, t.Date, t.Title, t.IsAlert });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.TYPE)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.CreatorTypeID)
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Content)
                .HasMaxLength(2000);

            this.Property(t => t.IsAlert)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ViewEtypeIDS)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("Crm_Schedule");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TYPE).HasColumnName("TYPE");
            this.Property(t => t.CreatorTypeID).HasColumnName("CreatorTypeID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.AlterDate).HasColumnName("AlterDate");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.IsAlert).HasColumnName("IsAlert");
            this.Property(t => t.ViewEtypeIDS).HasColumnName("ViewEtypeIDS");
        }
    }
}
