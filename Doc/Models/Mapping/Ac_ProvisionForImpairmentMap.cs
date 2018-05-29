using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_ProvisionForImpairmentMap : EntityTypeConfiguration<Ac_ProvisionForImpairment>
    {
        public Ac_ProvisionForImpairmentMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.IfRecalculate });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.IfRecalculate)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Ac_ProvisionForImpairment");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.DevalueReady).HasColumnName("DevalueReady");
            this.Property(t => t.UsedDevalueReady).HasColumnName("UsedDevalueReady");
            this.Property(t => t.AfterNetValue).HasColumnName("AfterNetValue");
            this.Property(t => t.BusinessDate).HasColumnName("BusinessDate");
            this.Property(t => t.OperationDate).HasColumnName("OperationDate");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.FYear).HasColumnName("FYear");
            this.Property(t => t.FPeriod).HasColumnName("FPeriod");
            this.Property(t => t.IfRecalculate).HasColumnName("IfRecalculate");
            this.Property(t => t.BillnumberId).HasColumnName("BillnumberId");
        }
    }
}
