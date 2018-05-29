using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sysmovedataMap : EntityTypeConfiguration<sysmovedata>
    {
        public sysmovedataMap()
        {
            // Primary Key
            this.HasKey(t => new { t.newparid, t.flag, t.happendate });

            // Properties
            this.Property(t => t.typeid)
                .HasMaxLength(50);

            this.Property(t => t.newparid)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.flag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("sysmovedata");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.newparid).HasColumnName("newparid");
            this.Property(t => t.flag).HasColumnName("flag");
            this.Property(t => t.happendate).HasColumnName("happendate");
        }
    }
}
