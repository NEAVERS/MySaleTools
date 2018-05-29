using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Pos_UploadDogInfoMap : EntityTypeConfiguration<Pos_UploadDogInfo>
    {
        public Pos_UploadDogInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.logtime });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.dognumber)
                .HasMaxLength(200);

            this.Property(t => t.posname)
                .HasMaxLength(200);

            this.Property(t => t.IsUpload)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("Pos_UploadDogInfo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.dognumber).HasColumnName("dognumber");
            this.Property(t => t.posname).HasColumnName("posname");
            this.Property(t => t.eid).HasColumnName("eid");
            this.Property(t => t.billcount).HasColumnName("billcount");
            this.Property(t => t.logtime).HasColumnName("logtime");
            this.Property(t => t.uploadtime).HasColumnName("uploadtime");
            this.Property(t => t.IsUpload).HasColumnName("IsUpload");
        }
    }
}
