using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VoucherTemplatePresetMap : EntityTypeConfiguration<VoucherTemplatePreset>
    {
        public VoucherTemplatePresetMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.usercode)
                .HasMaxLength(200);

            this.Property(t => t.fullname)
                .HasMaxLength(200);

            this.Property(t => t.groupfullname)
                .HasMaxLength(50);

            this.Property(t => t.summary)
                .HasMaxLength(200);

            this.Property(t => t.atypefrom)
                .HasMaxLength(200);

            this.Property(t => t.atypeusercode)
                .HasMaxLength(200);

            this.Property(t => t.atypefullname)
                .HasMaxLength(200);

            this.Property(t => t.dc)
                .HasMaxLength(50);

            this.Property(t => t.totalfrom)
                .HasMaxLength(200);

            this.Property(t => t.assitems)
                .HasMaxLength(2000);

            // Table & Column Mappings
            this.ToTable("VoucherTemplatePreset");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Billtype).HasColumnName("Billtype");
            this.Property(t => t.usercode).HasColumnName("usercode");
            this.Property(t => t.fullname).HasColumnName("fullname");
            this.Property(t => t.groupfullname).HasColumnName("groupfullname");
            this.Property(t => t.summary).HasColumnName("summary");
            this.Property(t => t.atypefrom).HasColumnName("atypefrom");
            this.Property(t => t.atypeusercode).HasColumnName("atypeusercode");
            this.Property(t => t.atypefullname).HasColumnName("atypefullname");
            this.Property(t => t.dc).HasColumnName("dc");
            this.Property(t => t.totalfrom).HasColumnName("totalfrom");
            this.Property(t => t.assitems).HasColumnName("assitems");
            this.Property(t => t.SubId).HasColumnName("SubId");
            this.Property(t => t.AuditType).HasColumnName("AuditType");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
            this.Property(t => t.ChargeOffType).HasColumnName("ChargeOffType");
            this.Property(t => t.MainRow).HasColumnName("MainRow");
        }
    }
}
