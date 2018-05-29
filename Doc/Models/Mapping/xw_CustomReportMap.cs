using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class xw_CustomReportMap : EntityTypeConfiguration<xw_CustomReport>
    {
        public xw_CustomReportMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProcedureName)
                .HasMaxLength(100);

            this.Property(t => t.Caption)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("xw_CustomReport");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProcedureName).HasColumnName("ProcedureName");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.ReportInfo).HasColumnName("ReportInfo");
        }
    }
}
