using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PType_PictureMap : EntityTypeConfiguration<PType_Picture>
    {
        public PType_PictureMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PTypeID, t.Name, t.OrderID, t.ImgURL });

            // Properties
            this.Property(t => t.PTypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ImgURL)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.filename)
                .HasMaxLength(200);

            this.Property(t => t.type)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PType_Picture");
            this.Property(t => t.PTypeID).HasColumnName("PTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrderID).HasColumnName("OrderID");
            this.Property(t => t.ImgURL).HasColumnName("ImgURL");
            this.Property(t => t.pic).HasColumnName("pic");
            this.Property(t => t.length).HasColumnName("length");
            this.Property(t => t.filename).HasColumnName("filename");
            this.Property(t => t.type).HasColumnName("type");
        }
    }
}
