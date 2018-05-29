using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Pos_UploadPicRecordMap : EntityTypeConfiguration<Pos_UploadPicRecord>
    {
        public Pos_UploadPicRecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.posid, t.pid, t.lastupdatenumber });

            // Properties
            this.Property(t => t.posid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.pid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.lastupdatenumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Pos_UploadPicRecord");
            this.Property(t => t.posid).HasColumnName("posid");
            this.Property(t => t.pid).HasColumnName("pid");
            this.Property(t => t.lastupdatenumber).HasColumnName("lastupdatenumber");
        }
    }
}
