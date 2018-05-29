using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class visitMap : EntityTypeConfiguration<visit>
    {
        public visitMap()
        {
            // Primary Key
            this.HasKey(t => new { t.billnumberid, t.billdate, t.billcode, t.etypeid, t.jbbillnumberid, t.btypeid });

            // Properties
            this.Property(t => t.billnumberid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.billcode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.jbbillnumberid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.btypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.fullname)
                .HasMaxLength(256);

            this.Property(t => t.linkman)
                .HasMaxLength(256);

            this.Property(t => t.linktel)
                .HasMaxLength(256);

            this.Property(t => t.linkaddr)
                .HasMaxLength(256);

            this.Property(t => t.inbillcode)
                .HasMaxLength(200);

            this.Property(t => t.manyidu)
                .HasMaxLength(256);

            this.Property(t => t.jianyi)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("visit");
            this.Property(t => t.billnumberid).HasColumnName("billnumberid");
            this.Property(t => t.billdate).HasColumnName("billdate");
            this.Property(t => t.billcode).HasColumnName("billcode");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.jbbillnumberid).HasColumnName("jbbillnumberid");
            this.Property(t => t.btypeid).HasColumnName("btypeid");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.linkman).HasColumnName("linkman");
            this.Property(t => t.linktel).HasColumnName("linktel");
            this.Property(t => t.linkaddr).HasColumnName("linkaddr");
            this.Property(t => t.inbilldate).HasColumnName("inbilldate");
            this.Property(t => t.inbillcode).HasColumnName("inbillcode");
            this.Property(t => t.manyidu).HasColumnName("manyidu");
            this.Property(t => t.jianyi).HasColumnName("jianyi");
            this.Property(t => t.fjid).HasColumnName("fjid");
        }
    }
}
