using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Test.Models.Mapping
{
    public class PosUserPowerRangeViewMap : EntityTypeConfiguration<PosUserPowerRangeView>
    {
        public PosUserPowerRangeViewMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ListID, t.EtypeID, t.BaseType });

            // Properties
            this.Property(t => t.ListID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EtypeID)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.TypeID)
                .HasMaxLength(30);

            this.Property(t => t.BaseType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("PosUserPowerRangeView");
            this.Property(t => t.ListID).HasColumnName("ListID");
            this.Property(t => t.EtypeID).HasColumnName("EtypeID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.BaseType).HasColumnName("BaseType");
        }
    }
}
