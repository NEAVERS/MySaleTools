using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ImportStateMap : EntityTypeConfiguration<ImportState>
    {
        public ImportStateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Typeid, t.State });

            // Properties
            this.Property(t => t.Typeid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UserId)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ImportState");
            this.Property(t => t.Typeid).HasColumnName("Typeid");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}
