using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class newsMap : EntityTypeConfiguration<news>
    {
        public newsMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.nClickNumber, t.IsDocking });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.strTitle)
                .HasMaxLength(100);

            this.Property(t => t.strDateTime)
                .HasMaxLength(50);

            this.Property(t => t.strAuthor)
                .HasMaxLength(50);

            this.Property(t => t.nClickNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nAuthorID)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("news");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.nCatalogID).HasColumnName("nCatalogID");
            this.Property(t => t.strTitle).HasColumnName("strTitle");
            this.Property(t => t.strContent).HasColumnName("strContent");
            this.Property(t => t.strDateTime).HasColumnName("strDateTime");
            this.Property(t => t.strAuthor).HasColumnName("strAuthor");
            this.Property(t => t.nClickNumber).HasColumnName("nClickNumber");
            this.Property(t => t.nAuthorID).HasColumnName("nAuthorID");
            this.Property(t => t.IsDocking).HasColumnName("IsDocking");
        }
    }
}
