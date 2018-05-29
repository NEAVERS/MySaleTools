using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class xw_ProcedureBackupMap : EntityTypeConfiguration<xw_ProcedureBackup>
    {
        public xw_ProcedureBackupMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProcedureName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("xw_ProcedureBackup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ProcedureName).HasColumnName("ProcedureName");
            this.Property(t => t.ProcedureInfo).HasColumnName("ProcedureInfo");
        }
    }
}
