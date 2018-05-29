using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_PersonWorkExpMap : EntityTypeConfiguration<HR_PersonWorkExp>
    {
        public HR_PersonWorkExpMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Person_ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Person_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HR_PersonWorkExp");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Person_ID).HasColumnName("Person_ID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Department).HasColumnName("Department");
            this.Property(t => t.Job).HasColumnName("Job");
            this.Property(t => t.DimissionReason).HasColumnName("DimissionReason");
            this.Property(t => t.ProvePerson).HasColumnName("ProvePerson");
            this.Property(t => t.CompanyPhone).HasColumnName("CompanyPhone");
        }
    }
}
