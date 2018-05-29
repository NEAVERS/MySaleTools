using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_Assist_CheckItems_BillTypeMap : EntityTypeConfiguration<Ac_Assist_CheckItems_BillType>
    {
        public Ac_Assist_CheckItems_BillTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.nId, t.AscIds, t.BillType, t.FullName, t.FieldValue });

            // Properties
            this.Property(t => t.nId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.AscIds)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FullName)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.FieldValue)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Ac_Assist_CheckItems_BillType");
            this.Property(t => t.nId).HasColumnName("nId");
            this.Property(t => t.AscIds).HasColumnName("AscIds");
            this.Property(t => t.BillType).HasColumnName("BillType");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.FieldValue).HasColumnName("FieldValue");
            this.Property(t => t.AuditType).HasColumnName("AuditType");
            this.Property(t => t.InOutType).HasColumnName("InOutType");
        }
    }
}
