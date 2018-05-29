using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class StartOkItemMap : EntityTypeConfiguration<StartOkItem>
    {
        public StartOkItemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.itemsName, t.partNameID, t.SortID, t.import, t.Complete });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.itemsName)
                .IsRequired();

            this.Property(t => t.partNameID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SortID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.import)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Complete)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("StartOkItems");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.itemsName).HasColumnName("itemsName");
            this.Property(t => t.partNameID).HasColumnName("partNameID");
            this.Property(t => t.SortID).HasColumnName("SortID");
            this.Property(t => t.import).HasColumnName("import");
            this.Property(t => t.otherItemsName).HasColumnName("otherItemsName");
            this.Property(t => t.expain).HasColumnName("expain");
            this.Property(t => t.Complete).HasColumnName("Complete");
            this.Property(t => t.LimitScan).HasColumnName("LimitScan");
            this.Property(t => t.LimitExport).HasColumnName("LimitExport");
        }
    }
}
