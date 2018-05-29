using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class POSBankRateInfoMap : EntityTypeConfiguration<POSBankRateInfo>
    {
        public POSBankRateInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.rateid, t.retaildefault, t.ratestate });

            // Properties
            this.Property(t => t.rateid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.UserCode)
                .HasMaxLength(200);

            this.Property(t => t.FullName)
                .HasMaxLength(200);

            this.Property(t => t.bankitemid)
                .HasMaxLength(50);

            this.Property(t => t.payitemid)
                .HasMaxLength(50);

            this.Property(t => t.retaildefault)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.comment)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("POSBankRateInfo");
            this.Property(t => t.rateid).HasColumnName("rateid");
            this.Property(t => t.UserCode).HasColumnName("UserCode");
            this.Property(t => t.FullName).HasColumnName("FullName");
            this.Property(t => t.bankitemid).HasColumnName("bankitemid");
            this.Property(t => t.payitemid).HasColumnName("payitemid");
            this.Property(t => t.payrate).HasColumnName("payrate");
            this.Property(t => t.limittotal).HasColumnName("limittotal");
            this.Property(t => t.retaildefault).HasColumnName("retaildefault");
            this.Property(t => t.ratestate).HasColumnName("ratestate");
            this.Property(t => t.comment).HasColumnName("comment");
        }
    }
}
