using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class StartOkMap : EntityTypeConfiguration<StartOk>
    {
        public StartOkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Name, t.NameCode, t.Complete });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Name)
                .IsRequired();

            this.Property(t => t.NameCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Complete)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StartOk");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.NameCode).HasColumnName("NameCode");
            this.Property(t => t.Complete).HasColumnName("Complete");
        }
    }
}
