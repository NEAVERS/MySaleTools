using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Pos_AdvertisementPicMap : EntityTypeConfiguration<Pos_AdvertisementPic>
    {
        public Pos_AdvertisementPicMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ORDERID, t.updatetime });

            // Properties
            this.Property(t => t.uniquename)
                .HasMaxLength(100);

            this.Property(t => t.ORDERID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.imgtype)
                .HasMaxLength(30);

            this.Property(t => t.imgname)
                .HasMaxLength(200);

            this.Property(t => t.random)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Pos_AdvertisementPic");
            this.Property(t => t.posid).HasColumnName("posid");
            this.Property(t => t.pic).HasColumnName("pic");
            this.Property(t => t.uniquename).HasColumnName("uniquename");
            this.Property(t => t.ORDERID).HasColumnName("ORDERID");
            this.Property(t => t.imgtype).HasColumnName("imgtype");
            this.Property(t => t.imgname).HasColumnName("imgname");
            this.Property(t => t.random).HasColumnName("random");
            this.Property(t => t.updatetime).HasColumnName("updatetime");
        }
    }
}
