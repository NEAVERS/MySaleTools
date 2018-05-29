using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Auditing_TemplateMap : EntityTypeConfiguration<Ac_Auditing_Template>
    {
        public Ac_Auditing_TemplateMap()
        {
            // Primary Key
            this.HasKey(t => new { t.AtId, t.UserCode, t.FullName, t.VgId, t.STypeId });

            // Properties
            this.Property(t => t.AtId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .HasMaxLength(200);

            this.Property(t => t.Comment)
                .HasMaxLength(400);

            this.Property(t => t.VgId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.STypeId)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Explaintext)
                .HasMaxLength(400);

            this.Property(t => t.ExplainAuditType)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("Ac_Auditing_Template");
            this.Property(t => t.AtId).HasColumnName("AtId");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
            this.Property(t => t.CreateDateTime).HasColumnName("CreateDateTime");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.FromAtid).HasColumnName("FromAtid");
            this.Property(t => t.AuditType).HasColumnName("AuditType");
            this.Property(t => t.ChargeOffType).HasColumnName("ChargeOffType");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
            this.Property(t => t.VgId).HasColumnName("VgId");
            this.Property(t => t.STypeId).HasColumnName("STypeId");
            this.Property(t => t.Sysrow).HasColumnName("Sysrow");
            this.Property(t => t.Explaintext).HasColumnName("Explaintext");
            this.Property(t => t.ExplainAuditType).HasColumnName("ExplainAuditType");
            this.Property(t => t.IsCombineRow).HasColumnName("IsCombineRow");
        }
    }
}
