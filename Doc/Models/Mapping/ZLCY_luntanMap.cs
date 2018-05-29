using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ZLCY_luntanMap : EntityTypeConfiguration<ZLCY_luntan>
    {
        public ZLCY_luntanMap()
        {
            // Primary Key
            this.HasKey(t => new { t.num, t.reply, t.clicknum });

            // Properties
            this.Property(t => t.num)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.title)
                .HasMaxLength(100);

            this.Property(t => t.dates)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.lastdates)
                .IsFixedLength()
                .HasMaxLength(20);

            this.Property(t => t.author)
                .HasMaxLength(50);

            this.Property(t => t.reply)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.img)
                .HasMaxLength(100);

            this.Property(t => t.clicknum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.imagetype)
                .HasMaxLength(50);

            this.Property(t => t.filename)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ZLCY_luntan");
            this.Property(t => t.num).HasColumnName("num");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.texts).HasColumnName("texts");
            this.Property(t => t.dates).HasColumnName("dates");
            this.Property(t => t.lastdates).HasColumnName("lastdates");
            this.Property(t => t.author).HasColumnName("author");
            this.Property(t => t.reply).HasColumnName("reply");
            this.Property(t => t.new_number).HasColumnName("new_number");
            this.Property(t => t.re_number).HasColumnName("re_number");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.clicknum).HasColumnName("clicknum");
            this.Property(t => t.htmlcode).HasColumnName("htmlcode");
            this.Property(t => t.image).HasColumnName("image");
            this.Property(t => t.imagelength).HasColumnName("imagelength");
            this.Property(t => t.imagetype).HasColumnName("imagetype");
            this.Property(t => t.haveimage).HasColumnName("haveimage");
            this.Property(t => t.filename).HasColumnName("filename");
        }
    }
}
