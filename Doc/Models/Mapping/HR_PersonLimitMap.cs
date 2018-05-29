using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_PersonLimitMap : EntityTypeConfiguration<HR_PersonLimit>
    {
        public HR_PersonLimitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Person_ID, t.Identifier, t.Limit });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Person_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Identifier)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Limit)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("HR_PersonLimit");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Person_ID).HasColumnName("Person_ID");
            this.Property(t => t.Identifier).HasColumnName("Identifier");
            this.Property(t => t.Limit).HasColumnName("Limit");
        }
    }
}
