using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class OM_SqlLogMap : EntityTypeConfiguration<OM_SqlLog>
    {
        public OM_SqlLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Params)
                .HasMaxLength(1000);

            this.Property(t => t.IPAddress)
                .HasMaxLength(15);

            this.Property(t => t.C_Sql)
                .HasMaxLength(8000);

            this.Property(t => t.Error)
                .HasMaxLength(400);

            // Table & Column Mappings
            this.ToTable("OM_SqlLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.DateTime).HasColumnName("DateTime");
            this.Property(t => t.Elapsed).HasColumnName("Elapsed");
            this.Property(t => t.Params).HasColumnName("Params");
            this.Property(t => t.IPAddress).HasColumnName("IPAddress");
            this.Property(t => t.C_Sql).HasColumnName("_Sql");
            this.Property(t => t.ExecuteElapsed).HasColumnName("ExecuteElapsed");
            this.Property(t => t.FetchElapsed).HasColumnName("FetchElapsed");
            this.Property(t => t.C_RowCount).HasColumnName("_RowCount");
            this.Property(t => t.Error).HasColumnName("Error");
            this.Property(t => t.LoginUserID).HasColumnName("LoginUserID");
        }
    }
}
