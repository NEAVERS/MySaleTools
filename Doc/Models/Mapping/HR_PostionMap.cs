using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_PostionMap : EntityTypeConfiguration<HR_Postion>
    {
        public HR_PostionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Department_ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Department_ID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HR_Postion");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Department_ID).HasColumnName("Department_ID");
            this.Property(t => t.Intro).HasColumnName("Intro");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
