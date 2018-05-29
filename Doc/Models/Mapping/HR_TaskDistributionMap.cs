using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class HR_TaskDistributionMap : EntityTypeConfiguration<HR_TaskDistribution>
    {
        public HR_TaskDistributionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Task_ID, t.Person_ID, t.TaskStatus_ID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Task_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Person_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TaskStatus_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("HR_TaskDistribution");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Task_ID).HasColumnName("Task_ID");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.DeadTime).HasColumnName("DeadTime");
            this.Property(t => t.Person_ID).HasColumnName("Person_ID");
            this.Property(t => t.TaskStatus_ID).HasColumnName("TaskStatus_ID");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
