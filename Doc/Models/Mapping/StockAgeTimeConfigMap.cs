using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class StockAgeTimeConfigMap : EntityTypeConfiguration<StockAgeTimeConfig>
    {
        public StockAgeTimeConfigMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ETypeID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeID)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("StockAgeTimeConfig");
            this.Property(t => t.typeID).HasColumnName("typeID");
            this.Property(t => t.parID).HasColumnName("parID");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.delete).HasColumnName("delete");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.Col).HasColumnName("Col");
            this.Property(t => t.Col0).HasColumnName("Col0");
            this.Property(t => t.Col1).HasColumnName("Col1");
            this.Property(t => t.Col2).HasColumnName("Col2");
            this.Property(t => t.Col3).HasColumnName("Col3");
            this.Property(t => t.Col4).HasColumnName("Col4");
            this.Property(t => t.Col5).HasColumnName("Col5");
            this.Property(t => t.Col6).HasColumnName("Col6");
            this.Property(t => t.Col7).HasColumnName("Col7");
            this.Property(t => t.Col8).HasColumnName("Col8");
            this.Property(t => t.Col9).HasColumnName("Col9");
        }
    }
}
