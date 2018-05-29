using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class CommissionRuleEtypeMap : EntityTypeConfiguration<CommissionRuleEtype>
    {
        public CommissionRuleEtypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNumberId, t.ID, t.EtypeID });

            // Properties
            this.Property(t => t.BillNumberId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.EtypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CommissionRuleEtype");
            this.Property(t => t.BillNumberId).HasColumnName("BillNumberId");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
        }
    }
}
