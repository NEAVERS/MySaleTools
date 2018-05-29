using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ord_PlugLimitFootingMap : EntityTypeConfiguration<Ord_PlugLimitFooting>
    {
        public Ord_PlugLimitFootingMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.plugid, t.LimitId, t.EtypeId, t.Lim });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.plugid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LimitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Lim)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ord_PlugLimitFooting");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.plugid).HasColumnName("plugid");
            this.Property(t => t.LimitId).HasColumnName("LimitId");
            this.Property(t => t.EtypeId).HasColumnName("EtypeId");
            this.Property(t => t.Lim).HasColumnName("Lim");
        }
    }
}
