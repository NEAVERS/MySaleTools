using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CheckBIllDataMap : EntityTypeConfiguration<CheckBIllData>
    {
        public CheckBIllDataMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.corpid)
                .HasMaxLength(500);

            this.Property(t => t.guid)
                .HasMaxLength(500);

            this.Property(t => t.dbname)
                .HasMaxLength(500);

            this.Property(t => t.operatorid)
                .HasMaxLength(500);

            this.Property(t => t.auditingstep)
                .HasMaxLength(500);

            this.Property(t => t.billnumberid)
                .HasMaxLength(500);

            this.Property(t => t.billindextype)
                .HasMaxLength(500);

            this.Property(t => t.billtype)
                .HasMaxLength(500);

            this.Property(t => t.stypeid)
                .HasMaxLength(500);

            this.Property(t => t.dtypeid)
                .HasMaxLength(500);

            this.Property(t => t.etypeid)
                .HasMaxLength(500);

            this.Property(t => t.dealbtypeid)
                .HasMaxLength(500);

            this.Property(t => t.result)
                .HasMaxLength(500);

            this.Property(t => t.billcode)
                .HasMaxLength(500);

            this.Property(t => t.audtype)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CheckBIllData");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.corpid).HasColumnName("corpid");
            this.Property(t => t.guid).HasColumnName("guid");
            this.Property(t => t.dbname).HasColumnName("dbname");
            this.Property(t => t.operatorid).HasColumnName("operatorid");
            this.Property(t => t.auditingstep).HasColumnName("auditingstep");
            this.Property(t => t.billnumberid).HasColumnName("billnumberid");
            this.Property(t => t.billindextype).HasColumnName("billindextype");
            this.Property(t => t.billtype).HasColumnName("billtype");
            this.Property(t => t.stypeid).HasColumnName("stypeid");
            this.Property(t => t.dtypeid).HasColumnName("dtypeid");
            this.Property(t => t.etypeid).HasColumnName("etypeid");
            this.Property(t => t.dealbtypeid).HasColumnName("dealbtypeid");
            this.Property(t => t.result).HasColumnName("result");
            this.Property(t => t.billcode).HasColumnName("billcode");
            this.Property(t => t.audtype).HasColumnName("audtype");
        }
    }
}
