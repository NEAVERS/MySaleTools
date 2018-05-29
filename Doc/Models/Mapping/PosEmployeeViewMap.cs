using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosEmployeeViewMap : EntityTypeConfiguration<PosEmployeeView>
    {
        public PosEmployeeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rec, t.leveal, t.soncount, t.sonnum, t.fullname, t.deleted, t.isShopSale, t.zkPopedom, t.iBYZD1, t.iBYZD2, t.nBYZD1, t.nBYZD2 });

            // Properties
            this.Property(t => t.etypeid)
                .HasMaxLength(50);

            this.Property(t => t.branchid)
                .HasMaxLength(50);

            this.Property(t => t.rec)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dtypeid)
                .HasMaxLength(50);

            this.Property(t => t.parid)
                .HasMaxLength(50);

            this.Property(t => t.leveal)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.soncount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.sonnum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.fullname)
                .IsRequired()
                .HasMaxLength(66);

            this.Property(t => t.name)
                .HasMaxLength(30);

            this.Property(t => t.usercode)
                .HasMaxLength(26);

            this.Property(t => t.isShopSale)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.zkPopedom)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.cBYZD1)
                .HasMaxLength(30);

            this.Property(t => t.cBYZD2)
                .HasMaxLength(30);

            this.Property(t => t.iBYZD1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.iBYZD2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.nBYZD2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosEmployeeView");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.branchid).HasColumnName("branchid");
            this.Property(t => t.rec).HasColumnName("rec");
            this.Property(t => t.dtypeid).HasColumnName("dtypeid");
            this.Property(t => t.parid).HasColumnName("parid");
            this.Property(t => t.leveal).HasColumnName("leveal");
            this.Property(t => t.soncount).HasColumnName("soncount");
            this.Property(t => t.sonnum).HasColumnName("sonnum");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.isShopSale).HasColumnName("isShopSale");
            this.Property(t => t.zkPopedom).HasColumnName("zkPopedom");
            this.Property(t => t.YHPopedom).HasColumnName("YHPopedom");
            this.Property(t => t.updatetag).HasColumnName("updatetag");
            this.Property(t => t.cBYZD1).HasColumnName("cBYZD1");
            this.Property(t => t.cBYZD2).HasColumnName("cBYZD2");
            this.Property(t => t.iBYZD1).HasColumnName("iBYZD1");
            this.Property(t => t.iBYZD2).HasColumnName("iBYZD2");
            this.Property(t => t.nBYZD1).HasColumnName("nBYZD1");
            this.Property(t => t.nBYZD2).HasColumnName("nBYZD2");
        }
    }
}
