using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_PersonEduMap : EntityTypeConfiguration<HR_PersonEdu>
    {
        public HR_PersonEduMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Person_ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Person_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HR_PersonEdu");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Person_ID).HasColumnName("Person_ID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.School).HasColumnName("School");
            this.Property(t => t.Specialty).HasColumnName("Specialty");
            this.Property(t => t.Degree).HasColumnName("Degree");
        }
    }
}
