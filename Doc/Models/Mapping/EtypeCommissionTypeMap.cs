using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class EtypeCommissionTypeMap : EntityTypeConfiguration<EtypeCommissionType>
    {
        public EtypeCommissionTypeMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.ETypeID, t.CommissionTypeID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ETypeID)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CommissionTypeID)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("EtypeCommissionType");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ETypeID).HasColumnName("ETypeID");
            this.Property(t => t.CommissionTypeID).HasColumnName("CommissionTypeID");
        }
    }
}
