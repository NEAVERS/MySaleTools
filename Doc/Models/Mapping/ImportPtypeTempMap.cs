using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class ImportPtypeTempMap : EntityTypeConfiguration<ImportPtypeTemp>
    {
        public ImportPtypeTempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.etypeid, t.BillType, t.PtypeId });

            // Properties
            this.Property(t => t.etypeid)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BillType)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.PtypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StrEntryCode)
                .HasMaxLength(500);

            this.Property(t => t.StrPrice)
                .HasMaxLength(66);

            this.Property(t => t.StrTax)
                .HasMaxLength(66);

            this.Property(t => t.StrDiscount)
                .HasMaxLength(66);

            this.Property(t => t.munitid)
                .HasMaxLength(66);

            this.Property(t => t.munit)
                .HasMaxLength(66);

            this.Property(t => t.baseunitid)
                .HasMaxLength(66);

            this.Property(t => t.baseunit)
                .HasMaxLength(66);

            this.Property(t => t.nunitid)
                .HasMaxLength(66);

            this.Property(t => t.nunit)
                .HasMaxLength(66);

            this.Property(t => t.munitrate)
                .HasMaxLength(66);

            this.Property(t => t.unitrate)
                .HasMaxLength(66);

            this.Property(t => t.unitstype)
                .HasMaxLength(66);

            this.Property(t => t.stockid)
                .HasMaxLength(500);

            this.Property(t => t.stockname)
                .HasMaxLength(500);

            this.Property(t => t.cargoid)
                .HasMaxLength(500);

            this.Property(t => t.cargoName)
                .HasMaxLength(500);

            this.Property(t => t.ProduceDate)
                .HasMaxLength(100);

            this.Property(t => t.ValidDate)
                .HasMaxLength(100);

            this.Property(t => t.GoodsNumber)
                .HasMaxLength(100);

            this.Property(t => t.Comment)
                .HasMaxLength(255);

            this.Property(t => t.unitsentrycode)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ImportPtypeTemp");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.PtypeId).HasColumnName("PtypeId");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.StrEntryCode).HasColumnName("StrEntryCode");
            this.Property(t => t.StrPrice).HasColumnName("StrPrice");
            this.Property(t => t.StrTax).HasColumnName("StrTax");
            this.Property(t => t.StrDiscount).HasColumnName("StrDiscount");
            this.Property(t => t.munitid).HasColumnName("munitid");
            this.Property(t => t.munit).HasColumnName("munit");
            this.Property(t => t.baseunitid).HasColumnName("baseunitid");
            this.Property(t => t.baseunit).HasColumnName("baseunit");
            this.Property(t => t.nunitid).HasColumnName("nunitid");
            this.Property(t => t.nunit).HasColumnName("nunit");
            this.Property(t => t.munitrate).HasColumnName("munitrate");
            this.Property(t => t.unitrate).HasColumnName("unitrate");
            this.Property(t => t.unitstype).HasColumnName("unitstype");
            this.Property(t => t.deleted).HasColumnName("deleted");
            this.Property(t => t.ImportTime).HasColumnName("ImportTime");
            this.Property(t => t.stockid).HasColumnName("stockid");
            this.Property(t => t.stockname).HasColumnName("stockname");
            this.Property(t => t.cargoid).HasColumnName("cargoid");
            this.Property(t => t.cargoName).HasColumnName("cargoName");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.ValidDate).HasColumnName("ValidDate");
            this.Property(t => t.GoodsNumber).HasColumnName("GoodsNumber");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.IsService).HasColumnName("IsService");
            this.Property(t => t.ReferPrice).HasColumnName("ReferPrice");
            this.Property(t => t.unitsentrycode).HasColumnName("unitsentrycode");
        }
    }
}
