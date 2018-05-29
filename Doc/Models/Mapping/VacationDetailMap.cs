using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class VacationDetailMap : EntityTypeConfiguration<VacationDetail>
    {
        public VacationDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.IndexId, t.VacationDetailsDate });

            // Properties
            this.Property(t => t.IndexId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VacationDetails");
            this.Property(t => t.IndexId).HasColumnName("IndexId");
            this.Property(t => t.VacationDetailsDate).HasColumnName("VacationDetailsDate");
        }
    }
}
