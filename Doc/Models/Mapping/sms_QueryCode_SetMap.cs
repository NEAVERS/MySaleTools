using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class sms_QueryCode_SetMap : EntityTypeConfiguration<sms_QueryCode_Set>
    {
        public sms_QueryCode_SetMap()
        {
            // Primary Key
            this.HasKey(t => t.CodeID);

            // Properties
            this.Property(t => t.QryCode)
                .HasMaxLength(50);

            this.Property(t => t.VERSION)
                .HasMaxLength(50);

            this.Property(t => t.QRYNAME)
                .HasMaxLength(50);

            this.Property(t => t.PROCNAME)
                .HasMaxLength(50);

            this.Property(t => t.Params)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("sms_QueryCode_Set");
            this.Property(t => t.CodeID).HasColumnName("CodeID");
            this.Property(t => t.QryCode).HasColumnName("QryCode");
            this.Property(t => t.VERSION).HasColumnName("VERSION");
            this.Property(t => t.QRYNAME).HasColumnName("QRYNAME");
            this.Property(t => t.PROCNAME).HasColumnName("PROCNAME");
            this.Property(t => t.Params).HasColumnName("Params");
            this.Property(t => t.STATE).HasColumnName("STATE");
            this.Property(t => t.CONTENT).HasColumnName("CONTENT");
            this.Property(t => t.Comment).HasColumnName("Comment");
        }
    }
}
