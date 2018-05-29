using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class Qp_RepairStateMap : EntityTypeConfiguration<Qp_RepairState>
    {
        public Qp_RepairStateMap()
        {
            // Primary Key
            this.HasKey(t => t.StateId);

            // Properties
            this.Property(t => t.StateId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StateName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Qp_RepairState");
            this.Property(t => t.StateId).HasColumnName("StateId");
            this.Property(t => t.StateName).HasColumnName("StateName");
            this.Property(t => t.IsOperation).HasColumnName("IsOperation");
        }
    }
}
