using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OFF_FtypeMap : EntityTypeConfiguration<OFF_Ftype>
    {
        public OFF_FtypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NUM, t.layer1, t.layer2, t.layer3, t.layer4, t.layer5, t.layer6, t.soncount, t.store, t.AllSee });

            // Properties
            this.Property(t => t.NUM)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.barname)
                .HasMaxLength(50);

            this.Property(t => t.layer1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.layer2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.layer3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.layer4)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.layer5)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.layer6)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.bardescript)
                .HasMaxLength(100);

            this.Property(t => t.url)
                .HasMaxLength(100);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.powername0)
                .HasMaxLength(50);

            this.Property(t => t.powername1)
                .HasMaxLength(50);

            this.Property(t => t.powername2)
                .HasMaxLength(50);

            this.Property(t => t.powername3)
                .HasMaxLength(50);

            this.Property(t => t.powername4)
                .HasMaxLength(50);

            this.Property(t => t.store)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AllSee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.room_name)
                .HasMaxLength(50);

            this.Property(t => t.room_auto)
                .HasMaxLength(10);

            this.Property(t => t.room_owner)
                .HasMaxLength(50);

            this.Property(t => t.room_des)
                .HasMaxLength(50);

            this.Property(t => t.room_ref)
                .HasMaxLength(50);

            this.Property(t => t.room_title)
                .HasMaxLength(50);

            this.Property(t => t.room_time)
                .HasMaxLength(50);

            this.Property(t => t.room_html)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("OFF_Ftype");
            this.Property(t => t.NUM).HasColumnName("NUM");
            this.Property(t => t.barname).HasColumnName("barname");
            this.Property(t => t.layer1).HasColumnName("layer1");
            this.Property(t => t.layer2).HasColumnName("layer2");
            this.Property(t => t.layer3).HasColumnName("layer3");
            this.Property(t => t.layer4).HasColumnName("layer4");
            this.Property(t => t.layer5).HasColumnName("layer5");
            this.Property(t => t.layer6).HasColumnName("layer6");
            this.Property(t => t.bardescript).HasColumnName("bardescript");
            this.Property(t => t.url).HasColumnName("url");
            this.Property(t => t.parent).HasColumnName("parent");
            this.Property(t => t.son).HasColumnName("son");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.levelnum).HasColumnName("levelnum");
            this.Property(t => t.powername0).HasColumnName("powername0");
            this.Property(t => t.powername1).HasColumnName("powername1");
            this.Property(t => t.powername2).HasColumnName("powername2");
            this.Property(t => t.powername3).HasColumnName("powername3");
            this.Property(t => t.powername4).HasColumnName("powername4");
            this.Property(t => t.store).HasColumnName("store");
            this.Property(t => t.nsave).HasColumnName("nsave");
            this.Property(t => t.breed).HasColumnName("breed");
            this.Property(t => t.AllSee).HasColumnName("AllSee");
            this.Property(t => t.room_name).HasColumnName("room_name");
            this.Property(t => t.room_auto).HasColumnName("room_auto");
            this.Property(t => t.room_owner).HasColumnName("room_owner");
            this.Property(t => t.room_des).HasColumnName("room_des");
            this.Property(t => t.room_ref).HasColumnName("room_ref");
            this.Property(t => t.room_title).HasColumnName("room_title");
            this.Property(t => t.room_keep).HasColumnName("room_keep");
            this.Property(t => t.room_time).HasColumnName("room_time");
            this.Property(t => t.room_html).HasColumnName("room_html");
            this.Property(t => t.ip_protect).HasColumnName("ip_protect");
        }
    }
}
