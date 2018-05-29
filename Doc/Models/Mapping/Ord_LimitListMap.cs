using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ord_LimitListMap : EntityTypeConfiguration<Ord_LimitList>
    {
        public Ord_LimitListMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.PlugId, t.QXEnum });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PlugId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QXName)
                .HasMaxLength(200);

            this.Property(t => t.QXEnum)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Ord_LimitList");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PlugId).HasColumnName("PlugId");
            this.Property(t => t.QXName).HasColumnName("QXName");
            this.Property(t => t.QXEnum).HasColumnName("QXEnum");
            this.Property(t => t.plugmenuid).HasColumnName("plugmenuid");
            this.Property(t => t.limittype).HasColumnName("limittype");
        }
    }
}
