using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_TaskMap : EntityTypeConfiguration<HR_Task>
    {
        public HR_TaskMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Postion_ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Postion_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HR_Task");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.IntendingDays).HasColumnName("IntendingDays");
            this.Property(t => t.Postion_ID).HasColumnName("Postion_ID");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.StatusID).HasColumnName("StatusID");
        }
    }
}
