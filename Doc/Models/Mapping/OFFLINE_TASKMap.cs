using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OFFLINE_TASKMap : EntityTypeConfiguration<OFFLINE_TASK>
    {
        public OFFLINE_TASKMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.FILENAME, t.DATE, t.FLAG, t.TASKID, t.STATUS });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.FILENAME)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.FLAG)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TASKID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STATUS)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STOCKID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OFFLINE_TASK");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FILENAME).HasColumnName("FILENAME");
            this.Property(t => t.DATE).HasColumnName("DATE");
            this.Property(t => t.FLAG).HasColumnName("FLAG");
            this.Property(t => t.TASKID).HasColumnName("TASKID");
            this.Property(t => t.STATUS).HasColumnName("STATUS");
            this.Property(t => t.STOCKID).HasColumnName("STOCKID");
        }
    }
}
