using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosStockViewMap : EntityTypeConfiguration<PosStockView>
    {
        public PosStockViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.leveal, t.sonnum, t.soncount, t.fullname, t.PriceTypeID, t.deleted, t.iBYZD });

            // Properties
            this.Property(t => t.branchid)
                .HasMaxLength(50);

            this.Property(t => t.Ktypeid)
                .HasMaxLength(50);

            this.Property(t => t.parid)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fullname)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.name)
                .HasMaxLength(30);

            this.Property(t => t.usercode)
                .HasMaxLength(26);

            this.Property(t => t.PriceTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cBYZD)
                .HasMaxLength(30);

            this.Property(t => t.iBYZD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosStockView");
            this.Property(t => t.branchid).HasColumnName("branchid");
            this.Property(t => t.Ktypeid).HasColumnName("Ktypeid");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.PriceTypeID).HasColumnName("PriceTypeID");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.updatetag).HasColumnName("updatetag");
            this.Property(t => t.cBYZD).HasColumnName("cBYZD");
            this.Property(t => t.iBYZD).HasColumnName("iBYZD");
        }
    }
}
