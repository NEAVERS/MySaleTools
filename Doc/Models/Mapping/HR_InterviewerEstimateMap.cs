using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_InterviewerEstimateMap : EntityTypeConfiguration<HR_InterviewerEstimate>
    {
        public HR_InterviewerEstimateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Times, t.Person_ID, t.HR_ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Times)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Person_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HR_ID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HR_InterviewerEstimate");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Times).HasColumnName("Times");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Person_ID).HasColumnName("Person_ID");
            this.Property(t => t.HR_ID).HasColumnName("HR_ID");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
        }
    }
}
