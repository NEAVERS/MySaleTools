using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class DocFilePathMap : EntityTypeConfiguration<DocFilePath>
    {
        public DocFilePathMap()
        {
            // Primary Key
            this.HasKey(t => new { t.typeid, t.parid, t.leveal, t.sonnum, t.soncount, t.FullName, t.etypeid });

            // Properties
            this.Property(t => t.typeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.parid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DocFilePath");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
        }
    }
}
