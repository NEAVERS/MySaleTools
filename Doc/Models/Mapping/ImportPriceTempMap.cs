using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ImportPriceTempMap : EntityTypeConfiguration<ImportPriceTemp>
    {
        public ImportPriceTempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.typeid });

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.typeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.usercode)
                .HasMaxLength(200);

            this.Property(t => t.fullname)
                .HasMaxLength(200);

            this.Property(t => t.itemname)
                .HasMaxLength(100);

            this.Property(t => t.munit)
                .HasMaxLength(100);

            this.Property(t => t.comment)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ImportPriceTemp");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.typeid).HasColumnName("typeid");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.itemid).HasColumnName("itemid");
            this.Property(t => t.itemname).HasColumnName("itemname");
            this.Property(t => t.iscombined).HasColumnName("iscombined");
            this.Property(t => t.munit).HasColumnName("munit");
            this.Property(t => t.munitid).HasColumnName("munitid");
            this.Property(t => t.munitrate).HasColumnName("munitrate");
            this.Property(t => t.baojiamode).HasColumnName("baojiamode");
            this.Property(t => t.price).HasColumnName("price");
            this.Property(t => t.discount).HasColumnName("discount");
            this.Property(t => t.curmdiscountprice).HasColumnName("curmdiscountprice");
            this.Property(t => t.xianjiamode).HasColumnName("xianjiamode");
            this.Property(t => t.comment).HasColumnName("comment");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.importtime).HasColumnName("importtime");
            this.Property(t => t.tax).HasColumnName("tax");
            this.Property(t => t.curmtaxprice).HasColumnName("curmtaxprice");
        }
    }
}
