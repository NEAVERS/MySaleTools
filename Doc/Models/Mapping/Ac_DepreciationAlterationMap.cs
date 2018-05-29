using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Ac_DepreciationAlterationMap : EntityTypeConfiguration<Ac_DepreciationAlteration>
    {
        public Ac_DepreciationAlterationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Id, t.durmonth });

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeId)
                .HasMaxLength(50);

            this.Property(t => t.durmonth)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WorkUnit)
                .HasMaxLength(50);

            this.Property(t => t.OldWorkUnit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Ac_DepreciationAlteration");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.CardId).HasColumnName("CardId");
            this.Property(t => t.OldNetSalvage).HasColumnName("OldNetSalvage");
            this.Property(t => t.NetSalvage).HasColumnName("NetSalvage");
            this.Property(t => t.OldNetSalvageRate).HasColumnName("OldNetSalvageRate");
            this.Property(t => t.NetSalvageRate).HasColumnName("NetSalvageRate");
            this.Property(t => t.OldDepreciationMean).HasColumnName("OldDepreciationMean");
            this.Property(t => t.DepreciationMean).HasColumnName("DepreciationMean");
            this.Property(t => t.OldDurYear).HasColumnName("OldDurYear");
            this.Property(t => t.DurYear).HasColumnName("DurYear");
            this.Property(t => t.BusinessDate).HasColumnName("BusinessDate");
            this.Property(t => t.OperationDate).HasColumnName("OperationDate");
            this.Property(t => t.ETypeId).HasColumnName("ETypeId");
            this.Property(t => t.durmonth).HasColumnName("durmonth");
            this.Property(t => t.ExpectWork).HasColumnName("ExpectWork");
            this.Property(t => t.OldExpectWork).HasColumnName("OldExpectWork");
            this.Property(t => t.FinishWork).HasColumnName("FinishWork");
            this.Property(t => t.OldFinishWork).HasColumnName("OldFinishWork");
            this.Property(t => t.WorkUnit).HasColumnName("WorkUnit");
            this.Property(t => t.OldWorkUnit).HasColumnName("OldWorkUnit");
        }
    }
}
