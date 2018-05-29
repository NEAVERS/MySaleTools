using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Pos_PicUpdateRecordMap : EntityTypeConfiguration<Pos_PicUpdateRecord>
    {
        public Pos_PicUpdateRecordMap()
        {
            // Primary Key
            this.HasKey(t => t.pid);

            // Properties
            this.Property(t => t.pid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Pos_PicUpdateRecord");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.updatenumber).HasColumnName("updatenumber");
        }
    }
}
